﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model {
    public class ShopComputerModel {
        
        Generator Generator = new Generator();
        Random rnd = new Random();

        public List<CashDesk> CashDesks { get; set; } = new List<CashDesk>();
        public List<Card> Cards { get; set; } // = new List<Card>();
        public List<Check> Checks { get; set; } = new List<Check>();
        public List<Sell> Sells { get; set; } = new List<Sell>();
        public Queue<Seller> Sellers { get; set; } = new Queue<Seller>();

        public ShopComputerModel() {
           var sellers =  Generator.GetNewSeller(20);
           var products = Generator.GetNewProducts(1000);
           var costumers = Generator.GetNewCustomers(100);

            foreach (var seller in sellers ) {
                Sellers.Enqueue(seller);
            }

            for (int i = 0; i < 3; i++) {
                CashDesks.Add(new CashDesk(CashDesks.Count, Sellers.Dequeue()));
            }
        }


        public void Start() {
            var customers = Generator.GetNewCustomers(10);
            var  cards = new Queue<Card>();

            foreach (var customer in customers) {

                var card = new Card(customer);

                foreach (var product in Generator.GetRandomProducts(10, 30)) {
                    card.Add(product);
                }

                cards.Enqueue(card);
            }

            while (cards.Count >0)
            {
                    var cash = CashDesks[rnd.Next(CashDesks.Count - 1)];
                    cash.Enqueue(cards.Dequeue());
            }
           

            while (true){
                var cash = CashDesks[rnd.Next(CashDesks.Count - 1)];
                var money = cash.Dequeue();
            }

        }


    }
}