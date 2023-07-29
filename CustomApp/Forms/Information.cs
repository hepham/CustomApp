using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomApp.Forms
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
            richTextBox1.Text = "Sản phẩm được làm bởi DungPham Team.\n Nếu bạn có nhu cầu muốn sử dụng các tool khác của DungPham Team\n Truy cập vào link https://dungpham.com.vn/ để có thông tin chi tiết\nCopyright DungPham Team-2023.\nAll rights reserved ";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.LinkClicked += richTextBox1_LinkClicked;
            CenterTextInRichTextBox(richTextBox1);
        }
        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            // Open the link in the default web browser
            Process.Start(e.LinkText);
        }
        private void CenterTextInRichTextBox(RichTextBox richTextBox)
        {
            int linesCount = richTextBox1.Lines.Length;
            int lineHeight = richTextBox1.GetPositionFromCharIndex(richTextBox.GetFirstCharIndexFromLine(1)).Y;
            int totalPadding = richTextBox1.Height - linesCount * lineHeight;

            // Đảm bảo padding không âm
            if (totalPadding > 0)
            {
                int topPadding = totalPadding / 2;
                richTextBox.Padding = new Padding(0, topPadding, 0, 0);
            }
        }
    }
}
