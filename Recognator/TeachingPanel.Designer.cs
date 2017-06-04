namespace Recognator
{
    partial class TeachingPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeachingPanel));
            this.teach_process_panel_progressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.SuspendLayout();
            // 
            // teach_process_panel_progressbar
            // 
            this.teach_process_panel_progressbar.animated = true;
            this.teach_process_panel_progressbar.animationIterval = 5;
            this.teach_process_panel_progressbar.animationSpeed = 3;
            this.teach_process_panel_progressbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.teach_process_panel_progressbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("teach_process_panel_progressbar.BackgroundImage")));
            this.teach_process_panel_progressbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.teach_process_panel_progressbar.ForeColor = System.Drawing.Color.SeaGreen;
            this.teach_process_panel_progressbar.LabelVisible = true;
            this.teach_process_panel_progressbar.LineProgressThickness = 8;
            this.teach_process_panel_progressbar.LineThickness = 5;
            this.teach_process_panel_progressbar.Location = new System.Drawing.Point(252, 126);
            this.teach_process_panel_progressbar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.teach_process_panel_progressbar.MaxValue = 100;
            this.teach_process_panel_progressbar.Name = "teach_process_panel_progressbar";
            this.teach_process_panel_progressbar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.teach_process_panel_progressbar.ProgressColor = System.Drawing.Color.SeaGreen;
            this.teach_process_panel_progressbar.Size = new System.Drawing.Size(201, 201);
            this.teach_process_panel_progressbar.TabIndex = 1;
            this.teach_process_panel_progressbar.Value = 1;
            // 
            // TeachingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.teach_process_panel_progressbar);
            this.Name = "TeachingPanel";
            this.Size = new System.Drawing.Size(725, 445);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar teach_process_panel_progressbar;
    }
}
