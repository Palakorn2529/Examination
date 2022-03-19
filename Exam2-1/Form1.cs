using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Exam2_1
{
    public partial class Form1 : Form
    {
        string[] dataArray = new string[5];
        public Form1()
        {
            InitializeComponent();
        }

        int sequence = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            ResultGroup.Visible = false;
            lbSequence.Text = "";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
           
                if (String.IsNullOrEmpty(inputText.Text))
                {
                    MessageBox.Show("ท่านไม่ได้ทำการกรอกข้อมูล", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {     
                    dataArray[sequence - 1] = inputText.Text;
                    inputText.Text = "";
                    lbSequence.Text = "ครั้งที่"+(sequence+1);
                    sequence++;
            }
           
            if (sequence > 5)
            {
                lbSequence.Text = "ครบแล้ว";
                saveBtn.Visible = false;
                sequence = 1;
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            saveBtn.Visible = true;
           for(int i = 0; i<5; i++)
            {
                dataArray[i] = "";
            }
        }

        private void seachBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(searchText.Text))
            {
                string str = searchText.Text;
                List<string> position = new List<string>();
               for(int i = 0; i < dataArray.Length; i++)
                {
                    if (dataArray[i].Contains(str))
                    {
                        position.Add((i + 1).ToString());
                    }
                }
                showResult(position);
            }
            else
            {
                MessageBox.Show("กรุณาใส่ข้อมูลที่ต้องการค้นหา", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void showResult(List<string> position)
        {
            ResultGroup.Visible = true;
            string resultStr = "พบอยู่ตำแหน่งที่ ";
            if (position.Count > 0)
            {
                foreach(var item  in position)
                {
                    resultStr += item + ",";
                }
            }
            else
            {
                resultStr = "ไม่พบตำแหน่งที่ท่านค้นหา ";
            }
            lbResult.Text = resultStr.Substring(0,resultStr.Length-1);
        }

        private void inputText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13) { 
            saveBtn_Click(sender, e);
            }
        }

        private void searchText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                seachBtn_Click(sender, e);
            }
        }
    }
}
