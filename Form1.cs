using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppStoreNET
{
    public partial class Form1 : Form
    {
        public static List<productList> cart;
        public static int cartCount;
        public static DataTable dataTable;

        SqlConnection connection;
        SqlCommand insCommmand, sqlCommand;
        SqlDataAdapter myAdapter;

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
            memoryRam1.Hide();
            laptopPage2.Hide();
            homePage2.Hide();
            desktopPage1.Hide();
            miscPage1.Hide();
            motherboardPage1.Hide();
            cpuPage1.Hide();
            accountPage2.Show();
            accountPage2.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            memoryRam1.Hide();
            laptopPage2.Hide();
            accountPage2.Hide();
            motherboardPage1.Hide();
            desktopPage1.Hide();
            miscPage1.Hide();
            cpuPage1.Hide();
            homePage2.Show();
            homePage2.BringToFront();

            dataTable = GetProducts();
            cart = new List<productList>();
            linkLabel1.Text = "(" + cart.Count + ") " + "Cart";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            accountPage2.Hide();
            memoryRam1.Hide();
            motherboardPage1.Hide();
            desktopPage1.Hide();
            miscPage1.Hide();
            cpuPage1.Hide();
            laptopPage2.Hide();
            homePage2.Show();
            homePage2.BringToFront();
            linkLabel1.Text = "(" + cart.Count + ") " + "Cart";

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            accountPage2.Hide();
            motherboardPage1.Hide();
            cpuPage1.Hide();
            desktopPage1.Hide();
            miscPage1.Hide();
            homePage2.Hide();
            memoryRam1.Hide();
            laptopPage2.Show();
            laptopPage2.BringToFront();
        }

        private void memoryRam1_Load(object sender, EventArgs e)
        {
            accountPage2.Hide();
            motherboardPage1.Hide();
            cpuPage1.Hide();
            desktopPage1.Hide();
            miscPage1.Hide();
            homePage2.Hide();
            memoryRam1.Show();
            laptopPage2.Hide();
            memoryRam1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            accountPage2.Hide();
            motherboardPage1.Hide();
            cpuPage1.Hide();
            desktopPage1.Show();
            miscPage1.Hide();
            homePage2.Hide();
            memoryRam1.Hide();
            laptopPage2.Hide();
            desktopPage1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            accountPage2.Hide();
            motherboardPage1.Hide();
            cpuPage1.Show();
            desktopPage1.Hide();
            miscPage1.Hide();
            homePage2.Hide();
            memoryRam1.Hide();
            laptopPage2.Hide();
            cpuPage1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            accountPage2.Hide();
            motherboardPage1.Show();
            cpuPage1.Hide();
            desktopPage1.Hide();
            miscPage1.Hide();
            homePage2.Hide();
            memoryRam1.Hide();
            laptopPage2.Hide();
            motherboardPage1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            accountPage2.Hide();
            motherboardPage1.Hide();
            cpuPage1.Hide();
            desktopPage1.Hide();
            miscPage1.Show();
            homePage2.Hide();
            memoryRam1.Hide();
            laptopPage2.Hide();
            miscPage1.BringToFront();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "(" + cart.Count + ") " + "Cart";

        }

        private DataTable GetProducts()
        {
            DataTable dataTable = new DataTable();

            //Establish a connection
            connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\less7\\source\\repos\\AppStoreNET\\AppStoreDatabase.mdf;Integrated Security=True";
            connection.Open();

            //create sql access request
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection; //connect sqlCommand with the database
            sqlCommand.CommandText = "Select * from Product";

            // give command to a messenger, that will return the data and put it to the data table
            myAdapter = new SqlDataAdapter(); //create the Adapter 
            myAdapter.SelectCommand = sqlCommand;// connect it with the Sqlcommand
            dataTable = new DataTable(); // create a dataTable
            myAdapter.Fill(dataTable); // make adpter fill the datatable

            return dataTable;
        }


    }
}
