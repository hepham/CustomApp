using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace CustomApp
{
    public class UserList
    {
        private List<User> users;

        private static volatile UserList instance;

        public List<User> Users { get => users; set => users = value; }
        public static UserList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserList();
                }
                return instance;
            }
        }
        private UserList()
        {
            users = new List<User>();
            string filePath = "../../data/data.txt";

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        User newUser=new User(parts[0], parts[1], parts[2],false);
                       users.Add(newUser);
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("không tìm thấy tệp data");
            }

        }
    }
}
