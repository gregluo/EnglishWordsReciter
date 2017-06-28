using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myEnglish;

namespace myEnglish
{          


    public partial class Form1 : Form
    {
        test mgr = new test();
        private int wordNum;
        private List<string> list;
        private string folderBase;
        public Form1()
        {
            InitializeComponent();
            wordNum = 0;
            folderBase = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            checkStartEndNum();
            showWordinUI();
        }

        private void checkStartEndNum()
        {
            List<string> list = mgr.ReadTextFileToList(folderBase + @"NewWord.txt");//记取字符串 
            int num1, num2;

            if (int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2))
            {
                if (num1 < 0 || num1 > num2 || num1 > list.Count )
                    textBox1.Text = "1";
                if (num2 > list.Count)
                    textBox2.Text = (list.Count ).ToString();
            }
            else
            {
                textBox1.Text = "1";
                textBox2.Text = (list.Count ).ToString();
            }
        }
 
        [DllImport("User32")]
        public extern static void SetCursorPos(int x, int y);
        [DllImport("User32")]
        public extern static bool GetCursorPos(ref Point lpPoint);  
  
        private void timer1_Tick(object sender, EventArgs e)
        {
            showWordinUI();
        }

        private void showWordinUI()
        {
            list = mgr.ReadTextFileToList(folderBase + @"NewWord.txt");//记取字符串 

            int startNum, endNum;
            string showWord;

            Random ran = new Random();
            if (int.TryParse(textBox1.Text, out startNum) && int.TryParse(textBox2.Text, out endNum))
            {
                if (chkRandom.Checked)
                {
                    wordNum = ran.Next(startNum-1, endNum);
                    wordNum++;
                }
                else
                {
                    wordNum++;
                    if (wordNum > endNum || wordNum > list.Count)
                        wordNum = startNum;
                    else if (wordNum < startNum )
                        wordNum = startNum;
                }
                showWord = list[wordNum-1];
                var showWordList = showWord.Split('#');
                if (showWordList.Length > 0) richTextBox1.Text = showWordList[0].Trim();
                if (showWordList.Length > 1) richTextBox2.Text = showWordList[1].Trim();

                label1.Text = wordNum.ToString();
            }

            timer2_Tick(this, null);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            checkStartEndNum();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            checkStartEndNum();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (chb_mouse.Checked)
            {
                SetCursorPos(richTextBox1.Left + this.Left - 50, this.Top + richTextBox1.Height - 50);
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            SetCursorPos(richTextBox1.Left + this.Left + 15, this.Top + richTextBox1.Height + 20);
            timer3.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            showWordinUI();
            timer1.Start();
        }

        private void btnESC_Click(object sender, EventArgs e)
        {
            list.RemoveAt(wordNum-1);
            mgr.WriteListToTextFile(list, folderBase + @"NewWord.txt"); //测试生成新的Txt文件
            wordNum--;
            showWordinUI();

            timer1.Stop();
            timer1.Start();
            if (chkAll.Checked)
                textBox2.Text = (list.Count).ToString();
        }

        private void chk_all_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.Checked)
            {
                List<string> list = mgr.ReadTextFileToList(folderBase + @"NewWord.txt");//记取字符串 
                textBox1.Text = "1";
                textBox2.Text = (list.Count ).ToString();
            }
        }
    }
}
