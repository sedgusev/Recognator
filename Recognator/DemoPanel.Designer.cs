namespace Recognator
{
    partial class DemoPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoPanel));
            this.demo_panel_dialogBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.demo_panel_pathTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.demo_panel_dialogBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // demo_panel_dialogBtn
            // 
            this.demo_panel_dialogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.demo_panel_dialogBtn.Image = ((System.Drawing.Image)(resources.GetObject("demo_panel_dialogBtn.Image")));
            this.demo_panel_dialogBtn.ImageActive = null;
            this.demo_panel_dialogBtn.Location = new System.Drawing.Point(432, 174);
            this.demo_panel_dialogBtn.Name = "demo_panel_dialogBtn";
            this.demo_panel_dialogBtn.Size = new System.Drawing.Size(48, 44);
            this.demo_panel_dialogBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.demo_panel_dialogBtn.TabIndex = 3;
            this.demo_panel_dialogBtn.TabStop = false;
            this.demo_panel_dialogBtn.Zoom = 10;
            this.demo_panel_dialogBtn.Click += new System.EventHandler(this.demo_panel_dialogBtn_Click);
            // 
            // demo_panel_pathTb
            // 
            this.demo_panel_pathTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.demo_panel_pathTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.demo_panel_pathTb.ForeColor = System.Drawing.Color.White;
            this.demo_panel_pathTb.HintForeColor = System.Drawing.Color.Gainsboro;
            this.demo_panel_pathTb.HintText = "Путь к видеофайлу";
            this.demo_panel_pathTb.isPassword = false;
            this.demo_panel_pathTb.LineFocusedColor = System.Drawing.Color.White;
            this.demo_panel_pathTb.LineIdleColor = System.Drawing.Color.Gray;
            this.demo_panel_pathTb.LineMouseHoverColor = System.Drawing.Color.White;
            this.demo_panel_pathTb.LineThickness = 3;
            this.demo_panel_pathTb.Location = new System.Drawing.Point(201, 174);
            this.demo_panel_pathTb.Margin = new System.Windows.Forms.Padding(4);
            this.demo_panel_pathTb.Name = "demo_panel_pathTb";
            this.demo_panel_pathTb.Size = new System.Drawing.Size(224, 44);
            this.demo_panel_pathTb.TabIndex = 2;
            this.demo_panel_pathTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DemoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.demo_panel_dialogBtn);
            this.Controls.Add(this.demo_panel_pathTb);
            this.Name = "DemoPanel";
            this.Size = new System.Drawing.Size(725, 445);
            ((System.ComponentModel.ISupportInitialize)(this.demo_panel_dialogBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton demo_panel_dialogBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox demo_panel_pathTb;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
