using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabaseConnection
{
    public partial class UserLogin : Form
    {
        public static SqlConnection connection;
        public static string type;
        public UserLogin()
        {
            InitializeComponent();
        }

        private void show_Click(object sender, EventArgs e)
        {
            iconHide.Visible = true;
            txtPassword.PasswordChar = '\0';
            iconShow.Visible = false;
        }

        private void iconHide_Click(object sender, EventArgs e)
        {
            iconShow.Visible = true;
            txtPassword.PasswordChar = '*';
            iconHide.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //SpalashScreen sb = new SpalashScreen();
            //sb.Show();

            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isBlank())
            {

                if (check_User())
                {
                    successLogin();
                }

            }
        }


        private bool check_User()
        {
            connection = myConnections.GetConnections();
            connection.Open();
            SqlCommand cmd = new SqlCommand("select utype username from users where  username = '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "' ", connection);
            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataTable data_Table = new DataTable();
            reader.Fill(data_Table);
            if (data_Table.Rows.Count > 0)
            {
                type = (string)cmd.ExecuteScalar();
                return true;
            }
            else
            {
                MessageBox.Show("username or password is incorrect.\nPlease try again.!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                makeEmpty();
                return false;
                //makeEmpty();
            }
        }


        private void successLogin()
        {
            myDash dash = new myDash(txtUsername.Text,type);
            dash.Show();
            this.Hide();
        }

        private bool isBlank()
        {
            if (txtUsername.Text.Trim().Equals("") || txtPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("All Fields Are Required.!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                makeEmpty();
                return false;
            }
            else
            {

                return true;
            }
        }


        private void makeEmpty()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword forget = new ForgetPassword();
            forget.Show();
            this.Close();
        }


      
    }
}
