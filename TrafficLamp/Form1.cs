using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLamp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        int timer, cycle;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer = 30;
            time_Tick.Enabled = true;
            time_Tick.Interval = 400;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button3.Text = timer.ToString();
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button3.BackColor = Color.LightBlue;

        }
        private void time_Tick(object sender, EventArgs e)
        {
            if (cycle == 0)
            {
                if (timer == 2)
                    S.BackColor = Color.Yellow;
                if (timer == 0)
                {
                    button1.BackColor = Color.Black;
                    button2.BackColor = Color.Black;
                    button3.BackColor = Color.Green;
                    timer = 30;
                    cycle = 1;
                }
            }
            if (cycle == 1)
            {
                if (timer == 2)
                    S.BackColor = Color.Yellow;
                if (timer == 0)
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Black;
                    button3.BackColor = Color.Black;
                    timer = 30;
                    cycle = 0;
                }
            }

            button4.Text = timer.ToString();
            timer = timer - 1;
        }
    }
    }

