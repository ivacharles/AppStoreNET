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
        SqlCommand insCommmand;
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

                File.Copy(pictPath, $"{destinationPath}{pictName}", true);
                pictureBox1.ImageLocation = pictPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("path = "+pictPath + "picName = " + pictName + "titleTextBox = " + titleTextBox.Text + "productDescBox = " + productDescBox.Text + "categoryBox2 = " + categoryBox2.Text + "priceBox = " + priceBox.Text);
            if (!pictPath.Equals("") && !pictName.Equals("") && !titleTextBox.Text.Equals("") && !productDescBox.Text.Equals("") && !categoryBox2.Text.Equals("") && priceBox.Text.Equals(""))
            {
                MessageBox.Show("Everything is ok here inside of the save method iva ");
                PersitProduct(titleTextBox.Text, productDescBox.Text, categoryBox2.Text, priceBox.Text);
            }
        }


        private void PersitProduct(String pName, String pDesc, String pCategory, String pPrice)
        {
            //Establish a connection
            connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\less7\\source\\repos\\AppStoreNET\\AppStoreDatabase.mdf;Integrated Security=True";
            connection.Open();

            //create sql access request
            //insert command
            myAdapter = new SqlDataAdapter();
            insCommmand = new SqlCommand();
            insCommmand.Connection = connection;
            insCommmand.CommandText = "Insert into product (productName, productDesc, productCategory, productPrice) Values(@productName, @productDesc, @productCategory, @productPrice)";
            insCommmand.Parameters.AddWithValue("@productName", pName);
            insCommmand.Parameters.AddWithValue("@productDesc", pDesc);
            insCommmand.Parameters.AddWithValue("@productCategory", pCategory);
            insCommmand.Parameters.AddWithValue("@productPrice", pPrice);

            myAdapter.InsertCommand = insCommmand;
        }
    }
}
