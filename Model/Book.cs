using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotechDB.Model
{
    class Book
    {
        private string title;
        private int author;
        private string isbn;
        private int copyNumber;

        public int CopyNumber { get => copyNumber; set => copyNumber = value; }
        public string Title { get => title; set => title = value; }
        public int Author { get => author; set => author = value; }
        public string Isbn { get => isbn; set => isbn = value; }

        public Book(string title, int author, string isbn, int copyNumber)
        {
            this.Isbn = isbn;
            this.Title = title;
            this.Author = author;
            this.CopyNumber = copyNumber;
        }
    }
}
