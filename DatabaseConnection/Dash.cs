﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnection
{
    public partial class Dash : Form
    {
        public static Label countUserLabel;
        public static Label countCategoryLabel;
        public static Label countAuthorLabel;
        public static Label countPublisherLabel;
        public static Label countBookLabel;
        public static Label countMemberLabel;
        public static Label countLendBookLabel;
        public static Label countReturnBookLabel;

        public Dash()
        {
            InitializeComponent();
            timer1.Start();
            

        }

        private void Dash_Load(object sender, EventArgs e)
        {
            userInfo usr = new userInfo();
            countUserLabel = lblDisplayUser;
            usr.CountUser(lblDisplayUser);

            countCategoryLabel = lblDisplayCategory;
            CategoryInfo.CountCategory(lblDisplayCategory);

            countAuthorLabel = lbllDisplayAuthor;
            AuthorInfo.CountAuthor(lbllDisplayAuthor);

            countPublisherLabel = lblDisplayPublisher;
            PublisherInfo.CountPublisher(lblDisplayPublisher);

            countBookLabel = lblDisplayBook;
            BookInfo.CountBook(lblDisplayBook);

            countMemberLabel = lblDisplayMember;
            MemberInfo.CountMember(lblDisplayMember);

            countLendBookLabel = lblDisplayLendBook;
            LendBookInfo.CountLendBook(lblDisplayLendBook);

            countReturnBookLabel = lblDisplayReturnBook;
            ReturnBookInfo.CountReturnBook(lblDisplayReturnBook);

            timer1.Start();

            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToShortDateString();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

      
    }
}
