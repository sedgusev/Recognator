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
            this.components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation2 = new AnimatorNS.Animation();
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.sidepanel = new System.Windows.Forms.Panel();
            this.header_panel = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.camera_panel = new System.Windows.Forms.Panel();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.PORT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.IP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PASSWORD = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.USER = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.animator1 = new AnimatorNS.Animator(this.components);
            this.demo_panel = new System.Windows.Forms.Panel();
            this.demo_panel_pathTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.teach_panel = new System.Windows.Forms.Panel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.teach_panel_pathTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.teach_process_panel = new System.Windows.Forms.Panel();
            this.main_panel = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.main_panel_passwordTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.main_panel_usernameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SwitchAnimator = new AnimatorNS.Animator(this.components);
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.main_panel_loginBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.teach_process_panel_progressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.teach_panel_switchT = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.teach_panel_switchS = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.teach_panel_teachBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.teach_panel_dialogBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.demo_panel_dialogBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.camera_panel_okBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.collapseBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.homeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cameraBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.demoBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.settingsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.minimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.exitBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.sidepanel.SuspendLayout();
            this.header_panel.SuspendLayout();
            this.camera_panel.SuspendLayout();
            this.demo_panel.SuspendLayout();
            this.teach_panel.SuspendLayout();
            this.teach_process_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teach_panel_dialogBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demo_panel_dialogBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.sidepanel.Controls.Add(this.collapseBtn);
            this.sidepanel.Controls.Add(this.homeBtn);
            this.sidepanel.Controls.Add(this.cameraBtn);
            this.sidepanel.Controls.Add(this.demoBtn);
            this.sidepanel.Controls.Add(this.settingsBtn);
            this.SwitchAnimator.SetDecoration(this.sidepanel, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.sidepanel, AnimatorNS.DecorationType.None);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 38);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(212, 429);
            this.sidepanel.TabIndex = 4;
            // 
            // header_panel
            // 
            this.header_panel.AllowDrop = true;
            this.header_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.header_panel.Controls.Add(this.materialLabel1);
            this.header_panel.Controls.Add(this.minimizeBtn);
            this.header_panel.Controls.Add(this.exitBtn);
            this.SwitchAnimator.SetDecoration(this.header_panel, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.header_panel, AnimatorNS.DecorationType.None);
            this.header_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel.Location = new System.Drawing.Point(0, 0);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(649, 38);
            this.header_panel.TabIndex = 5;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.SwitchAnimator.SetDecoration(this.materialLabel1, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.materialLabel1, AnimatorNS.DecorationType.None);
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(36, 13);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(86, 18);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Recognator";
            // 
            // camera_panel
            // 
            this.camera_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.camera_panel.Controls.Add(this.bunifuSeparator3);
            this.camera_panel.Controls.Add(this.camera_panel_okBtn);
            this.camera_panel.Controls.Add(this.PORT);
            this.camera_panel.Controls.Add(this.IP);
            this.camera_panel.Controls.Add(this.PASSWORD);
            this.camera_panel.Controls.Add(this.USER);
            this.SwitchAnimator.SetDecoration(this.camera_panel, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.camera_panel, AnimatorNS.DecorationType.None);
            this.camera_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.camera_panel.Location = new System.Drawing.Point(212, 38);
            this.camera_panel.Name = "camera_panel";
            this.camera_panel.Size = new System.Drawing.Size(437, 434);
            this.camera_panel.TabIndex = 6;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.SwitchAnimator.SetDecoration(this.bunifuSeparator3, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.bunifuSeparator3, AnimatorNS.DecorationType.None);
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(0, 340);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(639, 19);
            this.bunifuSeparator3.TabIndex = 8;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // PORT
            // 
            this.PORT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SwitchAnimator.SetDecoration(this.PORT, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.PORT, AnimatorNS.DecorationType.None);
            this.PORT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PORT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PORT.HintForeColor = System.Drawing.Color.White;
            this.PORT.HintText = "port";
            this.PORT.isPassword = false;
            this.PORT.LineFocusedColor = System.Drawing.Color.Lavender;
            this.PORT.LineIdleColor = System.Drawing.Color.Gray;
            this.PORT.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.PORT.LineThickness = 3;
            this.PORT.Location = new System.Drawing.Point(254, 173);
            this.PORT.Margin = new System.Windows.Forms.Padding(4);
            this.PORT.Name = "PORT";
            this.PORT.Size = new System.Drawing.Size(52, 40);
            this.PORT.TabIndex = 3;
            this.PORT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // IP
            // 
            this.IP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SwitchAnimator.SetDecoration(this.IP, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.IP, AnimatorNS.DecorationType.None);
            this.IP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.IP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IP.HintForeColor = System.Drawing.Color.White;
            this.IP.HintText = "ip";
            this.IP.isPassword = false;
            this.IP.LineFocusedColor = System.Drawing.Color.Lavender;
            this.IP.LineIdleColor = System.Drawing.Color.Gray;
            this.IP.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.IP.LineThickness = 3;
            this.IP.Location = new System.Drawing.Point(254, 125);
            this.IP.Margin = new System.Windows.Forms.Padding(4);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(133, 40);
            this.IP.TabIndex = 2;
            this.IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PASSWORD
            // 
            this.PASSWORD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SwitchAnimator.SetDecoration(this.PASSWORD, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.PASSWORD, AnimatorNS.DecorationType.None);
            this.PASSWORD.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PASSWORD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PASSWORD.HintForeColor = System.Drawing.Color.White;
            this.PASSWORD.HintText = "password";
            this.PASSWORD.isPassword = true;
            this.PASSWORD.LineFocusedColor = System.Drawing.Color.Lavender;
            this.PASSWORD.LineIdleColor = System.Drawing.Color.Gray;
            this.PASSWORD.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.PASSWORD.LineThickness = 3;
            this.PASSWORD.Location = new System.Drawing.Point(37, 173);
            this.PASSWORD.Margin = new System.Windows.Forms.Padding(4);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(195, 40);
            this.PASSWORD.TabIndex = 1;
            this.PASSWORD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // USER
            // 
            this.USER.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SwitchAnimator.SetDecoration(this.USER, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.USER, AnimatorNS.DecorationType.None);
            this.USER.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.USER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.USER.HintForeColor = System.Drawing.Color.White;
            this.USER.HintText = "username";
            this.USER.isPassword = false;
            this.USER.LineFocusedColor = System.Drawing.Color.Lavender;
            this.USER.LineIdleColor = System.Drawing.Color.Gray;
            this.USER.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.USER.LineThickness = 3;
            this.USER.Location = new System.Drawing.Point(37, 125);
            this.USER.Margin = new System.Windows.Forms.Padding(4);
            this.USER.Name = "USER";
            this.USER.Size = new System.Drawing.Size(195, 40);
            this.USER.TabIndex = 0;
            this.USER.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // animator1
            // 
            this.animator1.AnimationType = AnimatorNS.AnimationType.Mosaic;
            this.animator1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 20;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation2;
            // 
            // demo_panel
            // 
            this.demo_panel.Controls.Add(this.demo_panel_dialogBtn);
            this.demo_panel.Controls.Add(this.demo_panel_pathTb);
            this.SwitchAnimator.SetDecoration(this.demo_panel, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.demo_panel, AnimatorNS.DecorationType.None);
            this.demo_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.demo_panel.Location = new System.Drawing.Point(212, 472);
            this.demo_panel.Name = "demo_panel";
            this.demo_panel.Size = new System.Drawing.Size(437, 349);
            this.demo_panel.TabIndex = 7;
            // 
            // demo_panel_pathTb
            // 
            this.demo_panel_pathTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SwitchAnimator.SetDecoration(this.demo_panel_pathTb, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.demo_panel_pathTb, AnimatorNS.DecorationType.None);
            this.demo_panel_pathTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.demo_panel_pathTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.demo_panel_pathTb.HintForeColor = System.Drawing.Color.Empty;
            this.demo_panel_pathTb.HintText = "Путь к файлу";
            this.demo_panel_pathTb.isPassword = false;
            this.demo_panel_pathTb.LineFocusedColor = System.Drawing.Color.White;
            this.demo_panel_pathTb.LineIdleColor = System.Drawing.Color.Gray;
            this.demo_panel_pathTb.LineMouseHoverColor = System.Drawing.Color.White;
            this.demo_panel_pathTb.LineThickness = 3;
            this.demo_panel_pathTb.Location = new System.Drawing.Point(82, 108);
            this.demo_panel_pathTb.Margin = new System.Windows.Forms.Padding(4);
            this.demo_panel_pathTb.Name = "demo_panel_pathTb";
            this.demo_panel_pathTb.Size = new System.Drawing.Size(224, 44);
            this.demo_panel_pathTb.TabIndex = 0;
            this.demo_panel_pathTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // teach_panel
            // 
            this.teach_panel.Controls.Add(this.materialLabel3);
            this.teach_panel.Controls.Add(this.teach_panel_switchT);
            this.teach_panel.Controls.Add(this.materialLabel2);
            this.teach_panel.Controls.Add(this.bunifuSeparator1);
            this.teach_panel.Controls.Add(this.teach_panel_switchS);
            this.teach_panel.Controls.Add(this.teach_panel_teachBtn);
            this.teach_panel.Controls.Add(this.teach_panel_dialogBtn);
            this.teach_panel.Controls.Add(this.teach_panel_pathTb);
            this.SwitchAnimator.SetDecoration(this.teach_panel, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.teach_panel, AnimatorNS.DecorationType.None);
            this.teach_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.teach_panel.Location = new System.Drawing.Point(212, 821);
            this.teach_panel.Name = "teach_panel";
            this.teach_panel.Size = new System.Drawing.Size(437, 380);
            this.teach_panel.TabIndex = 8;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.SwitchAnimator.SetDecoration(this.materialLabel3, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.materialLabel3, AnimatorNS.DecorationType.None);
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(56, 198);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(120, 18);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Тангенциальная";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.SwitchAnimator.SetDecoration(this.materialLabel2, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.materialLabel2, AnimatorNS.DecorationType.None);
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(56, 168);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(119, 18);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Сигмоидальная";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.SwitchAnimator.SetDecoration(this.bunifuSeparator1, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.bunifuSeparator1, AnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 319);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(639, 22);
            this.bunifuSeparator1.TabIndex = 6;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // teach_panel_pathTb
            // 
            this.teach_panel_pathTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SwitchAnimator.SetDecoration(this.teach_panel_pathTb, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.teach_panel_pathTb, AnimatorNS.DecorationType.None);
            this.teach_panel_pathTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.teach_panel_pathTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teach_panel_pathTb.HintForeColor = System.Drawing.Color.Empty;
            this.teach_panel_pathTb.HintText = "Путь к файлу";
            this.teach_panel_pathTb.isPassword = false;
            this.teach_panel_pathTb.LineFocusedColor = System.Drawing.Color.White;
            this.teach_panel_pathTb.LineIdleColor = System.Drawing.Color.Gray;
            this.teach_panel_pathTb.LineMouseHoverColor = System.Drawing.Color.White;
            this.teach_panel_pathTb.LineThickness = 3;
            this.teach_panel_pathTb.Location = new System.Drawing.Point(82, 72);
            this.teach_panel_pathTb.Margin = new System.Windows.Forms.Padding(4);
            this.teach_panel_pathTb.Name = "teach_panel_pathTb";
            this.teach_panel_pathTb.Size = new System.Drawing.Size(224, 44);
            this.teach_panel_pathTb.TabIndex = 2;
            this.teach_panel_pathTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // teach_process_panel
            // 
            this.teach_process_panel.Controls.Add(this.teach_process_panel_progressbar);
            this.SwitchAnimator.SetDecoration(this.teach_process_panel, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.teach_process_panel, AnimatorNS.DecorationType.None);
            this.teach_process_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.teach_process_panel.Location = new System.Drawing.Point(212, 1201);
            this.teach_process_panel.Name = "teach_process_panel";
            this.teach_process_panel.Size = new System.Drawing.Size(437, 339);
            this.teach_process_panel.TabIndex = 9;
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.bunifuSeparator2);
            this.main_panel.Controls.Add(this.main_panel_loginBtn);
            this.main_panel.Controls.Add(this.main_panel_passwordTb);
            this.main_panel.Controls.Add(this.main_panel_usernameTb);
            this.SwitchAnimator.SetDecoration(this.main_panel, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.main_panel, AnimatorNS.DecorationType.None);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_panel.Location = new System.Drawing.Point(212, 1540);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(437, 351);
            this.main_panel.TabIndex = 10;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.SwitchAnimator.SetDecoration(this.bunifuSeparator2, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.bunifuSeparator2, AnimatorNS.DecorationType.None);
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 294);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(639, 20);
            this.bunifuSeparator2.TabIndex = 5;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // main_panel_passwordTb
            // 
            this.main_panel_passwordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SwitchAnimator.SetDecoration(this.main_panel_passwordTb, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.main_panel_passwordTb, AnimatorNS.DecorationType.None);
            this.main_panel_passwordTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.main_panel_passwordTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.main_panel_passwordTb.HintForeColor = System.Drawing.Color.White;
            this.main_panel_passwordTb.HintText = "password";
            this.main_panel_passwordTb.isPassword = true;
            this.main_panel_passwordTb.LineFocusedColor = System.Drawing.Color.Lavender;
            this.main_panel_passwordTb.LineIdleColor = System.Drawing.Color.Gray;
            this.main_panel_passwordTb.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.main_panel_passwordTb.LineThickness = 3;
            this.main_panel_passwordTb.Location = new System.Drawing.Point(94, 126);
            this.main_panel_passwordTb.Margin = new System.Windows.Forms.Padding(4);
            this.main_panel_passwordTb.Name = "main_panel_passwordTb";
            this.main_panel_passwordTb.Size = new System.Drawing.Size(195, 40);
            this.main_panel_passwordTb.TabIndex = 3;
            this.main_panel_passwordTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // main_panel_usernameTb
            // 
            this.main_panel_usernameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SwitchAnimator.SetDecoration(this.main_panel_usernameTb, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.main_panel_usernameTb, AnimatorNS.DecorationType.None);
            this.main_panel_usernameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.main_panel_usernameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.main_panel_usernameTb.HintForeColor = System.Drawing.Color.White;
            this.main_panel_usernameTb.HintText = "username";
            this.main_panel_usernameTb.isPassword = false;
            this.main_panel_usernameTb.LineFocusedColor = System.Drawing.Color.Lavender;
            this.main_panel_usernameTb.LineIdleColor = System.Drawing.Color.Gray;
            this.main_panel_usernameTb.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.main_panel_usernameTb.LineThickness = 3;
            this.main_panel_usernameTb.Location = new System.Drawing.Point(94, 78);
            this.main_panel_usernameTb.Margin = new System.Windows.Forms.Padding(4);
            this.main_panel_usernameTb.Name = "main_panel_usernameTb";
            this.main_panel_usernameTb.Size = new System.Drawing.Size(195, 40);
            this.main_panel_usernameTb.TabIndex = 2;
            this.main_panel_usernameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SwitchAnimator
            // 
            this.SwitchAnimator.AnimationType = AnimatorNS.AnimationType.VertSlide;
            this.SwitchAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.SwitchAnimator.DefaultAnimation = animation1;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.worker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_Completed);
            // 
            // main_panel_loginBtn
            // 
            this.main_panel_loginBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.main_panel_loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.main_panel_loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_panel_loginBtn.BorderRadius = 0;
            this.main_panel_loginBtn.ButtonText = "Войти";
            this.main_panel_loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchAnimator.SetDecoration(this.main_panel_loginBtn, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.main_panel_loginBtn, AnimatorNS.DecorationType.None);
            this.main_panel_loginBtn.DisabledColor = System.Drawing.Color.Gray;
            this.main_panel_loginBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.main_panel_loginBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("main_panel_loginBtn.Iconimage")));
            this.main_panel_loginBtn.Iconimage_right = null;
            this.main_panel_loginBtn.Iconimage_right_Selected = null;
            this.main_panel_loginBtn.Iconimage_Selected = null;
            this.main_panel_loginBtn.IconMarginLeft = 0;
            this.main_panel_loginBtn.IconMarginRight = 0;
            this.main_panel_loginBtn.IconRightVisible = true;
            this.main_panel_loginBtn.IconRightZoom = 0D;
            this.main_panel_loginBtn.IconVisible = true;
            this.main_panel_loginBtn.IconZoom = 90D;
            this.main_panel_loginBtn.IsTab = false;
            this.main_panel_loginBtn.Location = new System.Drawing.Point(308, 320);
            this.main_panel_loginBtn.Name = "main_panel_loginBtn";
            this.main_panel_loginBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.main_panel_loginBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.main_panel_loginBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.main_panel_loginBtn.selected = false;
            this.main_panel_loginBtn.Size = new System.Drawing.Size(117, 48);
            this.main_panel_loginBtn.TabIndex = 4;
            this.main_panel_loginBtn.Text = "Войти";
            this.main_panel_loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.main_panel_loginBtn.Textcolor = System.Drawing.Color.White;
            this.main_panel_loginBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // teach_process_panel_progressbar
            // 
            this.teach_process_panel_progressbar.animated = true;
            this.teach_process_panel_progressbar.animationIterval = 5;
            this.teach_process_panel_progressbar.animationSpeed = 3;
            this.teach_process_panel_progressbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.teach_process_panel_progressbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("teach_process_panel_progressbar.BackgroundImage")));
            this.SwitchAnimator.SetDecoration(this.teach_process_panel_progressbar, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.teach_process_panel_progressbar, AnimatorNS.DecorationType.None);
            this.teach_process_panel_progressbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.teach_process_panel_progressbar.ForeColor = System.Drawing.Color.SeaGreen;
            this.teach_process_panel_progressbar.LabelVisible = true;
            this.teach_process_panel_progressbar.LineProgressThickness = 8;
            this.teach_process_panel_progressbar.LineThickness = 5;
            this.teach_process_panel_progressbar.Location = new System.Drawing.Point(107, 71);
            this.teach_process_panel_progressbar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.teach_process_panel_progressbar.MaxValue = 100;
            this.teach_process_panel_progressbar.Name = "teach_process_panel_progressbar";
            this.teach_process_panel_progressbar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.teach_process_panel_progressbar.ProgressColor = System.Drawing.Color.SeaGreen;
            this.teach_process_panel_progressbar.Size = new System.Drawing.Size(201, 201);
            this.teach_process_panel_progressbar.TabIndex = 0;
            this.teach_process_panel_progressbar.Value = 1;
            // 
            // teach_panel_switchT
            // 
            this.teach_panel_switchT.BackColor = System.Drawing.Color.Transparent;
            this.teach_panel_switchT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("teach_panel_switchT.BackgroundImage")));
            this.teach_panel_switchT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.teach_panel_switchT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchAnimator.SetDecoration(this.teach_panel_switchT, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.teach_panel_switchT, AnimatorNS.DecorationType.None);
            this.teach_panel_switchT.Location = new System.Drawing.Point(189, 193);
            this.teach_panel_switchT.Name = "teach_panel_switchT";
            this.teach_panel_switchT.OffColor = System.Drawing.Color.Gray;
            this.teach_panel_switchT.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.teach_panel_switchT.Size = new System.Drawing.Size(43, 25);
            this.teach_panel_switchT.TabIndex = 12;
            this.teach_panel_switchT.Value = true;
            // 
            // teach_panel_switchS
            // 
            this.teach_panel_switchS.BackColor = System.Drawing.Color.Transparent;
            this.teach_panel_switchS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("teach_panel_switchS.BackgroundImage")));
            this.teach_panel_switchS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.teach_panel_switchS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchAnimator.SetDecoration(this.teach_panel_switchS, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.teach_panel_switchS, AnimatorNS.DecorationType.None);
            this.teach_panel_switchS.Location = new System.Drawing.Point(189, 163);
            this.teach_panel_switchS.Name = "teach_panel_switchS";
            this.teach_panel_switchS.OffColor = System.Drawing.Color.Gray;
            this.teach_panel_switchS.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.teach_panel_switchS.Size = new System.Drawing.Size(43, 25);
            this.teach_panel_switchS.TabIndex = 5;
            this.teach_panel_switchS.Value = true;
            // 
            // teach_panel_teachBtn
            // 
            this.teach_panel_teachBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.teach_panel_teachBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.teach_panel_teachBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.teach_panel_teachBtn.BorderRadius = 0;
            this.teach_panel_teachBtn.ButtonText = "Обучить";
            this.teach_panel_teachBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchAnimator.SetDecoration(this.teach_panel_teachBtn, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.teach_panel_teachBtn, AnimatorNS.DecorationType.None);
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
            this.teach_panel_teachBtn.Location = new System.Drawing.Point(308, 347);
            this.teach_panel_teachBtn.Name = "teach_panel_teachBtn";
            this.teach_panel_teachBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.teach_panel_teachBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.teach_panel_teachBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.teach_panel_teachBtn.selected = false;
            this.teach_panel_teachBtn.Size = new System.Drawing.Size(121, 48);
            this.teach_panel_teachBtn.TabIndex = 4;
            this.teach_panel_teachBtn.Text = "Обучить";
            this.teach_panel_teachBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.teach_panel_teachBtn.Textcolor = System.Drawing.Color.White;
            this.teach_panel_teachBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // teach_panel_dialogBtn
            // 
            this.teach_panel_dialogBtn.BackColor = System.Drawing.Color.Transparent;
            this.SwitchAnimator.SetDecoration(this.teach_panel_dialogBtn, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.teach_panel_dialogBtn, AnimatorNS.DecorationType.None);
            this.teach_panel_dialogBtn.Image = ((System.Drawing.Image)(resources.GetObject("teach_panel_dialogBtn.Image")));
            this.teach_panel_dialogBtn.ImageActive = null;
            this.teach_panel_dialogBtn.Location = new System.Drawing.Point(313, 72);
            this.teach_panel_dialogBtn.Name = "teach_panel_dialogBtn";
            this.teach_panel_dialogBtn.Size = new System.Drawing.Size(44, 44);
            this.teach_panel_dialogBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.teach_panel_dialogBtn.TabIndex = 3;
            this.teach_panel_dialogBtn.TabStop = false;
            this.teach_panel_dialogBtn.Zoom = 10;
            // 
            // demo_panel_dialogBtn
            // 
            this.demo_panel_dialogBtn.BackColor = System.Drawing.Color.Transparent;
            this.SwitchAnimator.SetDecoration(this.demo_panel_dialogBtn, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.demo_panel_dialogBtn, AnimatorNS.DecorationType.None);
            this.demo_panel_dialogBtn.Image = ((System.Drawing.Image)(resources.GetObject("demo_panel_dialogBtn.Image")));
            this.demo_panel_dialogBtn.ImageActive = null;
            this.demo_panel_dialogBtn.Location = new System.Drawing.Point(313, 108);
            this.demo_panel_dialogBtn.Name = "demo_panel_dialogBtn";
            this.demo_panel_dialogBtn.Size = new System.Drawing.Size(44, 44);
            this.demo_panel_dialogBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.demo_panel_dialogBtn.TabIndex = 1;
            this.demo_panel_dialogBtn.TabStop = false;
            this.demo_panel_dialogBtn.Zoom = 10;
            // 
            // camera_panel_okBtn
            // 
            this.camera_panel_okBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.camera_panel_okBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.camera_panel_okBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.camera_panel_okBtn.BorderRadius = 0;
            this.camera_panel_okBtn.ButtonText = "OK";
            this.camera_panel_okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchAnimator.SetDecoration(this.camera_panel_okBtn, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.camera_panel_okBtn, AnimatorNS.DecorationType.None);
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
            this.camera_panel_okBtn.Location = new System.Drawing.Point(335, 365);
            this.camera_panel_okBtn.Name = "camera_panel_okBtn";
            this.camera_panel_okBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.camera_panel_okBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.camera_panel_okBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.camera_panel_okBtn.selected = false;
            this.camera_panel_okBtn.Size = new System.Drawing.Size(90, 48);
            this.camera_panel_okBtn.TabIndex = 7;
            this.camera_panel_okBtn.Text = "OK";
            this.camera_panel_okBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.camera_panel_okBtn.Textcolor = System.Drawing.Color.White;
            this.camera_panel_okBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // collapseBtn
            // 
            this.collapseBtn.Activecolor = System.Drawing.Color.Transparent;
            this.collapseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.collapseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.collapseBtn.BorderRadius = 0;
            this.collapseBtn.ButtonText = "";
            this.collapseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchAnimator.SetDecoration(this.collapseBtn, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.collapseBtn, AnimatorNS.DecorationType.None);
            this.collapseBtn.DisabledColor = System.Drawing.Color.Gray;
            this.collapseBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.collapseBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("collapseBtn.Iconimage")));
            this.collapseBtn.Iconimage_right = null;
            this.collapseBtn.Iconimage_right_Selected = null;
            this.collapseBtn.Iconimage_Selected = null;
            this.collapseBtn.IconMarginLeft = 0;
            this.collapseBtn.IconMarginRight = 0;
            this.collapseBtn.IconRightVisible = true;
            this.collapseBtn.IconRightZoom = 0D;
            this.collapseBtn.IconVisible = true;
            this.collapseBtn.IconZoom = 50D;
            this.collapseBtn.IsTab = false;
            this.collapseBtn.Location = new System.Drawing.Point(0, 6);
            this.collapseBtn.Name = "collapseBtn";
            this.collapseBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.collapseBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.collapseBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.collapseBtn.selected = false;
            this.collapseBtn.Size = new System.Drawing.Size(212, 48);
            this.collapseBtn.TabIndex = 16;
            this.collapseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.collapseBtn.Textcolor = System.Drawing.Color.White;
            this.collapseBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collapseBtn.Click += new System.EventHandler(this.collapseBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeBtn.BorderRadius = 0;
            this.homeBtn.ButtonText = "Главная";
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchAnimator.SetDecoration(this.homeBtn, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.homeBtn, AnimatorNS.DecorationType.None);
            this.homeBtn.DisabledColor = System.Drawing.Color.Gray;
            this.homeBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.homeBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("homeBtn.Iconimage")));
            this.homeBtn.Iconimage_right = null;
            this.homeBtn.Iconimage_right_Selected = null;
            this.homeBtn.Iconimage_Selected = null;
            this.homeBtn.IconMarginLeft = 0;
            this.homeBtn.IconMarginRight = 0;
            this.homeBtn.IconRightVisible = true;
            this.homeBtn.IconRightZoom = 0D;
            this.homeBtn.IconVisible = true;
            this.homeBtn.IconZoom = 50D;
            this.homeBtn.IsTab = true;
            this.homeBtn.Location = new System.Drawing.Point(0, 82);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.homeBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.homeBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.homeBtn.selected = false;
            this.homeBtn.Size = new System.Drawing.Size(209, 48);
            this.homeBtn.TabIndex = 15;
            this.homeBtn.Text = "Главная";
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homeBtn.Textcolor = System.Drawing.Color.White;
            this.homeBtn.TextFont = new System.Drawing.Font("Californian FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // cameraBtn
            // 
            this.cameraBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.cameraBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.cameraBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cameraBtn.BorderRadius = 0;
            this.cameraBtn.ButtonText = "Камера";
            this.cameraBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchAnimator.SetDecoration(this.cameraBtn, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.cameraBtn, AnimatorNS.DecorationType.None);
            this.cameraBtn.DisabledColor = System.Drawing.Color.Gray;
            this.cameraBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.cameraBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("cameraBtn.Iconimage")));
            this.cameraBtn.Iconimage_right = null;
            this.cameraBtn.Iconimage_right_Selected = null;
            this.cameraBtn.Iconimage_Selected = null;
            this.cameraBtn.IconMarginLeft = 0;
            this.cameraBtn.IconMarginRight = 0;
            this.cameraBtn.IconRightVisible = true;
            this.cameraBtn.IconRightZoom = 0D;
            this.cameraBtn.IconVisible = true;
            this.cameraBtn.IconZoom = 50D;
            this.cameraBtn.IsTab = true;
            this.cameraBtn.Location = new System.Drawing.Point(0, 136);
            this.cameraBtn.Name = "cameraBtn";
            this.cameraBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.cameraBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.cameraBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.cameraBtn.selected = false;
            this.cameraBtn.Size = new System.Drawing.Size(209, 48);
            this.cameraBtn.TabIndex = 14;
            this.cameraBtn.Text = "Камера";
            this.cameraBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cameraBtn.Textcolor = System.Drawing.Color.White;
            this.cameraBtn.TextFont = new System.Drawing.Font("Californian FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cameraBtn.Click += new System.EventHandler(this.cameraBtn_Click);
            // 
            // demoBtn
            // 
            this.demoBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.demoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.demoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.demoBtn.BorderRadius = 0;
            this.demoBtn.ButtonText = "Демонстрация";
            this.demoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchAnimator.SetDecoration(this.demoBtn, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.demoBtn, AnimatorNS.DecorationType.None);
            this.demoBtn.DisabledColor = System.Drawing.Color.Gray;
            this.demoBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.demoBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("demoBtn.Iconimage")));
            this.demoBtn.Iconimage_right = null;
            this.demoBtn.Iconimage_right_Selected = null;
            this.demoBtn.Iconimage_Selected = null;
            this.demoBtn.IconMarginLeft = 0;
            this.demoBtn.IconMarginRight = 0;
            this.demoBtn.IconRightVisible = true;
            this.demoBtn.IconRightZoom = 0D;
            this.demoBtn.IconVisible = true;
            this.demoBtn.IconZoom = 50D;
            this.demoBtn.IsTab = true;
            this.demoBtn.Location = new System.Drawing.Point(0, 190);
            this.demoBtn.Name = "demoBtn";
            this.demoBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.demoBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.demoBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.demoBtn.selected = false;
            this.demoBtn.Size = new System.Drawing.Size(209, 48);
            this.demoBtn.TabIndex = 13;
            this.demoBtn.Text = "Демонстрация";
            this.demoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.demoBtn.Textcolor = System.Drawing.Color.White;
            this.demoBtn.TextFont = new System.Drawing.Font("Californian FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demoBtn.Click += new System.EventHandler(this.demoBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.settingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsBtn.BorderRadius = 0;
            this.settingsBtn.ButtonText = "Настройки";
            this.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchAnimator.SetDecoration(this.settingsBtn, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.settingsBtn, AnimatorNS.DecorationType.None);
            this.settingsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.settingsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.settingsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Iconimage")));
            this.settingsBtn.Iconimage_right = null;
            this.settingsBtn.Iconimage_right_Selected = null;
            this.settingsBtn.Iconimage_Selected = null;
            this.settingsBtn.IconMarginLeft = 0;
            this.settingsBtn.IconMarginRight = 0;
            this.settingsBtn.IconRightVisible = true;
            this.settingsBtn.IconRightZoom = 0D;
            this.settingsBtn.IconVisible = true;
            this.settingsBtn.IconZoom = 50D;
            this.settingsBtn.IsTab = true;
            this.settingsBtn.Location = new System.Drawing.Point(0, 244);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.settingsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.settingsBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.settingsBtn.selected = false;
            this.settingsBtn.Size = new System.Drawing.Size(209, 48);
            this.settingsBtn.TabIndex = 8;
            this.settingsBtn.Text = "Настройки";
            this.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingsBtn.Textcolor = System.Drawing.Color.White;
            this.settingsBtn.TextFont = new System.Drawing.Font("Californian FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.SwitchAnimator.SetDecoration(this.minimizeBtn, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.minimizeBtn, AnimatorNS.DecorationType.None);
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.ImageActive = null;
            this.minimizeBtn.Location = new System.Drawing.Point(579, 6);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(25, 25);
            this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeBtn.TabIndex = 9;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Zoom = 4;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.SwitchAnimator.SetDecoration(this.exitBtn, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.exitBtn, AnimatorNS.DecorationType.None);
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageActive = null;
            this.exitBtn.Location = new System.Drawing.Point(616, 6);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(25, 25);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBtn.TabIndex = 8;
            this.exitBtn.TabStop = false;
            this.exitBtn.Zoom = 4;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Settings
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(649, 467);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.teach_process_panel);
            this.Controls.Add(this.teach_panel);
            this.Controls.Add(this.demo_panel);
            this.Controls.Add(this.camera_panel);
            this.Controls.Add(this.sidepanel);
            this.Controls.Add(this.header_panel);
            this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.SwitchAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор камеры";
            this.Load += new System.EventHandler(this.formLoad);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.sidepanel.ResumeLayout(false);
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.camera_panel.ResumeLayout(false);
            this.demo_panel.ResumeLayout(false);
            this.teach_panel.ResumeLayout(false);
            this.teach_panel.PerformLayout();
            this.teach_process_panel.ResumeLayout(false);
            this.main_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teach_panel_dialogBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demo_panel_dialogBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel header_panel;
        private Bunifu.Framework.UI.BunifuImageButton minimizeBtn;
        private Bunifu.Framework.UI.BunifuImageButton exitBtn;
        private System.Windows.Forms.Panel camera_panel;
        private Bunifu.Framework.UI.BunifuFlatButton camera_panel_okBtn;
        private Bunifu.Framework.UI.BunifuFlatButton collapseBtn;
        private Bunifu.Framework.UI.BunifuFlatButton homeBtn;
        private Bunifu.Framework.UI.BunifuFlatButton cameraBtn;
        private Bunifu.Framework.UI.BunifuFlatButton demoBtn;
        private Bunifu.Framework.UI.BunifuFlatButton settingsBtn;
        private AnimatorNS.Animator animator1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PASSWORD;
        private Bunifu.Framework.UI.BunifuMaterialTextbox USER;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PORT;
        private Bunifu.Framework.UI.BunifuMaterialTextbox IP;
        private System.Windows.Forms.Panel demo_panel;
        private Bunifu.Framework.UI.BunifuImageButton demo_panel_dialogBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox demo_panel_pathTb;
        private System.Windows.Forms.Panel teach_panel;
        private Bunifu.Framework.UI.BunifuImageButton teach_panel_dialogBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox teach_panel_pathTb;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private Bunifu.Framework.UI.BunifuiOSSwitch teach_panel_switchT;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuiOSSwitch teach_panel_switchS;
        private Bunifu.Framework.UI.BunifuFlatButton teach_panel_teachBtn;
        private System.Windows.Forms.Panel teach_process_panel;
        private AnimatorNS.Animator SwitchAnimator;
        private Bunifu.Framework.UI.BunifuCircleProgressbar teach_process_panel_progressbar;
        private System.Windows.Forms.Panel main_panel;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuFlatButton main_panel_loginBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox main_panel_passwordTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox main_panel_usernameTb;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}