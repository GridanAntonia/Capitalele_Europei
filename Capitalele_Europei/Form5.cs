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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Atena;
            pictureBox1.Refresh();
            System.Threading.Thread.Sleep(2000);
            pictureBox1.Image = Properties.Resources.Paris;
            pictureBox1.Refresh();
            System.Threading.Thread.Sleep(2000);
            pictureBox1.Image = Properties.Resources.Londra;
            pictureBox1.Refresh();
            System.Threading.Thread.Sleep(2000);
            pictureBox1.Image = Properties.Resources.Madrid;
            pictureBox1.Refresh();
            System.Threading.Thread.Sleep(2000);
            pictureBox1.Image = Properties.Resources.Budapesta;
            pictureBox1.Refresh();
            System.Threading.Thread.Sleep(2000);
            pictureBox1.Image = Properties.Resources.Stockholm;
            pictureBox1.Refresh();
            System.Threading.Thread.Sleep(2000);
            pictureBox1.Image = Properties.Resources.berlin;
            pictureBox1.Refresh();
            System.Threading.Thread.Sleep(2000);
            pictureBox1.Image = Properties.Resources.brusseles;
            pictureBox1.Refresh();
            System.Threading.Thread.Sleep(2000);
            pictureBox1.Image = Properties.Resources.erevan;
            pictureBox1.Refresh();
            System.Threading.Thread.Sleep(2000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
