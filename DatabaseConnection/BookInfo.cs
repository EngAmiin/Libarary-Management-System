﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace DatabaseConnection
{
    public class BookInfo
    {
        public static SqlConnection conn;

        public static void loadAllBooks(GunaDataGridView bookView)
        {
            conn = myConnections.GetConnections();
            conn.Open();
            SqlCommand cmd = new SqlCommand("readallbook", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataTable dTable = new DataTable();
            reader.Fill(dTable);
            bookView.DataSource = dTable;
            cmd.ExecuteNonQuery();
            conn.Close();
        }




        public static void registerBooks(string name, int cid, int aid, int pid , string type , int pages , string edition)
        {
            try
            {
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand insertCommand = new SqlCommand("registerbook", conn);
                insertCommand.CommandType = CommandType.StoredProcedure;

                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@cid", cid);
                insertCommand.Parameters.AddWithValue("@aid", aid);
                insertCommand.Parameters.AddWithValue("@pid", pid);
                insertCommand.Parameters.AddWithValue("@type", type);
                insertCommand.Parameters.AddWithValue("@pages", pages);
                insertCommand.Parameters.AddWithValue("@edition", edition);

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Successfully Registered Book ✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("sorry you have an error. \nplease try again.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void updateBooks(string name, int cid, int aid, int pid , string type , int pages , string edition,int updateid)
        {
            try
            {
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand insertCommand = new SqlCommand("updatebook", conn);
                insertCommand.CommandType = CommandType.StoredProcedure;

                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@cid", cid);
                insertCommand.Parameters.AddWithValue("@aid", aid);
                insertCommand.Parameters.AddWithValue("@pid", pid);
                insertCommand.Parameters.AddWithValue("@type", type);
                insertCommand.Parameters.AddWithValue("@pages", pages);
                insertCommand.Parameters.AddWithValue("@edition", edition);
                insertCommand.Parameters.AddWithValue("@updateid", updateid);

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Successfully Updated Book ✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("sorry you have an error. \nplease try again.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        public static void deleteBook(int id)
        {
            try
            {
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand deleteCommand = new SqlCommand("deletebook", conn);
                deleteCommand.CommandType = CommandType.StoredProcedure;
                deleteCommand.Parameters.AddWithValue("@id", id);
                deleteCommand.ExecuteNonQuery();
                MessageBox.Show("Successfully Deteled Book.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Sorry You Have An Error. \nPlease Try Again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public static void CountBook(Label count)
        {
            conn = myConnections.GetConnections();
            conn.Open();

            SqlCommand countCommand = new SqlCommand("countbook", conn);
            countCommand.CommandType = CommandType.StoredProcedure;
            int countText = (int)countCommand.ExecuteScalar();
            count.Text = countText.ToString();

            conn.Close();
        }



    }
}
