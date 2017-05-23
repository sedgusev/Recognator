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
            this.workStatus = new CircularProgressBar.CircularProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.plateRegion_textBox = new System.Windows.Forms.TextBox();
            this.plateMain_textBox = new System.Windows.Forms.TextBox();
            this.plateNumber = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.detectWorker = new System.ComponentModel.BackgroundWorker();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plateNumber)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.workStatus);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(997, 499);
            this.splitContainer1.SplitterDistance = 272;
            this.splitContainer1.TabIndex = 0;
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
            this.workStatus.Location = new System.Drawing.Point(225, 447);
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
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(3, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 347);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.plateRegion_textBox);
            this.panel3.Controls.Add(this.plateMain_textBox);
            this.panel3.Controls.Add(this.plateNumber);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 85);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 499);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(706, 490);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // detectWorker
            // 
            this.detectWorker.WorkerReportsProgress = true;
            this.detectWorker.WorkerSupportsCancellation = true;
            this.detectWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.processWorker);
            this.detectWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.completeWorker);
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
            // RecognatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(997, 499);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RecognatorForm";
            this.Text = "Recognator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closingForm);
            this.Load += new System.EventHandler(this.formLoad);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plateNumber)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox plateNumber;
        private System.Windows.Forms.TextBox plateMain_textBox;
        private System.Windows.Forms.TextBox plateRegion_textBox;
        private System.Windows.Forms.Panel panel3;
        private System.ComponentModel.BackgroundWorker detectWorker;
        private CircularProgressBar.CircularProgressBar workStatus;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
    }
}