using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmBL.Model;

namespace CrmUI {
    public partial class Main : Form {

        CrmContext  db;
        Card card;
        Customer customer;

        public Main() {
            InitializeComponent();
            db = new CrmContext();
            card = new Card(customer);
        }
        private void ProductToolStripMenuItem_Click(object sender, EventArgs e) {
            var catalogProduct = new Catalog<Product>(db.Products, db);
            catalogProduct.Show();
        }

        private void SellerToolStripMenuItem_Click(object sender, EventArgs e) {
            var catalogSeller = new Catalog<Seller>(db.Sellers, db);
            catalogSeller.Show();
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e) {
            var catalogCustomer = new Catalog<Customer>(db.Customers, db);
            catalogCustomer.Show();
        }

        private void CheckToolStripMenuItem_Click(object sender, EventArgs e) {

            var checkCustomer = new Catalog<Check>(db.Checks, db);
            checkCustomer.Show();

        }

        private void CustomerAddToolStripMenuItem2_Click(object sender, EventArgs e) {
            var form = new CustomerForm();
            if (form.ShowDialog() == DialogResult.OK){
                db.Customers.Add(form.Customer);
                db.SaveChanges();
            }
        }

        private void sellerAddToolStripMenuItem1_Click(object sender, EventArgs e) {

            var form = new SellerForm();

            if (form.ShowDialog() == DialogResult.OK) {
                db.Sellers.Add(form.Seller);
                db.SaveChanges();
            }

        }

        private void productAddToolStripMenuItem_Click(object sender, EventArgs e) {

            var form = new ProductForm();

            if (form.ShowDialog() == DialogResult.OK) {
                db.Products.Add(form.Product);
                db.SaveChanges();
            }
        }
        private void modelToolStripMenuItem_Click(object sender, EventArgs e) {
            var form = new ModelForm();
            form.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
             
            Task.Run(() =>
            {
                listBox1.Invoke((Action) delegate {
                    var items = db.Products.ToArray();
                    listBox1.Items.AddRange(items);
                });
            });
        }

        private void listBox1_DoubleClick(object sender, EventArgs e) {
            if (listBox1.SelectedItem is Product product){
                card.Add(product);


            }
        }
    }
}
