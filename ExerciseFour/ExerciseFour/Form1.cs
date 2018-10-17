using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExerciseFour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_test1_Click(object sender, EventArgs e)
        {
            //fillTextBox(textBox1, Consts.TEST1);
            string text = removeInsignificantWords(removeSpecialCharacters(Consts.TEST1));
            fillTextBox(textBox1, text);

        }

        private void btn_test2_Click(object sender, EventArgs e)
        {
            fillTextBox(textBox1, removeSpecialCharacters(Consts.TEST2));
        }

        private void btn_test3_Click(object sender, EventArgs e)
        {
            fillTextBox(textBox1, removeSpecialCharacters(Consts.TEST3));
        }

        /// <summary>
        /// Fills the given Text Box with the given string.
        /// </summary>
        /// <param name="textBox">name of the text box</param>
        /// <param name="text">string</param>
        private void fillTextBox(TextBox textBox, string text)
        {
            textBox.Text = "";
            textBox.Text = text;
        }

        /// <summary>
        /// Replaces all special symbols from string with space.
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Returns string with no special characters.</returns>
        private string removeSpecialCharacters(string str)
        {
            string outputString = Regex.Replace(str, "[^a-zA-Z0-9]+", " ", RegexOptions.Compiled);
            return outputString;
        }

        private string removeInsignificantWords(string str)
        {
            str = removeWordFromText(str, "is");
            str = removeWordFromText(str, "of");
            str = removeWordFromText(str, "in");
            str = removeWordFromText(str, "an");
            str = removeWordFromText(str, "as");
            str = removeWordFromText(str, "the");

            return str;
        }
        private string removeWordFromText(string test, string str)
        {
            string second_string = string.Empty;
            if (test.Contains(str))
            {
                second_string = test.Remove(test.IndexOf(" " + str), (" " + str).Length);
            }
            return second_string;
        }
        
    }
}
