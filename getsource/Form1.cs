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
using System.Net;


namespace getsource
{
    public partial class grtsource : Form
    {
        public grtsource()
        {
            InitializeComponent();
        }

        private void grtsource_Load(object sender, EventArgs e)
        {

        }

        private void btn_gets_Click(object sender, EventArgs e)
        {
            string url = txt_url.Text;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();

        }
    }
}
