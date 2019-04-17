using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotechDB.DataAccessLayer;
using BibliotechDB.Model;


namespace BibliotechDB.View
{
    public partial class UpdatePwView : Form
    {
        private string thisUser;

        public UpdatePwView(string id)
        {
            InitializeComponent();
            thisUser = id;
        }

        private void btn_newpwcancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_newpwsend_Click(object sender, EventArgs e)
        {
            BibliotechDAL bd = new BibliotechDAL();
            bd.ChangePassword(thisUser,txt_newpw.Text);
        }
    }
}
