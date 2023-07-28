using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace CustomApp.Forms
{
    public partial class FormTool : Form
    {
        int index = -1;
        Dictionary<string,string> dataHashMap = new Dictionary<string,string>();
        public FormTool()
        {
            InitializeComponent();
            int i = 0;
            foreach(User user in UserList.Instance.Users)
            {
                i++;
                dataHashMap[user.Name] = user.Server;
                if (user.Status)
                {
                    dataGridView.Rows.Add(new object[] { imageUsersList.Images[0], i, user.Name, user.Server, imageCheckList.Images[1]});
                }
                else
                {
                    dataGridView.Rows.Add(new object[] { imageUsersList.Images[0], i, user.Name, user.Server, imageCheckList.Images[0] });
                }
                
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username=txUsername.Texts;
            string password=txtPassword.Texts;
            String server = comboBoxServer.Texts;         
            if(comboBoxServer.SelectedItem != null) {
                server = comboBoxServer.SelectedItem.ToString();
            }
           
            if(username != null && password != null)
            {
                User user = new User(username, password,server,false);
                
                if (dataHashMap.ContainsKey(username))
                {
                    string currentServer = dataHashMap[username];
                    if (currentServer.Equals(server))
                    {
                        MessageBox.Show("Tài khoản đã tồn tại.");
                        return;
                    }
                }
                UserList.Instance.Users.Add(user);
                dataGridView.Rows.Add(new object[] { imageUsersList.Images[0], UserList.Instance.Users.Count, user.Name, user.Server, imageCheckList.Images[0] });
                saveFile();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu chưa có");
            }
            index = -1;
            
        }
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if the clicked cell is within the data grid
            {
                txUsername.Texts = UserList.Instance.Users[e.RowIndex].Name;
                
                txtPassword.Texts = UserList.Instance.Users[e.RowIndex].Password;
                comboBoxServer.Texts = UserList.Instance.Users[e.RowIndex].Server;
                txUsername.isPlaceholder = false;
                txtPassword.isPlaceholder = false;
                index = e.RowIndex;
                //MessageBox.Show(e.RowIndex.ToString());
            }
        }

        private void saveFile()
        {
            List<string>userStringList=new List<string>();
            foreach(User user in UserList.Instance.Users)
            {
                string userString=user.ToString();
                userStringList.Add(userString);
            }
            string filePath = "C:/Users/phamh/OneDrive/Documents/Project/RestaurantManager/CustomApp/CustomApp/CustomApp/data.txt";
            File.WriteAllLines(filePath, userStringList);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                UserList.Instance.Users[index].Name=txUsername.Texts;
                UserList.Instance.Users[index].Password = txtPassword.Texts;
                UserList.Instance.Users[index].Server = comboBoxServer.Texts;
                dataGridView.Rows[index].Cells[2].Value=txUsername.Texts;
                dataGridView.Rows[index].Cells[3].Value = comboBoxServer.Texts;
                saveFile();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(index != -1)
            {
                UserList.Instance.Users.RemoveAt(index);
                dataGridView.Rows.RemoveAt(index);
                index = -1;
                saveFile();
            }
            
        }
    }
}
