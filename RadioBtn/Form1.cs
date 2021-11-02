using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioBtn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, surname,gender="";
            name = textBox1.Text;
            surname = textBox2.Text;
            if(radioButton1.Checked)
            {
                gender = "Man";
            }
            if(radioButton2.Checked)
            {
                gender = "Women";
            }
            MessageBox.Show("Name Surname:" + name + " " + surname + "\nGender:" + gender);
        }
    }
}
