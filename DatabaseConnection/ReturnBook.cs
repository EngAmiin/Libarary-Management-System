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
    public partial class ReturnBook : Form
    {
        public static SqlConnection conn;
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comBoxMemberId.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxMemberId.Focus();
            }
            else if (comBoxMemberId.Text.StartsWith("@") || (comBoxMemberId.Text.StartsWith(",")
                || (comBoxMemberId.Text.StartsWith(">")) || (comBoxMemberId.Text.StartsWith("/")) ||
                (comBoxMemberId.Text.StartsWith(".")) || (comBoxMemberId.Text.StartsWith("?")) ||
                (comBoxMemberId.Text.StartsWith("`")) || (comBoxMemberId.Text.StartsWith("_")) ||
                (comBoxMemberId.Text.StartsWith("-")) || (comBoxMemberId.Text.StartsWith("=")) ||
                (comBoxMemberId.Text.StartsWith("#")) || (comBoxMemberId.Text.StartsWith("$")) ||
                (comBoxMemberId.Text.StartsWith("!")) || (comBoxMemberId.Text.StartsWith("%")) ||
                (comBoxMemberId.Text.StartsWith("^")) || (comBoxMemberId.Text.StartsWith("&")) ||
                (comBoxMemberId.Text.StartsWith("(")) || (comBoxMemberId.Text.StartsWith(")")) ||
                (comBoxMemberId.Text.StartsWith("+")) || (comBoxMemberId.Text.StartsWith("e")) ||
                (comBoxMemberId.Text.StartsWith("a")) || (comBoxMemberId.Text.StartsWith("g")) ||
                (comBoxMemberId.Text.StartsWith("b")) || (comBoxMemberId.Text.StartsWith("h")) ||
                (comBoxMemberId.Text.StartsWith("c")) || (comBoxMemberId.Text.StartsWith("i")) ||
                (comBoxMemberId.Text.StartsWith("b")) || (comBoxMemberId.Text.StartsWith("j")) ||
                (comBoxMemberId.Text.StartsWith("e")) || (comBoxMemberId.Text.StartsWith("k")) ||
                (comBoxMemberId.Text.StartsWith("l")) || (comBoxMemberId.Text.StartsWith("q")) ||
                (comBoxMemberId.Text.StartsWith("m")) || (comBoxMemberId.Text.StartsWith("r")) ||
                (comBoxMemberId.Text.StartsWith("n")) || (comBoxMemberId.Text.StartsWith("s")) ||
                (comBoxMemberId.Text.StartsWith("o")) || (comBoxMemberId.Text.StartsWith("t")) ||
                (comBoxMemberId.Text.StartsWith("p")) || (comBoxMemberId.Text.StartsWith("u")) ||
                (comBoxMemberId.Text.StartsWith("v")) || (comBoxMemberId.Text.StartsWith("A")) ||
                (comBoxMemberId.Text.StartsWith("w")) || (comBoxMemberId.Text.StartsWith("B")) ||
                (comBoxMemberId.Text.StartsWith("x")) || (comBoxMemberId.Text.StartsWith("C")) ||
                (comBoxMemberId.Text.StartsWith("y")) || (comBoxMemberId.Text.StartsWith("D")) ||
                (comBoxMemberId.Text.StartsWith("z")) || (comBoxMemberId.Text.StartsWith("E")) ||
               (comBoxMemberId.Text.StartsWith("F")) || (comBoxMemberId.Text.StartsWith("O")) ||
                (comBoxMemberId.Text.StartsWith("G")) || (comBoxMemberId.Text.StartsWith("P")) ||
                (comBoxMemberId.Text.StartsWith("H")) || (comBoxMemberId.Text.StartsWith("Q")) ||
                (comBoxMemberId.Text.StartsWith("I")) || (comBoxMemberId.Text.StartsWith("R")) ||
                (comBoxMemberId.Text.StartsWith("J")) || (comBoxMemberId.Text.StartsWith("S")) ||
                (comBoxMemberId.Text.StartsWith("K")) || (comBoxMemberId.Text.StartsWith("T")) ||
                (comBoxMemberId.Text.StartsWith("L")) || (comBoxMemberId.Text.StartsWith("U")) ||
                (comBoxMemberId.Text.StartsWith("M")) || (comBoxMemberId.Text.StartsWith("V")) ||
                (comBoxMemberId.Text.StartsWith("N")) || (comBoxMemberId.Text.StartsWith("W")) ||
              (comBoxMemberId.Text.StartsWith("X")) || (comBoxMemberId.Text.StartsWith("Y")) ||
                (comBoxMemberId.Text.StartsWith("Z")) || (comBoxMemberId.Text.StartsWith(" "))
               ))
            {
                MessageBox.Show("Member ID  never start with Any Charecters .", "Member ID Must be digit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxMemberId.Focus();
            }

            else if (txtBookName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Book Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookName.Focus();
            }
            else if (txtBookName.Text.StartsWith("@") || (txtBookName.Text.StartsWith(",")
          || (txtBookName.Text.StartsWith(">")) || (txtBookName.Text.StartsWith("/")) ||
          (txtBookName.Text.StartsWith(".")) || (txtBookName.Text.StartsWith("?")) ||
          (txtBookName.Text.StartsWith("`")) || (txtBookName.Text.StartsWith("_")) ||
          (txtBookName.Text.StartsWith("-")) || (txtBookName.Text.StartsWith("=")) ||
          (txtBookName.Text.StartsWith("#")) || (txtBookName.Text.StartsWith("$")) ||
          (txtBookName.Text.StartsWith("!")) || (txtBookName.Text.StartsWith("%")) ||
          (txtBookName.Text.StartsWith("^")) || (txtBookName.Text.StartsWith("&")) ||
          (txtBookName.Text.StartsWith("(")) || (txtBookName.Text.StartsWith(")")) ||
          (txtBookName.Text.StartsWith("+")) || (txtBookName.Text.StartsWith("0")) ||
          (txtBookName.Text.StartsWith("1")) || (txtBookName.Text.StartsWith("2")) ||
          (txtBookName.Text.StartsWith("3")) || (txtBookName.Text.StartsWith("4")) ||
          (txtBookName.Text.StartsWith("5")) || (txtBookName.Text.StartsWith("6")) ||
          (txtBookName.Text.StartsWith("7")) || (txtBookName.Text.StartsWith("8")) ||
          (txtBookName.Text.StartsWith("9")) || (txtBookName.Text.StartsWith(" "))
          ))
            {
                MessageBox.Show("Book Name  never start with any digit .", "Book Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookName.Focus();
            }
            else if (txtReturnDate.Text.Trim().Equals(""))
            {
                MessageBox.Show("Return Book Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtReturnDate.Focus();
            }
            else if (txtDayEpalsed.Text.Trim().Equals(""))
            {
                MessageBox.Show("Day Elapsed TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDayEpalsed.Focus();
            }
            else if (txtFine.Text.Trim().Equals(""))
            {
                MessageBox.Show("Fine TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFine.Focus();
            }

            else
            {
                ReturnBookInfo.registerReturnBook(int.Parse(comBoxMemberId.Text), txtBookName.Text, txtReturnDate.Text, int.Parse(txtDayEpalsed.Text), Double.Parse(txtFine.Text));
                ReturnBookInfo.loadAllReturnBook(ReturnBookView);
                MakeEmptyRuturnBooks();

            }
        }

        private void MakeEmptyRuturnBooks()
        {
            comBoxMemberId.Text = "";
            txtBookName.Text = "";
            txtReturnDate.Text = "";
            txtDayEpalsed.Text = "";
            txtFine.Text = "";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            ReturnBookInfo.loadAllReturnBook(ReturnBookView);
        }
        public void memberIds()
        {
            conn = myConnections.GetConnections();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM member", conn);
            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataSet d_table = new DataSet();
            reader.Fill(d_table);
            comBoxMemberId.DataSource = d_table.Tables[0];
            comBoxMemberId.DisplayMember = "id";
            comBoxMemberId.ValueMember = "id";

            conn.Close();
        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (comBoxMemberId.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxMemberId.Focus();
            }

            else if (txtBookName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Book Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookName.Focus();
            }
            else if (txtReturnDate.Text.Trim().Equals(""))
            {
                MessageBox.Show("Return Book Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtReturnDate.Focus();
            }
            else if (txtDayEpalsed.Text.Trim().Equals(""))
            {
                MessageBox.Show("Day Elapsed TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDayEpalsed.Focus();
            }
            else if (txtFine.Text.Trim().Equals(""))
            {
                MessageBox.Show("Fine TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFine.Focus();
            }

            else
            {
                int updateId = (int)ReturnBookView.SelectedRows[0].Cells[1].Value;
                ReturnBookInfo.updateReturnBook(int.Parse(comBoxMemberId.Text), txtBookName.Text, txtReturnDate.Text, int.Parse(txtDayEpalsed.Text), Double.Parse(txtFine.Text),updateId);
                ReturnBookInfo.loadAllReturnBook(ReturnBookView);
                MakeEmptyRuturnBooks();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comBoxMemberId.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxMemberId.Focus();
            }

            else if (txtBookName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Book Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookName.Focus();
            }
            else if (txtReturnDate.Text.Trim().Equals(""))
            {
                MessageBox.Show("Return Book Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtReturnDate.Focus();
            }
            else if (txtDayEpalsed.Text.Trim().Equals(""))
            {
                MessageBox.Show("Day Elapsed TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDayEpalsed.Focus();
            }
            else if (txtFine.Text.Trim().Equals(""))
            {
                MessageBox.Show("Fine TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFine.Focus();
            }

            else
            {
                DialogResult confirmation = MessageBox.Show("Are You Sure To Delete Lended Book?", "COMFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation.HasFlag(DialogResult.No)) { return; }
                else
                {
                    int deletedId = (int)ReturnBookView.SelectedRows[0].Cells[0].Value;
                    ReturnBookInfo.deleteReturnBook(deletedId);
                    ReturnBookInfo.loadAllReturnBook(ReturnBookView);
                  
                    MakeEmptyRuturnBooks();
                    
                   
                }
                
            }

        }

        private void ReturnBookCellClick(object sender, DataGridViewCellEventArgs e)
        {
            memberIds();
            if (myDash.role != "ADMIN")
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;

            int id = (int)ReturnBookView.SelectedRows[0].Cells[0].Value;
            int mid = (int)ReturnBookView.SelectedRows[0].Cells[1].Value;
            txtBookName.Text = (string)ReturnBookView.SelectedRows[0].Cells[2].Value.ToString();
            DateTime rdate  = (DateTime)ReturnBookView.SelectedRows[0].Cells[3].Value;
            int elap = (int)ReturnBookView.SelectedRows[0].Cells[4].Value;
            double fine = (double)ReturnBookView.SelectedRows[0].Cells[5].Value;

            comBoxMemberId.Text = mid.ToString();
            txtDayEpalsed.Text = elap.ToString();
            txtFine.Text = fine.ToString();
            txtReturnDate.Text = rdate.ToLongDateString();
        }

        private void ComBoxTextChanged(object sender, EventArgs e)
        {
            if (comBoxMemberId.SelectedItem == "")
            {
                txtReturnDate.Text = "";
                txtFine.Text = "";
                txtDayEpalsed.Text = "";
                txtBookName.Text = "";
                return;
            }

            else
            {
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select bname, rdate, DATEDIFF(dd,rdate,GETDATE()) 'Elapsed' from lendbook WHERE mid = '" + comBoxMemberId.Text + "' ", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtBookName.Text = reader["bname"].ToString();
                    txtReturnDate.Text = reader["rdate"].ToString();
                    string elap = reader["Elapsed"].ToString();

                    int elapp = int.Parse(elap);
                    if (elapp > 0)
                    {
                        txtDayEpalsed.Text = elap;
                        double fine = (double)elapp / 100;
                        txtFine.Text = fine.ToString();
                    }
                    else
                    {
                        txtDayEpalsed.Text = "0";
                        txtFine.Text = "0";
                    }

                }
                else
                {
                    MessageBox.Show("Sorry This Member ID Not Found...!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comBoxMemberId.Text = "";
                }
                conn.Close();
            }
        }

        private void comBoxCliked(object sender, EventArgs e)
        {
            memberIds();
        }

       
    }
}
