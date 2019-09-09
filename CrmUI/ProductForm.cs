using CrmBL.Model;
using System;
using System.Windows.Forms;

namespace CrmUI {
   public partial class ProductForm : Form {

        public Product Product{ get; set; }

        public ProductForm() {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e) {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Product = new Product()
            {
                Name = nameProduct.Text,
                Price = priceProduct.Value,
                Count = Convert.ToInt32(countProduct.Value)
            };
            Close();


        }
    }
}
