using System;
using System.Windows.Forms;
using CrmBL.Model;

namespace CrmUI {
    public partial class Main : Form {

        CrmContext  db;

        public Main() {
            InitializeComponent();
            db = new CrmContext();
        }
        private void ProductToolStripMenuItem_Click(object sender, EventArgs e) {
          
        }

        private void SellerToolStripMenuItem_Click(object sender, EventArgs e) {
            var catalogSeller = new Catalog<Seller>(db.Sellers);
            catalogSeller.Show();
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e) {
            var catalogCustomer = new Catalog<Customer>(db.Customers);
            catalogCustomer.Show();
        }

        private void CheckToolStripMenuItem_Click(object sender, EventArgs e) {

            var checkCustomer = new Catalog<Check>(db.Checks);
            checkCustomer.Show();

        }

        private void CustomerAddToolStripMenuItem2_Click(object sender, EventArgs e) {

            var form = new CustomerForm();

            if (form.ShowDialog() == DialogResult.OK){
                db.Customers.Add(form.Customer);
                db.SaveChanges();
            }
        }
    }
}
