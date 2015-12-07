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
            double tbx1 = Convert.ToDouble(textBox3.Text); 
            
            label3.Text = ""; 
            if (tbx1 == 1)
            {
                label3.Text = Convert.ToString(klot_volym());
            }
            else if (tbx1 == 2)
            {
                label3.Text = Convert.ToString(cylinder_volym());
            }
            else if (tbx1 == 3)
            {
                label3.Text = Convert.ToString(braktal());
            }
            else if (tbx1 == 4)
            {
                label3.Text = Convert.ToString(summera());
            }
            else if (tbx1 == 5)
            {
                label3.Text = "";
            }
            else if (tbx1 == 6)
            {
                Application.Exit();
                
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

        private double braktal()
        {
            double tbx1 = Convert.ToDouble(textBox1.Text);
            double tbx2 = Convert.ToDouble(textBox2.Text);
            return (tbx1 / tbx2); 
        }

        private double summera()
        {
            double tbx1 = Convert.ToDouble(textBox1.Text);  
            for (int i = 1; i < tbx1; i++)
            {
              
            }
            return Convert.ToDouble(label3.Text); 
        }
    }
}
