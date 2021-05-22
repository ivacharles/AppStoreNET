using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppStoreNET
{
    public partial class Product : UserControl
    {
        SqlConnection connection;
        SqlCommand insCommmand, sqlCommand;
        SqlDataAdapter myAdapter;
        DataTable dataTable;

        String pictName = "";
        String pictPath = "";
        String destinationPath = @"C:\Users\less7\source\repos\AppStoreNET\images\productIMG\";

        public Product()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                pictPath = openFileDialog.FileName;
                pictName = Path.GetFileName(openFileDialog.FileName);
                pictureBox1.ImageLocation = pictPath;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (!pictPath.Equals("") && !pictName.Equals("") && !titleTextBox.Text.Equals("") && !productDescBox.Text.Equals("") && !categoryBox2.Text.Equals("") && !priceBox.Text.Equals(""))
            {
                //Establish a connection
                connection = new SqlConnection();
                connection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\less7\\source\\repos\\AppStoreNET\\AppStoreDatabase.mdf;Integrated Security=True";
                connection.Open();

                //myAdapter = new SqlDataAdapter();
                insCommmand = connection.CreateCommand();
                insCommmand.CommandType = CommandType.Text;
               // insCommmand.Connection = connection;
                insCommmand.CommandText = "Insert into product (productName, productDesc, productCategory, productPrice, imgPath,imgName ) Values('" + titleTextBox.Text + "', '" + productDescBox.Text + "', '" + categoryBox2.Text + "', '" + priceBox.Text + "', '" + pictPath + "', '" + pictName + "');";
                insCommmand.ExecuteNonQuery();
                //myAdapter.InsertCommand = insCommmand;
                //copy image and past to the app 
                File.Copy(pictPath, $"{destinationPath}{pictName}", true);



                //MessageBox.Show("Everything is ok here inside of the save method iva ");

            }
        }


        private void PersitProduct(String pName, String pDesc, String pCategory, String pPrice, String iPath, String iName)
        {
            //Establish a connection
            connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\less7\\source\\repos\\AppStoreNET\\AppStoreDatabase.mdf;Integrated Security=True";
            connection.Open();
            MessageBox.Show("connection open");
            //create sql access request
            //insert command
            myAdapter = new SqlDataAdapter();
            insCommmand = new SqlCommand();
            insCommmand.Connection = connection;
            //insCommmand.CommandText = "Insert into product (productName, productDesc, productCategory, productPrice, imgPath,imgName ) Values('"+pName+"', '"+pDesc+"', '"+pCategory+"', '"+pPrice+"', '"+iPath+"', '"+iName)";
            //insCommmand.Parameters.AddWithValue("@pName", pName);
            //insCommmand.Parameters.AddWithValue("@pDesc", pDesc);
            //insCommmand.Parameters.AddWithValue("@pCategory", pCategory);
            //insCommmand.Parameters.AddWithValue("@pPrice", pPrice);
            //insCommmand.Parameters.AddWithValue("@iPath", iPath);
            //insCommmand.Parameters.AddWithValue("@iName", iName);

            myAdapter.InsertCommand = insCommmand;

            //copy image and past to the app 
            File.Copy(pictPath, $"{destinationPath}{pictName}", true);

            MessageBox.Show("Title: " + pName + " Desc: " + pDesc + " Category: " + pCategory + " Price: " + pPrice+"Path: "+pictPath);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
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

            //bind the dataTablle with the gridView GUI
            dataGrid4productView.AutoGenerateColumns = false;
            dataGrid4productView.DataSource = dataTable;
        }
    }
}
