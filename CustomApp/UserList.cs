using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

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
            string filePath = "C:/Users/phamh/OneDrive/Documents/Project/RestaurantManager/CustomApp/CustomApp/CustomApp/data.txt";

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
                Console.WriteLine("File not found: " + filePath);
            }

        }
    }
}
