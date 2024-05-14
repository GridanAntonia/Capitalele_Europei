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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.casa_p;
            label1.Text = "A treia cea mai mare cladire administrativa pentru uz civil ca suprafață din lume";
            pictureBox1.Refresh();


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.ateneu;
            label1.Text = "Cladirea este realizata intr-o combinatie de stil neoclasic cu stil eclectic";
            pictureBox1.Refresh();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.arc;
            label1.Text = "Monumentul comemoreaza participarea Romaniei in Primul Razboi Mondial.";
            pictureBox1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.cismigiu;
            label1.Text = "Gradina Cismigiu este cea mai veche gradina publica din Bucuresti.";
            pictureBox1.Refresh();
        }
    }
}
