namespace DatabaseConnection
{
    partial class Book
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.txtBookEdition = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBookPages = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBookName = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comBoxCategory = new Guna.UI.WinForms.GunaComboBox();
            this.comBoxAthorName = new Guna.UI.WinForms.GunaComboBox();
            this.comBoxPublisherName = new Guna.UI.WinForms.GunaComboBox();
            this.comBoxBookType = new Guna.UI.WinForms.GunaComboBox();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BookView = new Guna.UI.WinForms.GunaDataGridView();
            this.lbl_display = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookView)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderSize = 3;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtSearch.Location = new System.Drawing.Point(657, 286);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 15;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(175, 34);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextOffsetX = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.BookTextChanged);
            // 
            // txtBookEdition
            // 
            this.txtBookEdition.BackColor = System.Drawing.Color.Transparent;
            this.txtBookEdition.BaseColor = System.Drawing.Color.White;
            this.txtBookEdition.BorderColor = System.Drawing.Color.Silver;
            this.txtBookEdition.BorderSize = 1;
            this.txtBookEdition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookEdition.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBookEdition.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtBookEdition.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBookEdition.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookEdition.Location = new System.Drawing.Point(275, 195);
            this.txtBookEdition.Name = "txtBookEdition";
            this.txtBookEdition.PasswordChar = '\0';
            this.txtBookEdition.Radius = 10;
            this.txtBookEdition.SelectedText = "";
            this.txtBookEdition.Size = new System.Drawing.Size(210, 39);
            this.txtBookEdition.TabIndex = 6;
            this.txtBookEdition.TextOffsetX = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(271, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 44;
            this.label7.Text = "Edition";
            // 
            // txtBookPages
            // 
            this.txtBookPages.BackColor = System.Drawing.Color.Transparent;
            this.txtBookPages.BaseColor = System.Drawing.Color.White;
            this.txtBookPages.BorderColor = System.Drawing.Color.Silver;
            this.txtBookPages.BorderSize = 1;
            this.txtBookPages.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookPages.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBookPages.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtBookPages.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBookPages.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookPages.Location = new System.Drawing.Point(16, 195);
            this.txtBookPages.Name = "txtBookPages";
            this.txtBookPages.PasswordChar = '\0';
            this.txtBookPages.Radius = 10;
            this.txtBookPages.SelectedText = "";
            this.txtBookPages.Size = new System.Drawing.Size(210, 39);
            this.txtBookPages.TabIndex = 5;
            this.txtBookPages.TextOffsetX = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 42;
            this.label8.Text = "Pages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "Book Type";
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = null;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(121, 264);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(76)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 5;
            this.btnAdd.Size = new System.Drawing.Size(139, 47);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.registerBook);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(517, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "Author Name";
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.Color.Transparent;
            this.txtBookName.BaseColor = System.Drawing.Color.White;
            this.txtBookName.BorderColor = System.Drawing.Color.Silver;
            this.txtBookName.BorderSize = 1;
            this.txtBookName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBookName.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtBookName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBookName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(12, 35);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.PasswordChar = '\0';
            this.txtBookName.Radius = 10;
            this.txtBookName.SelectedText = "";
            this.txtBookName.Size = new System.Drawing.Size(210, 39);
            this.txtBookName.TabIndex = 0;
            this.txtBookName.TextOffsetX = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Publisher Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Book Name";
            // 
            // comBoxCategory
            // 
            this.comBoxCategory.BackColor = System.Drawing.Color.Transparent;
            this.comBoxCategory.BaseColor = System.Drawing.Color.White;
            this.comBoxCategory.BorderColor = System.Drawing.Color.Silver;
            this.comBoxCategory.BorderSize = 1;
            this.comBoxCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxCategory.FocusedColor = System.Drawing.Color.Red;
            this.comBoxCategory.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.comBoxCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comBoxCategory.FormattingEnabled = true;
            this.comBoxCategory.Items.AddRange(new object[] {
            "Select"});
            this.comBoxCategory.Location = new System.Drawing.Point(279, 35);
            this.comBoxCategory.Name = "comBoxCategory";
            this.comBoxCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comBoxCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comBoxCategory.Radius = 10;
            this.comBoxCategory.Size = new System.Drawing.Size(210, 36);
            this.comBoxCategory.TabIndex = 1;
            // 
            // comBoxAthorName
            // 
            this.comBoxAthorName.BackColor = System.Drawing.Color.Transparent;
            this.comBoxAthorName.BaseColor = System.Drawing.Color.White;
            this.comBoxAthorName.BorderColor = System.Drawing.Color.Silver;
            this.comBoxAthorName.BorderSize = 1;
            this.comBoxAthorName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBoxAthorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxAthorName.FocusedColor = System.Drawing.Color.Red;
            this.comBoxAthorName.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.comBoxAthorName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comBoxAthorName.FormattingEnabled = true;
            this.comBoxAthorName.Items.AddRange(new object[] {
            "Select"});
            this.comBoxAthorName.Location = new System.Drawing.Point(521, 36);
            this.comBoxAthorName.Name = "comBoxAthorName";
            this.comBoxAthorName.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comBoxAthorName.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comBoxAthorName.Radius = 10;
            this.comBoxAthorName.Size = new System.Drawing.Size(210, 36);
            this.comBoxAthorName.TabIndex = 2;
            // 
            // comBoxPublisherName
            // 
            this.comBoxPublisherName.BackColor = System.Drawing.Color.Transparent;
            this.comBoxPublisherName.BaseColor = System.Drawing.Color.White;
            this.comBoxPublisherName.BorderColor = System.Drawing.Color.Silver;
            this.comBoxPublisherName.BorderSize = 1;
            this.comBoxPublisherName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBoxPublisherName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxPublisherName.FocusedColor = System.Drawing.Color.Red;
            this.comBoxPublisherName.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.comBoxPublisherName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comBoxPublisherName.FormattingEnabled = true;
            this.comBoxPublisherName.Items.AddRange(new object[] {
            "Select"});
            this.comBoxPublisherName.Location = new System.Drawing.Point(12, 117);
            this.comBoxPublisherName.Name = "comBoxPublisherName";
            this.comBoxPublisherName.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comBoxPublisherName.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comBoxPublisherName.Radius = 10;
            this.comBoxPublisherName.Size = new System.Drawing.Size(210, 36);
            this.comBoxPublisherName.TabIndex = 3;
            // 
            // comBoxBookType
            // 
            this.comBoxBookType.BackColor = System.Drawing.Color.Transparent;
            this.comBoxBookType.BaseColor = System.Drawing.Color.White;
            this.comBoxBookType.BorderColor = System.Drawing.Color.Silver;
            this.comBoxBookType.BorderSize = 1;
            this.comBoxBookType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBoxBookType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxBookType.FocusedColor = System.Drawing.Color.Red;
            this.comBoxBookType.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.comBoxBookType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comBoxBookType.FormattingEnabled = true;
            this.comBoxBookType.Items.AddRange(new object[] {
            "Select",
            "Basic",
            "intermediate",
            "Advanced",
            "Essential "});
            this.comBoxBookType.Location = new System.Drawing.Point(279, 116);
            this.comBoxBookType.Name = "comBoxBookType";
            this.comBoxBookType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comBoxBookType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comBoxBookType.Radius = 10;
            this.comBoxBookType.Size = new System.Drawing.Size(210, 36);
            this.comBoxBookType.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor = System.Drawing.Color.Purple;
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::DatabaseConnection.Properties.Resources.icons8_delete_25px;
            this.btnDelete.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDelete.Location = new System.Drawing.Point(447, 264);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 5;
            this.btnDelete.Size = new System.Drawing.Size(139, 47);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "  Delete";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.TextOffsetX = 5;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::DatabaseConnection.Properties.Resources.icons8_update_user_25px;
            this.btnUpdate.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUpdate.Location = new System.Drawing.Point(283, 264);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 5;
            this.btnUpdate.Size = new System.Drawing.Size(139, 47);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "   Update";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.TextOffsetX = 5;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DatabaseConnection.Properties.Resources.Reading_glasses_rafiki;
            this.pictureBox1.Location = new System.Drawing.Point(623, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // BookView
            // 
            this.BookView.AllowUserToAddRows = false;
            this.BookView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.BookView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.BookView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookView.BackgroundColor = System.Drawing.Color.White;
            this.BookView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BookView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BookView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.BookView.ColumnHeadersHeight = 24;
            this.BookView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookView.DefaultCellStyle = dataGridViewCellStyle6;
            this.BookView.EnableHeadersVisualStyles = false;
            this.BookView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BookView.Location = new System.Drawing.Point(0, 329);
            this.BookView.Name = "BookView";
            this.BookView.ReadOnly = true;
            this.BookView.RowHeadersVisible = false;
            this.BookView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookView.Size = new System.Drawing.Size(895, 308);
            this.BookView.TabIndex = 48;
            this.BookView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.BookView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BookView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BookView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BookView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BookView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BookView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BookView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BookView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BookView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BookView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BookView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BookView.ThemeStyle.HeaderStyle.Height = 24;
            this.BookView.ThemeStyle.ReadOnly = true;
            this.BookView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BookView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BookView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BookView.ThemeStyle.RowsStyle.Height = 22;
            this.BookView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BookView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BookView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClick);
            this.BookView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookView_CellContentClick);
            // 
            // lbl_display
            // 
            this.lbl_display.AutoSize = true;
            this.lbl_display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_display.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_display.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_display.Location = new System.Drawing.Point(275, 422);
            this.lbl_display.Name = "lbl_display";
            this.lbl_display.Size = new System.Drawing.Size(323, 39);
            this.lbl_display.TabIndex = 49;
            this.lbl_display.Text = "Sorry! No Data Found";
            this.lbl_display.Visible = false;
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(897, 636);
            this.Controls.Add(this.lbl_display);
            this.Controls.Add(this.BookView);
            this.Controls.Add(this.comBoxBookType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comBoxPublisherName);
            this.Controls.Add(this.comBoxAthorName);
            this.Controls.Add(this.comBoxCategory);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBookEdition);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBookPages);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book";
            this.Load += new System.EventHandler(this.Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaTextBox txtBookEdition;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox txtBookPages;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtBookName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaComboBox comBoxCategory;
        private Guna.UI.WinForms.GunaComboBox comBoxPublisherName;
        private Guna.UI.WinForms.GunaComboBox comBoxAthorName;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaComboBox comBoxBookType;
        private Guna.UI.WinForms.GunaDataGridView BookView;
        public Guna.UI.WinForms.GunaButton btnDelete;
        private System.Windows.Forms.Label lbl_display;
    }
}