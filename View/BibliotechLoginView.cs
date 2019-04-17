using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using BibliotechDB.DataAccessLayer;
using BibliotechDB.Controller;
using BibliotechDB.Model;

namespace BibliotechDB.View
{
    public partial class BibliotechLoginView : Form
    {
        public BibliotechLoginView() //Initiera form
        {
            InitializeComponent();
        }

        private void DbView_Load(object sender, System.EventArgs e)
        {


        }
       




        private void btn_Login_Click(object sender, EventArgs e)
        {

            if (txt_UserName.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Skriv in både användarnamn och lösenord");
                return;
            }
            try
            {
                BibliotechController bc = new BibliotechController();
                User u = bc.DoLogin(txt_UserName.Text, txt_Password.Text);
                if (u != null)
                {
                    if (u.UserPassword == txt_Password.Text)
                    {
                        if (u.Admin == "TRUE")
                        {
                            BibliotechAdminView aForm = new BibliotechAdminView(txt_UserName.Text);
                            aForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            BibliotechCustView fm = new BibliotechCustView(txt_UserName.Text);
                            fm.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fel personnummer eller lösenord");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
