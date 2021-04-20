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
    public partial class AccountPage : UserControl
    {
        SqlConnection connection;
        SqlCommand selectCommmand;
        SqlDataAdapter myAdapter;
        private Form1 Form1 = 

        public AccountPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Establish a connection
            connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\less7\\source\\repos\\AppStoreNET\\AppStoreDatabase.mdf;Integrated Security=True";
            connection.Open();

            //Select Command
            selectCommmand = new SqlCommand();
            selectCommmand.Connection = connection;
            selectCommmand.CommandText = "select custPwd from customer where custEmail = @email";

            selectCommmand.Parameters.AddWithValue("@email", loginEmailBox.Text);
            myAdapter = new SqlDataAdapter();
            myAdapter.SelectCommand = selectCommmand;
            DataTable dataTable = new DataTable();
            myAdapter.Fill(dataTable);

            MessageBox.Show((String)dataTable.Rows[0][0]);

            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Something is wrong! Try again");
            }else if(((String)dataTable.Rows[0][0]).Equals(loginPwdBox.Text))
            {
                
            }
            else
            {
                MessageBox.Show("hey!");
            }

        }
    }
}
