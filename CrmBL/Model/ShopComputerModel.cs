using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CrmBL.Model {
    public class ShopComputerModel {
        
        Generator Generator = new Generator();
        Random rnd = new Random();
        private bool IsWorking = false;


        public List<CashDesk> CashDesks { get; set; } = new List<CashDesk>();
        public List<Card> Cards { get; set; }  = new List<Card>(); 
        public List<Check> Checks { get; set; } = new List<Check>();
        public List<Sell> Sells { get; set; } = new List<Sell>();
        public Queue<Seller> Sellers { get; set; } = new Queue<Seller>();
        public int CustomerSpeed { get; set; } = 100;
        public int CashDeskSpeed { get; set; } = 100;


        public ShopComputerModel() {
           var sellers =  Generator.GetNewSeller(20);
           var products = Generator.GetNewProducts(100);
           var costumers = Generator.GetNewCustomers(56);

            foreach (var seller in sellers ) {
                Sellers.Enqueue(seller);
            }

            for (int i = 0; i < 3; i++) {
                CashDesks.Add(new CashDesk(CashDesks.Count, Sellers.Dequeue()));
            }
        }
        
        /// <summary>
        /// Стартуем модель
        /// </summary>
        public void Start() {

            IsWorking = true;
            Task.Run(() => CreateCards(10));
            var cashDeskTasks = CashDesks.Select(c => new Task(() => CashDeskWork(c)));
            foreach (Task task in cashDeskTasks){
                task.Start();
            }
        }

        public void Stop(){
            IsWorking = false;
        }

        private void CashDeskWork(CashDesk cashDesk) {
            while (IsWorking) {
                if (cashDesk.Count > 0) {
                    cashDesk.Dequeue();
                    Thread.Sleep(CashDeskSpeed);
                }
            }
        }

        private void CreateCards(int customerCounts) {
             while (IsWorking) {
              var customers = Generator.GetNewCustomers(customerCounts);
              var cards = new Queue<Card>();
                foreach (var customer in customers) {
                    var card = new Card(customer);
                    foreach (var product in Generator.GetRandomProducts(10,30)) {
                        card.Add(product);
                    }
                    var cash = CashDesks[rnd.Next(CashDesks.Count)];
                    cash.Enqueue(card);
                }
                Thread.Sleep(CustomerSpeed);
            }

         }


    }
}
