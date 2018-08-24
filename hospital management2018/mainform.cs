using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_management2018
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
            textBox4.Text = DateTime.Now.ToString("yyyy/MM/dd",new System.Globalization.CultureInfo(""));
            textBox5.Text = DateTime.Now.ToString("dddd", new System.Globalization.CultureInfo(""));
        }

         

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainform_Load(object sender, EventArgs e)
        {
            textBox3.Text = DateTime.Now.ToString("hh : mm : ss .tt");

            this.ActiveControl = textBox1;
            textBox1.SelectionStart = 6;
            textBox2.SelectionStart = 6;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "ad" && textBox2.Text == "12")
            {
                Form f1 = new Form();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("please check your username or password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
