namespace Recognator
{
    partial class TeachPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeachPanel));
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.teach_panel_pathTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.teach_panel_switchT = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.teach_panel_switchS = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.teach_panel_teachBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.teach_panel_dialogBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.selectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.teach_panel_dialogBtn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(43, 321);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(639, 22);
            this.bunifuSeparator1.TabIndex = 18;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // teach_panel_pathTb
            // 
            this.teach_panel_pathTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.teach_panel_pathTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.teach_panel_pathTb.ForeColor = System.Drawing.Color.White;
            this.teach_panel_pathTb.HintForeColor = System.Drawing.Color.Empty;
            this.teach_panel_pathTb.HintText = "Путь к обучающей выборке";
            this.teach_panel_pathTb.isPassword = false;
            this.teach_panel_pathTb.LineFocusedColor = System.Drawing.Color.White;
            this.teach_panel_pathTb.LineIdleColor = System.Drawing.Color.Gray;
            this.teach_panel_pathTb.LineMouseHoverColor = System.Drawing.Color.White;
            this.teach_panel_pathTb.LineThickness = 3;
            this.teach_panel_pathTb.Location = new System.Drawing.Point(202, 125);
            this.teach_panel_pathTb.Margin = new System.Windows.Forms.Padding(4);
            this.teach_panel_pathTb.Name = "teach_panel_pathTb";
            this.teach_panel_pathTb.Size = new System.Drawing.Size(224, 44);
            this.teach_panel_pathTb.TabIndex = 14;
            this.teach_panel_pathTb.Text = "Путь к файлу";
            this.teach_panel_pathTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // teach_panel_switchT
            // 
            this.teach_panel_switchT.BackColor = System.Drawing.Color.Transparent;
            this.teach_panel_switchT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("teach_panel_switchT.BackgroundImage")));
            this.teach_panel_switchT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.teach_panel_switchT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teach_panel_switchT.Location = new System.Drawing.Point(140, 45);
            this.teach_panel_switchT.Name = "teach_panel_switchT";
            this.teach_panel_switchT.OffColor = System.Drawing.Color.Gray;
            this.teach_panel_switchT.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.teach_panel_switchT.Size = new System.Drawing.Size(43, 25);
            this.teach_panel_switchT.TabIndex = 20;
            this.teach_panel_switchT.Value = true;
            this.teach_panel_switchT.Click += new System.EventHandler(this.selectRadBtn);
            // 
            // teach_panel_switchS
            // 
            this.teach_panel_switchS.BackColor = System.Drawing.Color.Transparent;
            this.teach_panel_switchS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("teach_panel_switchS.BackgroundImage")));
            this.teach_panel_switchS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.teach_panel_switchS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teach_panel_switchS.Location = new System.Drawing.Point(140, 15);
            this.teach_panel_switchS.Name = "teach_panel_switchS";
            this.teach_panel_switchS.OffColor = System.Drawing.Color.Gray;
            this.teach_panel_switchS.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.teach_panel_switchS.Size = new System.Drawing.Size(43, 25);
            this.teach_panel_switchS.TabIndex = 17;
            this.teach_panel_switchS.Value = true;
            this.teach_panel_switchS.Click += new System.EventHandler(this.selectRadBtn);
            // 
            // teach_panel_teachBtn
            // 
            this.teach_panel_teachBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.teach_panel_teachBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.teach_panel_teachBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.teach_panel_teachBtn.BorderRadius = 0;
            this.teach_panel_teachBtn.ButtonText = "Обучить";
            this.teach_panel_teachBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teach_panel_teachBtn.DisabledColor = System.Drawing.Color.Gray;
            this.teach_panel_teachBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.teach_panel_teachBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("teach_panel_teachBtn.Iconimage")));
            this.teach_panel_teachBtn.Iconimage_right = null;
            this.teach_panel_teachBtn.Iconimage_right_Selected = null;
            this.teach_panel_teachBtn.Iconimage_Selected = null;
            this.teach_panel_teachBtn.IconMarginLeft = 0;
            this.teach_panel_teachBtn.IconMarginRight = 0;
            this.teach_panel_teachBtn.IconRightVisible = true;
            this.teach_panel_teachBtn.IconRightZoom = 0D;
            this.teach_panel_teachBtn.IconVisible = true;
            this.teach_panel_teachBtn.IconZoom = 90D;
            this.teach_panel_teachBtn.IsTab = false;
            this.teach_panel_teachBtn.Location = new System.Drawing.Point(539, 369);
            this.teach_panel_teachBtn.Name = "teach_panel_teachBtn";
            this.teach_panel_teachBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.teach_panel_teachBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.teach_panel_teachBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.teach_panel_teachBtn.selected = false;
            this.teach_panel_teachBtn.Size = new System.Drawing.Size(121, 48);
            this.teach_panel_teachBtn.TabIndex = 16;
            this.teach_panel_teachBtn.Text = "Обучить";
            this.teach_panel_teachBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.teach_panel_teachBtn.Textcolor = System.Drawing.Color.White;
            this.teach_panel_teachBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teach_panel_teachBtn.Visible = false;
            this.teach_panel_teachBtn.Click += new System.EventHandler(this.teach_panel_teachBtn_Click);
            // 
            // teach_panel_dialogBtn
            // 
            this.teach_panel_dialogBtn.BackColor = System.Drawing.Color.Transparent;
            this.teach_panel_dialogBtn.Image = ((System.Drawing.Image)(resources.GetObject("teach_panel_dialogBtn.Image")));
            this.teach_panel_dialogBtn.ImageActive = null;
            this.teach_panel_dialogBtn.Location = new System.Drawing.Point(433, 125);
            this.teach_panel_dialogBtn.Name = "teach_panel_dialogBtn";
            this.teach_panel_dialogBtn.Size = new System.Drawing.Size(44, 44);
            this.teach_panel_dialogBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.teach_panel_dialogBtn.TabIndex = 15;
            this.teach_panel_dialogBtn.TabStop = false;
            this.teach_panel_dialogBtn.Zoom = 10;
            this.teach_panel_dialogBtn.Click += new System.EventHandler(this.teach_panel_dialogBtn_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(116, 207);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(147, 18);
            this.bunifuCustomLabel1.TabIndex = 22;
            this.bunifuCustomLabel1.Text = "Функция активации:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(7, 22);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(119, 18);
            this.bunifuCustomLabel2.TabIndex = 23;
            this.bunifuCustomLabel2.Text = "Сигмоидальная";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(7, 52);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(120, 18);
            this.bunifuCustomLabel3.TabIndex = 24;
            this.bunifuCustomLabel3.Text = "Тангенциальная";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.teach_panel_switchT);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.teach_panel_switchS);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Location = new System.Drawing.Point(119, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 88);
            this.panel1.TabIndex = 25;
            // 
            // TeachPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.teach_panel_teachBtn);
            this.Controls.Add(this.teach_panel_dialogBtn);
            this.Controls.Add(this.teach_panel_pathTb);
            this.Name = "TeachPanel";
            this.Size = new System.Drawing.Size(725, 445);
            ((System.ComponentModel.ISupportInitialize)(this.teach_panel_dialogBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuiOSSwitch teach_panel_switchT;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuiOSSwitch teach_panel_switchS;
        private Bunifu.Framework.UI.BunifuFlatButton teach_panel_teachBtn;
        private Bunifu.Framework.UI.BunifuImageButton teach_panel_dialogBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox teach_panel_pathTb;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.FolderBrowserDialog selectFolder;
        private System.Windows.Forms.Panel panel1;
    }
}
