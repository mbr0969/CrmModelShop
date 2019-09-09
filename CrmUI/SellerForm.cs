using CrmBL.Model;
using System;
using System.Windows.Forms;

namespace CrmUI {
    public partial class SellerForm : Form {

        public Seller Seller{ get; set; }

        public SellerForm() {
            InitializeComponent();
        }

        public SellerForm(Seller seller) : this(){
            Seller = seller;
            nameSeller.Text = Seller.Name;
        }

        private void SellerForm_Load(object sender, EventArgs e) {

           
        }

        private void button1_Click(object sender, EventArgs e) {
            var s = Seller ?? new Seller();
            s.Name = nameSeller.Text;
            Close();
        }
    }
}
