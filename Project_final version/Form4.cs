using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
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
            using (OpenFileDialog fileop = new OpenFileDialog() { Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*", ValidateNames = true, Multiselect = false })
            {
                if (fileop.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = fileop.FileName;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            using (OpenFileDialog fileop = new OpenFileDialog() { Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*", ValidateNames = true, Multiselect = false })
            {
                if (fileop.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = fileop.FileName;
                }
            }
        }

        private void txtFileName_Click(object sender, EventArgs e)
        {
            txtFileName.Clear();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtFileName.Text != "" && txtFileName.Text != "Choose CF file")&& (textBox1.Text != "" && textBox1.Text != "Choose CSF file"))
            {
                if ((File.Exists(txtFileName.Text))&&(File.Exists(textBox1.Text)))
                {
                    try
                    {
                    Project_UI.Class1.End(txtFileName.Text,textBox1.Text);
                    string emp=File.ReadAllText("C:\\Users\\Public\\Documents\\Decode.txt");
                    if (string.IsNullOrWhiteSpace(emp)) MessageBox.Show("Files seemed to be different!");
                    else MessageBox.Show("File Decompressed Successfully!");
                    }
                    catch (System.IndexOutOfRangeException)  
                    {
                        MessageBox.Show("Files seemed to be different");
                        throw new System.ArgumentOutOfRangeException("input files are not correct.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Filename");
                }
            }
            else
            {
                MessageBox.Show("File or path is missing");
            }
        }
    }
}
