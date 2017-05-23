using CircularProgressBar;
namespace Recognator
{
    partial class LoadForm
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
            this.radDropDownButton1 = new Telerik.WinControls.UI.RadDropDownButton();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.progressBar1 = new CircularProgressBar.CircularProgressBar();
            this.captureLoadWorker = new System.ComponentModel.BackgroundWorker();
            this.error_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownButton1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radDropDownButton1
            // 
            this.radDropDownButton1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuItem4});
            this.radDropDownButton1.Location = new System.Drawing.Point(134, 92);
            this.radDropDownButton1.Name = "radDropDownButton1";
            this.radDropDownButton1.Size = new System.Drawing.Size(175, 40);
            this.radDropDownButton1.TabIndex = 1;
            this.radDropDownButton1.Text = "Режим";
            this.radDropDownButton1.ThemeName = "Material";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Камера";
            this.radMenuItem1.Click += new System.EventHandler(this.radMenuItem1_Click);
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Демо";
            this.radMenuItem2.Click += new System.EventHandler(this.radMenuItem2_Click);
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Настройки";
            this.radMenuItem4.Click += new System.EventHandler(this.radMenuItem4_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CircularEaseInOut;
            this.progressBar1.AnimationSpeed = 500;
            this.progressBar1.BackColor = System.Drawing.Color.Transparent;
            this.progressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar1.InnerColor = System.Drawing.Color.WhiteSmoke;
            this.progressBar1.InnerMargin = 2;
            this.progressBar1.InnerWidth = -1;
            this.progressBar1.Location = new System.Drawing.Point(202, 73);
            this.progressBar1.MarqueeAnimationSpeed = 2000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.OuterColor = System.Drawing.Color.Maroon;
            this.progressBar1.OuterMargin = -25;
            this.progressBar1.OuterWidth = 26;
            this.progressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.progressBar1.ProgressWidth = 3;
            this.progressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progressBar1.Size = new System.Drawing.Size(40, 40);
            this.progressBar1.StartAngle = 0;
            this.progressBar1.Step = 32;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.SubscriptColor = System.Drawing.Color.Transparent;
            this.progressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressBar1.SubscriptText = "";
            this.progressBar1.SuperscriptColor = System.Drawing.Color.Transparent;
            this.progressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBar1.SuperscriptText = "";
            this.progressBar1.TabIndex = 13;
            this.progressBar1.TextMargin = new System.Windows.Forms.Padding(0);
            this.progressBar1.Value = 68;
            this.progressBar1.Visible = false;
            // 
            // captureLoadWorker
            // 
            this.captureLoadWorker.WorkerReportsProgress = true;
            this.captureLoadWorker.WorkerSupportsCancellation = true;
            this.captureLoadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.processWorker);
            this.captureLoadWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.completeWorker);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.error_label.Location = new System.Drawing.Point(134, 73);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(175, 16);
            this.error_label.TabIndex = 14;
            this.error_label.Text = "Ошибка подключения";
            this.error_label.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.error_label);
            this.panel1.Controls.Add(this.radDropDownButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 211);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 211);
            this.panel2.TabIndex = 16;
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(457, 211);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closingForm);
            this.Load += new System.EventHandler(this.formLoad);
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadDropDownButton radDropDownButton1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private CircularProgressBar.CircularProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker captureLoadWorker;
        private System.Windows.Forms.Label error_label;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}