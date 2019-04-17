using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BibliotechDB.DataAccessLayer
{
    public class BibliotechConnector
    {
        // Connection to the Bibliotech database
        private static readonly string URL = "Data Source =DESKTOP-7CTQSC5; Initial Catalog = Bibliotech; Integrated Security = True";

        public SqlConnection Connect()
        {
            try
            {
                SqlConnection myConnection = new SqlConnection(URL);
                myConnection.Open();
                return myConnection;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return null;
        }
    }
}
