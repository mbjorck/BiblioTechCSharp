using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using BibliotechDB.Model;

namespace BibliotechDB.DataAccessLayer
{
    class BibliotechDAL
    {
        public void AddAuthor(int authorId, string authorName) //Lägg till författare
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd =
                              new SqlCommand("addAuthor", conn)
                              {
                                  CommandType = CommandType.StoredProcedure
                              };
            cmd.Parameters.AddWithValue("@AuthorID", authorId);
            cmd.Parameters.AddWithValue("@AuthorName", authorName);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataSet Login(string userId, string userPassword) //Kontrollera loginuppgifter
        {
            
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd =
                new SqlCommand(
                    "login", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
            cmd.Parameters.AddWithValue("@UserID", userId);
            cmd.Parameters.AddWithValue("@UserPassword", userPassword);

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);

  

            DataSet ds = new DataSet();
            adapt.Fill(ds);
            return ds;
        }

        public DataTable GetUserInfo(string userId) //Hämta info om användare
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd = new SqlCommand("userID", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@UserID", userId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }


        
        public DataTable GetOutstandingLoans(string userId) //Hämta användares aktiva lån
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd =
                new SqlCommand("getOutstandingLoans", conn)
                {
                    CommandType = CommandType.StoredProcedure
                }
                ;

            cmd.Parameters.AddWithValue("@UserID", userId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable SearchTitle(string searchTitle) //Hämta lista med böcker utifrån Titel
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd =
                new SqlCommand(
                    "searchTitle", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
            cmd.Parameters.AddWithValue("@searchTitle", searchTitle);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable SearchIsbn(string searchIsbn) //Hämta lista med böcker utifrån ISBN
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd =
                new SqlCommand("searchIsbn", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
            cmd.Parameters.AddWithValue("@searchIsbn", searchIsbn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable SearchAuthor(string searchAuthor) //Hämta lista med böcker utifrån Författare
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd =
                new SqlCommand(
                    "selectAuthor", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
            cmd.Parameters.AddWithValue("@searchAuthor", searchAuthor);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public void AddNewUser(User u) //Lägg till ny användare
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd =
                new SqlCommand(
                    "addNewUser", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
            cmd.Parameters.AddWithValue("@UserFirstName", u.UserFirstName);
            cmd.Parameters.AddWithValue("@UserLastName", u.UserLastName);
            cmd.Parameters.AddWithValue("@UserDebt", u.Debt);
            cmd.Parameters.AddWithValue("@UserPassword", u.UserPassword);
            cmd.Parameters.AddWithValue("@UserAdmin", u.Admin);
            cmd.Parameters.AddWithValue("@UserID", u.UserId);

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Användaren är registrerad");
        }

        public void AddNewBook(Book b) //Lägg till ny bok
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd =
                new SqlCommand(
                    "addNewBook", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
            cmd.Parameters.AddWithValue("@Title", b.Title);
            cmd.Parameters.AddWithValue("@AuthorID", b.Author);
            cmd.Parameters.AddWithValue("@ISBN", b.Isbn);
            cmd.Parameters.AddWithValue("@CopyNbr", b.CopyNumber);

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Boken är registrerad");
        }

        public DataTable AllAuthors() //Returnera alla författare
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

          

            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd =
                new SqlCommand("allAuthors", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(dt);
            conn.Close();

            sw.Stop();

            System.Console.WriteLine("Elapsed={0}", sw.Elapsed);
            return dt;  

        }

        public DataTable AllBooks() //Returnera alla böcker
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd =
                new SqlCommand("allBooks", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable AllUsers() //Returnera alla användare
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd =
                new SqlCommand("allUsers", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable AllLoans() //Returnera alla lån
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd =
                new SqlCommand("allLoans", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable AllLoanHistory() //Returnera all lånhistorik
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd =
                new SqlCommand("allLoanHistory", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public void AddNewAuthor(Author a) //Lägg till ny författare
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd =
                new SqlCommand("addNewAuthor", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
            cmd.Parameters.AddWithValue("@AuthorID", a.AuthorId);
            cmd.Parameters.AddWithValue("@AuthorName", a.AuthorName);

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Författaren är registrerad");
        }

        public int GetNextAuthorId() //Hämta nästa författarID
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd = new SqlCommand("getNextAuthorId", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            foreach (DataRow row in dt.Rows)
            {
                int id = (int)row["maxID"];
                return id + 1;
            }

            return 0;
        }

        public int GetCopyNbr(string isbn) //Hämta books exemplarsnummer
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd =
                new SqlCommand("getCopyNbr", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
            cmd.Parameters.AddWithValue("@ISBN", isbn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            foreach (DataRow row in dt.Rows)
            {
                int count = (int)row["nrCopy"];
                return count + 1;
            }

            return 0;
        }

        public void DeleteBook(string isbn, int copyNbr) //Radera en bok
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd = new SqlCommand("deleteBook", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@ISBN", isbn);
            cmd.Parameters.AddWithValue("@CopyNbr", copyNbr);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Boken är raderad");
            conn.Close();
        }

        public void DeleteAuthor(int authorID) //Radera en författare
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd = new SqlCommand("deleteAuthor", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@AuthorID", authorID);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Författaren är borttagen");
            conn.Close();
        }

        public void DeleteUser(string userID) //Radera en användare
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd = new SqlCommand("deleteUser", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@UserID", userID);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Användaren är borttagen");
            conn.Close();
        }

        public int AuthorNbrOfBooks(int authorID) //Returnera antal böcker som en författare skrivit
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd = new SqlCommand("authorNbrOfLoans", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@AuthorID", authorID);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            foreach (DataRow row in dt.Rows)
            {
                int count = (int)row["nrBooks"];
                return count;
            }

            return 0;
        }

        public int UserNbrOfLoans(string userID) //Returnera antal lån som en användare har
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd = new SqlCommand("userNbrOfLoans", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@UserID", userID);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            foreach (DataRow row in dt.Rows)
            {
                int count = (int)row["nrLoans"];
                return count;
            }

            return 0;
        }
        public int CheckAvailability(string bookISBN, int bookCopy) //Kontrollerar om boken är utlånad
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd = new SqlCommand("checkAvailability", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@BookISBN", bookISBN);
            cmd.Parameters.AddWithValue("@BookCopy", bookCopy);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            foreach (DataRow row in dt.Rows)
            {
                int count = (int)row["nrLoans"];
                return count;
            }

            return 0;
        }

        public void EndLoan(string bookISNB, int bookCopy) //Avsluta ett lån
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd = new SqlCommand("endLoan", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@ISBN", bookISNB);
            cmd.Parameters.AddWithValue("@CopyNbr", bookCopy);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Lånet är avslutat");
            conn.Close();
        }

        public void AddNewLoan(Loan loan) //Registrera ett nytt Lån
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd =
                new SqlCommand("addNewLoan", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
            cmd.Parameters.AddWithValue("@BookISBN", loan.BookIsbn);
            cmd.Parameters.AddWithValue("@BookCopy", loan.BookCopy);
            cmd.Parameters.AddWithValue("@UserID", loan.UserId);
            cmd.Parameters.AddWithValue("@LoanDate", loan.LoanDate);
            cmd.Parameters.AddWithValue("@ExpiryDate", loan.ExpiryDate);

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Lånet är registrerat");
        }

        public string ReturnAuthorName(int authorId) //Returnera författarens namn
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd =
                new SqlCommand("returnAuthorName", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
            cmd.Parameters.AddWithValue("@AuthorID", authorId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            foreach (DataRow row in dt.Rows)
            {
                string name = row["AuthorName"].ToString();
                return name;
            }

            return null;
        }

        public void EditAuthor(int authorId, string authorName) //Uppdatera en författare                                                               
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd = new SqlCommand("editAuthor", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@AuthorName", authorName);
            cmd.Parameters.AddWithValue("@AuthorId", authorId);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Namnet är ändrat");
            conn.Close();
        }

        public void EditUser(User u) //Uppdatera en användare
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();
            SqlCommand cmd = new SqlCommand("editUser", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@UserFirstName", u.UserFirstName);
            cmd.Parameters.AddWithValue("@UserLastName", u.UserLastName);
            cmd.Parameters.AddWithValue("@UserDebt", u.Debt);
            cmd.Parameters.AddWithValue("@UserPassword", u.UserPassword);
            cmd.Parameters.AddWithValue("@UserAdmin", u.Admin);
            cmd.Parameters.AddWithValue("@UserID", u.UserId);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Uppgifterna är ändrade");
            conn.Close();
        }

        public void ChangePassword(string id, string newPw) //Byt lösenord
        {
            BibliotechConnector dbConn = new BibliotechConnector();
            SqlConnection conn = dbConn.Connect();

            SqlCommand cmd = new SqlCommand("changePassword", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@UserID", id);
            cmd.Parameters.AddWithValue("@UserPassword", newPw);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Lösenordet är ändrat");
            conn.Close();
        }
    }
}