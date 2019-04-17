using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BibliotechDB.DataAccessLayer;
using BibliotechDB.Controller;
using BibliotechDB.Model;
using BibliotechDB.View;
using System.Collections;

namespace BibliotechDB.View
{
    public partial class BibliotechAdminView : Form
    {
        private string thisUser;
        private User us;
        public BibliotechAdminView(string userId)
        {
            InitializeComponent();
            BibliotechDAL dbUser = new BibliotechDAL();
            FillViewBooks();
            thisUser = userId;

            DataTable a = dbUser.AllAuthors();
            cmb_authors.DataSource = a;
            cmb_authors.DisplayMember = "AuthorName";
            cmb_authors.ValueMember = "AuthorID";

            DataTable dt = dbUser.GetUserInfo(userId);        
            foreach (DataRow row in dt.Rows)
            {
                string id = row["UserId"].ToString();
                string fname = row["UserFirstName"].ToString();
                string lname = row["UserLastName"].ToString();
                string passw = row["UserPassword"].ToString();
                string admin = row["UserAdmin"].ToString();
                int debt = (int)row["UserDebt"];
                lbl_username.Text = fname + " " + lname;
                us = new User(id,fname,lname,debt,passw,admin);
            }           
        }
        
        
        private void btn_search_Click(object sender, EventArgs e) // Click search button
        {
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

        private void btn_register_Click(object sender, EventArgs e) // Click add user
        {
            BibliotechController bc = new BibliotechController();
            
            bc.AddUser(txt_pnr.Text, txt_fname.Text, txt_lname.Text, txt_pword.Text, box_admin.Text.ToString());
        }

        


        private void btn_listallAuthors_Click(object sender, EventArgs e) // klicka Alla Författare
        {
            FillViewAuthors();
        }

        private void btn_allusers_Click(object sender, EventArgs e) // klicka Alla Användare
        {
            FillViewUsers();
        }

        private void btn_allBooks_Click(object sender, EventArgs e) // klicka Alla böcker
        {
            FillViewBooks();
        }

        private void DrawBookResults(DataTable dt) // Fyll grid_view med böcker efter sök
        { 
            grid_results_adm.Columns.Clear();
            grid_results_adm.DataSource = dt;
            grid_results_adm.Columns["CopyNbr"].HeaderText = "Exemplar nr";
            grid_results_adm.Columns["Title"].HeaderText = "Titel";
            grid_results_adm.Columns["AuthorName"].HeaderText = "Författare";
            grid_results_adm.Columns["AuthorID"].Visible = false;
            grid_results_adm.Columns["AuthorID1"].Visible = false;
            grid_results_adm.Columns["BookISBN"].Visible = false;
            grid_results_adm.Columns["BookCopy"].Visible = false;
            grid_results_adm.Columns["UserID"].Visible = false;
            grid_results_adm.Show();
        }

        private void btn_allLoans_Click(object sender, EventArgs e) // klicka Alla lån
        {
            FillViewLoans();
        }

        private void btn_loan_Click(object sender, EventArgs e)   //Button loan book
        {
            int i = grid_results_adm.CurrentRow.Index;
            string isbn = grid_results_adm["Isbn", i].Value.ToString();
            int copy = (int)grid_results_adm["CopyNbr", i].Value;
            BibliotechController bc = new BibliotechController();
            bc.LoanBook(isbn, copy, us.UserId);
            FillViewBooks();
        }

        private void FillViewBooks() //Fill view with all books
        {
            BibliotechDAL bd = new BibliotechDAL();
            grid_results_adm.Columns.Clear();
            grid_results_adm.DataSource = bd.AllBooks();
            grid_results_adm.Columns["CopyNbr"].HeaderText = "Exemplar nr";
            grid_results_adm.Columns["Title"].HeaderText = "Titel";
            grid_results_adm.Columns["AuthorName"].HeaderText = "Författare";
            grid_results_adm.Columns["AuthorID"].Visible = false;
            grid_results_adm.Columns["AuthorID1"].Visible = false;
            grid_results_adm.Columns["BookISBN"].Visible = false;
            grid_results_adm.Columns["BookCopy"].Visible = false;
            grid_results_adm.Columns["UserID"].Visible = false;
            btn_delbook.Visible = true;
            btn_deluser.Visible = false;
            btn_loan.Visible = true;
            btn_returnbook.Visible = true;
            btn_edituser.Visible = false;
            btn_deleteauthor.Visible = false;
            btn_editauthor.Visible = false;
            grid_results_adm.Show();
        }
        private void FillViewAuthors() //Fill view with all authors
        {
            BibliotechDAL bd = new BibliotechDAL();
            grid_results_adm.Columns.Clear();
            grid_results_adm.DataSource = bd.AllAuthors();
            grid_results_adm.Show();
            btn_delbook.Visible = false;
            btn_deluser.Visible = false;
            btn_loan.Visible = false;
            btn_returnbook.Visible = false;
            btn_edituser.Visible = false;
            btn_deleteauthor.Visible = true;
            btn_editauthor.Visible = true;
        }
        private void FillViewUsers() //Fill view with all users
        {
            BibliotechDAL bd = new BibliotechDAL();
            grid_results_adm.Columns.Clear();
            grid_results_adm.DataSource = bd.AllUsers();
            grid_results_adm.Show();
            btn_delbook.Visible = false;
            btn_deluser.Visible = true;
            btn_loan.Visible = false;
            btn_returnbook.Visible = false;
            btn_edituser.Visible = true;
            btn_deleteauthor.Visible = false;
            btn_editauthor.Visible = false;
        }
        private void FillViewLoans() //Fill view with all loans
        {
            BibliotechDAL bd = new BibliotechDAL();
            grid_results_adm.Columns.Clear();
            grid_results_adm.DataSource = bd.AllLoans();
            grid_results_adm.Columns["CopyNbr"].HeaderText = "Exemplar nr";
            grid_results_adm.Columns["Title"].HeaderText = "Titel";
            grid_results_adm.Columns["BookCopy"].Visible = false;
            grid_results_adm.Columns["ISBN"].Visible = false;
            grid_results_adm.Columns["AuthorID"].Visible = false;
            grid_results_adm.Show();
            btn_delbook.Visible = false;
            btn_deluser.Visible = false;
            btn_loan.Visible = false;
            btn_returnbook.Visible = true;
            btn_edituser.Visible = false;
            btn_deleteauthor.Visible = false;
            btn_editauthor.Visible = false;
        }
        private void FillViewLoanHistory() //Fill view with all loans
        {
            BibliotechDAL bd = new BibliotechDAL();
            grid_results_adm.Columns.Clear();
            grid_results_adm.DataSource = bd.AllLoanHistory();
            grid_results_adm.Columns["TimeStamp"].HeaderText = "TimeStamp";
            grid_results_adm.Columns["CopyNbr"].HeaderText = "Exemplar nr";
            grid_results_adm.Columns["Title"].HeaderText = "Titel";
            grid_results_adm.Columns["BookCopy"].Visible = false;
            grid_results_adm.Columns["ISBN"].Visible = false;
            grid_results_adm.Columns["AuthorID"].Visible = false;
            grid_results_adm.Show();
            btn_delbook.Visible = false;
            btn_deluser.Visible = false;
            btn_loan.Visible = false;
            btn_returnbook.Visible = false;
            btn_edituser.Visible = false;
            btn_deleteauthor.Visible = false;
            btn_editauthor.Visible = false;
        }

        private void btn_returnbook_Click(object sender, EventArgs e)   // Button return book
        {
            
                int i = grid_results_adm.CurrentRow.Index;
                string isbn = grid_results_adm["Isbn", i].Value.ToString();
                int copy = (int)grid_results_adm["CopyNbr", i].Value;
                BibliotechDAL bd = new BibliotechDAL();
                bd.EndLoan(isbn, copy);
                FillViewBooks();
            
        }

        private void btn_delbook_Click(object sender, EventArgs e) // Button Delete book
        {
            int i = grid_results_adm.CurrentRow.Index;
            string isbn = grid_results_adm["Isbn", i].Value.ToString();
            int copy = (int)grid_results_adm["CopyNbr", i].Value;


            BibliotechDAL bd = new BibliotechDAL();
            int s = bd.CheckAvailability(isbn, copy);
            if(s==1)
            {
                MessageBox.Show("Går ej att radera, boken är lånad");
            }
            else
            {
                bd.DeleteBook(isbn, copy);
                FillViewBooks();
            }
            
        }

        private void btn_edituser_Click(object sender, EventArgs e) // Button edit user
        {
            int i = grid_results_adm.CurrentRow.Index;
            string id = grid_results_adm["UserID", i].Value.ToString(); //TODO update
            BibliotechController bc = new BibliotechController();
            EditUserView aForm = new EditUserView(id);
            aForm.Show();
        }

        private void btn_deluser_Click(object sender, EventArgs e) //Button delete user
        {
            int i = grid_results_adm.CurrentRow.Index;
            string id = grid_results_adm["UserID", i].Value.ToString();
            BibliotechDAL bd = new BibliotechDAL();
            int s = bd.UserNbrOfLoans(id);
            if (s == 0)
            {
                bd.DeleteUser(id);
                FillViewUsers();
            }
            else
            {
                MessageBox.Show("Går ej att radera, användaren har lån");
            }
        }

        private void btn_deleteauthor_Click(object sender, EventArgs e) //Button delete author
        {
            int i = grid_results_adm.CurrentRow.Index;
            int id = (int)grid_results_adm["AuthorID", i].Value;
            BibliotechDAL bd = new BibliotechDAL();
            int s = bd.AuthorNbrOfBooks(id);
            if (s == 0)
            {
                bd.DeleteAuthor(id);
                FillViewAuthors();
            }
            else
            {
                MessageBox.Show("Går ej att radera, författaren har böcker i biblioteket");
            }
        }

        private void btn_editauthor_Click(object sender, EventArgs e) //Button edit author
        {
            int i = grid_results_adm.CurrentRow.Index;
            int id = (int)grid_results_adm["AuthorID", i].Value;
            BibliotechDAL bd = new BibliotechDAL();
            EditAuthorView aForm = new EditAuthorView(id);
            aForm.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            BibliotechLoginView aForm = new BibliotechLoginView();
            aForm.Show();
            Hide();
        }

        private void btn_AddAuthor_Click(object sender, EventArgs e)
        {
            BibliotechController bc = new BibliotechController();
            bc.AddAuthor(txt_newAuthorName.Text);
            BibliotechDAL dbUser = new BibliotechDAL();
            DataTable a = dbUser.AllAuthors();
            cmb_authors.DataSource = a;
            cmb_authors.DisplayMember = "AuthorName";
            cmb_authors.ValueMember = "AuthorID";
        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            BibliotechController bc = new BibliotechController();
            if (txt_addtitle.Text != "" && txt_addisbn.Text != "")
            {
                bc.AddBook(txt_addtitle.Text, Convert.ToInt32(cmb_authors.SelectedValue.ToString()), txt_addisbn.Text);
            }
            else
            {
                MessageBox.Show("Fyll i ISBN och boktitel");
            }
        }

        private void btn_LoanHistory_Click(object sender, EventArgs e)
        {
            FillViewLoanHistory();
        }
    }
}
