namespace Recognator
{
    partial class Teach
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
            this.selectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.progressBar1 = new CircularProgressBar.CircularProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.sinRadBtn = new Telerik.WinControls.UI.RadRadioButton();
            this.tanRadBtn = new Telerik.WinControls.UI.RadRadioButton();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.teachBtn = new Telerik.WinControls.UI.RadButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinRadBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanRadBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressBar1.AnimationSpeed = 1000;
            this.progressBar1.BackColor = System.Drawing.Color.Transparent;
            this.progressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progressBar1.ForeColor = System.Drawing.Color.White;
            this.progressBar1.InnerColor = System.Drawing.Color.Maroon;
            this.progressBar1.InnerMargin = 2;
            this.progressBar1.InnerWidth = -1;
            this.progressBar1.Location = new System.Drawing.Point(131, 34);
            this.progressBar1.MarqueeAnimationSpeed = 800;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.OuterColor = System.Drawing.Color.Yellow;
            this.progressBar1.OuterMargin = -25;
            this.progressBar1.OuterWidth = 26;
            this.progressBar1.ProgressColor = System.Drawing.Color.WhiteSmoke;
            this.progressBar1.ProgressWidth = 4;
            this.progressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progressBar1.Size = new System.Drawing.Size(200, 200);
            this.progressBar1.StartAngle = 0;
            this.progressBar1.Step = 32;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.SubscriptColor = System.Drawing.Color.Transparent;
            this.progressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressBar1.SubscriptText = "";
            this.progressBar1.SuperscriptColor = System.Drawing.Color.Transparent;
            this.progressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBar1.SuperscriptText = "";
            this.progressBar1.TabIndex = 14;
            this.progressBar1.Text = "test";
            this.progressBar1.TextMargin = new System.Windows.Forms.Padding(0);
            this.progressBar1.Value = 80;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 250);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radLabel1);
            this.panel1.Controls.Add(this.panel);
            this.panel1.Controls.Add(this.radTextBox1);
            this.panel1.Controls.Add(this.radButton3);
            this.panel1.Controls.Add(this.radButton1);
            this.panel1.Controls.Add(this.teachBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 250);
            this.panel1.TabIndex = 18;
            // 
            // radLabel1
            // 
            this.radLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radLabel1.Location = new System.Drawing.Point(82, 90);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(109, 18);
            this.radLabel1.TabIndex = 7;
            this.radLabel1.Text = "Функция активации";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radLabel1.ThemeName = "Material";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.sinRadBtn);
            this.panel.Controls.Add(this.tanRadBtn);
            this.panel.Location = new System.Drawing.Point(82, 111);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(187, 56);
            this.panel.TabIndex = 6;
            // 
            // sinRadBtn
            // 
            this.sinRadBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sinRadBtn.Location = new System.Drawing.Point(3, 3);
            this.sinRadBtn.Name = "sinRadBtn";
            this.sinRadBtn.Size = new System.Drawing.Size(104, 16);
            this.sinRadBtn.TabIndex = 4;
            this.sinRadBtn.Text = "Синусоидальная";
            this.sinRadBtn.ThemeName = "Material";
            this.sinRadBtn.CheckStateChanged += new System.EventHandler(this.radButtonsSelect);
            // 
            // tanRadBtn
            // 
            this.tanRadBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tanRadBtn.Location = new System.Drawing.Point(3, 25);
            this.tanRadBtn.Name = "tanRadBtn";
            this.tanRadBtn.Size = new System.Drawing.Size(102, 16);
            this.tanRadBtn.TabIndex = 5;
            this.tanRadBtn.Text = "Тангенциальная";
            this.tanRadBtn.ThemeName = "Material";
            this.tanRadBtn.ToggleStateChanging += new Telerik.WinControls.UI.StateChangingEventHandler(this.tanRadBtn_ToggleStateChanging);
            this.tanRadBtn.CheckStateChanged += new System.EventHandler(this.radButtonsSelect);
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(85, 34);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(202, 20);
            this.radTextBox1.TabIndex = 0;
            this.radTextBox1.ThemeName = "Material";
            // 
            // radButton3
            // 
            this.radButton3.Location = new System.Drawing.Point(352, 201);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(94, 37);
            this.radButton3.TabIndex = 3;
            this.radButton3.Text = "Отмена";
            this.radButton3.ThemeName = "Material";
            this.radButton3.Click += new System.EventHandler(this.radButton3_Click);
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(293, 34);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(83, 36);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "Выбор";
            this.radButton1.ThemeName = "Material";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // teachBtn
            // 
            this.teachBtn.Location = new System.Drawing.Point(252, 201);
            this.teachBtn.Name = "teachBtn";
            this.teachBtn.Size = new System.Drawing.Size(94, 37);
            this.teachBtn.TabIndex = 2;
            this.teachBtn.Text = "Обучить";
            this.teachBtn.ThemeName = "Material";
            this.teachBtn.Visible = false;
            this.teachBtn.Click += new System.EventHandler(this.teachBtn_Click);
            // 
            // Teach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(458, 250);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Teach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Обучение";
            this.Load += new System.EventHandler(this.formLoad);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinRadBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanRadBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog selectFolder;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private CircularProgressBar.CircularProgressBar progressBar1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panel;
        private Telerik.WinControls.UI.RadRadioButton sinRadBtn;
        private Telerik.WinControls.UI.RadRadioButton tanRadBtn;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton teachBtn;
    }
}