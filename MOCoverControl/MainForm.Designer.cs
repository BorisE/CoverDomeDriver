namespace MotoHatControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtLogBox = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPortList = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBarOpenClose = new System.Windows.Forms.ProgressBar();
            this.btnCloseCover = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSlowBackward = new System.Windows.Forms.Button();
            this.btnFastBackward = new System.Windows.Forms.Button();
            this.btnSlowForward = new System.Windows.Forms.Button();
            this.btnFastForward = new System.Windows.Forms.Button();
            this.btnOpenCover = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.linkAstrohostel = new System.Windows.Forms.LinkLabel();
            this.linkMilantiev = new System.Windows.Forms.LinkLabel();
            this.linkAstromania = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRewindSlowSteps = new System.Windows.Forms.TextBox();
            this.txtRewindFastSteps = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSensorSetCLN = new System.Windows.Forms.Button();
            this.btnSensorSetACL = new System.Windows.Forms.Button();
            this.btnSensorSetSPD = new System.Windows.Forms.Button();
            this.btnSensorSetPOS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSensPOS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSensSPD = new System.Windows.Forms.TextBox();
            this.txtSensSPC = new System.Windows.Forms.TextBox();
            this.txtSensCLN = new System.Windows.Forms.TextBox();
            this.txtSensACL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.timerRewind = new System.Windows.Forms.Timer(this.components);
            this.lblHardwareVersion = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLogBox
            // 
            this.txtLogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogBox.Location = new System.Drawing.Point(6, 25);
            this.txtLogBox.Name = "txtLogBox";
            this.txtLogBox.Size = new System.Drawing.Size(457, 603);
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
            this.groupBox1.Controls.Add(this.cmbPortList);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Location = new System.Drawing.Point(590, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 177);
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
            // cmbPortList
            // 
            this.cmbPortList.FormattingEnabled = true;
            this.cmbPortList.Location = new System.Drawing.Point(111, 33);
            this.cmbPortList.Name = "cmbPortList";
            this.cmbPortList.Size = new System.Drawing.Size(98, 28);
            this.cmbPortList.TabIndex = 0;
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
            // progressBarOpenClose
            // 
            this.progressBarOpenClose.Location = new System.Drawing.Point(19, 105);
            this.progressBarOpenClose.Name = "progressBarOpenClose";
            this.progressBarOpenClose.Size = new System.Drawing.Size(533, 17);
            this.progressBarOpenClose.TabIndex = 3;
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
            this.button3.Location = new System.Drawing.Point(782, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 36);
            this.button3.TabIndex = 4;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(3, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 645);
            this.panel1.TabIndex = 5;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblHardwareVersion);
            this.groupBox6.Controls.Add(this.lblVersion);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.linkAstrohostel);
            this.groupBox6.Controls.Add(this.linkMilantiev);
            this.groupBox6.Controls.Add(this.linkAstromania);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Location = new System.Drawing.Point(478, 337);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(454, 300);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "O..";
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(6, 44);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(238, 41);
            this.lblVersion.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(251, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Part of Astrohostel.ru project";
            // 
            // linkAstrohostel
            // 
            this.linkAstrohostel.AutoSize = true;
            this.linkAstrohostel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkAstrohostel.Location = new System.Drawing.Point(251, 124);
            this.linkAstrohostel.Name = "linkAstrohostel";
            this.linkAstrohostel.Size = new System.Drawing.Size(106, 20);
            this.linkAstrohostel.TabIndex = 17;
            this.linkAstrohostel.TabStop = true;
            this.linkAstrohostel.Text = "astrohostel.ru";
            // 
            // linkMilantiev
            // 
            this.linkMilantiev.AutoSize = true;
            this.linkMilantiev.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkMilantiev.Location = new System.Drawing.Point(243, 226);
            this.linkMilantiev.Name = "linkMilantiev";
            this.linkMilantiev.Size = new System.Drawing.Size(144, 20);
            this.linkMilantiev.TabIndex = 15;
            this.linkMilantiev.TabStop = true;
            this.linkMilantiev.Text = "astro.milantiev.com";
            // 
            // linkAstromania
            // 
            this.linkAstromania.AutoSize = true;
            this.linkAstromania.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkAstromania.Location = new System.Drawing.Point(232, 258);
            this.linkAstromania.Name = "linkAstromania";
            this.linkAstromania.Size = new System.Drawing.Size(155, 20);
            this.linkAstromania.TabIndex = 16;
            this.linkAstromania.TabStop = true;
            this.linkAstromania.Text = "www.astromania.info";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Software by Boris Emchenko";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Device by Oleg Milantiev";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(6, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(266, 22);
            this.label14.TabIndex = 12;
            this.label14.Text = "MotoHat Contorl Software";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(6, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtRewindSlowSteps);
            this.groupBox5.Controls.Add(this.txtRewindFastSteps);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(478, 226);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(454, 105);
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
            this.groupBox4.Location = new System.Drawing.Point(478, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(454, 217);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Параметры драйвера";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Длина цикла";
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
            // txtSensCLN
            // 
            this.txtSensCLN.Location = new System.Drawing.Point(140, 169);
            this.txtSensCLN.Name = "txtSensCLN";
            this.txtSensCLN.Size = new System.Drawing.Size(84, 26);
            this.txtSensCLN.TabIndex = 2;
            this.txtSensCLN.Enter += new System.EventHandler(this.txtSens_Enter);
            this.txtSensCLN.Leave += new System.EventHandler(this.txtSens_Leave);
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
            this.groupBox3.Size = new System.Drawing.Size(469, 634);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Лог";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(6, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 226);
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
            // timerRewind
            // 
            this.timerRewind.Interval = 1000;
            this.timerRewind.Tick += new System.EventHandler(this.timerRewind_Tick);
            // 
            // lblHardwareVersion
            // 
            this.lblHardwareVersion.Location = new System.Drawing.Point(251, 44);
            this.lblHardwareVersion.Name = "lblHardwareVersion";
            this.lblHardwareVersion.Size = new System.Drawing.Size(197, 41);
            this.lblHardwareVersion.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 888);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Контроллер крышки объектива MotoHat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtLogBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPortList;
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
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkAstrohostel;
        private System.Windows.Forms.LinkLabel linkMilantiev;
        private System.Windows.Forms.LinkLabel linkAstromania;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblHardwareVersion;
    }
}

