using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szop_php_rest_template
{
    public class Response
    {
        private int error;

        public int Error
        {
            get { return error; }
            set { error = value; }
        }


        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }


        private List<User> users;

        public List<User> Users
        {
            get { return users; }
            set { users = value; }
        }

    }
}
