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
        public bool mouseDown;
        private Point lastLocation;
      
       
        public Form1()
        {
            InitializeComponent();
          
        }

        

      



        private void siticoneButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
          


        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "") 
            {
                
                label11.Text = "";
                label4.ForeColor = Color.Silver;
                label3.ForeColor = Color.Crimson;
                label10.Text = "- This field is required";
                guna2TextBox1.BorderColor = Color.Crimson;
            }
            else
            {
                pictureBox1.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
      
           
            
            




        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var email = guna2TextBox1.Text;
            var pass = guna2TextBox2.Text;
            WebClient w = new WebClient();
            string whitelist = new System.Net.WebClient() { Proxy = null }.DownloadString("https://mojstarytanczy.000webhostapp.com/email.txt");
            string password = new System.Net.WebClient() { Proxy = null }.DownloadString("https://mojstarytanczy.000webhostapp.com/pass.txt");
            if (email.Contains(whitelist) && pass.Contains(password))
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

           

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X)+ e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }
    }
    }

