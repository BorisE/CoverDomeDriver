using LoggingLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MotoHatControl
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

        const int mainTimer_Interval_Quick = 50;
        const int mainTimer_Interval_Normal = 2000;

        bool bBlockSensorRefresh = false;
        bool bMoving = false;

        int ShuffleDistance = 0;

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


            VersionData.initVersionData();
            LoadAboutData();

            //READ COM PORT LIST
            cmbPortList.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
                cmbPortList.Items.Add(s);

            cmbPortList.SelectedItem = ComObj.DataReadObj.PortName;
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
                //Запустить чтение COM порта
                if (ComObj.DataReadObj.StartReadData())
                {
                    btnStart.Text = "Отключиться";

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
                }
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
            LoadHardwareVersion(); //update sketch version

            //Если сейчас в движении
            if (ComObj.sensorMVE == 1)
            {
                //разблокировать кнопку Stop
                btnStop.Enabled = true;

                mainTimer.Interval = mainTimer_Interval_Quick;

                //Если эо первый цикл запуска
                if (!bMoving)
                {
                    //Установить прогресс бар
                    progressBarOpenClose.Minimum = 0;
                    progressBarOpenClose.Maximum = Math.Abs(ComObj.sensorDST);
                    bMoving = true;
                }

                try
                {
                    //а то он при частом нажатии клавиш не успевает обрабатывать и бывает вылетает
                    progressBarOpenClose.Value = Math.Abs(ComObj.sensorPOS - ComObj.StartPos);
                }
                catch
                { }

            }
            else
            {
                //заблокировать кнопку Stop
                btnStop.Enabled = false;
                btnFastForward.Enabled = true;
                btnSlowForward.Enabled = true;
                btnSlowBackward.Enabled = true;
                btnFastBackward.Enabled = true;

                mainTimer.Interval = mainTimer_Interval_Normal;

                //Если раньше было в движении
                if (bMoving)
                {
                    //Окончить прогресс бар 
                    progressBarOpenClose.Maximum = Math.Abs(ComObj.sensorPOS - ComObj.StartPos);
                    progressBarOpenClose.Value = Math.Abs(ComObj.sensorPOS - ComObj.StartPos);
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

        private void btnOpenCover_Click(object sender, EventArgs e)
        {
            bMoving = true;
            ComObj.OpenCover();
            mainTimer.Interval = mainTimer_Interval_Quick;

        }
        private void btnCloseCover_Click(object sender, EventArgs e)
        {
            bMoving = true;
            ComObj.CloseCover();
            mainTimer.Interval = mainTimer_Interval_Quick;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ComObj.StopCover();
        }

        
        /******************************************************************
        * 
        * Перемотка
        * 
        ******************************************************************/
        private void timerRewind_Tick(object sender, EventArgs e)
        {
            ComObj.MoveCoverInc(ShuffleDistance);
        }


        /// <summary>
        /// Перемотка быстрая вперед
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFastForward_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Int32.TryParse(txtRewindFastSteps.Text, out int FFSteps)) FFSteps = FastForwardDefault;
            ShuffleDistance = FFSteps;
            timerRewind.Enabled = true;
            timerRewind_Tick(null, null);
        }

        private void btnFastForward_MouseUp(object sender, MouseEventArgs e)
        {
            timerRewind.Enabled = false;
        }


        /// <summary>
        /// Перемотка медленная вперед
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSlowForward_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Int32.TryParse(txtRewindSlowSteps.Text, out int SFSteps)) SFSteps = SlowForwardDefault;
            ShuffleDistance = SFSteps;
            timerRewind.Enabled = true;
            timerRewind_Tick(null, null);
        }

        private void btnSlowForward_MouseUp(object sender, MouseEventArgs e)
        {
            timerRewind.Enabled = false;
        }


        /// <summary>
        /// Перемотка быстрая назад
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFastBackward_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Int32.TryParse(txtRewindFastSteps.Text, out int FFSteps)) FFSteps = FastForwardDefault;
            ShuffleDistance = -FFSteps;
            timerRewind.Enabled = true;
            timerRewind_Tick(null, null);
        }

        private void btnFastBackward_MouseUp(object sender, MouseEventArgs e)
        {
            timerRewind.Enabled = false;
        }

        /// <summary>
        /// Перемотка медленная назад
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSlowBackward_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Int32.TryParse(txtRewindSlowSteps.Text, out int SFSteps)) SFSteps = SlowForwardDefault;
            ShuffleDistance = -SFSteps;
            timerRewind.Enabled = true;
            timerRewind_Tick(null, null);
        }
        private void btnSlowBackward_MouseUp(object sender, MouseEventArgs e)
        {
            timerRewind.Enabled = false;
        }


        /************************************************************************
         * 
         *      Установка параметров
         * 
         * **********************************************************************/
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
            ComObj.setAcceleration(Convert.ToInt32(txtSensACL.Text));
        }

        private void btnSensorSetCLN_Click(object sender, EventArgs e)
        {
            ComObj.setCylceLength(Convert.ToInt32(txtSensCLN.Text));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainTimer.Stop();
            timerRewind.Stop();

            Properties.Settings.Default.Save(); // Commit changes
            //SaveXMLSettingsToConfigFile();

            Logging.AddLog("Program exit");
            Logging.DumpToFile();
        }



        /**************************************************************************************************/
        #region //// About information //////////////////////////////////////
        private void LoadAboutData()
        {
            lblVersion.Text += "Publish version: " + VersionData.PublishVersionSt;
            lblVersion.Text += Environment.NewLine + "Assembly version: " + VersionData.AssemblyVersionSt;
            lblVersion.Text += Environment.NewLine + "File version: " + VersionData.FileVersionSt;
            //lblVersion.Text += Environment.NewLine + "Product version " + ProductVersionSt;

            //MessageBox.Show("Application " + assemName.Name + ", Version " + ver.ToString());
            lblVersion.Text += Environment.NewLine + "Compile time: " + VersionData.CompileTime.ToString("yyyy-MM-dd HH:mm:ss");

            // Add link
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://www.astromania.info/";
            linkAstromania.Links.Add(link);

            LinkLabel.Link link2 = new LinkLabel.Link();
            link2.LinkData = "http://astrohostel.ru/";
            linkAstrohostel.Links.Add(link2);

            LinkLabel.Link link3 = new LinkLabel.Link();
            link3.LinkData = "http://astro.milantiev.com/";
            linkMilantiev.Links.Add(link3);
        }

        private void LoadHardwareVersion()
        {
            lblHardwareVersion.Text = "Firmware: " + ComObj.SketchVersion;
            lblHardwareVersion.Text = "Compile time: " + ComObj.SketchVersionDate;
        }

        private void linkAny_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        #endregion About information
        /**************************************************************************************************/

    }
}
