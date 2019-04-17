using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotechDB.Model
{
    class Author
    {
        private int authorId;
        private string authorName;

        public string AuthorName { get => authorName; set => authorName = value; }
        public int AuthorId { get => authorId; set => authorId = value; }

        public Author(int authorId, string authorName)
        {
            this.AuthorId = authorId;
            this.AuthorName = authorName;
        }
    }
}
