using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model.Tests {
    [TestClass()]
    public class CashDeskTests {
        [TestMethod()]
        public void CashDeskTest() {
            //arrange
            Customer customer1 = new Customer() {
                Name = "Tester1",
                CustomerId = 1,
            };

            Customer customer2 = new Customer() {
                Name = "Tester2",
                CustomerId = 2,
            };

            Seller seller = new Seller(){
                Name = "SellerTest",
                SellerId = 1
            };

            var product1 = new Product() {
                ProductId = 1,
                Name = "pr1",
                Price = 100,
                Count = 10
            };
            var product2 = new Product() {
                ProductId = 2,
                Name = "pr2",
                Price = 200,
                Count = 20
            };

            var card1 = new Card(customer1);
            card1.Add(product1);
            card1.Add(product1);
            card1.Add(product2);
            var card2 = new Card(customer2);
            card2.Add(product1);
            card2.Add(product2);
            card2.Add(product2);
            var chashDesk = new  CashDesk(1,seller);
            chashDesk.MaxQueueLenght = 10;

            chashDesk.Enqueue(card1);
            chashDesk.Enqueue(card2);

            var card1Result = 400;
            var card2Result = 500;

            //act
            var card1ActualResult = chashDesk.Dequeue();
            var card2ActualResult = chashDesk.Dequeue();

            //assert
            Assert.AreEqual(card1Result, card1ActualResult);
            Assert.AreEqual(card2Result, card2ActualResult);
            Assert.AreEqual(7, product1.Count);
            Assert.AreEqual(17, product2.Count);
        }

    }
}