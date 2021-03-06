namespace Uniden_Remote_Head
{
    partial class UnidenRemoteHead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnidenRemoteHead));
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.timerReadScanner = new System.Windows.Forms.Timer();
            this.textDisplayLine2 = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textDisplayLine3 = new System.Windows.Forms.TextBox();
            this.textDisplayLine4 = new System.Windows.Forms.TextBox();
            this.textDisplayLine5 = new System.Windows.Forms.TextBox();
            this.buttonFunction = new System.Windows.Forms.Button();
            this.textDisplayLine1 = new System.Windows.Forms.TextBox();
            this.buttonPOL = new System.Windows.Forms.Button();
            this.buttonHP = new System.Windows.Forms.Button();
            this.buttonGPS = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonLO = new System.Windows.Forms.Button();
            this.buttonNum1 = new System.Windows.Forms.Button();
            this.buttonNum2 = new System.Windows.Forms.Button();
            this.buttonNum3 = new System.Windows.Forms.Button();
            this.buttonNum6 = new System.Windows.Forms.Button();
            this.buttonNum5 = new System.Windows.Forms.Button();
            this.buttonNum4 = new System.Windows.Forms.Button();
            this.buttonNum9 = new System.Windows.Forms.Button();
            this.buttonNum8 = new System.Windows.Forms.Button();
            this.buttonNum7 = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNum0 = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonBacklight = new System.Windows.Forms.Button();
            this.buttonHold = new System.Windows.Forms.Button();
            this.buttonCloseCall = new System.Windows.Forms.Button();
            this.buttonScan = new System.Windows.Forms.Button();
            this.textDisplayLine6 = new System.Windows.Forms.TextBox();
            this.timerUpdateSettingsXML = new System.Windows.Forms.Timer();
            this.SuspendLayout();
            // 
            // buttonDown
            // 
            this.buttonDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDown.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.buttonDown.ForeColor = System.Drawing.Color.White;
            this.buttonDown.Location = new System.Drawing.Point(283, 532);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(72, 93);
            this.buttonDown.TabIndex = 0;
            this.buttonDown.TabStop = false;
            this.buttonDown.Text = "↓";
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonUp.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.buttonUp.ForeColor = System.Drawing.Color.White;
            this.buttonUp.Location = new System.Drawing.Point(122, 532);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(74, 93);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.TabStop = false;
            this.buttonUp.Text = "↑";
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // timerReadScanner
            // 
            this.timerReadScanner.Tick += new System.EventHandler(this.timerReadScanner_Tick);
            // 
            // textDisplayLine2
            // 
            this.textDisplayLine2.BackColor = System.Drawing.Color.White;
            this.textDisplayLine2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDisplayLine2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.textDisplayLine2.Location = new System.Drawing.Point(17, 42);
            this.textDisplayLine2.Name = "textDisplayLine2";
            this.textDisplayLine2.Size = new System.Drawing.Size(358, 64);
            this.textDisplayLine2.TabIndex = 2;
            this.textDisplayLine2.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Black;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(451, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(26, 26);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "X";
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textDisplayLine3
            // 
            this.textDisplayLine3.BackColor = System.Drawing.Color.White;
            this.textDisplayLine3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDisplayLine3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.textDisplayLine3.Location = new System.Drawing.Point(17, 94);
            this.textDisplayLine3.Name = "textDisplayLine3";
            this.textDisplayLine3.Size = new System.Drawing.Size(358, 64);
            this.textDisplayLine3.TabIndex = 5;
            this.textDisplayLine3.TabStop = false;
            // 
            // textDisplayLine4
            // 
            this.textDisplayLine4.BackColor = System.Drawing.Color.White;
            this.textDisplayLine4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDisplayLine4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.textDisplayLine4.Location = new System.Drawing.Point(17, 145);
            this.textDisplayLine4.Name = "textDisplayLine4";
            this.textDisplayLine4.Size = new System.Drawing.Size(358, 51);
            this.textDisplayLine4.TabIndex = 6;
            this.textDisplayLine4.TabStop = false;
            // 
            // textDisplayLine5
            // 
            this.textDisplayLine5.BackColor = System.Drawing.Color.White;
            this.textDisplayLine5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDisplayLine5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.textDisplayLine5.Location = new System.Drawing.Point(17, 182);
            this.textDisplayLine5.Name = "textDisplayLine5";
            this.textDisplayLine5.Size = new System.Drawing.Size(358, 51);
            this.textDisplayLine5.TabIndex = 7;
            this.textDisplayLine5.TabStop = false;
            // 
            // buttonFunction
            // 
            this.buttonFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonFunction.ForeColor = System.Drawing.Color.White;
            this.buttonFunction.Location = new System.Drawing.Point(202, 532);
            this.buttonFunction.Name = "buttonFunction";
            this.buttonFunction.Size = new System.Drawing.Size(75, 93);
            this.buttonFunction.TabIndex = 8;
            this.buttonFunction.TabStop = false;
            this.buttonFunction.Text = "Func";
            this.buttonFunction.Click += new System.EventHandler(this.buttonFunction_Click);
            // 
            // textDisplayLine1
            // 
            this.textDisplayLine1.BackColor = System.Drawing.Color.White;
            this.textDisplayLine1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDisplayLine1.Location = new System.Drawing.Point(17, 13);
            this.textDisplayLine1.Name = "textDisplayLine1";
            this.textDisplayLine1.Size = new System.Drawing.Size(358, 41);
            this.textDisplayLine1.TabIndex = 9;
            this.textDisplayLine1.TabStop = false;
            // 
            // buttonPOL
            // 
            this.buttonPOL.BackColor = System.Drawing.Color.Black;
            this.buttonPOL.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.buttonPOL.ForeColor = System.Drawing.Color.White;
            this.buttonPOL.Location = new System.Drawing.Point(381, 35);
            this.buttonPOL.Name = "buttonPOL";
            this.buttonPOL.Size = new System.Drawing.Size(84, 35);
            this.buttonPOL.TabIndex = 10;
            this.buttonPOL.TabStop = false;
            this.buttonPOL.Text = "POL";
            this.buttonPOL.Click += new System.EventHandler(this.buttonPOL_Click);
            // 
            // buttonHP
            // 
            this.buttonHP.BackColor = System.Drawing.Color.Black;
            this.buttonHP.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.buttonHP.ForeColor = System.Drawing.Color.White;
            this.buttonHP.Location = new System.Drawing.Point(381, 79);
            this.buttonHP.Name = "buttonHP";
            this.buttonHP.Size = new System.Drawing.Size(84, 35);
            this.buttonHP.TabIndex = 11;
            this.buttonHP.TabStop = false;
            this.buttonHP.Text = "HP";
            this.buttonHP.Click += new System.EventHandler(this.buttonHP_Click);
            // 
            // buttonGPS
            // 
            this.buttonGPS.BackColor = System.Drawing.Color.Black;
            this.buttonGPS.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.buttonGPS.ForeColor = System.Drawing.Color.White;
            this.buttonGPS.Location = new System.Drawing.Point(381, 123);
            this.buttonGPS.Name = "buttonGPS";
            this.buttonGPS.Size = new System.Drawing.Size(84, 35);
            this.buttonGPS.TabIndex = 12;
            this.buttonGPS.TabStop = false;
            this.buttonGPS.Text = "GPS";
            this.buttonGPS.Click += new System.EventHandler(this.buttonGPS_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.Black;
            this.buttonMenu.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.buttonMenu.ForeColor = System.Drawing.Color.White;
            this.buttonMenu.Location = new System.Drawing.Point(381, 167);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(84, 35);
            this.buttonMenu.TabIndex = 13;
            this.buttonMenu.TabStop = false;
            this.buttonMenu.Text = "MENU";
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonLO
            // 
            this.buttonLO.BackColor = System.Drawing.Color.Black;
            this.buttonLO.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.buttonLO.ForeColor = System.Drawing.Color.White;
            this.buttonLO.Location = new System.Drawing.Point(381, 208);
            this.buttonLO.Name = "buttonLO";
            this.buttonLO.Size = new System.Drawing.Size(84, 53);
            this.buttonLO.TabIndex = 14;
            this.buttonLO.TabStop = false;
            this.buttonLO.Text = "L/O";
            this.buttonLO.Click += new System.EventHandler(this.buttonLO_Click);
            // 
            // buttonNum1
            // 
            this.buttonNum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonNum1.ForeColor = System.Drawing.Color.White;
            this.buttonNum1.Location = new System.Drawing.Point(27, 272);
            this.buttonNum1.Name = "buttonNum1";
            this.buttonNum1.Size = new System.Drawing.Size(119, 50);
            this.buttonNum1.TabIndex = 15;
            this.buttonNum1.TabStop = false;
            this.buttonNum1.Text = "1/SRCH";
            this.buttonNum1.Click += new System.EventHandler(this.buttonNum1_Click);
            // 
            // buttonNum2
            // 
            this.buttonNum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonNum2.ForeColor = System.Drawing.Color.White;
            this.buttonNum2.Location = new System.Drawing.Point(179, 272);
            this.buttonNum2.Name = "buttonNum2";
            this.buttonNum2.Size = new System.Drawing.Size(119, 50);
            this.buttonNum2.TabIndex = 16;
            this.buttonNum2.TabStop = false;
            this.buttonNum2.Text = "2/SRCH";
            this.buttonNum2.Click += new System.EventHandler(this.buttonNum2_Click);
            // 
            // buttonNum3
            // 
            this.buttonNum3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonNum3.ForeColor = System.Drawing.Color.White;
            this.buttonNum3.Location = new System.Drawing.Point(331, 272);
            this.buttonNum3.Name = "buttonNum3";
            this.buttonNum3.Size = new System.Drawing.Size(119, 50);
            this.buttonNum3.TabIndex = 17;
            this.buttonNum3.TabStop = false;
            this.buttonNum3.Text = "3/SRCH";
            this.buttonNum3.Click += new System.EventHandler(this.buttonNum3_Click);
            // 
            // buttonNum6
            // 
            this.buttonNum6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonNum6.ForeColor = System.Drawing.Color.White;
            this.buttonNum6.Location = new System.Drawing.Point(331, 337);
            this.buttonNum6.Name = "buttonNum6";
            this.buttonNum6.Size = new System.Drawing.Size(119, 50);
            this.buttonNum6.TabIndex = 20;
            this.buttonNum6.TabStop = false;
            this.buttonNum6.Text = "6/DISP";
            this.buttonNum6.Click += new System.EventHandler(this.buttonNum6_Click);
            // 
            // buttonNum5
            // 
            this.buttonNum5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonNum5.ForeColor = System.Drawing.Color.White;
            this.buttonNum5.Location = new System.Drawing.Point(179, 337);
            this.buttonNum5.Name = "buttonNum5";
            this.buttonNum5.Size = new System.Drawing.Size(119, 50);
            this.buttonNum5.TabIndex = 19;
            this.buttonNum5.TabStop = false;
            this.buttonNum5.Text = "5/LVL";
            this.buttonNum5.Click += new System.EventHandler(this.buttonNum5_Click);
            // 
            // buttonNum4
            // 
            this.buttonNum4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonNum4.ForeColor = System.Drawing.Color.White;
            this.buttonNum4.Location = new System.Drawing.Point(27, 337);
            this.buttonNum4.Name = "buttonNum4";
            this.buttonNum4.Size = new System.Drawing.Size(119, 50);
            this.buttonNum4.TabIndex = 18;
            this.buttonNum4.TabStop = false;
            this.buttonNum4.Text = "4/IFX";
            this.buttonNum4.Click += new System.EventHandler(this.buttonNum4_Click);
            // 
            // buttonNum9
            // 
            this.buttonNum9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonNum9.ForeColor = System.Drawing.Color.White;
            this.buttonNum9.Location = new System.Drawing.Point(331, 402);
            this.buttonNum9.Name = "buttonNum9";
            this.buttonNum9.Size = new System.Drawing.Size(119, 50);
            this.buttonNum9.TabIndex = 23;
            this.buttonNum9.TabStop = false;
            this.buttonNum9.Text = "9/MOD";
            this.buttonNum9.Click += new System.EventHandler(this.buttonNum9_Click);
            // 
            // buttonNum8
            // 
            this.buttonNum8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonNum8.ForeColor = System.Drawing.Color.White;
            this.buttonNum8.Location = new System.Drawing.Point(179, 402);
            this.buttonNum8.Name = "buttonNum8";
            this.buttonNum8.Size = new System.Drawing.Size(119, 50);
            this.buttonNum8.TabIndex = 22;
            this.buttonNum8.TabStop = false;
            this.buttonNum8.Text = "8/REV";
            this.buttonNum8.Click += new System.EventHandler(this.buttonNum8_Click);
            // 
            // buttonNum7
            // 
            this.buttonNum7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonNum7.ForeColor = System.Drawing.Color.White;
            this.buttonNum7.Location = new System.Drawing.Point(27, 402);
            this.buttonNum7.Name = "buttonNum7";
            this.buttonNum7.Size = new System.Drawing.Size(119, 50);
            this.buttonNum7.TabIndex = 21;
            this.buttonNum7.TabStop = false;
            this.buttonNum7.Text = "7/ATT";
            this.buttonNum7.Click += new System.EventHandler(this.buttonNum7_Click);
            // 
            // buttonYes
            // 
            this.buttonYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonYes.ForeColor = System.Drawing.Color.White;
            this.buttonYes.Location = new System.Drawing.Point(331, 467);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(119, 50);
            this.buttonYes.TabIndex = 26;
            this.buttonYes.TabStop = false;
            this.buttonYes.Text = "E Yes";
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonNum0
            // 
            this.buttonNum0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonNum0.ForeColor = System.Drawing.Color.White;
            this.buttonNum0.Location = new System.Drawing.Point(179, 467);
            this.buttonNum0.Name = "buttonNum0";
            this.buttonNum0.Size = new System.Drawing.Size(119, 50);
            this.buttonNum0.TabIndex = 25;
            this.buttonNum0.TabStop = false;
            this.buttonNum0.Text = "0";
            this.buttonNum0.Click += new System.EventHandler(this.buttonNum0_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonNo.ForeColor = System.Drawing.Color.White;
            this.buttonNo.Location = new System.Drawing.Point(27, 467);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(119, 50);
            this.buttonNo.TabIndex = 24;
            this.buttonNo.TabStop = false;
            this.buttonNo.Text = ". No";
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // buttonBacklight
            // 
            this.buttonBacklight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBacklight.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold);
            this.buttonBacklight.ForeColor = System.Drawing.Color.White;
            this.buttonBacklight.Location = new System.Drawing.Point(27, 585);
            this.buttonBacklight.Name = "buttonBacklight";
            this.buttonBacklight.Size = new System.Drawing.Size(89, 40);
            this.buttonBacklight.TabIndex = 29;
            this.buttonBacklight.TabStop = false;
            this.buttonBacklight.Text = "☼";
            this.buttonBacklight.Click += new System.EventHandler(this.buttonBacklight_Click);
            // 
            // buttonHold
            // 
            this.buttonHold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonHold.ForeColor = System.Drawing.Color.White;
            this.buttonHold.Location = new System.Drawing.Point(361, 585);
            this.buttonHold.Name = "buttonHold";
            this.buttonHold.Size = new System.Drawing.Size(89, 40);
            this.buttonHold.TabIndex = 28;
            this.buttonHold.TabStop = false;
            this.buttonHold.Text = "Hold";
            this.buttonHold.Click += new System.EventHandler(this.buttonHold_Click);
            // 
            // buttonCloseCall
            // 
            this.buttonCloseCall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCloseCall.ForeColor = System.Drawing.Color.White;
            this.buttonCloseCall.Location = new System.Drawing.Point(27, 532);
            this.buttonCloseCall.Name = "buttonCloseCall";
            this.buttonCloseCall.Size = new System.Drawing.Size(89, 40);
            this.buttonCloseCall.TabIndex = 27;
            this.buttonCloseCall.TabStop = false;
            this.buttonCloseCall.Text = "©/M";
            this.buttonCloseCall.Click += new System.EventHandler(this.buttonCloseCall_Click);
            // 
            // buttonScan
            // 
            this.buttonScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonScan.ForeColor = System.Drawing.Color.White;
            this.buttonScan.Location = new System.Drawing.Point(361, 532);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(89, 40);
            this.buttonScan.TabIndex = 30;
            this.buttonScan.TabStop = false;
            this.buttonScan.Text = "Scan";
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // textDisplayLine6
            // 
            this.textDisplayLine6.BackColor = System.Drawing.Color.White;
            this.textDisplayLine6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDisplayLine6.Location = new System.Drawing.Point(17, 220);
            this.textDisplayLine6.Name = "textDisplayLine6";
            this.textDisplayLine6.Size = new System.Drawing.Size(358, 41);
            this.textDisplayLine6.TabIndex = 31;
            this.textDisplayLine6.TabStop = false;
            // 
            // timerUpdateSettingsXML
            // 
            this.timerUpdateSettingsXML.Interval = 10000;
            this.timerUpdateSettingsXML.Tick += new System.EventHandler(this.timerUpdateSettingsXML_Tick);
            // 
            // UnidenRemoteHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(480, 640);
            this.Controls.Add(this.textDisplayLine6);
            this.Controls.Add(this.textDisplayLine5);
            this.Controls.Add(this.textDisplayLine4);
            this.Controls.Add(this.textDisplayLine3);
            this.Controls.Add(this.textDisplayLine2);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.buttonBacklight);
            this.Controls.Add(this.buttonHold);
            this.Controls.Add(this.buttonCloseCall);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.buttonNum0);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonNum9);
            this.Controls.Add(this.buttonNum8);
            this.Controls.Add(this.buttonNum7);
            this.Controls.Add(this.buttonNum6);
            this.Controls.Add(this.buttonNum5);
            this.Controls.Add(this.buttonNum4);
            this.Controls.Add(this.buttonNum3);
            this.Controls.Add(this.buttonNum2);
            this.Controls.Add(this.buttonNum1);
            this.Controls.Add(this.buttonLO);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonGPS);
            this.Controls.Add(this.buttonHP);
            this.Controls.Add(this.buttonPOL);
            this.Controls.Add(this.textDisplayLine1);
            this.Controls.Add(this.buttonFunction);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonDown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "UnidenRemoteHead";
            this.Text = "Uniden Remote Head";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UnidenRemoteHead_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Timer timerReadScanner;
        private System.Windows.Forms.TextBox textDisplayLine2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textDisplayLine3;
        private System.Windows.Forms.TextBox textDisplayLine4;
        private System.Windows.Forms.TextBox textDisplayLine5;
        private System.Windows.Forms.Button buttonFunction;
        private System.Windows.Forms.TextBox textDisplayLine1;
        private System.Windows.Forms.Button buttonPOL;
        private System.Windows.Forms.Button buttonHP;
        private System.Windows.Forms.Button buttonGPS;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonLO;
        private System.Windows.Forms.Button buttonNum1;
        private System.Windows.Forms.Button buttonNum2;
        private System.Windows.Forms.Button buttonNum3;
        private System.Windows.Forms.Button buttonNum6;
        private System.Windows.Forms.Button buttonNum5;
        private System.Windows.Forms.Button buttonNum4;
        private System.Windows.Forms.Button buttonNum9;
        private System.Windows.Forms.Button buttonNum8;
        private System.Windows.Forms.Button buttonNum7;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonNum0;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonBacklight;
        private System.Windows.Forms.Button buttonHold;
        private System.Windows.Forms.Button buttonCloseCall;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.TextBox textDisplayLine6;
        private System.Windows.Forms.Timer timerUpdateSettingsXML;
    }
}

