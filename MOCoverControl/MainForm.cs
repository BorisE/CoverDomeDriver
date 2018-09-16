using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MOCoverControl
{
    public partial class MainForm : Form
    {
        public Communications ComObj;

        //Color constants
        Color OnColor = Color.DarkSeaGreen;
        Color OffColor = Color.Tomato;
        Color DisabledColor = Color.LightGray;
        Color InterColor = Color.Yellow;
        Color DefBackColor;
        Color DefBackColorTextBoxes;

        const int mainTimer_Interval_Quick = 100;
        const int mainTimer_Interval_Normal = 2000;

        bool bBlockSensorRefresh = false;
        bool bMoving = false;
        Int32 DistanceToGo = 0;

        int FastForwardDefault = 200;
        int SlowForwardDefault = 50;


        public MainForm()
        {
            InitializeComponent();

            ComObj = new Communications(new Communications.CallBackOutputFunction(PublishData));

            mainTimer.Interval = mainTimer_Interval_Normal;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DefBackColor = btnOpenCover.BackColor;
        }


        /// <summary>
        /// Method which ivoked from other class to add to grid
        /// </summary>
        /// <param name="FileResObj"></param>
        public void PublishData(string stOutput)
        {
            this.Invoke(new Action(() => this.PublishDataInvoke(stOutput)));
        }

        private void PublishDataInvoke(string stAddSt)
        {
            string RetStr = stAddSt;

            //RetStr = String.Format("{0} {1}", DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("HH:mm:ss"));
            //RetStr += String.Format(": {0}", stAddSt) + Environment.NewLine;

            txtLogBox.AppendText(RetStr);


            //set cursor to the end
            txtLogBox.SelectionStart = txtLogBox.TextLength;
            txtLogBox.SelectionLength = 0;
            txtLogBox.ScrollToCaret();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Подключиться")
            {
                //Разблокировать кнопки управления
                btnOpenCover.Enabled = true;
                btnFastForward.Enabled = true;
                btnSlowForward.Enabled = true;
                btnStop.Enabled = false;
                btnSlowBackward.Enabled = true;
                btnFastBackward.Enabled = true;
                btnCloseCover.Enabled = true;

                //Включить таймер
                mainTimer.Enabled = true;

                //Запустить чтение COM порта
                ComObj.DataReadObj.StartReadData();

                btnStart.Text = "Отключиться";
            }
            else
            {
                //Заблокировать кнопки управления
                btnOpenCover.Enabled = false;
                btnFastForward.Enabled = false;
                btnSlowForward.Enabled = false;
                btnStop.Enabled = false;
                btnSlowBackward.Enabled = false;
                btnFastBackward.Enabled = false;
                btnCloseCover.Enabled = false;

                //Выключить таймер
                mainTimer.Enabled = false;

                //Закрыть чтение COM порта
                ComObj.DataReadObj.StopReadData();

                btnStart.Text = "Подключиться";
            }
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            //Get current buffer for logging
            string curSerialBuffer = "";

            ComObj.DataParseObj.LOOP_CYCLE(out curSerialBuffer);


            RefreshFormFields();
        }

        private void RefreshFormFields()
        {
            //Sensors if not edit simultaneously
            if (!bBlockSensorRefresh)
            { 
                txtSensPOS.Text = ComObj.sensorPOS.ToString();
                txtSensACL.Text = ComObj.sensorACL.ToString();
                txtSensSPD.Text = ComObj.sensorSPD.ToString();
                txtSensCLN.Text = ComObj.sensorCLN.ToString();
            }
            //Sensors without possibility to edit
            txtSensSPC.Text = ComObj.sensorSPC.ToString();

            //Если сейчас в движении
            if (ComObj.sensorMVE == 1)
            {
                //разблокировать кнопку Stop
                btnStop.Enabled = true;

                mainTimer.Interval = mainTimer_Interval_Quick;

                //Если только запуск
                if (!bMoving)
                {
                    //Установить прогресс бар
                    progressBarOpenClose.Maximum = Math.Abs(ComObj.sensorPOS + DistanceToGo);
                    progressBarOpenClose.Minimum = Math.Abs(ComObj.sensorPOS);
                    bMoving = true;
                }
                progressBarOpenClose.Value = ComObj.sensorPOS;
            }
            else
            {
                //заблокировать кнопку Stop
                btnStop.Enabled = false;
                mainTimer.Interval = mainTimer_Interval_Normal;

                //Если раньше было в движении
                if (bMoving)
                {
                    //Окончить прогресс бар 
                    if (curRewindSteps < 0)
                    { 
                        progressBarOpenClose.Minimum = ComObj.sensorPOS;
                    }
                    else
                    {
                        progressBarOpenClose.Maximum = ComObj.sensorPOS;
                    }
                    progressBarOpenClose.Value = ComObj.sensorPOS;
                    bMoving = false;
                }
            }

            //Если крыша открыта
            if (ComObj.sensorOpened == 1)
            {
                btnOpenCover.BackColor = OnColor;
            }
            else
            {
                btnOpenCover.BackColor = DefaultBackColor;
            }


            //Если крышка закрыта
            if (ComObj.sensorClosed == 1)
            {
                btnCloseCover.BackColor = OnColor;
            }
            else
            {
                btnCloseCover.BackColor = DefaultBackColor;
            }


        }

        private void txtSens_Enter(object sender, EventArgs e)
        {
            bBlockSensorRefresh = true;
        }

        private void txtSens_Leave(object sender, EventArgs e)
        {
            bBlockSensorRefresh = false;
        }


        private void btnSensorSetPOS_Click(object sender, EventArgs e)
        {
            ComObj.setPos(Convert.ToInt32(txtSensPOS.Text));
        }

        private void btnSensorSetSPD_Click(object sender, EventArgs e)
        {
            ComObj.setMaxSpeed(Convert.ToInt32(txtSensSPD.Text));

        }

        private void btnSensorSetACL_Click(object sender, EventArgs e)
        {
            ComObj.setAcceleration (Convert.ToInt32(txtSensACL.Text));
        }

        private void btnSensorSetCLN_Click(object sender, EventArgs e)
        {
            ComObj.setCylceLength(Convert.ToInt32(txtSensCLN.Text));
        }

        private void btnOpenCover_Click(object sender, EventArgs e)
        {
            bMoving = true;
            ComObj.OpenCover();
            mainTimer.Interval = mainTimer_Interval_Quick;
            DistanceToGo = ComObj.sensorCLN;

        }
        private void btnCloseCover_Click(object sender, EventArgs e)
        {
            bMoving = true;
            ComObj.CloseCover();
            mainTimer.Interval = mainTimer_Interval_Quick;
            DistanceToGo = -ComObj.sensorCLN;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ComObj.StopCover();
        }

        
        // ******************************************************************
        // Перемотка
        // ******************************************************************
        private void timerRewind_Tick(object sender, EventArgs e)
        {
            ComObj.MoveCoverInc(DistanceToGo);
        }

        // ******************************************************************
        // Перемотка быстрая вперед
        // ******************************************************************
        private void btnFastForward_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Int32.TryParse(txtRewindFastSteps.Text, out int FFSteps)) FFSteps = FastForwardDefault;
            DistanceToGo = FFSteps;
            timerRewind.Enabled = true;
            timerRewind_Tick(null, null);
        }

        private void btnFastForward_MouseUp(object sender, MouseEventArgs e)
        {
            timerRewind.Enabled = false;
        }
        // ******************************************************************
        // Перемотка медленная вперед
        // ******************************************************************
        private void btnSlowForward_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Int32.TryParse(txtRewindSlowSteps.Text, out int SFSteps)) SFSteps = SlowForwardDefault;
            DistanceToGo = SFSteps;
            timerRewind.Enabled = true;
            timerRewind_Tick(null, null);
        }
        private void btnSlowForward_MouseUp(object sender, MouseEventArgs e)
        {
            timerRewind.Enabled = false;
        }

        // ******************************************************************
        // Перемотка быстрая назад
        // ******************************************************************

        private void btnFastBackward_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Int32.TryParse(txtRewindFastSteps.Text, out int FFSteps)) FFSteps = FastForwardDefault;
            DistanceToGo = -FFSteps;
            timerRewind.Enabled = true;
            timerRewind_Tick(null, null);
        }

        private void btnFastBackward_MouseUp(object sender, MouseEventArgs e)
        {
            timerRewind.Enabled = false;
        }

        // ******************************************************************
        // Перемотка медленная назад
        // ******************************************************************

        private void btnSlowBackward_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Int32.TryParse(txtRewindSlowSteps.Text, out int SFSteps)) SFSteps = SlowForwardDefault;
            DistanceToGo = -SFSteps;
            timerRewind.Enabled = true;
            timerRewind_Tick(null, null);
        }


        private void btnSlowBackward_MouseUp(object sender, MouseEventArgs e)
        {
            timerRewind.Enabled = false;
        }

    }
}
