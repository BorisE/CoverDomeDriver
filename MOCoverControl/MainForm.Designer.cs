namespace MOCoverControl
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtLogBox = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCloseCover = new System.Windows.Forms.Button();
            this.btnOpenCover = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSensorSetPOS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSensPOS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSensSPD = new System.Windows.Forms.TextBox();
            this.txtSensSPC = new System.Windows.Forms.TextBox();
            this.txtSensACL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.btnSensorSetSPD = new System.Windows.Forms.Button();
            this.btnSensorSetACL = new System.Windows.Forms.Button();
            this.txtSensCLN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSensorSetCLN = new System.Windows.Forms.Button();
            this.progressBarOpenClose = new System.Windows.Forms.ProgressBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnFastForward = new System.Windows.Forms.Button();
            this.btnFastBackward = new System.Windows.Forms.Button();
            this.btnSlowForward = new System.Windows.Forms.Button();
            this.btnSlowBackward = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRewindSlowSteps = new System.Windows.Forms.TextBox();
            this.txtRewindFastSteps = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.timerRewind = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLogBox
            // 
            this.txtLogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogBox.Location = new System.Drawing.Point(6, 25);
            this.txtLogBox.Name = "txtLogBox";
            this.txtLogBox.Size = new System.Drawing.Size(509, 555);
            this.txtLogBox.TabIndex = 0;
            this.txtLogBox.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(92, 105);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(167, 40);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Подключиться";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Location = new System.Drawing.Point(590, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 177);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подключение";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM порт";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBarOpenClose);
            this.groupBox2.Controls.Add(this.btnCloseCover);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.btnSlowBackward);
            this.groupBox2.Controls.Add(this.btnFastBackward);
            this.groupBox2.Controls.Add(this.btnSlowForward);
            this.groupBox2.Controls.Add(this.btnFastForward);
            this.groupBox2.Controls.Add(this.btnOpenCover);
            this.groupBox2.Location = new System.Drawing.Point(6, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 177);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление крышкой";
            // 
            // btnCloseCover
            // 
            this.btnCloseCover.Enabled = false;
            this.btnCloseCover.Location = new System.Drawing.Point(451, 36);
            this.btnCloseCover.Name = "btnCloseCover";
            this.btnCloseCover.Size = new System.Drawing.Size(101, 45);
            this.btnCloseCover.TabIndex = 0;
            this.btnCloseCover.Text = "Закрыть";
            this.btnCloseCover.UseVisualStyleBackColor = true;
            this.btnCloseCover.Click += new System.EventHandler(this.btnCloseCover_Click);
            // 
            // btnOpenCover
            // 
            this.btnOpenCover.Enabled = false;
            this.btnOpenCover.Location = new System.Drawing.Point(19, 36);
            this.btnOpenCover.Name = "btnOpenCover";
            this.btnOpenCover.Size = new System.Drawing.Size(101, 45);
            this.btnOpenCover.TabIndex = 0;
            this.btnOpenCover.Text = "Открыть";
            this.btnOpenCover.UseVisualStyleBackColor = true;
            this.btnOpenCover.Click += new System.EventHandler(this.btnOpenCover_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(759, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 36);
            this.button3.TabIndex = 4;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(3, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 592);
            this.panel1.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSensorSetCLN);
            this.groupBox4.Controls.Add(this.btnSensorSetACL);
            this.groupBox4.Controls.Add(this.btnSensorSetSPD);
            this.groupBox4.Controls.Add(this.btnSensorSetPOS);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtSensPOS);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtSensSPD);
            this.groupBox4.Controls.Add(this.txtSensSPC);
            this.groupBox4.Controls.Add(this.txtSensCLN);
            this.groupBox4.Controls.Add(this.txtSensACL);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(530, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(369, 217);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Параметры драйвера";
            // 
            // btnSensorSetPOS
            // 
            this.btnSensorSetPOS.Location = new System.Drawing.Point(247, 28);
            this.btnSensorSetPOS.Name = "btnSensorSetPOS";
            this.btnSensorSetPOS.Size = new System.Drawing.Size(75, 29);
            this.btnSensorSetPOS.TabIndex = 4;
            this.btnSensorSetPOS.Text = ">>";
            this.btnSensorSetPOS.UseVisualStyleBackColor = true;
            this.btnSensorSetPOS.Click += new System.EventHandler(this.btnSensorSetPOS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Позиция";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Тек.скорость";
            // 
            // txtSensPOS
            // 
            this.txtSensPOS.Location = new System.Drawing.Point(140, 29);
            this.txtSensPOS.Name = "txtSensPOS";
            this.txtSensPOS.Size = new System.Drawing.Size(84, 26);
            this.txtSensPOS.TabIndex = 2;
            this.txtSensPOS.Enter += new System.EventHandler(this.txtSens_Enter);
            this.txtSensPOS.Leave += new System.EventHandler(this.txtSens_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ускорение";
            // 
            // txtSensSPD
            // 
            this.txtSensSPD.Location = new System.Drawing.Point(140, 64);
            this.txtSensSPD.Name = "txtSensSPD";
            this.txtSensSPD.Size = new System.Drawing.Size(84, 26);
            this.txtSensSPD.TabIndex = 2;
            this.txtSensSPD.Enter += new System.EventHandler(this.txtSens_Enter);
            this.txtSensSPD.Leave += new System.EventHandler(this.txtSens_Leave);
            // 
            // txtSensSPC
            // 
            this.txtSensSPC.Location = new System.Drawing.Point(140, 134);
            this.txtSensSPC.Name = "txtSensSPC";
            this.txtSensSPC.ReadOnly = true;
            this.txtSensSPC.Size = new System.Drawing.Size(84, 26);
            this.txtSensSPC.TabIndex = 2;
            // 
            // txtSensACL
            // 
            this.txtSensACL.Location = new System.Drawing.Point(140, 99);
            this.txtSensACL.Name = "txtSensACL";
            this.txtSensACL.Size = new System.Drawing.Size(84, 26);
            this.txtSensACL.TabIndex = 2;
            this.txtSensACL.Enter += new System.EventHandler(this.txtSens_Enter);
            this.txtSensACL.Leave += new System.EventHandler(this.txtSens_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Макс.скорость";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLogBox);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(521, 586);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Лог";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(6, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 226);
            this.panel2.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 187);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 36);
            this.button5.TabIndex = 4;
            this.button5.Text = "О программе";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // btnSensorSetSPD
            // 
            this.btnSensorSetSPD.Location = new System.Drawing.Point(247, 63);
            this.btnSensorSetSPD.Name = "btnSensorSetSPD";
            this.btnSensorSetSPD.Size = new System.Drawing.Size(75, 29);
            this.btnSensorSetSPD.TabIndex = 4;
            this.btnSensorSetSPD.Text = ">>";
            this.btnSensorSetSPD.UseVisualStyleBackColor = true;
            this.btnSensorSetSPD.Click += new System.EventHandler(this.btnSensorSetSPD_Click);
            // 
            // btnSensorSetACL
            // 
            this.btnSensorSetACL.Location = new System.Drawing.Point(247, 98);
            this.btnSensorSetACL.Name = "btnSensorSetACL";
            this.btnSensorSetACL.Size = new System.Drawing.Size(75, 29);
            this.btnSensorSetACL.TabIndex = 4;
            this.btnSensorSetACL.Text = ">>";
            this.btnSensorSetACL.UseVisualStyleBackColor = true;
            this.btnSensorSetACL.Click += new System.EventHandler(this.btnSensorSetACL_Click);
            // 
            // txtSensCLN
            // 
            this.txtSensCLN.Location = new System.Drawing.Point(140, 169);
            this.txtSensCLN.Name = "txtSensCLN";
            this.txtSensCLN.Size = new System.Drawing.Size(84, 26);
            this.txtSensCLN.TabIndex = 2;
            this.txtSensCLN.Enter += new System.EventHandler(this.txtSens_Enter);
            this.txtSensCLN.Leave += new System.EventHandler(this.txtSens_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Длина цикла";
            // 
            // btnSensorSetCLN
            // 
            this.btnSensorSetCLN.Location = new System.Drawing.Point(247, 168);
            this.btnSensorSetCLN.Name = "btnSensorSetCLN";
            this.btnSensorSetCLN.Size = new System.Drawing.Size(75, 29);
            this.btnSensorSetCLN.TabIndex = 4;
            this.btnSensorSetCLN.Text = ">>";
            this.btnSensorSetCLN.UseVisualStyleBackColor = true;
            this.btnSensorSetCLN.Click += new System.EventHandler(this.btnSensorSetCLN_Click);
            // 
            // progressBarOpenClose
            // 
            this.progressBarOpenClose.Location = new System.Drawing.Point(19, 105);
            this.progressBarOpenClose.Name = "progressBarOpenClose";
            this.progressBarOpenClose.Size = new System.Drawing.Size(533, 17);
            this.progressBarOpenClose.TabIndex = 3;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(235, 36);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(101, 45);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnFastForward
            // 
            this.btnFastForward.Enabled = false;
            this.btnFastForward.Location = new System.Drawing.Point(127, 36);
            this.btnFastForward.Name = "btnFastForward";
            this.btnFastForward.Size = new System.Drawing.Size(47, 45);
            this.btnFastForward.TabIndex = 0;
            this.btnFastForward.Text = "<<";
            this.btnFastForward.UseVisualStyleBackColor = true;
            this.btnFastForward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFastForward_MouseDown);
            this.btnFastForward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnFastForward_MouseUp);
            // 
            // btnFastBackward
            // 
            this.btnFastBackward.Enabled = false;
            this.btnFastBackward.Location = new System.Drawing.Point(397, 36);
            this.btnFastBackward.Name = "btnFastBackward";
            this.btnFastBackward.Size = new System.Drawing.Size(47, 45);
            this.btnFastBackward.TabIndex = 0;
            this.btnFastBackward.Text = ">>";
            this.btnFastBackward.UseVisualStyleBackColor = true;
            this.btnFastBackward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFastBackward_MouseDown);
            this.btnFastBackward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnFastBackward_MouseUp);
            // 
            // btnSlowForward
            // 
            this.btnSlowForward.Enabled = false;
            this.btnSlowForward.Location = new System.Drawing.Point(181, 36);
            this.btnSlowForward.Name = "btnSlowForward";
            this.btnSlowForward.Size = new System.Drawing.Size(47, 45);
            this.btnSlowForward.TabIndex = 0;
            this.btnSlowForward.Text = "<";
            this.btnSlowForward.UseVisualStyleBackColor = true;
            this.btnSlowForward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSlowForward_MouseDown);
            this.btnSlowForward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSlowForward_MouseUp);
            // 
            // btnSlowBackward
            // 
            this.btnSlowBackward.Enabled = false;
            this.btnSlowBackward.Location = new System.Drawing.Point(343, 36);
            this.btnSlowBackward.Name = "btnSlowBackward";
            this.btnSlowBackward.Size = new System.Drawing.Size(47, 45);
            this.btnSlowBackward.TabIndex = 0;
            this.btnSlowBackward.Text = ">";
            this.btnSlowBackward.UseVisualStyleBackColor = true;
            this.btnSlowBackward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSlowBackward_MouseDown);
            this.btnSlowBackward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSlowBackward_MouseUp);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtRewindSlowSteps);
            this.groupBox5.Controls.Add(this.txtRewindFastSteps);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(530, 236);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(369, 132);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Параметры программы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Перемотка";
            // 
            // txtRewindSlowSteps
            // 
            this.txtRewindSlowSteps.Location = new System.Drawing.Point(212, 29);
            this.txtRewindSlowSteps.Name = "txtRewindSlowSteps";
            this.txtRewindSlowSteps.Size = new System.Drawing.Size(84, 26);
            this.txtRewindSlowSteps.TabIndex = 2;
            this.txtRewindSlowSteps.Enter += new System.EventHandler(this.txtSens_Enter);
            this.txtRewindSlowSteps.Leave += new System.EventHandler(this.txtSens_Leave);
            // 
            // txtRewindFastSteps
            // 
            this.txtRewindFastSteps.Location = new System.Drawing.Point(212, 64);
            this.txtRewindFastSteps.Name = "txtRewindFastSteps";
            this.txtRewindFastSteps.Size = new System.Drawing.Size(84, 26);
            this.txtRewindFastSteps.TabIndex = 2;
            this.txtRewindFastSteps.Enter += new System.EventHandler(this.txtSens_Enter);
            this.txtRewindFastSteps.Leave += new System.EventHandler(this.txtSens_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Быстрая перемотка";
            // 
            // timerRewind
            // 
            this.timerRewind.Interval = 1000;
            this.timerRewind.Tick += new System.EventHandler(this.timerRewind_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 838);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Контроллер крышки объектива";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtLogBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCloseCover;
        private System.Windows.Forms.Button btnOpenCover;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSensSPD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSensPOS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSensSPC;
        private System.Windows.Forms.TextBox txtSensACL;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSensorSetPOS;
        private System.Windows.Forms.Button btnSensorSetACL;
        private System.Windows.Forms.Button btnSensorSetSPD;
        private System.Windows.Forms.Button btnSensorSetCLN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSensCLN;
        private System.Windows.Forms.ProgressBar progressBarOpenClose;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSlowBackward;
        private System.Windows.Forms.Button btnFastBackward;
        private System.Windows.Forms.Button btnSlowForward;
        private System.Windows.Forms.Button btnFastForward;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRewindSlowSteps;
        private System.Windows.Forms.TextBox txtRewindFastSteps;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timerRewind;
    }
}

