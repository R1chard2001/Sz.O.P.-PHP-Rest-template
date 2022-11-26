using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szop_php_rest_template
{
    public class User
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }


        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
