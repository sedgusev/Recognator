namespace Recognator
{
    partial class Settings
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
            this.login_panel = new System.Windows.Forms.Panel();
            this.USER = new System.Windows.Forms.TextBox();
            this.PORT = new System.Windows.Forms.TextBox();
            this.informationLabel = new System.Windows.Forms.Label();
            this.processTimeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.TextBox();
            this.PASSWORD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.login_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_panel
            // 
            this.login_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_panel.Controls.Add(this.USER);
            this.login_panel.Controls.Add(this.PORT);
            this.login_panel.Controls.Add(this.informationLabel);
            this.login_panel.Controls.Add(this.processTimeLabel);
            this.login_panel.Controls.Add(this.label4);
            this.login_panel.Controls.Add(this.label1);
            this.login_panel.Controls.Add(this.IP);
            this.login_panel.Controls.Add(this.PASSWORD);
            this.login_panel.Controls.Add(this.label3);
            this.login_panel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_panel.Location = new System.Drawing.Point(-2, -1);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(303, 101);
            this.login_panel.TabIndex = 2;
            // 
            // USER
            // 
            this.USER.Location = new System.Drawing.Point(89, 12);
            this.USER.Name = "USER";
            this.USER.Size = new System.Drawing.Size(148, 23);
            this.USER.TabIndex = 8;
            // 
            // PORT
            // 
            this.PORT.Location = new System.Drawing.Point(190, 64);
            this.PORT.Name = "PORT";
            this.PORT.Size = new System.Drawing.Size(47, 23);
            this.PORT.TabIndex = 15;
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Location = new System.Drawing.Point(52, 52);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(0, 15);
            this.informationLabel.TabIndex = 3;
            // 
            // processTimeLabel
            // 
            this.processTimeLabel.AutoSize = true;
            this.processTimeLabel.Location = new System.Drawing.Point(59, 51);
            this.processTimeLabel.Name = "processTimeLabel";
            this.processTimeLabel.Size = new System.Drawing.Size(0, 15);
            this.processTimeLabel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(59, 66);
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
            this.label1.Location = new System.Drawing.Point(39, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Логин:";
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(89, 64);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(95, 23);
            this.IP.TabIndex = 12;
            // 
            // PASSWORD
            // 
            this.PASSWORD.Location = new System.Drawing.Point(89, 38);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.PasswordChar = '●';
            this.PASSWORD.Size = new System.Drawing.Size(148, 23);
            this.PASSWORD.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(32, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Пароль:";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(218, 106);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(70, 36);
            this.radButton1.TabIndex = 3;
            this.radButton1.Text = "ОК";
            this.radButton1.ThemeName = "Material";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(300, 143);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.login_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор камеры";
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.TextBox USER;
        private System.Windows.Forms.TextBox PORT;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.Label processTimeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox PASSWORD;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
    }
}