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
    public partial class UserProfile : Form
    {
        public static SqlConnection conn;
        public static string type;
        public UserProfile()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            conn = myConnections.GetConnections();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select id , name, sex, username, password,phone from users WHERE username = '" +myDash.user + "' ", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtUserId.Text = reader["id"].ToString();
                txtName.Text = reader["name"].ToString();
                comBoxSex.Text = reader["sex"].ToString();
                txtUsername.Text = reader["username"].ToString();
                txtPassword.Text = reader["password"].ToString();
                txtUserPhoneNo.Text = reader["phone"].ToString();

            }

            conn.Close();
        }

        private void txtUserIdTextChanged(object sender, EventArgs e)
        {
            //if (txtUserId.Text.Trim().Equals(""))
            //{
            //    txtName.Text = "";
            //    comBoxSex.Text = "";
            //    txtUsername.Text = "";
            //    txtPassword.Text = "";
            //    txtUserPhoneNo.Text = "";
            //    return;
            //}
            
            //else
            //{
            //    conn = myConnections.GetConnections();
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand("Select id , name, sex, username, password phone from lendbook WHERE id = '" + txtUserId.Text + "' ", conn);
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    if (reader.Read())
            //    {
            //        txtName.Text = reader["name"].ToString();
            //        comBoxSex.Text = reader["sex"].ToString();
            //        txtUsername.Text = reader["username"].ToString();
            //        txtPassword.Text = reader["password"].ToString();
            //        txtUserPhoneNo.Text = reader["phone"].ToString();
                    
            //    }
               
            //    conn.Close();
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string phone = txtUserPhoneNo.Text;
            if (txtName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Name Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
            else if (txtName.Text.StartsWith("@") || (txtName.Text.StartsWith(",")
              || (txtName.Text.StartsWith(">")) || (txtName.Text.StartsWith("/")) ||
              (txtName.Text.StartsWith(".")) || (txtName.Text.StartsWith("?")) ||
              (txtName.Text.StartsWith("`")) || (txtName.Text.StartsWith("_")) ||
              (txtName.Text.StartsWith("-")) || (txtName.Text.StartsWith("=")) ||
              (txtName.Text.StartsWith("#")) || (txtName.Text.StartsWith("$")) ||
              (txtName.Text.StartsWith("!")) || (txtName.Text.StartsWith("%")) ||
              (txtName.Text.StartsWith("^")) || (txtName.Text.StartsWith("&")) ||
              (txtName.Text.StartsWith("(")) || (txtName.Text.StartsWith(")")) ||
              (txtName.Text.StartsWith("+")) || (txtName.Text.StartsWith("0")) ||
              (txtName.Text.StartsWith("1")) || (txtName.Text.StartsWith("2")) ||
              (txtName.Text.StartsWith("3")) || (txtName.Text.StartsWith("4")) ||
              (txtName.Text.StartsWith("5")) || (txtName.Text.StartsWith("6")) ||
              (txtName.Text.StartsWith("7")) || (txtName.Text.StartsWith("8")) ||
              (txtName.Text.StartsWith("9")) || (txtName.Text.StartsWith(" "))
              ))
            {
                MessageBox.Show("Full Name  never start with any digit .", "Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }

            else if (comBoxSex.Text.Trim().Equals(""))
            {
                MessageBox.Show("Gender Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxSex.Focus();
            }
            else if (txtUsername.Text.Trim().Equals(""))
            {
                MessageBox.Show("Username Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if (txtUsername.Text.StartsWith("@") || (txtUsername.Text.StartsWith(",")
              || (txtUsername.Text.StartsWith(">")) || (txtUsername.Text.StartsWith("/")) ||
              (txtUsername.Text.StartsWith(".")) || (txtUsername.Text.StartsWith("?")) ||
              (txtUsername.Text.StartsWith("`")) || (txtUsername.Text.StartsWith("_")) ||
              (txtUsername.Text.StartsWith("-")) || (txtUsername.Text.StartsWith("=")) ||
              (txtUsername.Text.StartsWith("#")) || (txtUsername.Text.StartsWith("$")) ||
              (txtUsername.Text.StartsWith("!")) || (txtUsername.Text.StartsWith("%")) ||
              (txtUsername.Text.StartsWith("^")) || (txtUsername.Text.StartsWith("&")) ||
              (txtUsername.Text.StartsWith("(")) || (txtUsername.Text.StartsWith(")")) ||
              (txtUsername.Text.StartsWith("+")) || (txtUsername.Text.StartsWith("0")) ||
              (txtUsername.Text.StartsWith("1")) || (txtUsername.Text.StartsWith("2")) ||
              (txtUsername.Text.StartsWith("3")) || (txtUsername.Text.StartsWith("4")) ||
              (txtUsername.Text.StartsWith("5")) || (txtUsername.Text.StartsWith("6")) ||
              (txtUsername.Text.StartsWith("7")) || (txtUsername.Text.StartsWith("8")) ||
              (txtUsername.Text.StartsWith("9")) || (txtUsername.Text.StartsWith(" "))
              ))
            {
                MessageBox.Show("Username  never start with any digit .", "Username Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if (txtPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("User Psssword Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
           
            else if (txtUserPhoneNo.Text.Trim().Equals(""))
            {
                MessageBox.Show("User Phone No Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!(txtUserPhoneNo.Text.StartsWith("6")))
            {
                MessageBox.Show("Your Phone number is must Start with 6.", "User Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (txtUserPhoneNo.Text.Length < 9)
            {
                MessageBox.Show("User Phone Is Invalid Number", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 0))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 1))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 2))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 3))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 4))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 5))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 6))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 7))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 8))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else
            {
               try
                {
                    conn = myConnections.GetConnections();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Update users set name ='"+txtName.Text+"',sex = '"+comBoxSex.Text+"',username = '"+txtUsername.Text+"', password = '"+txtPassword.Text+ "',phone = '"+txtUserPhoneNo.Text+"' Where id = '" + txtUserId.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated Your Profile.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                    conn.Close();

            
          
                    
                    
                }
               catch
               {
                   MessageBox.Show("Username Or User Phone Are Alreay Exists ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   txtUsername.Focus();
               }

               this.Hide();

               DialogResult res = MessageBox.Show("Are You Want To Refresh The System To See Event Changed!", "Confiramtion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (res.HasFlag(DialogResult.No)) { return; }
               else
               {
                   UserLogin usr = new UserLogin();
                   usr.Show();
                   this.Close();
               }
                

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Name Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
            else if (comBoxSex.Text.Trim().Equals(""))
            {
                MessageBox.Show("Gender Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxSex.Focus();
            }
            else if (txtUsername.Text.Trim().Equals(""))
            {
                MessageBox.Show("Username Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if (txtPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("User Psssword Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            
            else if (txtUserPhoneNo.Text.Trim().Equals(""))
            {
                MessageBox.Show("User Phone No Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }


            else
            {




                DialogResult confim = MessageBox.Show("Are You Sure To Delete Your Account Permanently ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confim.HasFlag(DialogResult.No))
                {
                    return;
                }
                else
                {
                    userInfo user = new userInfo();
                    user.deleteUser(int.Parse(txtUserId.Text.ToString()));
                    this.Hide();
                    myDash d = new myDash();
                    d.Hide();
                    UserDash ud = new UserDash();
                    ud.Hide();
                    UserLogin usr = new UserLogin();
                    usr.Show();
                    //this.Hide();
                }


            }
        }
    }
}
