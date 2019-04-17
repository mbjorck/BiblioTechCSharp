using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotechDB.Model
{
    class Loan
    {
        private string bookIsbn;
        private int bookCopy;
        private string userId;
        private DateTime loanDate;
        private DateTime expiryDate;

       public Loan(string bookIsbn, int bookCopy,string userId)
        {
            this.bookIsbn = bookIsbn;
            this.bookCopy = bookCopy;
            this.userId = userId;
            this.loanDate = DateTime.Today;
            this.expiryDate = DateTime.Today.AddDays(14);
        }

        public DateTime LoanDate { get => loanDate; set => loanDate = value; }
        public string UserId { get => userId; set => userId = value; }
        public int BookCopy { get => bookCopy; set => bookCopy = value; }
        public DateTime ExpiryDate { get => expiryDate; set => expiryDate = value; }
        public string BookIsbn { get => bookIsbn; set => bookIsbn = value; }
    }
}
