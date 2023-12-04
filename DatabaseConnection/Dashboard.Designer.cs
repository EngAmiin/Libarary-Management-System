namespace DatabaseConnection
{
    partial class myDash
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblType = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.cA202DataSet = new DatabaseConnection.CA202DataSet();
            this.toolTipProfile = new System.Windows.Forms.ToolTip(this.components);
            this.btnProfile = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnLendBook = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnPublisher = new System.Windows.Forms.Button();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cA202DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnReturnBook);
            this.panel1.Controls.Add(this.btnLendBook);
            this.panel1.Controls.Add(this.btnMember);
            this.panel1.Controls.Add(this.btnBook);
            this.panel1.Controls.Add(this.btnPublisher);
            this.panel1.Controls.Add(this.btnAuthor);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 720);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.lblType);
            this.panel2.Controls.Add(this.label_user);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 80);
            this.panel2.TabIndex = 0;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.Yellow;
            this.lblType.Location = new System.Drawing.Point(72, 41);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(62, 19);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "ADMIN";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.ForeColor = System.Drawing.Color.Orange;
            this.label_user.Location = new System.Drawing.Point(66, 20);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(87, 19);
            this.label_user.TabIndex = 2;
            this.label_user.Text = "username";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.btnProfile);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(220, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(898, 80);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(241, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Library Management System";
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(220, 80);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(897, 636);
            this.panelContainer.TabIndex = 3;
            // 
            // cA202DataSet
            // 
            this.cA202DataSet.DataSetName = "CA202DataSet";
            this.cA202DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnProfile
            // 
            this.btnProfile.BaseColor = System.Drawing.Color.LightSeaGreen;
            this.btnProfile.Image = global::DatabaseConnection.Properties.Resources.icons8_male_user_50;
            this.btnProfile.Location = new System.Drawing.Point(800, 12);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(42, 42);
            this.btnProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnProfile.TabIndex = 3;
            this.btnProfile.TabStop = false;
            this.toolTipProfile.SetToolTip(this.btnProfile, "User Profile");
            this.btnProfile.UseTransfarantBackground = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::DatabaseConnection.Properties.Resources.icons8_close_25px;
            this.btnClose.Location = new System.Drawing.Point(848, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 35);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.Image = global::DatabaseConnection.Properties.Resources.icons8_shutdown_25px;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 620);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(220, 60);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "          Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReturnBook.FlatAppearance.BorderSize = 0;
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReturnBook.Image = global::DatabaseConnection.Properties.Resources.icons8_return_book_48;
            this.btnReturnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnBook.Location = new System.Drawing.Point(0, 560);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReturnBook.Size = new System.Drawing.Size(220, 60);
            this.btnReturnBook.TabIndex = 10;
            this.btnReturnBook.Text = "          Return Book";
            this.btnReturnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnLendBook
            // 
            this.btnLendBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLendBook.FlatAppearance.BorderSize = 0;
            this.btnLendBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLendBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLendBook.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLendBook.Image = global::DatabaseConnection.Properties.Resources.icons8_borrow_book_50;
            this.btnLendBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLendBook.Location = new System.Drawing.Point(0, 500);
            this.btnLendBook.Name = "btnLendBook";
            this.btnLendBook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLendBook.Size = new System.Drawing.Size(220, 60);
            this.btnLendBook.TabIndex = 9;
            this.btnLendBook.Text = "          Lend Book";
            this.btnLendBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLendBook.UseVisualStyleBackColor = true;
            this.btnLendBook.Click += new System.EventHandler(this.btnLendBook_Click);
            // 
            // btnMember
            // 
            this.btnMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMember.FlatAppearance.BorderSize = 0;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMember.Image = global::DatabaseConnection.Properties.Resources.icons8_membership_64__1_;
            this.btnMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMember.Location = new System.Drawing.Point(0, 440);
            this.btnMember.Name = "btnMember";
            this.btnMember.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMember.Size = new System.Drawing.Size(220, 60);
            this.btnMember.TabIndex = 8;
            this.btnMember.Text = "          Member";
            this.btnMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnBook
            // 
            this.btnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBook.Image = global::DatabaseConnection.Properties.Resources.icons8_read_50_2;
            this.btnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.Location = new System.Drawing.Point(0, 380);
            this.btnBook.Name = "btnBook";
            this.btnBook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBook.Size = new System.Drawing.Size(220, 60);
            this.btnBook.TabIndex = 7;
            this.btnBook.Text = "          Book";
            this.btnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnPublisher
            // 
            this.btnPublisher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPublisher.FlatAppearance.BorderSize = 0;
            this.btnPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublisher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublisher.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPublisher.Image = global::DatabaseConnection.Properties.Resources.icons8_printer_32__1_;
            this.btnPublisher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPublisher.Location = new System.Drawing.Point(0, 320);
            this.btnPublisher.Name = "btnPublisher";
            this.btnPublisher.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPublisher.Size = new System.Drawing.Size(220, 60);
            this.btnPublisher.TabIndex = 6;
            this.btnPublisher.Text = "          Publisher";
            this.btnPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPublisher.UseVisualStyleBackColor = true;
            this.btnPublisher.Click += new System.EventHandler(this.btnPublisher_Click);
            // 
            // btnAuthor
            // 
            this.btnAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAuthor.FlatAppearance.BorderSize = 0;
            this.btnAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthor.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAuthor.Image = global::DatabaseConnection.Properties.Resources.icons8_author_64__1__3;
            this.btnAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthor.Location = new System.Drawing.Point(0, 260);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAuthor.Size = new System.Drawing.Size(220, 60);
            this.btnAuthor.TabIndex = 5;
            this.btnAuthor.Text = "           Author";
            this.btnAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthor.UseVisualStyleBackColor = true;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCategory.Image = global::DatabaseConnection.Properties.Resources.category_removebg_preview2;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(0, 200);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCategory.Size = new System.Drawing.Size(220, 60);
            this.btnCategory.TabIndex = 4;
            this.btnCategory.Text = "          Category";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUsers.Image = global::DatabaseConnection.Properties.Resources.icons8_user_account_25px;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 140);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(220, 60);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "          Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.brnUsers_Click_1);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.Image = global::DatabaseConnection.Properties.Resources.icons8_home_25px_1;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 80);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(220, 60);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "          Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DatabaseConnection.Properties.Resources.unknown;
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // myDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1118, 720);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "myDash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.myDash_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cA202DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Panel panel3;
        private CA202DataSet cA202DataSet;
        public System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnLendBook;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnPublisher;
        private System.Windows.Forms.Button btnAuthor;
        public System.Windows.Forms.Label lblType;
        private Guna.UI.WinForms.GunaCirclePictureBox btnProfile;
        private System.Windows.Forms.ToolTip toolTipProfile;
        public System.Windows.Forms.Label label_user;

    }
}

