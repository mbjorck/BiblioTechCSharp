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

namespace BibliotechDB.View
{
    public partial class EditAuthorView : Form
    {
        private int thisAuthor;
        public EditAuthorView(int id)
        {
            InitializeComponent();
            thisAuthor = id;
            BibliotechDAL bd = new BibliotechDAL();
            txt_aName.Text = bd.ReturnAuthorName(id);
        }



        private void btn_Save_Click(object sender, EventArgs e)
        {
            BibliotechDAL bd = new BibliotechDAL();
            bd.EditAuthor(thisAuthor, txt_aName.Text);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
