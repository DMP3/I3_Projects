using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExserciseThree
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
            richTextBox1.Text = Consts.TEXT;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int broi = 0;
            listBox1.Items.Clear();
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;
            var convertedList = new List<int>();
            
            richTextBox1.SelectionBackColor = Color.White;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            convertedList = ConvertToList(richTextBox1.Text, textBox1.Text);
            watch.Stop();
            var timeMs = watch.ElapsedMilliseconds;
       
            for (int i = 0; i < convertedList.Count; i++)
            {
                broi++;
                listBox1.Items.Add(convertedList[i].ToString());
            }
            label3.Text = broi.ToString();
            label2.Text = timeMs.ToString();
            convertedList.Clear();
        }

        private List<int> ConvertToList(string text, string word)
        {
            richTextBox1.BackColor = Color.White;
            int position;
            var posList = new List<int>();
            var convertedList = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < text.Length; i++)
            {
                try
                {
                    if (text.Substring(i, 1) != " " && text.Substring(i, 1) != "(" && text.Substring(i, 1) != ")" && text.Substring(i, 1) != "-" && text.Substring(i, 1) != "/" && text.Substring(i, 1) != ":" && text.Substring(i, 1) != ";" && text.Substring(i, 1) != "," && text.Substring(i, 1) != ".")
                    { 

                        subString += text.Substring(i, 1);
                    }
                    else
                    {
                        position = i;
                        KeyValuePair<string, int> pair;
                        pair = new KeyValuePair<string, int>(subString, position-subString.Length);
                        convertedList.Add(pair);
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
            
            foreach (KeyValuePair<string, int> acct in convertedList)
            {
                if (acct.Key.Contains(word))
                {
                    posList.Add(acct.Value);
                    richTextBox1.Select(acct.Value, acct.Key.Length);
                    
                    richTextBox1.SelectionBackColor = Color.Yellow;
                }
            }
            return posList;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
