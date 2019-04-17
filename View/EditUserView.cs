using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotechDB.Controller;
using BibliotechDB.DataAccessLayer;
using BibliotechDB.Model;

namespace BibliotechDB.View
{
    
    public partial class EditUserView : Form
    {
        private string thisUser;
        public EditUserView(string id)
        {
            InitializeComponent();
            thisUser = id;
            BibliotechController bc=new BibliotechController();
            User u = bc.UserInfo(id);
            txt_editfname.Text = u.UserFirstName;
            txt_editlname.Text = u.UserLastName;
            txt_editdebt.Text = u.Debt.ToString();
            txt_editpw.Text = u.UserPassword;
            cmb_admin.Text = u.Admin;
        }

  

        private void btn_Update_Click(object sender, EventArgs e)
        {
            BibliotechDAL bd = new BibliotechDAL();
            User u2 = new User(thisUser, txt_editfname.Text, txt_editlname.Text, Convert.ToInt32(txt_editdebt.Text),
                txt_editpw.Text, cmb_admin.Text);
            bd.EditUser(u2);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
