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
        private string note;
        public string Name { get { return name; } set { name = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Server { get { return server; } set { server = value; } }
        public string Note { get { return note; } set { note = value; } }

        public User(string name, string password, string server, string note)
        {
            this.name = name;
            this.password = password;
            this.server = server;
            this.note= note;
        }

        public override string ToString()
        {
            return $"{name}|{password}|{server}|{note}";
        }
    }
}
