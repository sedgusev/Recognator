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
            AnimatorNS.Animation animation3 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            AnimatorNS.Animation animation4 = new AnimatorNS.Animation();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.collapseBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.homeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cameraBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.demoBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.settingsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.header_panel = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.minimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.exitBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.animator1 = new AnimatorNS.Animator(this.components);
            this.container = new System.Windows.Forms.Panel();
            this.errorPanel = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SwitchAnimator = new AnimatorNS.Animator(this.components);
            this.captureLoadWorker = new System.ComponentModel.BackgroundWorker();
            this.dbConnect = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.sidepanel.SuspendLayout();
            this.header_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            this.container.SuspendLayout();
            this.errorPanel.SuspendLayout();
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
            this.sidepanel.Size = new System.Drawing.Size(212, 475);
            this.sidepanel.TabIndex = 4;
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
            this.homeBtn.IconMarginLeft = 20;
            this.homeBtn.IconMarginRight = 0;
            this.homeBtn.IconRightVisible = true;
            this.homeBtn.IconRightZoom = 10D;
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
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cameraBtn.Enabled = false;
            this.cameraBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.cameraBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("cameraBtn.Iconimage")));
            this.cameraBtn.Iconimage_right = null;
            this.cameraBtn.Iconimage_right_Selected = null;
            this.cameraBtn.Iconimage_Selected = null;
            this.cameraBtn.IconMarginLeft = 20;
            this.cameraBtn.IconMarginRight = 0;
            this.cameraBtn.IconRightVisible = true;
            this.cameraBtn.IconRightZoom = 10D;
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
            this.cameraBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.demoBtn.Enabled = false;
            this.demoBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.demoBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("demoBtn.Iconimage")));
            this.demoBtn.Iconimage_right = null;
            this.demoBtn.Iconimage_right_Selected = null;
            this.demoBtn.Iconimage_Selected = null;
            this.demoBtn.IconMarginLeft = 20;
            this.demoBtn.IconMarginRight = 0;
            this.demoBtn.IconRightVisible = true;
            this.demoBtn.IconRightZoom = 10D;
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
            this.demoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.settingsBtn.Enabled = false;
            this.settingsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.settingsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Iconimage")));
            this.settingsBtn.Iconimage_right = null;
            this.settingsBtn.Iconimage_right_Selected = null;
            this.settingsBtn.Iconimage_Selected = null;
            this.settingsBtn.IconMarginLeft = 20;
            this.settingsBtn.IconMarginRight = 0;
            this.settingsBtn.IconRightVisible = true;
            this.settingsBtn.IconRightZoom = 10D;
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
            this.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.Textcolor = System.Drawing.Color.White;
            this.settingsBtn.TextFont = new System.Drawing.Font("Californian FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
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
            this.header_panel.Size = new System.Drawing.Size(937, 38);
            this.header_panel.TabIndex = 5;
            this.header_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.header_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.header_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.SwitchAnimator.SetDecoration(this.materialLabel1, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.materialLabel1, AnimatorNS.DecorationType.None);
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(36, 13);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(85, 18);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Recognator";
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.SwitchAnimator.SetDecoration(this.minimizeBtn, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.minimizeBtn, AnimatorNS.DecorationType.None);
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.ImageActive = null;
            this.minimizeBtn.Location = new System.Drawing.Point(872, 7);
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
            this.exitBtn.Location = new System.Drawing.Point(909, 7);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(25, 25);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBtn.TabIndex = 8;
            this.exitBtn.TabStop = false;
            this.exitBtn.Zoom = 4;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // animator1
            // 
            this.animator1.AnimationType = AnimatorNS.AnimationType.Mosaic;
            this.animator1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 20;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation3;
            // 
            // container
            // 
            this.container.Controls.Add(this.bunifuCustomLabel2);
            this.container.Controls.Add(this.dbConnect);
            this.SwitchAnimator.SetDecoration(this.container, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.container, AnimatorNS.DecorationType.None);
            this.container.Dock = System.Windows.Forms.DockStyle.Right;
            this.container.Location = new System.Drawing.Point(212, 68);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(725, 445);
            this.container.TabIndex = 6;
            // 
            // errorPanel
            // 
            this.errorPanel.Controls.Add(this.bunifuCustomLabel1);
            this.SwitchAnimator.SetDecoration(this.errorPanel, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.errorPanel, AnimatorNS.DecorationType.None);
            this.errorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.errorPanel.Location = new System.Drawing.Point(212, 38);
            this.errorPanel.Name = "errorPanel";
            this.errorPanel.Size = new System.Drawing.Size(725, 30);
            this.errorPanel.TabIndex = 7;
            this.errorPanel.Visible = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel1, AnimatorNS.DecorationType.None);
            this.SwitchAnimator.SetDecoration(this.bunifuCustomLabel1, AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(257, 6);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(174, 16);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Ошибка загрузки видео...";
            // 
            // SwitchAnimator
            // 
            this.SwitchAnimator.AnimationType = AnimatorNS.AnimationType.VertSlide;
            this.SwitchAnimator.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.SwitchAnimator.DefaultAnimation = animation4;
            // 
            // captureLoadWorker
            // 
            this.captureLoadWorker.WorkerReportsProgress = true;
            this.captureLoadWorker.WorkerSupportsCancellation = true;
            this.captureLoadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            this.captureLoadWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.worker_ProgressChanged);
            this.captureLoadWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_Completed);
            // 
            // dbConnect
            // 
            this.dbConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.dbConnect.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.dbConnect.Checked = false;
            this.dbConnect.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.animator1.SetDecoration(this.dbConnect, AnimatorNS.DecorationType.None);
            this.SwitchAnimator.SetDecoration(this.dbConnect, AnimatorNS.DecorationType.None);
            this.dbConnect.ForeColor = System.Drawing.Color.White;
            this.dbConnect.Location = new System.Drawing.Point(231, 172);
            this.dbConnect.Name = "dbConnect";
            this.dbConnect.Size = new System.Drawing.Size(20, 20);
            this.dbConnect.TabIndex = 0;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel2, AnimatorNS.DecorationType.None);
            this.SwitchAnimator.SetDecoration(this.bunifuCustomLabel2, AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(257, 168);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(256, 24);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Использовать базу данных";
            // 
            // Settings
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(937, 513);
            this.Controls.Add(this.container);
            this.Controls.Add(this.errorPanel);
            this.Controls.Add(this.sidepanel);
            this.Controls.Add(this.header_panel);
            this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.SwitchAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор камеры";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formCLosing);
            this.Load += new System.EventHandler(this.formLoad);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.sidepanel.ResumeLayout(false);
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.errorPanel.ResumeLayout(false);
            this.errorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel header_panel;
        private Bunifu.Framework.UI.BunifuImageButton minimizeBtn;
        private Bunifu.Framework.UI.BunifuImageButton exitBtn;
        private Bunifu.Framework.UI.BunifuFlatButton collapseBtn;
        private Bunifu.Framework.UI.BunifuFlatButton homeBtn;
        private AnimatorNS.Animator animator1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private AnimatorNS.Animator SwitchAnimator;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public Bunifu.Framework.UI.BunifuFlatButton cameraBtn;
        public Bunifu.Framework.UI.BunifuFlatButton demoBtn;
        public Bunifu.Framework.UI.BunifuFlatButton settingsBtn;
        public System.ComponentModel.BackgroundWorker captureLoadWorker;
        public System.Windows.Forms.Panel errorPanel;
        public System.Windows.Forms.Panel container;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        public Bunifu.Framework.UI.BunifuCheckbox dbConnect;
    }
}