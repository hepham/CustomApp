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
        Dictionary<string,User> dataHashMap = new Dictionary<string,User>();
        public FormTool()
        {
            InitializeComponent();
            string currentPath = Application.StartupPath;
            dataGridView.MouseWheel += dataGridView1_MouseWheel;


            int i = 0;
            foreach(User user in UserList.Instance.Users)
            {
                i++;
                string key=user.Name+user.Server;
                dataHashMap[key] = user;
                if (user.Note==null)
                {
                    dataGridView.Rows.Add(new object[] { imageUsersList.Images[0], i, user.Name, user.Server});
                }
                else
                {
                    dataGridView.Rows.Add(new object[] { imageUsersList.Images[0], i, user.Name, user.Server, user.Note });
                }
                
                
            }
            disableScrollBar();
            
        }
        private void disableScrollBar()
        {
            if (UserList.Instance.Users.Count() <= 7)
            {
                scrollBar.Visible=false;
            }
            else
            {
                scrollBar.Refresh();
                scrollBar.Visible = true;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username=txUsername.Texts;
            string password=txtPassword.Texts;
            string server = comboBoxServer.Text;
            string note = noteTextBox.Texts;
            
            if (comboBoxServer.SelectedItem != null) {
                server = comboBoxServer.SelectedItem.ToString();
            }
           
            if(username != null && password != null)
            {
                User user = new User(username, password,server,note);
                string key = username + server;
                if (dataHashMap.ContainsKey(key))
                {
                    User currentUser = dataHashMap[key];
                    if (currentUser.Server.Equals(server))
                    {
                        MessageBox.Show("Tài khoản đã tồn tại.");
                        return;
                    }
                }
                UserList.Instance.Users.Add(user);
                dataGridView.Rows.Add(new object[] { imageUsersList.Images[0], UserList.Instance.Users.Count, user.Name, user.Server,user.Note });
                //MessageBox.Show(UserList.Instance.Users.Count().ToString());
                disableScrollBar();
                dataHashMap.Add(key, user);
                saveFile();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin tài khoản và mật khẩu");
            }
            index = -1;
            
        }
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if the clicked cell is within the data grid
            {
                txUsername.Texts = UserList.Instance.Users[e.RowIndex].Name;
                txtPassword.Texts = UserList.Instance.Users[e.RowIndex].Password;
                comboBoxServer.Text = UserList.Instance.Users[e.RowIndex].Server;
                noteTextBox.Texts= UserList.Instance.Users[e.RowIndex].Note;        
                txUsername.isPlaceholder = false;
                txtPassword.isPlaceholder = false;
                noteTextBox.isPlaceholder = false;
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
            string filePath ="data.txt";

            File.WriteAllLines(filePath, userStringList);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                UserList.Instance.Users[index].Name=txUsername.Texts;
                UserList.Instance.Users[index].Password = txtPassword.Texts;
                UserList.Instance.Users[index].Server = comboBoxServer.Text;
                UserList.Instance.Users[index].Note = noteTextBox.Texts;
                dataGridView.Rows[index].Cells[2].Value=txUsername.Texts;
                dataGridView.Rows[index].Cells[3].Value = comboBoxServer.Text;
                dataGridView.Rows[index].Cells[4].Value = noteTextBox.Texts;
                saveFile();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            List<int> selectedRowIndices = new List<int>();
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    selectedRowIndices.Add(row.Index);
                }
            }

            selectedRowIndices.Sort();
            selectedRowIndices.Reverse();
            disableScrollBar();
            foreach (int index in selectedRowIndices)
            {
                // Remove the row from the DataGridView
                dataGridView.Rows.RemoveAt(index);
                UserList.Instance.Users.RemoveAt(index);
                saveFile();
            }
        }

        private bool isHiddenPassword = true;

        private void pictureHiddenPassword_Click(object sender, EventArgs e)
        {
            isHiddenPassword = !isHiddenPassword;
            if (isHiddenPassword)
            {
                pictureHiddenPassword.Image = CustomApp.Properties.Resources.view;
                txtPassword.PasswordChar = false;
            }
            else
            {
                pictureHiddenPassword.Image = CustomApp.Properties.Resources._private;
                txtPassword.PasswordChar = true;
            }
        }

        private void customComboBoxTest1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxServer_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuVSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs e)
        {
            dataGridView.FirstDisplayedScrollingRowIndex = dataGridView.SelectedRows[e.Value].Index;
        }

        private void bunifuVScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            try
            {
                dataGridView.FirstDisplayedScrollingRowIndex = dataGridView.Rows[e.Value].Index;
            }
            catch (Exception){ }
            
        }

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                scrollBar.Maximum = dataGridView.RowCount - dataGridView.DisplayedRowCount(false);
            }
            catch(Exception) { }
          
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                scrollBar.Maximum = dataGridView.RowCount - dataGridView.DisplayedRowCount(false);
            }
            catch (Exception) { }

        }
        private void dataGridView1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0) // Scrolling up
            {
                if (dataGridView.FirstDisplayedScrollingRowIndex > 0)
                {
                    dataGridView.FirstDisplayedScrollingRowIndex--;
                     scrollBar.Value= dataGridView.FirstDisplayedScrollingRowIndex;
                }
            }
            else // Scrolling down
            {
                if (dataGridView.FirstDisplayedScrollingRowIndex < dataGridView.RowCount - 1)
                {
                    dataGridView.FirstDisplayedScrollingRowIndex++;
                    scrollBar.Value = dataGridView.FirstDisplayedScrollingRowIndex;
                }
            }
        }

        private void upButton_Click(object sender, KeyEventArgs e)
        {
            // Scroll the content up
            scrollBar.Value = dataGridView.FirstDisplayedScrollingRowIndex;
        }

        private void downButton_Click(object sender, KeyEventArgs e)
        {
            // Scroll the content down
            scrollBar.Value = dataGridView.FirstDisplayedScrollingRowIndex;
        }
    }
}
