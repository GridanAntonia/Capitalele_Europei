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
    public partial class Form7 : Form
    {
        int correct, qnumber = 1, score, total;
        public Form7()
        {
            InitializeComponent();
            askQuestion(qnumber);
            total = 9;
        }

        private void checkanswerEvent(object sender, EventArgs e)
        {
            var senderobject = (Button)sender;
            int buttontag = Convert.ToInt32(senderobject.Tag);
            if (buttontag == correct)
            {
                score++;
            }
            if(qnumber==total && score!=1)
            {
                MessageBox.Show(
                    "Testul s-a incheiat!" + Environment.NewLine +
                    "Ai raspuns corect la "+ score+ " intrebari" + Environment.NewLine+
                    "Apasa pe OK daca doresti sa mai joci!"

                    );
                score = 0;
                qnumber = 0;
                askQuestion(qnumber);
            }
            else if(qnumber == total && score == 1)
            {
                MessageBox.Show(
                    "Testul s-a incheiat!" + Environment.NewLine +
                    "Ai raspuns corect la " + score + " intrebare" + Environment.NewLine +
                    "Apasa pe OK daca doresti sa mai joci!"

                    );
                score = 0;
                qnumber = 0;
                askQuestion(qnumber);
            }
            qnumber++;
            askQuestion(qnumber);
        }
        
        private void askQuestion(int qnum)
        {
            switch(qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.italia;
                    label1.Text = "Care este capitala Italiei?";
                    button1.Text = "Roma";
                    button2.Text = "Venetia";
                    button3.Text = "Milano";
                    button4.Text = "Vatican";
                    correct = 1;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.austria;
                    label1.Text = "Care este capitala Austriei?";
                    button1.Text = "Budapesta";
                    button2.Text = "Petrosani";
                    button3.Text = "Viena";
                    button4.Text = "Podgorica";
                    correct = 3;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.romania;
                    label1.Text = "Care este capitala Romaniei?";
                    button1.Text = "Cluj-Napoca";
                    button2.Text = "Timisoara";
                    button3.Text = "Orastie";
                    button4.Text = "Bucuresti";
                    correct = 4;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.muntenegru;
                    label1.Text = "Care este capitala statului Muntenegru?";
                    button1.Text = "Tirana";
                    button2.Text = "Sarajevo";
                    button3.Text = "Podgorica";
                    button4.Text = "Ljublijana";
                    correct = 3;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.olanda;
                    label1.Text = "Care este capitala Olandei?";
                    button1.Text = "Delft";
                    button2.Text = "Amsterdam";
                    button3.Text = "Rotterdam";
                    button4.Text = "Brusseles";
                    correct = 2;
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.elvetia;
                    label1.Text = "Care este capitala Elvetiei?";
                    button1.Text = "Geneva";
                    button2.Text = "Zurich";
                    button3.Text = "Skopje";
                    button4.Text = "Berna";
                    correct = 4;
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.croatia;
                    label1.Text = "Care este capitala Croatiei?";
                    button1.Text = "Zagreb";
                    button2.Text = "Kiev";
                    button3.Text = "Praga";
                    button4.Text = "Bratislava";
                    correct = 1;
                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.germania;
                    label1.Text = "Care este capitala Germaniei?";
                    button1.Text = "Lisabona";
                    button2.Text = "Berlin";
                    button3.Text = "Sofia";
                    button4.Text = "Koln";
                    correct = 2;
                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.irlanda;
                    label1.Text = "Care este capitala Irlandei?";
                    button1.Text = "Londra";
                    button2.Text = "Riga";
                    button3.Text = "Dublin";
                    button4.Text = "Vaduz";
                    correct = 3;
                    break;
            }
        }
    }
}
