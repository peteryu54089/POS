using Microsoft.VisualStudio.TestTools.UnitTesting;
using POS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.Tests
{
    [TestClass()]
    public class OrderTests
    {
        Order order = new Order();

        /// <summary>
        /// OrderTest
        /// </summary>
        [TestMethod()]
        public void OrderTest()
        {
            Assert.AreEqual(0, order.Orders.Count);
        }

        /// <summary>
        /// SetTempOrderTest
        /// </summary>
        [TestMethod()]
        public void SetTempOrderTest()
        {
            string orderName;
            IList<Meal> meals;

            meals = new List<Meal>();
            meals.Add(new Meal("name", 1, "detail", "image", "category"));
            orderName = "name\n";
            order.SetTempOrder(meals, orderName);
            Assert.AreEqual("name", order.TempOrder.Name);
        }

        /// <summary>
        /// CreateTest
        /// </summary>
        [TestMethod()]
        public void CreateTest()
        {
            bool isCreate;

            order.TempOrder = null;
            isCreate = order.Create();
            Assert.AreEqual(false, isCreate);

            order.Orders = new List<Meal>();
            order.Orders.Add(new Meal("name", 1, "detail", "image", "category"));
            order.TempOrder = new Meal("name", 1, "detail", "image", "category");
            isCreate = order.Create();
            Assert.AreEqual("name", order.TempMealName);
            Assert.AreEqual(1, order.TempMealPrice);
            Assert.AreEqual(2, order.Orders[0].Quantity);
            Assert.AreEqual(2, order.Orders[0].UnitTotal);

            order.Orders = new List<Meal>();
            order.TempOrder = new Meal("name", 1, "detail", "image", "category");
            isCreate = order.Create();
            Assert.AreNotEqual(0, order.Orders.Count);
            Assert.AreEqual(null, order.TempOrder);
            Assert.AreEqual(true, isCreate);
        }

        /// <summary>
        /// SetQuantityAndUnitTotalTest
        /// </summary>
        [TestMethod()]
        public void SetQuantityAndUnitTotalTest()
        {
            order.Orders = new List<Meal>();
            order.Orders.Add(new Meal("name", 1, "detail", "image", "category"));
            order.TempMealName = "name";
            order.TempMealPrice = 1;
            order.SetQuantityAndUnitTotal();
            Assert.AreEqual(2, order.Orders.FirstOrDefault().Quantity);
            Assert.AreEqual(2, order.Orders.FirstOrDefault().UnitTotal);
        }

        /// <summary>
        /// DeleteByIndexTest
        /// </summary>
        [TestMethod()]
        public void DeleteByIndexTest()
        {
            order.Orders = new List<Meal>();
            order.Orders.Add(new Meal("name", 1, "detail", "image", "category"));
            order.TotalPrice = 1;
            order.DeleteByIndex(0);
            Assert.AreEqual(0, order.TotalPrice);
            Assert.AreEqual(0, order.Orders.Count);
        }

        /// <summary>
        /// DeleteByNameTest
        /// </summary>
        [TestMethod()]
        public void DeleteByNameTest()
        {
            order.Orders = new List<Meal>();
            order.Orders.Add(new Meal("name", 1, "detail", "image", "category"));
            order.Orders.Add(new Meal("name2", 1, "detail", "image", "category"));
            order.TotalPrice = 1;
            order.DeleteByName("name");
            Assert.AreEqual(0, order.TotalPrice);
            Assert.AreEqual(1, order.Orders.Count);
        }

        /// <summary>
        /// GetTempQuantityTest
        /// </summary>
        [TestMethod()]
        public void GetTempQuantityTest()
        {
            string quantity;

            order.Orders = new List<Meal>();
            order.Orders.Add(new Meal("name", 1, "detail", "image", "category"));
            quantity = order.GetTempQuantity("name");
            Assert.AreEqual("name", order.TempMealName);
            Assert.AreEqual("1", quantity);

            order.Orders = new List<Meal>();
            order.Orders.Add(new Meal("name", 1, "detail", "image", "category"));
            quantity = order.GetTempQuantity("name2");
            Assert.AreEqual(string.Empty, quantity);

            order.Orders = new List<Meal>();
            quantity = order.GetTempQuantity("name");
            Assert.AreEqual(string.Empty, quantity);
        }

        /// <summary>
        /// GetTempUnitTotalTest
        /// </summary>
        [TestMethod()]
        public void GetTempUnitTotalTest()
        {
            int unitTotal;

            order.Orders = new List<Meal>();
            order.Orders.Add(new Meal("name", 1, "detail", "image", "category"));
            unitTotal = order.GetTempUnitTotal("name");
            Assert.AreEqual("name", order.TempMealName);
            Assert.AreEqual(1, unitTotal);

            order.Orders = new List<Meal>();
            order.Orders.Add(new Meal("name", 1, "detail", "image", "category"));
            unitTotal = order.GetTempUnitTotal("name2");
            Assert.AreEqual(0, unitTotal);

            order.Orders = new List<Meal>();
            unitTotal = order.GetTempUnitTotal("name");
            Assert.AreEqual(0, unitTotal);
        }

        /// <summary>
        /// GetTempUnitPriceTest
        /// </summary>
        [TestMethod()]
        public void GetTempUnitPriceTest()
        {
            int unitPrice;

            order.Orders = new List<Meal>();
            order.Orders.Add(new Meal("name", 1, "detail", "image", "category"));
            unitPrice = order.GetTempUnitPrice("name");
            Assert.AreEqual("name", order.TempMealName);
            Assert.AreEqual(1, unitPrice);

            order.Orders = new List<Meal>();
            order.Orders.Add(new Meal("name", 1, "detail", "image", "category"));
            unitPrice = order.GetTempUnitPrice("name2");
            Assert.AreEqual(0, unitPrice);

            order.Orders = new List<Meal>();
            unitPrice = order.GetTempUnitPrice("name");
            Assert.AreEqual(0, unitPrice);
        }

        /// <summary>
        /// IsNameEqualTest
        /// </summary>
        [TestMethod()]
        public void IsNameEqualTest()
        {
            bool isNameEqual;

            order.TempMealName = "name";
            isNameEqual = order.IsNameEqual("name");
            Assert.AreEqual(true, isNameEqual);
        }

        /// <summary>
        /// UpdateTotalPriceTest
        /// </summary>
        [TestMethod()]
        public void UpdateTotalPriceTest()
        {
            order.Orders = new List<Meal>();
            order.Orders.Add(new Meal("name", 1, "detail", "image", "category"));
            order.TotalPrice = 1;
            order.UpdateTotalPrice("name", 1);
            Assert.AreEqual(1, order.TotalPrice);
        }
    }
}
