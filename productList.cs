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
    public partial class productList : UserControl
    {
        public productList()
        {
            InitializeComponent();
        }


        #region Properties

        private String _title;
        private String _desc;
        private String _catergory;
        private String _price;
        private Image _productPict;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; productLlabelTItle.Text = value; }
        }
        [Category("Custom Props")]
        public string Desc
        {
            get { return _desc; }
            set { _desc = value; productLabelDesc.Text = value; }
        }
        [Category("Custom Props")]
        public string Category
        {
            get { return _catergory; }
            set { _catergory = value; prodcutLabelCateg.Text = value; }
        }
        [Category("Custom Props")]
        public string Price
        {
            get { return _price; }
            set { _price = value; productLabelPrice.Text = value; }
        }
        [Category("Custom Props")]
        public Image ProductPIct
        {
            get { return _productPict; }
            set { _productPict = value; productpictureBox.Image = value; }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            productList product = new productList();
            product.Title = _title;
            product.Desc = _desc;
            product.Category = _catergory;
            product.Price = _price;
            product.ProductPIct = _productPict;

            Form1.cart.Add(product);
            
        }
    }
}
