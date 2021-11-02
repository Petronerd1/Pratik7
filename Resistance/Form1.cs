using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resistance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r1, r2, r3, r4, result;
            r1 = comboBox1.SelectedIndex;
            r2 = comboBox2.SelectedIndex;
            r3 = comboBox3.SelectedIndex;
            r4 = comboBox4.SelectedIndex;
            string sum = r1 + r2.ToString();
            result = (Convert.ToDouble(sum) * Math.Pow(10, r3));
            if (result < 1000)
            {
                label5.Text = result + "Ohm".ToString();
            }
            else if (result < 1000000)
            {
                label5.Text = (result / 1000) + "Kilo Ohm".ToString();
            }
            else if (result < 1000000000)
            {
                label5.Text = (result / 1000000) + "Mega Ohm".ToString();
            }
            else if (result < 1000000000000)
            {
                label5.Text = (result / 1000000000) + "Giga Ohm".ToString();
            }
            else
            {
                label5.Text = "Hata";
            }
            if (r4 == 0)
            {
                label6.Text = "Tolerance %1";
            }
            else if(r4==1)
            {
                label6.Text = "Tolerance %5";
            }
            else if(r4==2)
            {
                label6.Text = "Tolerance %10";
            }
            else
            {
                label6.Text = "Tolerance %15";
            }

    }
    }
}
