using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Management;//添加引用
using System.IO;
namespace myEnglish
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
        public class test
        {
            //将List转换为TXT文件
            public void WriteListToTextFile(List<string> list, string txtFile)
            {
                //创建一个文件流，用以写入或者创建一个StreamWriter 
                FileStream fs = new FileStream(txtFile, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.Flush();
                // 使用StreamWriter来往文件中写入内容 
                sw.BaseStream.Seek(0, SeekOrigin.Begin);
                for (int i = 0; i < list.Count; i++)
                {
                    if (!string.IsNullOrEmpty(list[i].Trim()))
                        sw.WriteLine(list[i]);
                }
                //关闭此文件t 
                sw.Flush();
                sw.Close();
                fs.Close();
            }


            //读取文本文件转换为List 
            public List<string> ReadTextFileToList(string fileName)
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                List<string> list = new List<string>();
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                //使用StreamReader类来读取文件 
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                // 从数据流中读取每一行，直到文件的最后一行
                string tmp = sr.ReadLine();
                while (tmp != null)
                {
                    list.Add(tmp);
                    tmp = sr.ReadLine();
                }
                //关闭此StreamReader对象 
                sr.Close();
                fs.Close();
                return list;
            }
        }

    }