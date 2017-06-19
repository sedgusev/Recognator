namespace Recognator
{
    partial class CameraPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraPanel));
            this.PORT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.IP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PASSWORD = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.USER = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.camera_panel_okBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.SuspendLayout();
            // 
            // PORT
            // 
            this.PORT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PORT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PORT.ForeColor = System.Drawing.Color.White;
            this.PORT.HintForeColor = System.Drawing.Color.White;
            this.PORT.HintText = "port";
            this.PORT.isPassword = false;
            this.PORT.LineFocusedColor = System.Drawing.Color.Lavender;
            this.PORT.LineIdleColor = System.Drawing.Color.Gray;
            this.PORT.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.PORT.LineThickness = 3;
            this.PORT.Location = new System.Drawing.Point(399, 217);
            this.PORT.Margin = new System.Windows.Forms.Padding(4);
            this.PORT.Name = "PORT";
            this.PORT.Size = new System.Drawing.Size(52, 40);
            this.PORT.TabIndex = 7;
            this.PORT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // IP
            // 
            this.IP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.IP.ForeColor = System.Drawing.Color.White;
            this.IP.HintForeColor = System.Drawing.Color.White;
            this.IP.HintText = "ip";
            this.IP.isPassword = false;
            this.IP.LineFocusedColor = System.Drawing.Color.Lavender;
            this.IP.LineIdleColor = System.Drawing.Color.Gray;
            this.IP.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.IP.LineThickness = 3;
            this.IP.Location = new System.Drawing.Point(399, 169);
            this.IP.Margin = new System.Windows.Forms.Padding(4);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(133, 40);
            this.IP.TabIndex = 6;
            this.IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PASSWORD
            // 
            this.PASSWORD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PASSWORD.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PASSWORD.ForeColor = System.Drawing.Color.White;
            this.PASSWORD.HintForeColor = System.Drawing.Color.White;
            this.PASSWORD.HintText = "password";
            this.PASSWORD.isPassword = true;
            this.PASSWORD.LineFocusedColor = System.Drawing.Color.Lavender;
            this.PASSWORD.LineIdleColor = System.Drawing.Color.Gray;
            this.PASSWORD.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.PASSWORD.LineThickness = 3;
            this.PASSWORD.Location = new System.Drawing.Point(182, 217);
            this.PASSWORD.Margin = new System.Windows.Forms.Padding(4);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(195, 40);
            this.PASSWORD.TabIndex = 5;
            this.PASSWORD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // USER
            // 
            this.USER.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.USER.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.USER.ForeColor = System.Drawing.Color.White;
            this.USER.HintForeColor = System.Drawing.Color.White;
            this.USER.HintText = "username";
            this.USER.isPassword = false;
            this.USER.LineFocusedColor = System.Drawing.Color.Lavender;
            this.USER.LineIdleColor = System.Drawing.Color.Gray;
            this.USER.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.USER.LineThickness = 3;
            this.USER.Location = new System.Drawing.Point(182, 169);
            this.USER.Margin = new System.Windows.Forms.Padding(4);
            this.USER.Name = "USER";
            this.USER.Size = new System.Drawing.Size(195, 40);
            this.USER.TabIndex = 4;
            this.USER.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // camera_panel_okBtn
            // 
            this.camera_panel_okBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.camera_panel_okBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.camera_panel_okBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.camera_panel_okBtn.BorderRadius = 0;
            this.camera_panel_okBtn.ButtonText = "OK";
            this.camera_panel_okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.camera_panel_okBtn.DisabledColor = System.Drawing.Color.Gray;
            this.camera_panel_okBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.camera_panel_okBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("camera_panel_okBtn.Iconimage")));
            this.camera_panel_okBtn.Iconimage_right = null;
            this.camera_panel_okBtn.Iconimage_right_Selected = null;
            this.camera_panel_okBtn.Iconimage_Selected = null;
            this.camera_panel_okBtn.IconMarginLeft = 0;
            this.camera_panel_okBtn.IconMarginRight = 0;
            this.camera_panel_okBtn.IconRightVisible = true;
            this.camera_panel_okBtn.IconRightZoom = 0D;
            this.camera_panel_okBtn.IconVisible = true;
            this.camera_panel_okBtn.IconZoom = 90D;
            this.camera_panel_okBtn.IsTab = false;
            this.camera_panel_okBtn.Location = new System.Drawing.Point(563, 372);
            this.camera_panel_okBtn.Name = "camera_panel_okBtn";
            this.camera_panel_okBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.camera_panel_okBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.camera_panel_okBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.camera_panel_okBtn.selected = false;
            this.camera_panel_okBtn.Size = new System.Drawing.Size(117, 48);
            this.camera_panel_okBtn.TabIndex = 8;
            this.camera_panel_okBtn.Text = "OK";
            this.camera_panel_okBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.camera_panel_okBtn.Textcolor = System.Drawing.Color.White;
            this.camera_panel_okBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camera_panel_okBtn.Click += new System.EventHandler(this.camera_panel_okBtn_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(54, 327);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(639, 20);
            this.bunifuSeparator2.TabIndex = 10;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // CameraPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.camera_panel_okBtn);
            this.Controls.Add(this.PORT);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.USER);
            this.Name = "CameraPanel";
            this.Size = new System.Drawing.Size(725, 445);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox PORT;
        private Bunifu.Framework.UI.BunifuMaterialTextbox IP;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PASSWORD;
        private Bunifu.Framework.UI.BunifuMaterialTextbox USER;
        private Bunifu.Framework.UI.BunifuFlatButton camera_panel_okBtn;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
    }
}
