using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord_Login
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
          
        }

       

        private void siticoneButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient w = new WebClient();
            string whitelist =w.DownloadString("");
            string password = w.DownloadString(");
            if (whitelist.Contains(textBox1.Text) && password.Contains(textBox2.Text))
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();

            }
            
              else
            {
                label3.ForeColor = Color.Crimson;
                label4.ForeColor = Color.Crimson;
                label10.Text = "- Login or password is invalid.";
                label11.Text = "- Login or password is invalid.";


            }

            if (email == "")
            {
                label11.Text = "";
                label4.ForeColor = Color.Silver;
                label3.ForeColor = Color.Crimson;
                label10.Text = "- This field is required";
            }
            if (password == "")
            {
                label10.Text = "";
                label3.ForeColor = Color.Silver;
                label4.ForeColor = Color.Crimson;
                label11.Text = "- This field is required";
            }
          


        }


        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") 
            {
               
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
