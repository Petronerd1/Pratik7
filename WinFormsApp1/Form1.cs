using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            while (name.Contains("  "))
            {
                name = name.Replace("  ", " ");
            }
            string shortName = name.Substring(0, 1);
            int space = 0;
            while (name.IndexOf(' ', space + 1) >= 0)
            {
                space = name.IndexOf(' ', space + 1);
                shortName += "." + name.Substring(space + 1, 1);
            }
            string surname = textBox2.Text.Trim().ToLower();
            string school = textBox3.Text.Trim().Replace(" ", "").ToLower();
            string email = shortName + "." + surname + "@" + school + ".edu.tr";
            email = email.ToLower();
            email = email.Replace("ğ", "g");
            email = email.Replace("ş", "s");
            email = email.Replace("ı", "i");
            email = email.Replace("ü", "u");
            email = email.Replace("ö", "o");
            email = email.Replace("ç", "c");
            label4.Text = email;
        }
    }
}

