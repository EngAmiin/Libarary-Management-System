namespace DatabaseConnection
{
    partial class UserProfile
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUserPhoneNo = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comBoxSex = new Guna.UI.WinForms.GunaComboBox();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI.WinForms.GunaTextBox();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserId = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 8;
            this.gunaElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DatabaseConnection.Properties.Resources.icons8_close_25px;
            this.pictureBox1.Location = new System.Drawing.Point(481, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtUserPhoneNo
            // 
            this.txtUserPhoneNo.BackColor = System.Drawing.Color.Transparent;
            this.txtUserPhoneNo.BaseColor = System.Drawing.Color.White;
            this.txtUserPhoneNo.BorderColor = System.Drawing.Color.Silver;
            this.txtUserPhoneNo.BorderSize = 1;
            this.txtUserPhoneNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserPhoneNo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUserPhoneNo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtUserPhoneNo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserPhoneNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPhoneNo.Location = new System.Drawing.Point(249, 211);
            this.txtUserPhoneNo.MaxLength = 9;
            this.txtUserPhoneNo.Name = "txtUserPhoneNo";
            this.txtUserPhoneNo.PasswordChar = '\0';
            this.txtUserPhoneNo.Radius = 10;
            this.txtUserPhoneNo.SelectedText = "";
            this.txtUserPhoneNo.Size = new System.Drawing.Size(210, 39);
            this.txtUserPhoneNo.TabIndex = 5;
            this.txtUserPhoneNo.TextOffsetX = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(249, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Phone No";
            // 
            // comBoxSex
            // 
            this.comBoxSex.BackColor = System.Drawing.Color.Transparent;
            this.comBoxSex.BaseColor = System.Drawing.Color.White;
            this.comBoxSex.BorderColor = System.Drawing.Color.Silver;
            this.comBoxSex.BorderSize = 1;
            this.comBoxSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSex.FocusedColor = System.Drawing.Color.Red;
            this.comBoxSex.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.comBoxSex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comBoxSex.FormattingEnabled = true;
            this.comBoxSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comBoxSex.Location = new System.Drawing.Point(16, 132);
            this.comBoxSex.Name = "comBoxSex";
            this.comBoxSex.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comBoxSex.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comBoxSex.Radius = 10;
            this.comBoxSex.Size = new System.Drawing.Size(210, 36);
            this.comBoxSex.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.BorderSize = 1;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(12, 212);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Radius = 10;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(210, 39);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextOffsetX = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BaseColor = System.Drawing.Color.White;
            this.txtUsername.BorderColor = System.Drawing.Color.Silver;
            this.txtUsername.BorderSize = 1;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(249, 128);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.Radius = 10;
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(210, 39);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextOffsetX = 5;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BaseColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.Silver;
            this.txtName.BorderSize = 1;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(249, 35);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.Radius = 10;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(210, 39);
            this.txtName.TabIndex = 1;
            this.txtName.TextOffsetX = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(249, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Sex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(249, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name";
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.Color.Transparent;
            this.txtUserId.BaseColor = System.Drawing.Color.White;
            this.txtUserId.BorderColor = System.Drawing.Color.Silver;
            this.txtUserId.BorderSize = 1;
            this.txtUserId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserId.Enabled = false;
            this.txtUserId.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUserId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtUserId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(12, 35);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.PasswordChar = '\0';
            this.txtUserId.Radius = 10;
            this.txtUserId.SelectedText = "";
            this.txtUserId.Size = new System.Drawing.Size(210, 39);
            this.txtUserId.TabIndex = 0;
            this.txtUserId.TextOffsetX = 5;
            this.txtUserId.TextChanged += new System.EventHandler(this.txtUserIdTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "User ID";
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
            this.btnDelete.Location = new System.Drawing.Point(251, 296);
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
            this.btnUpdate.Location = new System.Drawing.Point(87, 296);
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
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(528, 468);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserPhoneNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comBoxSex);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserProfile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaTextBox txtUserPhoneNo;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaComboBox comBoxSex;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtUsername;
        private Guna.UI.WinForms.GunaTextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtUserId;
        private System.Windows.Forms.Label label1;
        public Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaButton btnUpdate;
    }
}