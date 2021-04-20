using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppStoreNET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void AccLableLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            homePage1.Hide();
            product1.Hide();
            accountPage1.Show();
            accountPage1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            homePage1.Show();
            accountPage1.Hide();
            product1.Hide();
            homePage1.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            homePage1.Show();
            accountPage1.Hide();
            product1.Hide();
            homePage1.BringToFront();
        }
    }
}
