using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitalele_Europei
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src='https://www.youtube.com/embed/{0}' width='600' height='300' frameborder='0' allowfullscreen></iframe>";
            html += "</head></html>";
            textBox1.Text = "https://www.youtube.com/watch?v=nxdTdjW-KQA";
            this.webBrowser1.DocumentText = string.Format(html, textBox1.Text.Split('=')[1]);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
