using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BibliotechDB.DataAccessLayer;
using BibliotechDB.Model;

namespace BibliotechDB.Controller
{
    class BibliotechController
    {
        public User DoLogin(string userName, string password) // Logga in
        {
            BibliotechDAL bd = new BibliotechDAL();
            DataTable dt = bd.GetUserInfo(userName);
            
            foreach(DataRow row in dt.Rows)
            {
                string id = row["UserID"].ToString();
                string fn = row["UserFirstName"].ToString();
                string ln = row["UserLastName"].ToString();
                int debt = (int) row["UserDebt"];
                string pw = row["UserPassword"].ToString();
                string adm = row["UserAdmin"].ToString();
                User user = new User(id, fn, ln, debt, pw, adm);
                return user;
            }
            return null;
        }
        public User UserInfo(string uId) // Hämta användaruppgifter
        {
            BibliotechDAL bd = new BibliotechDAL();
            DataTable dt = bd.GetUserInfo(uId);

            foreach (DataRow row in dt.Rows)
            {
                string id = row["UserID"].ToString();
                string fn = row["UserFirstName"].ToString();
                string ln = row["UserLastName"].ToString();
                int debt = (int)row["UserDebt"];
                string pw = row["UserPassword"].ToString();
                string adm = row["UserAdmin"].ToString();
                User user = new User(id, fn, ln, debt, pw, adm);
                return user;
            }
            return null;
        }


        public List<Book> SearchTitle(string searchTitle) // Search title
        {
            List<Book> resultList = new List<Book>();
            
            BibliotechDAL bs = new BibliotechDAL();
            DataTable res = bs.SearchTitle(searchTitle);

            foreach (DataRow row in res.Rows)
            {
                string title = row["Title"].ToString();
                string isbn = row["ISBN"].ToString();
                int author = (int) row["AuthorID"];
                int copy = (int) row["CopyNbr"];
                resultList.Add(new Book(title, author, isbn, copy));
                }
            return resultList;
        }

        
        public DataTable SearchIsbn(string searchIsbn) // Search ISBN
        {
            BibliotechDAL bs = new BibliotechDAL();
            DataTable res = bs.SearchIsbn(searchIsbn);
            return res;  
        }
        
        public DataTable SearchAuthor(string searchAuthor) // Search author by name
        {
            BibliotechDAL bs = new BibliotechDAL();
            DataTable res = bs.SearchAuthor(searchAuthor);
            return res;
        }
        
        public void AddUser(string pnr, string fName, string lName, string pword, string admin) // Add user
        {
            int debt = 0;
            User u = new User(pnr, fName, lName, debt,pword,admin);

            BibliotechDAL bd = new BibliotechDAL();
            bd.AddNewUser(u);
        }
        
        public void AddBook(string title, int author, string isbn) // Lägg till bok
        {
            BibliotechDAL bd = new BibliotechDAL();
            int copy = bd.GetCopyNbr(isbn);
            Book b = new Book(title, author, isbn, copy);
            bd.AddNewBook(b);
        }
        
        public List<Author> ListAllAuthors() // Lista alla författare 
        {
            List<Author> aList = new List<Author>();

            BibliotechDAL bs = new BibliotechDAL();
            DataTable res = bs.AllAuthors();

            foreach (DataRow row in res.Rows)
            {
                int id = (int)row["AuthorID"];
                string aName = row["AuthorName"].ToString();
                aList.Add(new Author(id, aName));
            }
            return aList;
        }
        
        public void AddAuthor(string aName) // Lägg till författare
        {
            BibliotechDAL bd = new BibliotechDAL();
            DataTable dt = bd.AllAuthors();
            int id = new BibliotechDAL().GetNextAuthorId();
            Author a =new Author(id,aName);
            bd.AddNewAuthor(a);
        }

        
        public void LoanBook(string isbn, int copy, string uId) // Låna en bok
        {
            BibliotechDAL bd = new BibliotechDAL();
            Loan loan = new Loan(isbn,copy,uId);
            if (bd.CheckAvailability(isbn, copy) == 0)
            {
                bd.AddNewLoan(loan);
            }
            else
            {
                MessageBox.Show("Boken är redan utlånad");
            }
        }

        //public void DeleteBook(string isbn, int copyNbr)
        //{
        //    BibliotechDAL bd = new BibliotechDAL();
        //    Loan loan = new Loan(isbn, copyNbr);
        //    if (bd.CheckAvailability(isbn, copyNbr) == 0)
        //    {
        //        bd.AddNewLoan(loan);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Boken är redan utlånad");
        //    }
        //}
    }
}
