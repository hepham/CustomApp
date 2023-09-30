using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomApp.Forms
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void dimensionApply_Click(object sender, EventArgs e)
        {
            try
            {
                int width = int.Parse(widthTextBox.Text);
                int height = int.Parse(heightTextBox.Text);
                if (width > 0 && height > 0)
                {
                    widthLabel.Text = width.ToString();
                    heightLabel.Text = height.ToString();
                }
            }
            catch (Exception) {
                MessageBox.Show("Vui lòng nhập số");
            }
            
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
