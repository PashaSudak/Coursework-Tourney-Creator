using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourney_Creator
{
    class User
    {
        public int id { get; set; }
        private string login, pass;
        public int isAdmin;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public int IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }


        public User () {}

        public User(string login, string pass)
        {
            this.login = login;
            this.pass = pass;
            isAdmin = 0;
        }
    }
}
