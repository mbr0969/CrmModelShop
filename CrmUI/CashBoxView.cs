using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmBL.Model;

namespace CrmUI {
    class CashBoxView
    {
        private CashDesk cashDesk;

        public Label Label { get; set; }
        public NumericUpDown NumericUpDown { get; set; }

        public CashBoxView(CashDesk cashDesk, int number, int x, int y){

            this.cashDesk = cashDesk;
           
            var label1 = new Label();
            var numericUpDown1 = new NumericUpDown();

            Label.AutoSize = true;
            Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Label.Location = new System.Drawing.Point(x, y);
            Label.Name = cashDesk.ToString();
            Label.Size = new System.Drawing.Size(107, 17);
            Label.TabIndex = number;
            Label.Text = $"Сумма покупки: {number}" ;
                  
            NumericUpDown.Location = new System.Drawing.Point(x, y);
            NumericUpDown.Name = $"numericUpDown{number}";
            NumericUpDown.Size = new System.Drawing.Size(310, 20); ;
            NumericUpDown.TabIndex = number+1;
            NumericUpDown.Value = number;
        }
    }
}
