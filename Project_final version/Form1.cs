using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;
        int len = 0;
        string txt;
        private void Form1_Load(object sender, EventArgs e)
        {
            txt = label2.Text;
            len = txt.Length;
            label2.Text = "";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > len)
            {
                counter = 0;
                label2.Text = "";
            }
            else
            {
                label2.Text = txt.Substring(0, counter);
                if (label2.ForeColor == Color.White)
                    label2.ForeColor = Color.Yellow;
                else
                    label2.ForeColor = Color.White;

            }
              if (counter == len)
                timer1.Stop();
           
        }

        private void MinW_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaxW_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void CloseW_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cntnubtn_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
          
        }
    }
}
