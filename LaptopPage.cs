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
    public partial class LaptopPage : UserControl
    {
        SqlConnection connection;
        SqlCommand insCommmand, sqlCommand;
        SqlDataAdapter myAdapter;

        public LaptopPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LaptopPage_Load(object sender, EventArgs e)
        {
            LoadLaptopProducts();
        }

        private void LoadLaptopProducts()
        {
            //get all products in a datatble
            DataTable productsTable = GetProducts();


            productList[] lists = new productList[10]; //create a list of the user control
            for(int i=0; i<productsTable.Rows.Count; i++)
            {
                lists[i] = new productList();
                lists[i].Title = (String) productsTable.Rows[i]["productName"];
                lists[i].Desc = (String) productsTable.Rows[i]["productDesc"];
                lists[i].Price = (String) productsTable.Rows[i]["productPrice"];
                lists[i].Category = (String)productsTable.Rows[i]["productCategory"];
                lists[i].ProductPIct = Image.FromFile((String) productsTable.Rows[i]["imgPath"]);

                if (flowLayoutPanel2.Controls.Count < 0)
                {
                    flowLayoutPanel2.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel2.Controls.Add(lists[i]);
                }
            }
        }

        //get products from the database
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
