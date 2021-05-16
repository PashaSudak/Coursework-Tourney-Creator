using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourney_Creator
{
    public class User
    {
        public int id { get; set; }
        private string login, pass;
        public int rights { get; set; }

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
            get { return rights; }
            set { rights = value; }
        }


        public User () {}

        public User(string login, string pass)
        {
            this.login = login;
            this.pass = pass;
            rights = 0;
        }
    }
}
