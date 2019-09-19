using CrmBL.Model;
using System;
using System.Windows.Forms;

namespace CrmUI {
   public partial class ProductForm : Form {

        public Product Product{ get; set; }

        public ProductForm() {
            InitializeComponent();
        }

       public ProductForm(Product product) :this() {

           Product = product ?? new Product();
           nameProduct.Text = Product.Name;
           priceProduct.Value = Product.Price;
           countProduct.Value = Product.Count;
       }

        private void ProductForm_Load(object sender, EventArgs e) {
        }

        private void button1_Click(object sender, EventArgs e) {

            Product = Product ?? new Product();
            Product.Name = nameProduct.Text;
            Product.Price = priceProduct.Value;
            Product.Count = Convert.ToInt32(countProduct.Value);
            Close();
        }
    }
}
