namespace CustomApp.Forms
{
    partial class FormTool
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTool));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxServer = new Bunifu.UI.WinForms.BunifuDropdown();
            this.noteTextBox = new CustomApp.Controls.CustomTextBox();
            this.pictureHiddenPassword = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new CustomApp.customButton();
            this.btnModify = new CustomApp.customButton();
            this.btnAdd = new CustomApp.customButton();
            this.customButton1 = new CustomApp.customButton();
            this.txtPassword = new CustomApp.Controls.CustomTextBox();
            this.txUsername = new CustomApp.Controls.CustomTextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageUsersList = new System.Windows.Forms.ImageList(this.components);
            this.imageCheckList = new System.Windows.Forms.ImageList(this.components);
            this.scrollBar = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHiddenPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxServer);
            this.panel1.Controls.Add(this.noteTextBox);
            this.panel1.Controls.Add(this.pictureHiddenPassword);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.customButton1);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 351);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxServer
            // 
            this.comboBoxServer.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxServer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.comboBoxServer.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxServer.BorderRadius = 12;
            this.comboBoxServer.Color = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxServer.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.comboBoxServer.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.comboBoxServer.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comboBoxServer.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.comboBoxServer.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.comboBoxServer.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.comboBoxServer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxServer.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.comboBoxServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServer.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.comboBoxServer.FillDropDown = true;
            this.comboBoxServer.FillIndicator = false;
            this.comboBoxServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxServer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxServer.ForeColor = System.Drawing.Color.White;
            this.comboBoxServer.FormattingEnabled = true;
            this.comboBoxServer.Icon = null;
            this.comboBoxServer.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.comboBoxServer.IndicatorColor = System.Drawing.Color.Gray;
            this.comboBoxServer.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.comboBoxServer.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.comboBoxServer.ItemBorderColor = System.Drawing.Color.White;
            this.comboBoxServer.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxServer.ItemHeight = 35;
            this.comboBoxServer.ItemHighLightColor = System.Drawing.Color.ForestGreen;
            this.comboBoxServer.ItemHighLightForeColor = System.Drawing.Color.White;
            this.comboBoxServer.Items.AddRange(new object[] {
            "Vũ trụ 1 sao",
            "Vũ trụ 2 sao",
            "Vũ trụ 3 sao",
            "Vũ trụ 4 sao",
            "Vũ trụ 5 sao",
            "Vũ trụ 6 sao",
            "Vũ trụ 7 sao",
            "Vũ trụ 8 sao",
            "Vũ trụ 9 sao",
            "Vũ trụ 10 sao",
            "Vũ trụ 11 sao",
            "Vũ trụ 12 sao",
            "Vũ trụ 13 sao",
            "Vũ trụ 14 sao",
            "Vũ trụ 15 sao",
            "Vũ trụ 16 sao"});
            this.comboBoxServer.ItemTopMargin = 3;
            this.comboBoxServer.Location = new System.Drawing.Point(14, 114);
            this.comboBoxServer.Name = "comboBoxServer";
            this.comboBoxServer.Size = new System.Drawing.Size(176, 41);
            this.comboBoxServer.TabIndex = 12;
            this.comboBoxServer.Text = "Vũ trụ 1 sao";
            this.comboBoxServer.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.comboBoxServer.TextLeftMargin = 5;
            // 
            // noteTextBox
            // 
            this.noteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.noteTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.noteTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.noteTextBox.BorderRadius = 15;
            this.noteTextBox.BorderSize = 1;
            this.noteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTextBox.ForeColor = System.Drawing.Color.White;
            this.noteTextBox.Location = new System.Drawing.Point(14, 163);
            this.noteTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.noteTextBox.Multiline = false;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.noteTextBox.PasswordChar = false;
            this.noteTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.noteTextBox.PlaceholderText = "Ghi chú";
            this.noteTextBox.Size = new System.Drawing.Size(176, 41);
            this.noteTextBox.TabIndex = 11;
            this.noteTextBox.Texts = "";
            this.noteTextBox.UnderlinedStyle = false;
            // 
            // pictureHiddenPassword
            // 
            this.pictureHiddenPassword.Image = global::CustomApp.Properties.Resources._private;
            this.pictureHiddenPassword.Location = new System.Drawing.Point(164, 77);
            this.pictureHiddenPassword.Margin = new System.Windows.Forms.Padding(2);
            this.pictureHiddenPassword.Name = "pictureHiddenPassword";
            this.pictureHiddenPassword.Size = new System.Drawing.Size(15, 16);
            this.pictureHiddenPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHiddenPassword.TabIndex = 10;
            this.pictureHiddenPassword.TabStop = false;
            this.pictureHiddenPassword.Click += new System.EventHandler(this.pictureHiddenPassword_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(376, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 450);
            this.panel2.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.BorderRadius = 15;
            this.btnDelete.BorderSize = 2;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(207, 114);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 41);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnModify.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnModify.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnModify.BorderRadius = 15;
            this.btnModify.BorderSize = 2;
            this.btnModify.FlatAppearance.BorderSize = 0;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Location = new System.Drawing.Point(207, 63);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(72, 41);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "Modify";
            this.btnModify.TextColor = System.Drawing.Color.White;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Green;
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.BorderSize = 2;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(207, 13);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 41);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.customButton1.BorderColor = System.Drawing.Color.Cyan;
            this.customButton1.BorderRadius = 15;
            this.customButton1.BorderSize = 2;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(14, 213);
            this.customButton1.Margin = new System.Windows.Forms.Padding(2);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(176, 41);
            this.customButton1.TabIndex = 3;
            this.customButton1.Text = "Login";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassword.BorderRadius = 15;
            this.txtPassword.BorderSize = 1;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(14, 63);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "Mật Khẩu";
            this.txtPassword.Size = new System.Drawing.Size(176, 41);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            // 
            // txUsername
            // 
            this.txUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txUsername.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txUsername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txUsername.BorderRadius = 15;
            this.txUsername.BorderSize = 1;
            this.txUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUsername.ForeColor = System.Drawing.Color.White;
            this.txUsername.Location = new System.Drawing.Point(14, 13);
            this.txUsername.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txUsername.Multiline = false;
            this.txUsername.Name = "txUsername";
            this.txUsername.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.txUsername.PasswordChar = false;
            this.txUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txUsername.PlaceholderText = "Tài Khoản";
            this.txUsername.Size = new System.Drawing.Size(176, 41);
            this.txUsername.TabIndex = 0;
            this.txUsername.Texts = "";
            this.txUsername.UnderlinedStyle = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 30;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridView.Location = new System.Drawing.Point(288, 0);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 30;
            this.dataGridView.RowTemplate.Height = 50;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(680, 351);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            this.dataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView_RowsRemoved);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.downButton_Click);
            this.dataGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.upButton_Click);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 10F;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 10F;
            this.Column2.HeaderText = "ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 30F;
            this.Column3.HeaderText = "Tài khoản";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 20F;
            this.Column4.HeaderText = "Máy chủ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 30F;
            this.Column5.HeaderText = "Ghi chú";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // imageUsersList
            // 
            this.imageUsersList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageUsersList.ImageStream")));
            this.imageUsersList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageUsersList.Images.SetKeyName(0, "icons8-user-96.png");
            // 
            // imageCheckList
            // 
            this.imageCheckList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageCheckList.ImageStream")));
            this.imageCheckList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageCheckList.Images.SetKeyName(0, "icons8-cancel-100.png");
            this.imageCheckList.Images.SetKeyName(1, "icons8-check-100.png");
            // 
            // scrollBar
            // 
            this.scrollBar.AllowCursorChanges = true;
            this.scrollBar.AllowHomeEndKeysDetection = false;
            this.scrollBar.AllowIncrementalClickMoves = true;
            this.scrollBar.AllowMouseDownEffects = true;
            this.scrollBar.AllowMouseHoverEffects = true;
            this.scrollBar.AllowScrollingAnimations = true;
            this.scrollBar.AllowScrollKeysDetection = true;
            this.scrollBar.AllowScrollOptionsMenu = true;
            this.scrollBar.AllowShrinkingOnFocusLost = false;
            this.scrollBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scrollBar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.scrollBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scrollBar.BackgroundImage")));
            this.scrollBar.BindingContainer = null;
            this.scrollBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.scrollBar.BorderRadius = 14;
            this.scrollBar.BorderThickness = 1;
            this.scrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.scrollBar.DurationBeforeShrink = 2000;
            this.scrollBar.LargeChange = 10;
            this.scrollBar.Location = new System.Drawing.Point(957, 0);
            this.scrollBar.Maximum = 100;
            this.scrollBar.Minimum = 0;
            this.scrollBar.MinimumThumbLength = 18;
            this.scrollBar.Name = "scrollBar";
            this.scrollBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.scrollBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.scrollBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.scrollBar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.scrollBar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.scrollBar.ShrinkSizeLimit = 3;
            this.scrollBar.Size = new System.Drawing.Size(11, 351);
            this.scrollBar.SmallChange = 1;
            this.scrollBar.TabIndex = 2;
            this.scrollBar.ThumbColor = System.Drawing.Color.MediumSlateBlue;
            this.scrollBar.ThumbLength = 34;
            this.scrollBar.ThumbMargin = 1;
            this.scrollBar.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.scrollBar.Value = 0;
            this.scrollBar.Scroll += new System.EventHandler<Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs>(this.bunifuVScrollBar1_Scroll);
            // 
            // FormTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(968, 351);
            this.Controls.Add(this.scrollBar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTool";
            this.Text = "FormTool";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHiddenPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Controls.CustomTextBox txUsername;
        private Controls.CustomTextBox txtPassword;
        private customButton customButton1;
        private customButton btnAdd;
        private customButton btnDelete;
        private customButton btnModify;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ImageList imageUsersList;
        private System.Windows.Forms.ImageList imageCheckList;
        private System.Windows.Forms.PictureBox pictureHiddenPassword;
        private Controls.CustomTextBox noteTextBox;
        private Bunifu.UI.WinForms.BunifuDropdown comboBoxServer;
        private Bunifu.UI.WinForms.BunifuVScrollBar scrollBar;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}