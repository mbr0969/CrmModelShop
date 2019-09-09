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
           Product = product;
           nameProduct.Text = Product.Name;
           priceProduct.Value = Product.Price;
           countProduct.Value = Product.Count;
       }

        private void ProductForm_Load(object sender, EventArgs e) {

           
        }

        private void button1_Click(object sender, EventArgs e) {

            var p = Product ?? new Product();
            p.Name = nameProduct.Text;
            p.Price = priceProduct.Value;
            p.Count = Convert.ToInt32(countProduct.Value);
            Close();
        }
    }
}
