using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise7
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

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            if(tbUrl.Text == "")
            {
                MessageBox.Show("Manqk, nqma link");
            }
            else
            {
                if (rbtnGet.Checked == true)
                {
                    var watch = Stopwatch.StartNew();
                    getHTML(tbUrl.Text);
                    watch.Stop();
                    lblTime.Text = watch.ElapsedMilliseconds.ToString() + " ms.";
                }
                else if (rbtnHead.Checked == true)
                {
                    var watch = Stopwatch.StartNew();
                    getHeaders(tbUrl.Text);
                    watch.Stop();
                    lblTime.Text = watch.ElapsedMilliseconds.ToString() + " ms.";
                }
            }
        }


        private void getHTML(string urlAddress)
        {
            tbHtml.Clear();
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = null;

                    if (response.CharacterSet == null)
                    {
                        readStream = new StreamReader(receiveStream);
                    }
                    else
                    {
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    }

                    string data = readStream.ReadToEnd();

                    response.Close();
                    readStream.Close();
                    tbHtml.Text = data;
                }
            }
            catch (System.Net.WebException) {
                MessageBox.Show("Nevaliden url manqk!");
            }
        }

        public void getHeaders(string url)
        {
            tbHeaders.Clear();
            try
            {
                // Creates an HttpWebRequest for the specified URL. 
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                // Sends the HttpWebRequest and waits for response.
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

                // Displays all the headers present in the response received from the URI.
                Console.WriteLine("\r\nThe following headers were received in the response:");
                // Displays each header and it's key associated with the response.
                for (int i = 0; i < myHttpWebResponse.Headers.Count; ++i)
                    tbHeaders.Text += "Header Name: " + myHttpWebResponse.Headers.Keys[i] +
                                        "Value:" + myHttpWebResponse.Headers[i] +
                                        Environment.NewLine;
                // Releases the resources of the response.
                myHttpWebResponse.Close();
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("Linka MANQQQQk!");
            }
        }

        private void btnTest1_Click(object sender, EventArgs e)
        {
            tbUrl.Text = "https://www.myprotein.bg/";
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            tbUrl.Text = "http://tu-varna.bg/";
        }

        private void btnTest3_Click(object sender, EventArgs e)
        {
            tbUrl.Text = "https://stackoverflow.com/";
        }

        private void btnTest4_Click(object sender, EventArgs e)
        {
            tbUrl.Text = "https://stacow.c";
        }

        private void btnTest5_Click(object sender, EventArgs e)
        {

        }
    }
}
