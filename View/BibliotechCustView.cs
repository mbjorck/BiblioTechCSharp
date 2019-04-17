using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BibliotechDB.DataAccessLayer;
using BibliotechDB.Controller;
using BibliotechDB.Model;

namespace BibliotechDB.View
{
    public partial class BibliotechCustView : Form
    {
        private string thisUser;
        private User us;

        public BibliotechCustView(string userId)
        {
            InitializeComponent();
            thisUser = userId;
            BibliotechDAL dbUser = new BibliotechDAL();

            DataTable dt = dbUser.GetUserInfo(userId);
            foreach (DataRow row in dt.Rows)
            {
                string id = row["UserId"].ToString();
                string fname = row["UserFirstName"].ToString();
                string lname = row["UserLastName"].ToString();
                string passw = row["UserPassword"].ToString();
                string admin = row["UserAdmin"].ToString();
                int debt = (int) row["UserDebt"];
                lbl_username.Text = fname + " " + lname;
                us = new User(id, fname, lname, debt, passw, admin);
                lbl_username.Text = us.UserFirstName + " " + us.UserLastName;
                if (us.Debt > 0)
                {
                    lbl_debt.Text = "OBS! Du har en skuld på " + us.Debt + " kr!";
                }
            }

            ShowLoans();
        }

       

        private void btn_search_Click(object sender, EventArgs e) //Klicka på sökknappen
        {
            BibliotechController bc = new BibliotechController();

            if (txt_title.Text.Length > 0)
            {
                BibliotechDAL bd = new BibliotechDAL();
                DataTable d = bd.SearchTitle(txt_title.Text);
                DrawBookResults(d);
            }
            else if (txt_isbn.Text.Length > 0)
            {

                BibliotechDAL bd = new BibliotechDAL();
                DataTable d = bd.SearchIsbn(txt_isbn.Text);
                DrawBookResults(d);
            }
            else if (txt_author.Text.Length > 0)
            {
                BibliotechDAL bd = new BibliotechDAL();
                DataTable d = bd.SearchAuthor(txt_author.Text);
                DrawBookResults(d);
            }
            else
            {
                MessageBox.Show("Fyll i ett av sökfälten");
            }
        }

        private void ShowLoans() //Visa användarens lån
        {
            BibliotechDAL dbUser = new BibliotechDAL();
            DataTable dtLoans = dbUser.GetOutstandingLoans(us.UserId);
            grid_results.Columns.Clear();
            grid_results.DataSource = dtLoans;
            btn_userreturn.Visible = true;
            btn_userloan.Visible = false;
            grid_results.Show();
        }

        private void DrawBookResults(DataTable dt) // Fyll grid_view med böcker efter sök
        {
            BibliotechDAL bd = new BibliotechDAL();

            grid_results.Columns.Clear();
            grid_results.DataSource = dt;
            grid_results.Columns["CopyNbr"].HeaderText = "Exemplar nr";
            grid_results.Columns["Title"].HeaderText = "Titel";
            grid_results.Columns["AuthorName"].HeaderText = "Författare";
            grid_results.Columns["AuthorID"].Visible = false;
            grid_results.Columns["AuthorID1"].Visible = false;
            grid_results.Columns["BookISBN"].Visible = false;
            grid_results.Columns["BookCopy"].Visible = false;
            grid_results.Columns["UserID"].Visible = false;
            grid_results.Show();
        }

        private void btn_seeallloans_Click(object sender, EventArgs e) //Klicka se mina lån
        {
            ShowLoans();
        }
        private void btn_allbooksuser_Click(object sender, EventArgs e) //Klicka se alla böcker
        {
            {
                BibliotechDAL bd = new BibliotechDAL();
                grid_results.Columns.Clear();
                grid_results.DataSource = bd.AllBooks();
                grid_results.Columns["CopyNbr"].HeaderText = "Exemplar nr";
                grid_results.Columns["Title"].HeaderText = "Titel";
                grid_results.Columns["AuthorName"].HeaderText = "Författare";
                grid_results.Columns["AuthorID"].Visible = false;
                grid_results.Columns["AuthorID1"].Visible = false;
                grid_results.Columns["BookISBN"].Visible = false;
                grid_results.Columns["BookCopy"].Visible = false;
                grid_results.Columns["UserID"].Visible = false;
                grid_results.Show();
                btn_userreturn.Visible = false;
                btn_userloan.Visible = true;
            }
        }

        private void btn_editmyinfo_Click(object sender, EventArgs e)
        {
            UpdatePwView aForm = new UpdatePwView(thisUser);
            aForm.Show();
        }

        private void btn_userloan_Click(object sender, EventArgs e)
        {
            int i = grid_results.CurrentRow.Index;
            string isbn = grid_results["Isbn", i].Value.ToString();
            int copy = (int)grid_results["CopyNbr", i].Value;
            BibliotechController bc = new BibliotechController();
            BibliotechDAL bd = new BibliotechDAL();
            int s = bd.CheckAvailability(isbn, copy);
            if (s == 1)
            {
                MessageBox.Show("Boken är utlånad");
            }
            else
            {
                bc.LoanBook(isbn, copy, us.UserId);
                ShowLoans();
            }
            
        }

        private void btn_userreturn_Click(object sender, EventArgs e)
        {
            int i = grid_results.CurrentRow.Index;
            string isbn = grid_results["BookIsbn", i].Value.ToString();
            int copy = (int)grid_results["BookCopy", i].Value;
            BibliotechDAL bd = new BibliotechDAL();
            bd.EndLoan(isbn, copy);
            ShowLoans();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            BibliotechLoginView aForm = new BibliotechLoginView();
            aForm.Show();
            Hide();
        }
    }
}