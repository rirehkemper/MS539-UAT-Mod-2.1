

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String firstName = textBox1.Text;
            String lastName = textBox2.Text;
            Boolean male = radioButton1.Checked;
            Boolean female = radioButton2.Checked;
            Boolean nonBinary = radioButton3.Checked;

            if (male)
            {
                String M = "Mr.";
                MessageBox.Show("Thank you for Submitting your Interest, " + M + " " + firstName + " " + lastName + ". Someone will Reach out to you soon.");
            }
            else if (female)
            {
                String F = "Mrs.";
                MessageBox.Show("Thank you for Submitting your Interest, " + F + " " + firstName + " " + lastName + ". Someone will Reach out to you soon.");
            }
            else
            {
                String U = "";
                MessageBox.Show("Thank you for Submitting your Interest, " + U + " " + firstName + " " + lastName + ". Someone will Reach out to you soon.");
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            String path;
            if (checkBox4.Checked)
            {
                path = Directory.GetCurrentDirectory();
                string imagePath = Path.Combine(path, "Driving.jpg");
                pictureBox4.ImageLocation = imagePath;
                pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;

                pictureBox4.Show();
            }
            else
            {
                pictureBox4.Hide();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            String path;
            if (checkBox3.Checked)
            {
                path = Directory.GetCurrentDirectory();
                string imagePath = Path.Combine(path, "Video games.jpg");
                pictureBox3.ImageLocation = imagePath;
                pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;

                pictureBox3.Show();
            }
            else
            {
                pictureBox3.Hide();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            String path;
            if (checkBox2.Checked)
            {
                path = Directory.GetCurrentDirectory();
                string imagePath = Path.Combine(path, "volleyball.jpg");
                pictureBox2.ImageLocation = imagePath;
                pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;

                pictureBox2.Show();
            }
            else
            {
                pictureBox2.Hide();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            String path;
            if (checkBox1.Checked)
            {
                path = Directory.GetCurrentDirectory();
                string imagePath = Path.Combine(path, "paddleboarding.jpg");
                pictureBox1.ImageLocation = imagePath;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

                pictureBox1.Show();
            }
            else 
            {
                pictureBox1.Hide();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            String[] Conditions = {};
comboBox1.Items.AddRange(Conditions);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String firstName= textBox1.Text;
        }
    }
}
