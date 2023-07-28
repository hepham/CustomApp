using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomApp
{
    public class User
    {
        private string name;
        private string password;
        private string server;
        private bool status;
        public string Name { get { return name; } set { name = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Server { get { return server; } set { server = value; } }

        public bool Status { get => status; set => status = value; }

        public User(string name, string password, string server, bool status)
        {
            this.name = name;
            this.password = password;
            this.server = server;
            this.status= status;
        }

        public override string ToString()
        {
            return $"{name}|{password}|{server}|{status}";
        }
    }
}
