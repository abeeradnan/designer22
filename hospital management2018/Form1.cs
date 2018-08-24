using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace hospital_management2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            slidepanel1.Top = button29.Top;
            userControl11.BringToFront();

            slide2panel1.Top = button29.Top;
            userControl41.BringToFront();

            slide3panel1.Top = button29.Top;
            userControl21.BringToFront();

            slide5panel2.Top = button29.Top;
            userControl51.BringToFront();

            slide6panel1.Top = button29.Top;
            userControl61.BringToFront();

            slide8panel1.Top = button29.Top;
            userControl81.BringToFront();
            
            
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            slidepanel1.Height = button29.Height;
            userControl11.BringToFront();

            slide2panel1.Top = button29.Top;
            userControl41.BringToFront();

            slide3panel1.Top = button29.Top;
            userControl21.BringToFront();


            slide5panel2.Top = button29.Top;
            userControl51.BringToFront();

            slide6panel1.Top = button29.Top;
            userControl61.BringToFront();

            slide8panel1.Top = button29.Top;
            userControl81.BringToFront();

            //Panel p = new Panel();
            //Controls.Add(p);
            //p.Location = new Point(10,50);
            //p.BackColor = Color.DarkGray;
            //p.Height = 370;
            //p.Width = 900;
            //p.AutoScroll = true;

            ////Panel pa = new Panel();
            ////Controls.Add(pa);
            ////pa.Location = new Point(0, 340);
            ////pa.BackColor = Color.DarkGray;
            ////pa.Height = 30;
            ////pa.Width = 900;

        
          

            //Label b = new Label();
            //Controls.Add(b);
            //b.Text="استمارة شعبة الطوارئ";
            //b.Left = 300;
            //b.Height = 50;
            //b.Width = 210;
            //b.Font = new Font("times new roman", 18, FontStyle.Italic);
            

            //TextBox tx1 = new TextBox();
            //Controls.Add(tx1);
            //tx1.Location=new Point(10,70);
            //tx1.Width = 150;
            //tx1.Multiline = true;
            //tx1.Height = 70;
            ////tx1.Text = "التاريخ";
            //tx1.Font = new Font("times new roman", 16, FontStyle.Italic);
            //tx1.Text= DateTime.Now.ToString("yyyy/MM/dd", new System.Globalization.CultureInfo(""));
          
            




            //TextBox tx2 = new TextBox();
            //Controls.Add(tx2);
            //tx2.Location = new Point(160, 70);
            //tx2.Width = 150;
            //tx2.Multiline = true;
            //tx2.Height = 70;
            //tx2.Text=DateTime.Now.ToString("hh : mm : ss .tt");
            //tx2.Font = new Font("times new roman", 16, FontStyle.Italic);

            //TextBox tx3 = new TextBox();
            //Controls.Add(tx3);
            //tx3.Location = new Point(310, 70);
            //tx3.Width = 300;
            //tx3.Multiline = true;
            //tx3.Height = 70;
            //tx3.Text = "ردهة الطوارئ";
            //tx3.Font = new Font("times new roman", 16, FontStyle.Italic);


            //TextBox tx4 = new TextBox();
            //Controls.Add(tx4);
            //tx4.Location = new Point(610, 70);
            //tx4.Width = 280;
            //tx4.Multiline = true;
            //tx4.Height = 70;

            ////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            //TextBox tx5 = new TextBox();
            //Controls.Add(tx5);
            //tx5.Location = new Point(10, 140);
            //tx5.Width = 300;
            //tx5.Multiline = true;
            //tx5.Height = 80;


            //TextBox tx6 = new TextBox();
            //Controls.Add(tx6);
            //tx6.Location = new Point(310, 140);
            //tx6.Width = 300;
            //tx6.Multiline = true;
            //tx6.Height = 80;

            //TextBox tx7 = new TextBox();
            //Controls.Add(tx7);
            //tx7.Location = new Point(610, 140);
            //tx7.Width = 280;
            //tx7.Multiline = true;
            //tx7.Height = 80;
            ////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            //TextBox tx8 = new TextBox();
            //Controls.Add(tx8);
            //tx8.Location = new Point(10, 220);
            //tx8.Width = 300;
            //tx8.Multiline = true;
            //tx8.Height = 60;



            //TextBox tx9 = new TextBox();
            //Controls.Add(tx9);
            //tx9.Location = new Point(310, 220);
            //tx9.Width = 150;
            //tx9.Multiline = true;
            //tx9.Height = 60;


            //TextBox tx10 = new TextBox();
            //Controls.Add(tx10);
            //tx10.Location = new Point(460, 220);
            //tx10.Width = 200;
            //tx10.Multiline = true;
            //tx10.Height = 60;

            //TextBox tx11 = new TextBox();
            //Controls.Add(tx11);
            //tx11.Location = new Point(660, 220);
            //tx11.Width = 230;
            //tx11.Multiline = true;
            //tx11.Height = 60;

            ////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            //TextBox tx12 = new TextBox();
            //Controls.Add(tx12);
            //tx12.Location = new Point(10, 280);
            //tx12.Width = 300;
            //tx12.Multiline = true;
            //tx12.Height = 60;

            //TextBox tx13 = new TextBox();
            //Controls.Add(tx13);
            //tx13.Location = new Point(310, 280);
            //tx13.Width = 150;
            //tx13.Multiline = true;
            //tx13.Height = 60;

            //TextBox tx14 = new TextBox();
            //Controls.Add(tx14);
            //tx14.Location = new Point(460, 280);
            //tx14.Width = 200;
            //tx14.Multiline = true;
            //tx14.Height = 60;


            //TextBox tx15 = new TextBox();
            //Controls.Add(tx15);
            //tx15.Location = new Point(660, 280);
            //tx15.Width = 230;
            //tx15.Multiline = true;
            //tx15.Height = 60;
            ////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            //Label b1 = new Label();
            //Controls.Add(b1);
            //b1.Text = "الانطباع العامImpression";
            //b1.Location = new Point(300, 370);
            //b1.Width = 210;
            //b1.BackColor=Color.White;
            ////b1.ForeColor = Color.Black;
            ////b1.Font = new Font("times new roman", 10, FontStyle.Italic);


            //Control[] allc = { b ,tx1, tx2,tx3,tx4,tx5,tx6,tx7,tx8,tx9,tx10,tx11,tx12,tx13,tx14,tx15};
            //p.Controls.AddRange(allc);



        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
    }
}
