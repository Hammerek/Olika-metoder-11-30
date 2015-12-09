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
                label3.Text = Convert.ToString(summera(tbx1));
            }
            else if (metod == 5)
            {
                label3.Text = "";
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
            return (Math.PI * Math.Pow(tbx1, 2)  * tbx2);
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

        private string summera(int tbx1)
        {

            int starttal = 1;
            while (starttal <= tbx1)
            {
                int total = 0;
                total += starttal;
                label3.Text = label3.Text + " " + total;
                starttal++;
                
            }
            return label3.Text = label3.Text; 
            
          

        }
    }
}
