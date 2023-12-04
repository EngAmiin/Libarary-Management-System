using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using System.Data.SqlClient;

namespace DatabaseConnection
{
    public partial class Book : Form
    {
        public static SqlConnection conn;
        public Book()
        {
            InitializeComponent();
        }

        private void registerBook(object sender, EventArgs e)
        {
            if (txtBookName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Book Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookName.Focus();

            }
            else if (txtBookName.Text.Trim().StartsWith("@") || (txtBookName.Text.Trim().StartsWith(",")
              || (txtBookName.Text.Trim().StartsWith(">")) || (txtBookName.Text.Trim().StartsWith("/")) ||
              (txtBookName.Text.Trim().StartsWith(".")) || (txtBookName.Text.Trim().StartsWith("?")) ||
              (txtBookName.Text.Trim().StartsWith("`")) || (txtBookName.Text.Trim().StartsWith("_")) ||
              (txtBookName.Text.Trim().StartsWith("-")) || (txtBookName.Text.Trim().StartsWith("=")) ||
              (txtBookName.Text.Trim().StartsWith("#")) || (txtBookName.Text.Trim().StartsWith("$")) ||
              (txtBookName.Text.Trim().StartsWith("!")) || (txtBookName.Text.Trim().StartsWith("%")) ||
              (txtBookName.Text.Trim().StartsWith("^")) || (txtBookName.Text.Trim().StartsWith("&")) ||
              (txtBookName.Text.Trim().StartsWith("(")) || (txtBookName.Text.Trim().StartsWith(")")) ||
              (txtBookName.Text.Trim().StartsWith("+")) || (txtBookName.Text.Trim().StartsWith("0")) ||
              (txtBookName.Text.Trim().StartsWith("1")) || (txtBookName.Text.Trim().StartsWith("2")) ||
              (txtBookName.Text.Trim().StartsWith("3")) || (txtBookName.Text.Trim().StartsWith("4")) ||
              (txtBookName.Text.Trim().StartsWith("5")) || (txtBookName.Text.Trim().StartsWith("6")) ||
              (txtBookName.Text.Trim().StartsWith("7")) || (txtBookName.Text.Trim().StartsWith("8")) ||
              (txtBookName.Text.Trim().StartsWith("9")) || (txtBookName.Text.Trim().StartsWith(" "))
              ))
            {
                MessageBox.Show("Book Name  never start with any digit .", "Book Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookName.Focus();
            }
            else if (comBoxCategory.Text.Trim().Equals(""))
            {
                MessageBox.Show("Categoty Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxCategory.Focus();
            }
            else if (comBoxAthorName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Author Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxAthorName.Focus();
            }
            else if (comBoxPublisherName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Publisher Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxPublisherName.Focus();
            }
            else if (comBoxBookType.Text.Trim().Equals(""))
            {
                MessageBox.Show("Book Type TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxBookType.Focus();
            }
            else if (txtBookPages.Text.Trim().Equals(""))
            {
                MessageBox.Show("Page TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookPages.Focus();
            }
            else if (txtBookPages.Text.Trim().StartsWith("@") || (txtBookPages.Text.Trim().StartsWith(",")
                  || (txtBookPages.Text.Trim().StartsWith(">")) || (txtBookPages.Text.Trim().StartsWith("/")) ||
                  (txtBookPages.Text.Trim().StartsWith(".")) || (txtBookPages.Text.Trim().StartsWith("?")) ||
                  (txtBookPages.Text.Trim().StartsWith("`")) || (txtBookPages.Text.Trim().StartsWith("_")) ||
                  (txtBookPages.Text.Trim().StartsWith("-")) || (txtBookPages.Text.Trim().StartsWith("=")) ||
                  (txtBookPages.Text.Trim().StartsWith("#")) || (txtBookPages.Text.Trim().StartsWith("$")) ||
                  (txtBookPages.Text.Trim().StartsWith("!")) || (txtBookPages.Text.Trim().StartsWith("%")) ||
                  (txtBookPages.Text.Trim().StartsWith("^")) || (txtBookPages.Text.Trim().StartsWith("&")) ||
                  (txtBookPages.Text.Trim().StartsWith("(")) || (txtBookPages.Text.Trim().StartsWith(")")) ||
                  (txtBookPages.Text.Trim().StartsWith("+")) || (txtBookPages.Text.Trim().StartsWith("e")) ||
                  (txtBookPages.Text.Trim().StartsWith("a")) || (txtBookPages.Text.Trim().StartsWith("g")) ||
                  (txtBookPages.Text.Trim().StartsWith("b")) || (txtBookPages.Text.Trim().StartsWith("h")) ||
                  (txtBookPages.Text.Trim().StartsWith("c")) || (txtBookPages.Text.Trim().StartsWith("i")) ||
                  (txtBookPages.Text.Trim().StartsWith("b")) || (txtBookPages.Text.Trim().StartsWith("j")) ||
                  (txtBookPages.Text.Trim().StartsWith("e")) || (txtBookPages.Text.Trim().StartsWith("k")) ||
                  (txtBookPages.Text.Trim().StartsWith("l")) || (txtBookPages.Text.Trim().StartsWith("q")) ||
                  (txtBookPages.Text.Trim().StartsWith("m")) || (txtBookPages.Text.Trim().StartsWith("r")) ||
                  (txtBookPages.Text.Trim().StartsWith("n")) || (txtBookPages.Text.Trim().StartsWith("s")) ||
                  (txtBookPages.Text.Trim().StartsWith("o")) || (txtBookPages.Text.Trim().StartsWith("t")) ||
                  (txtBookPages.Text.Trim().StartsWith("p")) || (txtBookPages.Text.Trim().StartsWith("u")) ||
                  (txtBookPages.Text.Trim().StartsWith("v")) || (txtBookPages.Text.Trim().StartsWith("A")) ||
                  (txtBookPages.Text.Trim().StartsWith("w")) || (txtBookPages.Text.Trim().StartsWith("B")) ||
                  (txtBookPages.Text.Trim().StartsWith("x")) || (txtBookPages.Text.Trim().StartsWith("C")) ||
                  (txtBookPages.Text.Trim().StartsWith("y")) || (txtBookPages.Text.Trim().StartsWith("D")) ||
                  (txtBookPages.Text.Trim().StartsWith("z")) || (txtBookPages.Text.Trim().StartsWith("E")) ||
                 (txtBookPages.Text.Trim().StartsWith("F")) || (txtBookPages.Text.Trim().StartsWith("O")) ||
                  (txtBookPages.Text.Trim().StartsWith("G")) || (txtBookPages.Text.Trim().StartsWith("P")) ||
                  (txtBookPages.Text.Trim().StartsWith("H")) || (txtBookPages.Text.Trim().StartsWith("Q")) ||
                  (txtBookPages.Text.Trim().StartsWith("I")) || (txtBookPages.Text.Trim().StartsWith("R")) ||
                  (txtBookPages.Text.Trim().StartsWith("J")) || (txtBookPages.Text.Trim().StartsWith("S")) ||
                  (txtBookPages.Text.Trim().StartsWith("K")) || (txtBookPages.Text.Trim().StartsWith("T")) ||
                  (txtBookPages.Text.Trim().StartsWith("L")) || (txtBookPages.Text.Trim().StartsWith("U")) ||
                  (txtBookPages.Text.Trim().StartsWith("M")) || (txtBookPages.Text.Trim().StartsWith("V")) ||
                  (txtBookPages.Text.Trim().StartsWith("N")) || (txtBookPages.Text.Trim().StartsWith("W")) ||
                (txtBookPages.Text.Trim().StartsWith("X")) || (txtBookPages.Text.Trim().StartsWith("Y")) ||
                  (txtBookPages.Text.Trim().StartsWith("Z")) || (txtBookPages.Text.Trim().StartsWith(" "))
              ))
            {
                MessageBox.Show("Book Page  never start with Any Charecters .", "Book Pages Must be digit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookPages.Focus();
            }
            else if (int.Parse(txtBookPages.Text) < 30)
            {
                MessageBox.Show("Book Pages is less then  30 page", "Book Page", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookPages.Focus();
            }
            else if (txtBookEdition.Text.Trim().Equals(""))
            {
                MessageBox.Show("Edition TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookEdition.Focus();
            }
            else if (txtBookEdition.Text.Trim().StartsWith("@") || (txtBookEdition.Text.Trim().StartsWith(",")
                  || (txtBookEdition.Text.Trim().StartsWith(">")) || (txtBookEdition.Text.Trim().StartsWith("/")) ||
                  (txtBookEdition.Text.Trim().StartsWith(".")) || (txtBookEdition.Text.Trim().StartsWith("?")) ||
                  (txtBookEdition.Text.Trim().StartsWith("`")) || (txtBookEdition.Text.Trim().StartsWith("_")) ||
                  (txtBookEdition.Text.Trim().StartsWith("-")) || (txtBookEdition.Text.Trim().StartsWith("=")) ||
                  (txtBookEdition.Text.Trim().StartsWith("#")) || (txtBookEdition.Text.Trim().StartsWith("$")) ||
                  (txtBookEdition.Text.Trim().StartsWith("!")) || (txtBookEdition.Text.Trim().StartsWith("%")) ||
                  (txtBookEdition.Text.Trim().StartsWith("^")) || (txtBookEdition.Text.Trim().StartsWith("&")) ||
                  (txtBookEdition.Text.Trim().StartsWith("(")) || (txtBookEdition.Text.Trim().StartsWith(")")) ||
                  (txtBookEdition.Text.Trim().StartsWith("+")) || (txtBookEdition.Text.Trim().StartsWith("0")) ||
                  (txtBookEdition.Text.Trim().StartsWith("1")) || (txtBookEdition.Text.Trim().StartsWith("2")) ||
                  (txtBookEdition.Text.Trim().StartsWith("3")) || (txtBookEdition.Text.Trim().StartsWith("4")) ||
                  (txtBookEdition.Text.Trim().StartsWith("5")) || (txtBookEdition.Text.Trim().StartsWith("6")) ||
                  (txtBookEdition.Text.Trim().StartsWith("7")) || (txtBookEdition.Text.Trim().StartsWith("8")) ||
                  (txtBookEdition.Text.Trim().StartsWith("9")) || (txtBookEdition.Text.Trim().StartsWith(" "))
            ))
            {
                MessageBox.Show("Book Edition never start with any digit .", "Book Edition Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookEdition.Focus();
            }
            else
            {
                string bookName = txtBookName.Text;
                int categoryName = int.Parse(comBoxCategory.SelectedValue.ToString());
                int authorName = int.Parse(comBoxAthorName.SelectedValue.ToString());
                int publisherName = int.Parse(comBoxPublisherName.SelectedValue.ToString());
                string bookType = comBoxBookType.Text;
                int pages = int.Parse(txtBookPages.Text.ToString());
                string edition = txtBookEdition.Text;

                BookInfo.registerBooks(bookName,categoryName,authorName,publisherName,bookType,pages,edition);
                BookInfo.loadAllBooks(BookView);
                MakeEmpryBooks();
            }
            
          
            
        }

        private void MakeEmpryBooks()
        {
            txtBookName.Text = "";
            comBoxCategory.Text = "";
            comBoxPublisherName.Text = "";
            comBoxPublisherName.Text = "";
            comBoxBookType.Text = "";
            txtBookPages.Text = "";
            txtBookEdition.Text = "";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void Book_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            BookInfo.loadAllBooks(BookView);
            categoryName();
            AuthorName();
            PublisherName();
            
           

        }




        public void categoryName()
        {
            conn = myConnections.GetConnections();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM category where status = 'active'", conn);
            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataSet d_table = new DataSet();
            reader.Fill(d_table);
            comBoxCategory.DataSource = d_table.Tables[0];
            comBoxCategory.DisplayMember = "catname";
            comBoxCategory.ValueMember = "id";

            conn.Close();
        }



        public void AuthorName()
        {
            conn = myConnections.GetConnections();   
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM author", conn);
            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataSet d_table = new DataSet();
            reader.Fill(d_table);
            comBoxAthorName.DataSource = d_table.Tables[0];
            comBoxAthorName.DisplayMember = "name";
            comBoxAthorName.ValueMember = "id";

            conn.Close();
        }
        


        public void PublisherName()
        {
            conn = myConnections.GetConnections();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM publisher", conn);
            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataSet d_table = new DataSet();
            reader.Fill(d_table);
            comBoxPublisherName.DataSource = d_table.Tables[0];
            comBoxPublisherName.DisplayMember = "name";
            comBoxPublisherName.ValueMember = "id";

            conn.Close();
        }

        //private void clicked(object sender, EventArgs e)
        //{
        //    categoryName();
        //}

        //private void clikedAuthor(object sender, EventArgs e)
        //{
        //    AuthorName();
           
        //}

        //private void ClikedPublisher(object sender, MouseEventArgs e)
        //{
        //    PublisherName();
        //}

        private void BookCellClik(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updatedId = (int)BookView.SelectedRows[0].Cells[0].Value;
            if (txtBookName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Book Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookName.Focus();

            }
            else if (txtBookName.Text.Trim().StartsWith("@") || (txtBookName.Text.Trim().StartsWith(",")
              || (txtBookName.Text.Trim().StartsWith(">")) || (txtBookName.Text.Trim().StartsWith("/")) ||
              (txtBookName.Text.Trim().StartsWith(".")) || (txtBookName.Text.Trim().StartsWith("?")) ||
              (txtBookName.Text.Trim().StartsWith("`")) || (txtBookName.Text.Trim().StartsWith("_")) ||
              (txtBookName.Text.Trim().StartsWith("-")) || (txtBookName.Text.Trim().StartsWith("=")) ||
              (txtBookName.Text.Trim().StartsWith("#")) || (txtBookName.Text.Trim().StartsWith("$")) ||
              (txtBookName.Text.Trim().StartsWith("!")) || (txtBookName.Text.Trim().StartsWith("%")) ||
              (txtBookName.Text.Trim().StartsWith("^")) || (txtBookName.Text.Trim().StartsWith("&")) ||
              (txtBookName.Text.Trim().StartsWith("(")) || (txtBookName.Text.Trim().StartsWith(")")) ||
              (txtBookName.Text.Trim().StartsWith("+")) || (txtBookName.Text.Trim().StartsWith("0")) ||
              (txtBookName.Text.Trim().StartsWith("1")) || (txtBookName.Text.Trim().StartsWith("2")) ||
              (txtBookName.Text.Trim().StartsWith("3")) || (txtBookName.Text.Trim().StartsWith("4")) ||
              (txtBookName.Text.Trim().StartsWith("5")) || (txtBookName.Text.Trim().StartsWith("6")) ||
              (txtBookName.Text.Trim().StartsWith("7")) || (txtBookName.Text.Trim().StartsWith("8")) ||
              (txtBookName.Text.Trim().StartsWith("9")) || (txtBookName.Text.Trim().StartsWith(" "))
              ))
            {
                MessageBox.Show("Book Name  never start with any digit .", "Book Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookName.Focus();
            }
            else if (comBoxCategory.Text.Trim().Equals(""))
            {
                MessageBox.Show("Categoty Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxCategory.Focus();
            }
            else if (comBoxAthorName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Author Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxAthorName.Focus();
            }
            else if (comBoxPublisherName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Publisher Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxPublisherName.Focus();
            }
            else if (comBoxBookType.Text.Trim().Equals(""))
            {
                MessageBox.Show("Book Type TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxBookType.Focus();
            }
            else if (txtBookPages.Text.Trim().Equals(""))
            {
                MessageBox.Show("Page TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookPages.Focus();
            }
            else if (txtBookPages.Text.Trim().StartsWith("@") || (txtBookPages.Text.Trim().StartsWith(",")
                  || (txtBookPages.Text.Trim().StartsWith(">")) || (txtBookPages.Text.Trim().StartsWith("/")) ||
                  (txtBookPages.Text.Trim().StartsWith(".")) || (txtBookPages.Text.Trim().StartsWith("?")) ||
                  (txtBookPages.Text.Trim().StartsWith("`")) || (txtBookPages.Text.Trim().StartsWith("_")) ||
                  (txtBookPages.Text.Trim().StartsWith("-")) || (txtBookPages.Text.Trim().StartsWith("=")) ||
                  (txtBookPages.Text.Trim().StartsWith("#")) || (txtBookPages.Text.Trim().StartsWith("$")) ||
                  (txtBookPages.Text.Trim().StartsWith("!")) || (txtBookPages.Text.Trim().StartsWith("%")) ||
                  (txtBookPages.Text.Trim().StartsWith("^")) || (txtBookPages.Text.Trim().StartsWith("&")) ||
                  (txtBookPages.Text.Trim().StartsWith("(")) || (txtBookPages.Text.Trim().StartsWith(")")) ||
                  (txtBookPages.Text.Trim().StartsWith("+")) || (txtBookPages.Text.Trim().StartsWith("e")) ||
                  (txtBookPages.Text.Trim().StartsWith("a")) || (txtBookPages.Text.Trim().StartsWith("g")) ||
                  (txtBookPages.Text.Trim().StartsWith("b")) || (txtBookPages.Text.Trim().StartsWith("h")) ||
                  (txtBookPages.Text.Trim().StartsWith("c")) || (txtBookPages.Text.Trim().StartsWith("i")) ||
                  (txtBookPages.Text.Trim().StartsWith("b")) || (txtBookPages.Text.Trim().StartsWith("j")) ||
                  (txtBookPages.Text.Trim().StartsWith("e")) || (txtBookPages.Text.Trim().StartsWith("k")) ||
                  (txtBookPages.Text.Trim().StartsWith("l")) || (txtBookPages.Text.Trim().StartsWith("q")) ||
                  (txtBookPages.Text.Trim().StartsWith("m")) || (txtBookPages.Text.Trim().StartsWith("r")) ||
                  (txtBookPages.Text.Trim().StartsWith("n")) || (txtBookPages.Text.Trim().StartsWith("s")) ||
                  (txtBookPages.Text.Trim().StartsWith("o")) || (txtBookPages.Text.Trim().StartsWith("t")) ||
                  (txtBookPages.Text.Trim().StartsWith("p")) || (txtBookPages.Text.Trim().StartsWith("u")) ||
                  (txtBookPages.Text.Trim().StartsWith("v")) || (txtBookPages.Text.Trim().StartsWith("A")) ||
                  (txtBookPages.Text.Trim().StartsWith("w")) || (txtBookPages.Text.Trim().StartsWith("B")) ||
                  (txtBookPages.Text.Trim().StartsWith("x")) || (txtBookPages.Text.Trim().StartsWith("C")) ||
                  (txtBookPages.Text.Trim().StartsWith("y")) || (txtBookPages.Text.Trim().StartsWith("D")) ||
                  (txtBookPages.Text.Trim().StartsWith("z")) || (txtBookPages.Text.Trim().StartsWith("E")) ||
                 (txtBookPages.Text.Trim().StartsWith("F")) || (txtBookPages.Text.Trim().StartsWith("O")) ||
                  (txtBookPages.Text.Trim().StartsWith("G")) || (txtBookPages.Text.Trim().StartsWith("P")) ||
                  (txtBookPages.Text.Trim().StartsWith("H")) || (txtBookPages.Text.Trim().StartsWith("Q")) ||
                  (txtBookPages.Text.Trim().StartsWith("I")) || (txtBookPages.Text.Trim().StartsWith("R")) ||
                  (txtBookPages.Text.Trim().StartsWith("J")) || (txtBookPages.Text.Trim().StartsWith("S")) ||
                  (txtBookPages.Text.Trim().StartsWith("K")) || (txtBookPages.Text.Trim().StartsWith("T")) ||
                  (txtBookPages.Text.Trim().StartsWith("L")) || (txtBookPages.Text.Trim().StartsWith("U")) ||
                  (txtBookPages.Text.Trim().StartsWith("M")) || (txtBookPages.Text.Trim().StartsWith("V")) ||
                  (txtBookPages.Text.Trim().StartsWith("N")) || (txtBookPages.Text.Trim().StartsWith("W")) ||
                (txtBookPages.Text.Trim().StartsWith("X")) || (txtBookPages.Text.Trim().StartsWith("Y")) ||
                  (txtBookPages.Text.Trim().StartsWith("Z")) || (txtBookPages.Text.Trim().StartsWith(" "))
              ))
            {
                MessageBox.Show("Book Page  never start with Any Charecters .", "Book Pages Must be digit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookPages.Focus();
            }
            else if (int.Parse(txtBookPages.Text) < 30)
            {
                MessageBox.Show("Book Pages is less then  30 page", "Book Page", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookPages.Focus();
            }
            else if (txtBookEdition.Text.Trim().Equals(""))
            {
                MessageBox.Show("Edition TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookEdition.Focus();
            }
            else if (txtBookEdition.Text.Trim().StartsWith("@") || (txtBookEdition.Text.Trim().StartsWith(",")
                  || (txtBookEdition.Text.Trim().StartsWith(">")) || (txtBookEdition.Text.Trim().StartsWith("/")) ||
                  (txtBookEdition.Text.Trim().StartsWith(".")) || (txtBookEdition.Text.Trim().StartsWith("?")) ||
                  (txtBookEdition.Text.Trim().StartsWith("`")) || (txtBookEdition.Text.Trim().StartsWith("_")) ||
                  (txtBookEdition.Text.Trim().StartsWith("-")) || (txtBookEdition.Text.Trim().StartsWith("=")) ||
                  (txtBookEdition.Text.Trim().StartsWith("#")) || (txtBookEdition.Text.Trim().StartsWith("$")) ||
                  (txtBookEdition.Text.Trim().StartsWith("!")) || (txtBookEdition.Text.Trim().StartsWith("%")) ||
                  (txtBookEdition.Text.Trim().StartsWith("^")) || (txtBookEdition.Text.Trim().StartsWith("&")) ||
                  (txtBookEdition.Text.Trim().StartsWith("(")) || (txtBookEdition.Text.Trim().StartsWith(")")) ||
                  (txtBookEdition.Text.Trim().StartsWith("+")) || (txtBookEdition.Text.Trim().StartsWith("0")) ||
                  (txtBookEdition.Text.Trim().StartsWith("1")) || (txtBookEdition.Text.Trim().StartsWith("2")) ||
                  (txtBookEdition.Text.Trim().StartsWith("3")) || (txtBookEdition.Text.Trim().StartsWith("4")) ||
                  (txtBookEdition.Text.Trim().StartsWith("5")) || (txtBookEdition.Text.Trim().StartsWith("6")) ||
                  (txtBookEdition.Text.Trim().StartsWith("7")) || (txtBookEdition.Text.Trim().StartsWith("8")) ||
                  (txtBookEdition.Text.Trim().StartsWith("9")) || (txtBookEdition.Text.Trim().StartsWith(" "))
            ))
            {
                MessageBox.Show("Book Edition never start with any digit .", "Book Edition Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookEdition.Focus();
            }
            else
            {
                string bookName = txtBookName.Text;
                int categoryName = int.Parse(comBoxCategory.SelectedValue.ToString());
                int authorName = int.Parse(comBoxAthorName.SelectedValue.ToString());
                int publisherName = int.Parse(comBoxPublisherName.SelectedValue.ToString());
                string bookType = comBoxBookType.Text;
                int pages = int.Parse(txtBookPages.Text.ToString());
                string edition = txtBookEdition.Text;

                BookInfo.updateBooks(bookName, categoryName, authorName, publisherName, bookType, pages, edition,updatedId);
                BookInfo.loadAllBooks(BookView);
                MakeEmpryBooks();
            }
        }






        public void serachText()
        {
            using (SqlConnection conn = myConnections.GetConnections())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select book.id 'BookID', book.name 'Book Name', category.catname 'Category Name',author.name 'Author Name', publisher.name 'Publisher Name', book.type 'Book Type',book.pages 'Pages', book.edition 'Edition' ,book.date 'Date' from book INNER JOIN category ON book.cid = category.id INNER JOIN author ON book.aid = author.id INNER JOIN publisher ON book.pid = publisher.id WHERE book.name LIKE '"  +txtSearch.Text + "%'", conn);
                SqlDataAdapter reader = new SqlDataAdapter(cmd);
                DataTable dTable = new DataTable();
                reader.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    BookView.DataSource = dTable;
                    BookView.Visible = true;
                    lbl_display.Visible = false;
                }
                else
                {
                    BookView.Visible = false;
                    lbl_display.Visible = true;

                }

               

                cmd.ExecuteNonQuery();

                conn.Close();



            }
        }

        private void BookTextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                serachText();
            }
            else
            {
                lbl_display.Visible = false;
                BookView.Visible = true;
                BookInfo.loadAllBooks(BookView);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int deletedId = (int)BookView.SelectedRows[0].Cells[0].Value;
            if (txtBookName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Book Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookPages.Focus();

            }
            else if (comBoxCategory.Text.Trim().Equals(""))
            {
                MessageBox.Show("Categoty Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxCategory.Focus();
            }
            else if (comBoxAthorName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Author Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxAthorName.Focus();
            }
            else if (comBoxPublisherName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Publisher Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxPublisherName.Focus();
            }
            else if (comBoxBookType.Text.Trim().Equals(""))
            {
                MessageBox.Show("Book Type TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxBookType.Focus();
            }
            else if (txtBookPages.Text.Trim().Equals(""))
            {
                MessageBox.Show("Page TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookPages.Focus();
            }
            else if (txtBookEdition.Text.Trim().Equals(""))
            {
                MessageBox.Show("Edition TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookEdition.Focus();
            }
            else
            {


                string name = txtBookPages.Text = (string)BookView.SelectedRows[0].Cells[1].Value;
                DialogResult confirmation = MessageBox.Show("Are You Sure To Delete " + name + " Book?", "COMFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation.HasFlag(DialogResult.No)) { return; }
                else
                {
                    PublisherInfo.deletePublisher(deletedId);
                    PublisherInfo.loadAllPublisher(BookView);
                    MakeEmpryBooks();
                }
                
            }
        }

        private void BookView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {


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
 
            int id = (int)BookView.SelectedRows[0].Cells[0].Value;
            txtBookName.Text = (string)BookView.SelectedRows[0].Cells[1].Value;
            comBoxCategory.Text = (string)BookView.SelectedRows[0].Cells[2].Value;
            comBoxAthorName.Text = (string)BookView.SelectedRows[0].Cells[3].Value;
            comBoxPublisherName.Text = (string)BookView.SelectedRows[0].Cells[4].Value;
            comBoxBookType.Text = (string)BookView.SelectedRows[0].Cells[5].Value;
            int pages = (int)BookView.SelectedRows[0].Cells[6].Value;
            txtBookEdition.Text = (string)BookView.SelectedRows[0].Cells[7].Value;
            txtBookPages.Text = pages.ToString();
        }



        

    }
}
