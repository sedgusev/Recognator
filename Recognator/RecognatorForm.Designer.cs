namespace Recognator
{
    partial class RecognatorForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.plateRegion_textBox = new System.Windows.Forms.TextBox();
            this.plateMain_textBox = new System.Windows.Forms.TextBox();
            this.plateNumber = new System.Windows.Forms.PictureBox();
            this.login_panel = new System.Windows.Forms.Panel();
            this.test_checkBox = new System.Windows.Forms.CheckBox();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.port_textBox = new System.Windows.Forms.TextBox();
            this.informationLabel = new System.Windows.Forms.Label();
            this.processTimeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ip_textBox = new System.Windows.Forms.TextBox();
            this.passw_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.workStatus = new CircularProgressBar.CircularProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.detectWorker = new System.ComponentModel.BackgroundWorker();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.stop_button = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plateNumber)).BeginInit();
            this.login_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop_button)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.login_panel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(997, 499);
            this.splitContainer1.SplitterDistance = 272;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(0, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 142);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.plateRegion_textBox);
            this.panel3.Controls.Add(this.plateMain_textBox);
            this.panel3.Controls.Add(this.plateNumber);
            this.panel3.Location = new System.Drawing.Point(7, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 85);
            this.panel3.TabIndex = 2;
            // 
            // plateRegion_textBox
            // 
            this.plateRegion_textBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.plateRegion_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.plateRegion_textBox.Enabled = false;
            this.plateRegion_textBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plateRegion_textBox.Location = new System.Drawing.Point(204, 23);
            this.plateRegion_textBox.Name = "plateRegion_textBox";
            this.plateRegion_textBox.ReadOnly = true;
            this.plateRegion_textBox.Size = new System.Drawing.Size(41, 23);
            this.plateRegion_textBox.TabIndex = 2;
            // 
            // plateMain_textBox
            // 
            this.plateMain_textBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.plateMain_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.plateMain_textBox.Enabled = false;
            this.plateMain_textBox.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plateMain_textBox.Location = new System.Drawing.Point(24, 23);
            this.plateMain_textBox.Name = "plateMain_textBox";
            this.plateMain_textBox.ReadOnly = true;
            this.plateMain_textBox.Size = new System.Drawing.Size(155, 38);
            this.plateMain_textBox.TabIndex = 1;
            this.plateMain_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plateNumber
            // 
            this.plateNumber.Image = global::Recognator.Properties.Resources.plate;
            this.plateNumber.Location = new System.Drawing.Point(7, 13);
            this.plateNumber.Name = "plateNumber";
            this.plateNumber.Size = new System.Drawing.Size(251, 59);
            this.plateNumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plateNumber.TabIndex = 0;
            this.plateNumber.TabStop = false;
            // 
            // login_panel
            // 
            this.login_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_panel.Controls.Add(this.test_checkBox);
            this.login_panel.Controls.Add(this.login_textBox);
            this.login_panel.Controls.Add(this.port_textBox);
            this.login_panel.Controls.Add(this.informationLabel);
            this.login_panel.Controls.Add(this.processTimeLabel);
            this.login_panel.Controls.Add(this.label4);
            this.login_panel.Controls.Add(this.label1);
            this.login_panel.Controls.Add(this.ip_textBox);
            this.login_panel.Controls.Add(this.passw_textBox);
            this.login_panel.Controls.Add(this.label3);
            this.login_panel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_panel.Location = new System.Drawing.Point(7, 151);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(273, 214);
            this.login_panel.TabIndex = 1;
            // 
            // test_checkBox
            // 
            this.test_checkBox.AutoSize = true;
            this.test_checkBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_checkBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.test_checkBox.Location = new System.Drawing.Point(77, 159);
            this.test_checkBox.Name = "test_checkBox";
            this.test_checkBox.Size = new System.Drawing.Size(64, 23);
            this.test_checkBox.TabIndex = 16;
            this.test_checkBox.Text = "Test";
            this.test_checkBox.UseVisualStyleBackColor = true;
            // 
            // login_textBox
            // 
            this.login_textBox.Location = new System.Drawing.Point(77, 59);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(148, 23);
            this.login_textBox.TabIndex = 8;
            // 
            // port_textBox
            // 
            this.port_textBox.Location = new System.Drawing.Point(178, 111);
            this.port_textBox.Name = "port_textBox";
            this.port_textBox.Size = new System.Drawing.Size(47, 23);
            this.port_textBox.TabIndex = 15;
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Location = new System.Drawing.Point(40, 99);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(0, 15);
            this.informationLabel.TabIndex = 3;
            // 
            // processTimeLabel
            // 
            this.processTimeLabel.AutoSize = true;
            this.processTimeLabel.Location = new System.Drawing.Point(47, 98);
            this.processTimeLabel.Name = "processTimeLabel";
            this.processTimeLabel.Size = new System.Drawing.Size(0, 15);
            this.processTimeLabel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(47, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(27, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Логин:";
            // 
            // ip_textBox
            // 
            this.ip_textBox.Location = new System.Drawing.Point(77, 111);
            this.ip_textBox.Name = "ip_textBox";
            this.ip_textBox.Size = new System.Drawing.Size(95, 23);
            this.ip_textBox.TabIndex = 12;
            // 
            // passw_textBox
            // 
            this.passw_textBox.Location = new System.Drawing.Point(77, 85);
            this.passw_textBox.Name = "passw_textBox";
            this.passw_textBox.PasswordChar = '●';
            this.passw_textBox.Size = new System.Drawing.Size(148, 23);
            this.passw_textBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(20, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Пароль:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.stop_button);
            this.panel2.Controls.Add(this.workStatus);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 499);
            this.panel2.TabIndex = 3;
            // 
            // workStatus
            // 
            this.workStatus.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CircularEaseInOut;
            this.workStatus.AnimationSpeed = 500;
            this.workStatus.BackColor = System.Drawing.Color.Transparent;
            this.workStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workStatus.ForeColor = System.Drawing.Color.Transparent;
            this.workStatus.InnerColor = System.Drawing.Color.WhiteSmoke;
            this.workStatus.InnerMargin = 2;
            this.workStatus.InnerWidth = -1;
            this.workStatus.Location = new System.Drawing.Point(3, 456);
            this.workStatus.MarqueeAnimationSpeed = 2000;
            this.workStatus.Name = "workStatus";
            this.workStatus.OuterColor = System.Drawing.Color.Maroon;
            this.workStatus.OuterMargin = -25;
            this.workStatus.OuterWidth = 26;
            this.workStatus.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.workStatus.ProgressWidth = 3;
            this.workStatus.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workStatus.Size = new System.Drawing.Size(40, 40);
            this.workStatus.StartAngle = 0;
            this.workStatus.Step = 32;
            this.workStatus.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.workStatus.SubscriptColor = System.Drawing.Color.Transparent;
            this.workStatus.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.workStatus.SubscriptText = "";
            this.workStatus.SuperscriptColor = System.Drawing.Color.Transparent;
            this.workStatus.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.workStatus.SuperscriptText = "";
            this.workStatus.TabIndex = 15;
            this.workStatus.TextMargin = new System.Windows.Forms.Padding(0);
            this.workStatus.Value = 68;
            this.workStatus.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(706, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox1.Location = new System.Drawing.Point(0, 81);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(567, 299);
            this.imageBox1.TabIndex = 4;
            this.imageBox1.TabStop = false;
            // 
            // detectWorker
            // 
            this.detectWorker.WorkerReportsProgress = true;
            this.detectWorker.WorkerSupportsCancellation = true;
            this.detectWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.processWorker);
            this.detectWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.completeWorker);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(62, 463);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(99, 30);
            this.stop_button.TabIndex = 16;
            this.stop_button.Text = "СТОП";
            this.stop_button.ThemeName = "Material";
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // RecognatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(997, 499);
            this.Controls.Add(this.splitContainer1);
            this.Name = "RecognatorForm";
            this.Text = "Recognator";
            this.Load += new System.EventHandler(this.formLoad);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plateNumber)).EndInit();
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop_button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.Label processTimeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox port_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ip_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passw_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.PictureBox plateNumber;
        private System.Windows.Forms.TextBox plateMain_textBox;
        private System.Windows.Forms.TextBox plateRegion_textBox;
        private System.Windows.Forms.CheckBox test_checkBox;
        private System.Windows.Forms.Panel panel3;
        private System.ComponentModel.BackgroundWorker detectWorker;
        private CircularProgressBar.CircularProgressBar workStatus;
        private Telerik.WinControls.UI.RadButton stop_button;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
    }
}