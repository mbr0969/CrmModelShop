using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmBL.Model;

namespace CrmUI {
    public partial class ModelForm : Form {
        private ShopComputerModel model = new ShopComputerModel();
        public ModelForm() {
            InitializeComponent();
        }

        private void startModel_Click(object sender, EventArgs e)
        {

            var cashBoxes = new List<CashBoxView>();

            for (int i = 0; i < model.CashDesks.Count; i++ ) {
                cashBoxes.Add(new CashBoxView(model.CashDesks[i], i, 10+i,10+i));
            }

         

        }

    }


}
