using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseTwo
{
    public partial class Form1 : Form
    {
        string subString = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_data.Text = Constants.TEXT;
        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            string data = lbl_data.Text;
            
            List<string> convertedList = convert(data);
            for (int i = 0; i < convertedList.Count; i++)
            {
                //lb_raw.Add(convertedList[i].ToString());
                lb_raw.Items.Add(convertedList[i].ToString());
                //tb_words.AppendText(convertedList[i].ToString());
                //tb_words.Text += convertedList[i].ToString();
            }
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {

        }

        private void btn_unique_Click(object sender, EventArgs e)
        {

        }

        private List<string> convert(string strDefault)
        {
            var convertedList = new List<string>();
            for (int i = 0; i < strDefault.Length; i++)
            {
                try
                {
                    if (strDefault.Substring(i, 1) != " ") 
                    {
                       // if (strDefault.Substring(i, 1) != "-" || strDefault.Substring(i, 1) != "\\") break;
                        subString += strDefault.Substring(i, 1);
                    }
                    else
                    {
                        convertedList.Add(subString);
                        subString = "";
                    }
                }
                catch (System.FormatException)
                {
                    System.Diagnostics.Debug.WriteLine(" \nThe list is not in the correct format");
                    DialogResult res = MessageBox.Show("Please make sure the data is in the correct format!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        break;
                    }

                }
            }
            return convertedList;
        }

        private List<int> sortList(List<int> listData)
        {
            var sortedDataList = new List<int>();
            int temp = 0;
            for (int write = 0; write < listData.Count; write++)
            {
                for (int sort = 0; sort < listData.Count - write - 1; sort++)
                {
                    if (listData[sort] > listData[sort + 1])
                    {
                        temp = listData[sort + 1];
                        listData[sort + 1] = listData[sort];
                        listData[sort] = temp;
                    }
                }
            }
            for (int i = 0; i < listData.Count; i++)
            {
                sortedDataList.Add(listData[i]);
            }
            return sortedDataList;
        }
    }
}
