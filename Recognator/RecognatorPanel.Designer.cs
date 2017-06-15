namespace Recognator
{
    partial class RecognatorPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecognatorPanel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.plateRegion_textBox = new System.Windows.Forms.TextBox();
            this.plateMain_textBox = new System.Windows.Forms.TextBox();
            this.plateNumber = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.workStatus = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.detectWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plateNumber)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(725, 378);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.plateRegion_textBox);
            this.panel3.Controls.Add(this.plateMain_textBox);
            this.panel3.Controls.Add(this.plateNumber);
            this.panel3.Location = new System.Drawing.Point(448, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 85);
            this.panel3.TabIndex = 3;
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
            this.panel2.Controls.Add(this.workStatus);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 354);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 91);
            this.panel2.TabIndex = 9;
            // 
            // workStatus
            // 
            this.workStatus.animated = true;
            this.workStatus.animationIterval = 10;
            this.workStatus.animationSpeed = 1;
            this.workStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.workStatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("workStatus.BackgroundImage")));
            this.workStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.workStatus.ForeColor = System.Drawing.Color.SeaGreen;
            this.workStatus.LabelVisible = false;
            this.workStatus.LineProgressThickness = 8;
            this.workStatus.LineThickness = 5;
            this.workStatus.Location = new System.Drawing.Point(13, 16);
            this.workStatus.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.workStatus.MaxValue = 100;
            this.workStatus.Name = "workStatus";
            this.workStatus.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.workStatus.ProgressColor = System.Drawing.Color.SeaGreen;
            this.workStatus.Size = new System.Drawing.Size(55, 55);
            this.workStatus.TabIndex = 20;
            this.workStatus.Value = 30;
            this.workStatus.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(382, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Запретить";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(313, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Разрешить";
            this.label1.Visible = false;
            // 
            // detectWorker
            // 
            this.detectWorker.WorkerReportsProgress = true;
            this.detectWorker.WorkerSupportsCancellation = true;
            this.detectWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.processWorker);
            this.detectWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.completeWorker);
            // 
            // RecognatorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RecognatorPanel";
            this.Size = new System.Drawing.Size(725, 445);
            this.Load += new System.EventHandler(this.panelLoad);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.removed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plateNumber)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox plateNumber;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox plateRegion_textBox;
        public System.Windows.Forms.TextBox plateMain_textBox;
        public System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuCircleProgressbar workStatus;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.ComponentModel.BackgroundWorker detectWorker;
    }
}
