using CrmBL.Model;
using System;
using System.Windows.Forms;

namespace CrmUI {
    public partial class SellerForm : Form {

        public Seller Seller{ get; set; }

        public SellerForm() {
            InitializeComponent();
        }

        private void SellerForm_Load(object sender, EventArgs e) {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Seller = new Seller()
            {
                Name = nameSeller.Text
            };
            Close();


        }
    }
}
