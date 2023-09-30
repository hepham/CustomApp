namespace CustomApp
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnInfo = new FontAwesome.Sharp.IconButton();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnTools = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.minimizeButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.exitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuPanel1);
            this.panel2.Controls.Add(this.TitleBar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 450);
            this.panel2.TabIndex = 1;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuPanel2);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 27);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(812, 423);
            this.bunifuPanel1.TabIndex = 4;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.panel1);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(812, 423);
            this.bunifuPanel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panelMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 423);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panelDesktop);
            this.panel4.Controls.Add(this.panelTitleBar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(133, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(679, 423);
            this.panel4.TabIndex = 9;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 65);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(679, 358);
            this.panelDesktop.TabIndex = 11;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(679, 65);
            this.panelTitleBar.TabIndex = 9;
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleChildForm.Location = new System.Drawing.Point(32, 23);
            this.labelTitleChildForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(40, 19);
            this.labelTitleChildForm.TabIndex = 1;
            this.labelTitleChildForm.Text = "Tools";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Rocket;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumVioletRed;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 24;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(4, 23);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(24, 26);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.BtnInfo);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnTools);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(133, 423);
            this.panelMenu.TabIndex = 8;
            // 
            // BtnInfo
            // 
            this.BtnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInfo.FlatAppearance.BorderSize = 0;
            this.BtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInfo.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnInfo.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.BtnInfo.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInfo.IconSize = 20;
            this.BtnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInfo.Location = new System.Drawing.Point(0, 210);
            this.BtnInfo.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnInfo.Size = new System.Drawing.Size(133, 45);
            this.BtnInfo.TabIndex = 6;
            this.BtnInfo.Text = "Information";
            this.BtnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInfo.UseVisualStyleBackColor = true;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnSettings.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 20;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 165);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnSettings.Size = new System.Drawing.Size(133, 45);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnTools
            // 
            this.btnTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTools.FlatAppearance.BorderSize = 0;
            this.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTools.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTools.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTools.IconChar = FontAwesome.Sharp.IconChar.Rocket;
            this.btnTools.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTools.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTools.IconSize = 20;
            this.btnTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.Location = new System.Drawing.Point(0, 120);
            this.btnTools.Margin = new System.Windows.Forms.Padding(2);
            this.btnTools.Name = "btnTools";
            this.btnTools.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnTools.Size = new System.Drawing.Size(133, 45);
            this.btnTools.TabIndex = 4;
            this.btnTools.Text = "Tools";
            this.btnTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTools.UseVisualStyleBackColor = true;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 29);
            this.panel3.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(133, 91);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(30, 12);
            this.btnHome.Margin = new System.Windows.Forms.Padding(10);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(20);
            this.btnHome.Size = new System.Drawing.Size(68, 66);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitleBar.Controls.Add(this.exitButton);
            this.TitleBar.Controls.Add(this.minimizeButton);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(812, 27);
            this.TitleBar.TabIndex = 1;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // minimizeButton
            // 
            this.minimizeButton.AllowAnimations = true;
            this.minimizeButton.AllowMouseEffects = true;
            this.minimizeButton.AllowToggling = false;
            this.minimizeButton.AnimationSpeed = 200;
            this.minimizeButton.AutoGenerateColors = false;
            this.minimizeButton.AutoRoundBorders = false;
            this.minimizeButton.AutoSizeLeftIcon = true;
            this.minimizeButton.AutoSizeRightIcon = true;
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.BackColor1 = System.Drawing.Color.Transparent;
            this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
            this.minimizeButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.minimizeButton.ButtonText = "-";
            this.minimizeButton.ButtonTextMarginLeft = 0;
            this.minimizeButton.ColorContrastOnClick = 45;
            this.minimizeButton.ColorContrastOnHover = 45;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.minimizeButton.CustomizableEdges = borderEdges4;
            this.minimizeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.minimizeButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.minimizeButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.minimizeButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.minimizeButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minimizeButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.minimizeButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.minimizeButton.IconMarginLeft = 11;
            this.minimizeButton.IconPadding = 10;
            this.minimizeButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.minimizeButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.minimizeButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.minimizeButton.IconSize = 25;
            this.minimizeButton.IdleBorderColor = System.Drawing.Color.Transparent;
            this.minimizeButton.IdleBorderRadius = 1;
            this.minimizeButton.IdleBorderThickness = 1;
            this.minimizeButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.minimizeButton.IdleIconLeftImage = null;
            this.minimizeButton.IdleIconRightImage = null;
            this.minimizeButton.IndicateFocus = false;
            this.minimizeButton.Location = new System.Drawing.Point(707, 1);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.minimizeButton.OnDisabledState.BorderRadius = 1;
            this.minimizeButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.minimizeButton.OnDisabledState.BorderThickness = 1;
            this.minimizeButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.minimizeButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.minimizeButton.OnDisabledState.IconLeftImage = null;
            this.minimizeButton.OnDisabledState.IconRightImage = null;
            this.minimizeButton.onHoverState.BorderColor = System.Drawing.Color.Silver;
            this.minimizeButton.onHoverState.BorderRadius = 1;
            this.minimizeButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.minimizeButton.onHoverState.BorderThickness = 1;
            this.minimizeButton.onHoverState.FillColor = System.Drawing.Color.Silver;
            this.minimizeButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.onHoverState.IconLeftImage = null;
            this.minimizeButton.onHoverState.IconRightImage = null;
            this.minimizeButton.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.minimizeButton.OnIdleState.BorderRadius = 1;
            this.minimizeButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.minimizeButton.OnIdleState.BorderThickness = 1;
            this.minimizeButton.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.minimizeButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.OnIdleState.IconLeftImage = null;
            this.minimizeButton.OnIdleState.IconRightImage = null;
            this.minimizeButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimizeButton.OnPressedState.BorderRadius = 1;
            this.minimizeButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.minimizeButton.OnPressedState.BorderThickness = 1;
            this.minimizeButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimizeButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.OnPressedState.IconLeftImage = null;
            this.minimizeButton.OnPressedState.IconRightImage = null;
            this.minimizeButton.Size = new System.Drawing.Size(50, 24);
            this.minimizeButton.TabIndex = 4;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minimizeButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.minimizeButton.TextMarginLeft = 0;
            this.minimizeButton.TextPadding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.minimizeButton.UseDefaultRadiusAndThickness = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AllowAnimations = true;
            this.exitButton.AllowMouseEffects = true;
            this.exitButton.AllowToggling = false;
            this.exitButton.AnimationSpeed = 200;
            this.exitButton.AutoGenerateColors = false;
            this.exitButton.AutoRoundBorders = false;
            this.exitButton.AutoSizeLeftIcon = true;
            this.exitButton.AutoSizeRightIcon = true;
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackColor1 = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exitButton.ButtonText = "X";
            this.exitButton.ButtonTextMarginLeft = 0;
            this.exitButton.ColorContrastOnClick = 45;
            this.exitButton.ColorContrastOnHover = 45;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.exitButton.CustomizableEdges = borderEdges3;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.exitButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.exitButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.exitButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.exitButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.exitButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.exitButton.IconMarginLeft = 11;
            this.exitButton.IconPadding = 10;
            this.exitButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.exitButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.exitButton.IconSize = 25;
            this.exitButton.IdleBorderColor = System.Drawing.Color.Transparent;
            this.exitButton.IdleBorderRadius = 1;
            this.exitButton.IdleBorderThickness = 1;
            this.exitButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.exitButton.IdleIconLeftImage = null;
            this.exitButton.IdleIconRightImage = null;
            this.exitButton.IndicateFocus = false;
            this.exitButton.Location = new System.Drawing.Point(763, 1);
            this.exitButton.Name = "exitButton";
            this.exitButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.exitButton.OnDisabledState.BorderRadius = 1;
            this.exitButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exitButton.OnDisabledState.BorderThickness = 1;
            this.exitButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.exitButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.exitButton.OnDisabledState.IconLeftImage = null;
            this.exitButton.OnDisabledState.IconRightImage = null;
            this.exitButton.onHoverState.BorderColor = System.Drawing.Color.Red;
            this.exitButton.onHoverState.BorderRadius = 1;
            this.exitButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exitButton.onHoverState.BorderThickness = 1;
            this.exitButton.onHoverState.FillColor = System.Drawing.Color.Red;
            this.exitButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.exitButton.onHoverState.IconLeftImage = null;
            this.exitButton.onHoverState.IconRightImage = null;
            this.exitButton.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.exitButton.OnIdleState.BorderRadius = 1;
            this.exitButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exitButton.OnIdleState.BorderThickness = 1;
            this.exitButton.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.exitButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.exitButton.OnIdleState.IconLeftImage = null;
            this.exitButton.OnIdleState.IconRightImage = null;
            this.exitButton.OnPressedState.BorderColor = System.Drawing.Color.Red;
            this.exitButton.OnPressedState.BorderRadius = 1;
            this.exitButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exitButton.OnPressedState.BorderThickness = 1;
            this.exitButton.OnPressedState.FillColor = System.Drawing.Color.Red;
            this.exitButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.exitButton.OnPressedState.IconLeftImage = null;
            this.exitButton.OnPressedState.IconRightImage = null;
            this.exitButton.Size = new System.Drawing.Size(49, 26);
            this.exitButton.TabIndex = 3;
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.exitButton.TextMarginLeft = 0;
            this.exitButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.exitButton.UseDefaultRadiusAndThickness = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel TitleBar;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton BtnInfo;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnTools;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton exitButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton minimizeButton;
    }
}

