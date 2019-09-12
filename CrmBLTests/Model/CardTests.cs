using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model.Tests {
    [TestClass()]
    public class CardTests {
        [TestMethod()]
        public void CardTest() {
            //arrange
            Customer customer = new Customer(){
                CustomerId = 1,
                Name = "testUser"
            };

            var  product1 = new Product(){
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
            var card = new Card(customer);
          
            var expectedResult = new List<Product>(){
                product1, product1, product2
            };

            //act
            card.Add(product1);
            card.Add(product1);
            card.Add(product2);
            var carResult = card.GetAll();

            //assert
            Assert.AreEqual(expectedResult.Count, carResult.Count);

            for (int i = 0; i < expectedResult.Count; i++) {
                Assert.AreEqual(expectedResult[i], carResult[i]);
            }

        }

    }
}