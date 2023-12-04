namespace DatabaseConnection
{
    partial class ReturnBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ReturnBookView = new Guna.UI.WinForms.GunaDataGridView();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDayEpalsed = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFine = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.txtBookName = new Guna.UI.WinForms.GunaTextBox();
            this.txtReturnDate = new Guna.UI.WinForms.GunaTextBox();
            this.comBoxMemberId = new Guna.UI.WinForms.GunaComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBookView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "Book Name";
            // 
            // ReturnBookView
            // 
            this.ReturnBookView.AllowUserToAddRows = false;
            this.ReturnBookView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.ReturnBookView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.ReturnBookView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReturnBookView.BackgroundColor = System.Drawing.Color.White;
            this.ReturnBookView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ReturnBookView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReturnBookView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReturnBookView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.ReturnBookView.ColumnHeadersHeight = 24;
            this.ReturnBookView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReturnBookView.DefaultCellStyle = dataGridViewCellStyle12;
            this.ReturnBookView.EnableHeadersVisualStyles = false;
            this.ReturnBookView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReturnBookView.Location = new System.Drawing.Point(1, 312);
            this.ReturnBookView.Name = "ReturnBookView";
            this.ReturnBookView.ReadOnly = true;
            this.ReturnBookView.RowHeadersVisible = false;
            this.ReturnBookView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReturnBookView.Size = new System.Drawing.Size(895, 319);
            this.ReturnBookView.TabIndex = 38;
            this.ReturnBookView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ReturnBookView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ReturnBookView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ReturnBookView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ReturnBookView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ReturnBookView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ReturnBookView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ReturnBookView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReturnBookView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ReturnBookView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ReturnBookView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBookView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ReturnBookView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ReturnBookView.ThemeStyle.HeaderStyle.Height = 24;
            this.ReturnBookView.ThemeStyle.ReadOnly = true;
            this.ReturnBookView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ReturnBookView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReturnBookView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBookView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReturnBookView.ThemeStyle.RowsStyle.Height = 22;
            this.ReturnBookView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReturnBookView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReturnBookView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReturnBookCellClick);
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
            this.btnAdd.Location = new System.Drawing.Point(57, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(76)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 5;
            this.btnAdd.Size = new System.Drawing.Size(139, 47);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(529, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Return Date";
            // 
            // txtDayEpalsed
            // 
            this.txtDayEpalsed.BackColor = System.Drawing.Color.Transparent;
            this.txtDayEpalsed.BaseColor = System.Drawing.Color.White;
            this.txtDayEpalsed.BorderColor = System.Drawing.Color.Silver;
            this.txtDayEpalsed.BorderSize = 1;
            this.txtDayEpalsed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDayEpalsed.Enabled = false;
            this.txtDayEpalsed.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDayEpalsed.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtDayEpalsed.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDayEpalsed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDayEpalsed.Location = new System.Drawing.Point(18, 117);
            this.txtDayEpalsed.Name = "txtDayEpalsed";
            this.txtDayEpalsed.PasswordChar = '\0';
            this.txtDayEpalsed.Radius = 10;
            this.txtDayEpalsed.SelectedText = "";
            this.txtDayEpalsed.Size = new System.Drawing.Size(210, 39);
            this.txtDayEpalsed.TabIndex = 3;
            this.txtDayEpalsed.TextOffsetX = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Day Elapsed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Member ID";
            // 
            // txtFine
            // 
            this.txtFine.BackColor = System.Drawing.Color.Transparent;
            this.txtFine.BaseColor = System.Drawing.Color.White;
            this.txtFine.BorderColor = System.Drawing.Color.Silver;
            this.txtFine.BorderSize = 1;
            this.txtFine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFine.Enabled = false;
            this.txtFine.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFine.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtFine.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFine.Location = new System.Drawing.Point(285, 117);
            this.txtFine.Name = "txtFine";
            this.txtFine.PasswordChar = '\0';
            this.txtFine.Radius = 10;
            this.txtFine.SelectedText = "";
            this.txtFine.Size = new System.Drawing.Size(210, 39);
            this.txtFine.TabIndex = 4;
            this.txtFine.TextOffsetX = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 42;
            this.label4.Text = "Fine";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::DatabaseConnection.Properties.Resources.Mobile_login_bro;
            this.gunaPictureBox1.Location = new System.Drawing.Point(688, 70);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(207, 213);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 39;
            this.gunaPictureBox1.TabStop = false;
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
            this.btnDelete.Location = new System.Drawing.Point(382, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 5;
            this.btnDelete.Size = new System.Drawing.Size(139, 47);
            this.btnDelete.TabIndex = 7;
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
            this.btnUpdate.Location = new System.Drawing.Point(222, 240);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 5;
            this.btnUpdate.Size = new System.Drawing.Size(139, 47);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "   Update";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.TextOffsetX = 5;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.Color.Transparent;
            this.txtBookName.BaseColor = System.Drawing.Color.White;
            this.txtBookName.BorderColor = System.Drawing.Color.Silver;
            this.txtBookName.BorderSize = 1;
            this.txtBookName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookName.Enabled = false;
            this.txtBookName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBookName.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtBookName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBookName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(285, 36);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.PasswordChar = '\0';
            this.txtBookName.Radius = 10;
            this.txtBookName.SelectedText = "";
            this.txtBookName.Size = new System.Drawing.Size(210, 39);
            this.txtBookName.TabIndex = 1;
            this.txtBookName.TextOffsetX = 5;
            // 
            // txtReturnDate
            // 
            this.txtReturnDate.BackColor = System.Drawing.Color.Transparent;
            this.txtReturnDate.BaseColor = System.Drawing.Color.White;
            this.txtReturnDate.BorderColor = System.Drawing.Color.Silver;
            this.txtReturnDate.BorderSize = 1;
            this.txtReturnDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReturnDate.Enabled = false;
            this.txtReturnDate.FocusedBaseColor = System.Drawing.Color.White;
            this.txtReturnDate.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtReturnDate.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtReturnDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnDate.Location = new System.Drawing.Point(533, 36);
            this.txtReturnDate.Name = "txtReturnDate";
            this.txtReturnDate.PasswordChar = '\0';
            this.txtReturnDate.Radius = 10;
            this.txtReturnDate.SelectedText = "";
            this.txtReturnDate.Size = new System.Drawing.Size(210, 39);
            this.txtReturnDate.TabIndex = 2;
            this.txtReturnDate.TextOffsetX = 5;
            // 
            // comBoxMemberId
            // 
            this.comBoxMemberId.BackColor = System.Drawing.Color.Transparent;
            this.comBoxMemberId.BaseColor = System.Drawing.Color.White;
            this.comBoxMemberId.BorderColor = System.Drawing.Color.Silver;
            this.comBoxMemberId.BorderSize = 1;
            this.comBoxMemberId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBoxMemberId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxMemberId.FocusedColor = System.Drawing.Color.Red;
            this.comBoxMemberId.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.comBoxMemberId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comBoxMemberId.FormattingEnabled = true;
            this.comBoxMemberId.Location = new System.Drawing.Point(18, 36);
            this.comBoxMemberId.Name = "comBoxMemberId";
            this.comBoxMemberId.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comBoxMemberId.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comBoxMemberId.Radius = 10;
            this.comBoxMemberId.Size = new System.Drawing.Size(210, 36);
            this.comBoxMemberId.TabIndex = 0;
            this.comBoxMemberId.TextChanged += new System.EventHandler(this.ComBoxTextChanged);
            this.comBoxMemberId.Click += new System.EventHandler(this.comBoxCliked);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(897, 636);
            this.Controls.Add(this.comBoxMemberId);
            this.Controls.Add(this.txtReturnDate);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtFine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.ReturnBookView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDayEpalsed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LendBook";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBookView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaDataGridView ReturnBookView;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtDayEpalsed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtFine;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaTextBox txtBookName;
        private Guna.UI.WinForms.GunaTextBox txtReturnDate;
        public Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaComboBox comBoxMemberId;
    }
}