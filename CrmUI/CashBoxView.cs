using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmBL.Model;

namespace CrmUI {
    class CashBoxView {
        private CashDesk cashDesk;

        public Label CashDeskName { get; set; }
        public NumericUpDown Price { get; set; }
        public ProgressBar QueueLenght { get; set; }
        public Label LeaveCustomersCount { get; set; }


        public CashBoxView(CashDesk cashDesk, int number, int x, int y){

            this.cashDesk = cashDesk;
           
            CashDeskName = new Label();
            LeaveCustomersCount = new Label();
            Price = new NumericUpDown();
            QueueLenght = new ProgressBar();

            CashDeskName.AutoSize = true;
            CashDeskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            CashDeskName.Location = new System.Drawing.Point(x, y +15);
            CashDeskName.Name = $"label{number}";
            CashDeskName.Size = new System.Drawing.Size(107, 17);
            CashDeskName.TabIndex = number;
            CashDeskName.Text =   cashDesk.ToString();

            LeaveCustomersCount.AutoSize = true;
            LeaveCustomersCount.Location = new System.Drawing.Point(x +630, y + 15);
            LeaveCustomersCount.Name = $"leave{number}";
            LeaveCustomersCount.Size = new System.Drawing.Size(107, 17);
            LeaveCustomersCount.TabIndex = number;
            LeaveCustomersCount.Text = "";


            Price.Location = new System.Drawing.Point(x + 90, y+15);
            Price.Name = $"numericUpDown{number}";
            Price.Size = new System.Drawing.Size(110, 20); ;
            Price.TabIndex = number+1;
            Price.Value = number;
            Price.Maximum = 10000000000;

            QueueLenght.ForeColor = System.Drawing.Color.DarkGreen;
            QueueLenght.Location = new System.Drawing.Point(x + 230, y+15);
            QueueLenght.Maximum = cashDesk.MaxQueueLenght;
            QueueLenght.Name = $"progressBar{number}";
            QueueLenght.Size = new System.Drawing.Size(300, 23);
            QueueLenght.TabIndex = number;
            QueueLenght.Value = 0;

            cashDesk.CheckClosed += CashDesk_CheckClosed;
        }

        private void CashDesk_CheckClosed(object sender, Check e) {
           
            Price.Invoke((Action) delegate{
                Price.Value += e.Price;
                QueueLenght.Value = cashDesk.Count;
                LeaveCustomersCount.Text = cashDesk.ExitCustomer.ToString();
            });
        }
    }
}
