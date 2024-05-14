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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.ShowDialog();
            this.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            this.Hide();
            f6.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            this.Hide();
            f8.ShowDialog();
            this.Show();
        }
    }
}
