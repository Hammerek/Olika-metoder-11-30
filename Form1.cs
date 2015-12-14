using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olika_metoder_11_30
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "Metoder:" + "\n" + "1 - klot volym" + "\n" + "2 - cylinder volym" + "\n" + "3 - bråktal" + "\n" + "4 - summa" + "\n" + "5 - ekvation" + "\n" + "6 - close";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int metod = Convert.ToInt32(textBox3.Text);
            int tbx1 = Convert.ToInt32(textBox1.Text);
            int tbx2 = Convert.ToInt32(textBox2.Text);
            label3.Text = "";
            if (metod == 1)
            {
                label3.Text = Convert.ToString(klot_volym());
            }
            else if (metod == 2)
            {
                label3.Text = Convert.ToString(cylinder_volym());
            }
            else if (metod == 3)
            {
                label3.Text = Convert.ToString(braktal(tbx1, tbx2));
            }
            else if (metod == 4)
            {
                label3.Text = Convert.ToString(sum(tbx1));
            }
            else if (metod == 5)
            {
                label3.Text = Convert.ToString(calcPoint(tbx1, tbx2, metod));
            }
            else if (metod == 6)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Välj metod mellan 1-6");
            }
        }

        private double klot_volym()
        {
            double tbx1 = Convert.ToDouble(textBox1.Text);
            return ((4 * Math.PI * Math.Pow(tbx1, 3)) / 3);
        }

        private double cylinder_volym()
        {
            double tbx1 = Convert.ToDouble(textBox1.Text);
            double tbx2 = Convert.ToDouble(textBox2.Text);
            return (Math.PI * Math.Pow(tbx1, 2) * tbx2);
        }

        private string braktal(int tbx1, int tbx2)
        {
            int helnummer = tbx1 / tbx2;
            int fraction = tbx1 % tbx2;
            if (helnummer == 0)
            {
                return fraction + "/" + tbx2;
            }
            else
            {
                if (fraction == 0)
                {
                    return helnummer + " ";
                }
                else
                {
                    return helnummer + " " + fraction + "/" + tbx2;
                }
            }
        }

        private string sum(int tbx1)
        {
            int starttal = 1;
            string resultat = "";
            int total = 0;
            while (starttal <= tbx1)
            {
                if (starttal == 1)
                {
                    resultat += starttal;
                }
                else
                {
                    resultat += " + " + starttal;
                }
                total += starttal;
                starttal++;
            }
            label3.Text = label3.Text + " " + resultat + " = " + total;
            return label3.Text = label3.Text;
        }
        private int calcPoint(int tbx1, int tbx2)
        {
            int total;
            int metod = Convert.ToInt32(textBox3.Text);
            total = tbx1 * tbx2 + metod;
            return total - metod;
        }
        private int calcLine(int tbx1, int tbx2)
        {
            


        }

    }
}
