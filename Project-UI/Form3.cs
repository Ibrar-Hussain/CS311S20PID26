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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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

        private void browsebtn_Click(object sender, EventArgs e)
        {
            txtFileName.Clear();
            using(OpenFileDialog fileop=new OpenFileDialog() { Filter="Text files(*.txt)|*.txt|All files(*.*)|*.*", ValidateNames = true, Multiselect = false })
            {
                if (fileop.ShowDialog()== DialogResult.OK)
                {
                    txtFileName.Text = fileop.FileName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }

        private void txtFileName_Click(object sender, EventArgs e)
        {
            txtFileName.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Project_UI.Class1.Start(txtFileName.Text);
        }
    }
}
