using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotechDB.Model
{
    class User
    {
        private string userId;
        private string userFirstName;
        private string userLastName;
        private string userPassword;
        private string admin;
        private int debt;

        public string UserId { get => userId; set => userId = value; }
        public string UserFirstName { get => userFirstName; set => userFirstName = value; }
        public string UserLastName { get => userLastName; set => userLastName = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public string Admin { get => admin; set => admin = value; }
        public int Debt { get => debt; set => debt = value; }

        public User(string userId, string firstName, string lastName, int debt,string password, string admin)
        {
            this.UserId = userId;
            this.UserFirstName = firstName;
            this.UserLastName = lastName;
            this.UserPassword = password;
            this.Debt = debt;
            this.Admin = admin;

        }
    }
}
