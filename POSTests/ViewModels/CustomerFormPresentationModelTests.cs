using Microsoft.VisualStudio.TestTools.UnitTesting;
using POS.Models;
using POS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.ViewModels.Tests
{
    [TestClass()]
    public class CustomerFormPresentationModelTests
    {
        CustomerFormPresentationModel customer = new CustomerFormPresentationModel(new SaleModel());

        /// <summary>
        /// CustomerFormPresentationModelTest
        /// </summary>
        [TestMethod()]
        public void CustomerFormPresentationModelTest()
        {
            int index;
            string temp;
            object unitTotal;

            customer = new CustomerFormPresentationModel(new SaleModel());
            temp = customer.DetailText;
            temp = customer.PageText;
            index = customer.CategoryTabIndex;
            customer.CategoryTabIndex = index;
            unitTotal = customer.TempUnitTotal;
            Assert.AreNotEqual(null, customer.Sale);
            Assert.AreNotEqual(0, customer.NowPages.Count);
        }

        /// <summary>
        /// SetNowPageTest
        /// </summary>
        [TestMethod()]
        public void SetNowPageTest()
        {
            customer = new CustomerFormPresentationModel(new SaleModel());
            customer.SetNowPage();
            Assert.AreNotEqual(0, customer.NowPages.Count);
        }

        /// <summary>
        /// SetTotalPriceTest
        /// </summary>
        [TestMethod()]
        public void SetTotalPriceTest()
        {
            customer = new CustomerFormPresentationModel(new SaleModel());
            customer.SetTotalPrice();
            Assert.AreEqual("Total: 0元", customer.TotalPriceText);
        }

        /// <summary>
        /// SetPageTest
        /// </summary>
        [TestMethod()]
        public void SetPageTest()
        {
            string category;

            category = "drink";
            customer = new CustomerFormPresentationModel(new SaleModel());
            customer.SetPage(category);
            Assert.AreEqual(false, customer.IsPreviousEnabled);
            Assert.AreEqual(false, customer.IsNextEnabled);
            Assert.AreEqual(false, customer.IsAddEnabled);
        }

        /// <summary>
        /// ClickPreviousTest
        /// </summary>
        [TestMethod()]
        public void ClickPreviousTest()
        {
            string category;

            category = "drink";
            customer = new CustomerFormPresentationModel(new SaleModel());
            customer.ClickPrevious(category);
            Assert.AreEqual(null, customer.Sale.Order.TempOrder);
        }

        /// <summary>
        /// ClickNextTest
        /// </summary>
        [TestMethod()]
        public void ClickNextTest()
        {
            string category;

            category = "drink";
            customer = new CustomerFormPresentationModel(new SaleModel());
            customer.ClickNext(category);
            Assert.AreEqual(null, customer.Sale.Order.TempOrder);
        }

        /// <summary>
        /// ClickMealButtonTest
        /// </summary>
        [TestMethod()]
        public void ClickMealButtonTest()
        {
            string name;

            name = "烤鯖魚押壽司\n";
            customer = new CustomerFormPresentationModel(new SaleModel());
            customer.ClickMealButton(name);
            Assert.AreEqual(true, customer.IsAddEnabled);
        }

        /// <summary>
        /// ClickAddTest
        /// </summary>
        [TestMethod()]
        public void ClickAddTest()
        {
            bool isClickedAdd;

            customer = new CustomerFormPresentationModel(new SaleModel());
            customer.Sale.Order.TempOrder = null;
            isClickedAdd = customer.ClickAdd();
            Assert.AreEqual(false, isClickedAdd);

            customer.Sale.Order.TempOrder = new Meal("name", 1, "detail", "image", "category");
            isClickedAdd = customer.ClickAdd();
            Assert.AreEqual(true, isClickedAdd);
        }

        /// <summary>
        /// SetIsCreateOrUpdateTest
        /// </summary>
        [TestMethod()]
        public void SetIsCreateOrUpdateTest()
        {
            customer = new CustomerFormPresentationModel(new SaleModel());
            customer.SetIsCreateOrUpdate();
            Assert.AreEqual(true, customer.IsCreateOrUpdate);

            customer.TempOrdersCount = 1;
            customer.SetIsCreateOrUpdate();
            Assert.AreEqual(false, customer.IsCreateOrUpdate);
        }

        /// <summary>
        /// SetQuantityAndUnitTotalTest
        /// </summary>
        [TestMethod()]
        public void SetQuantityAndUnitTotalTest()
        {
            customer = new CustomerFormPresentationModel(new SaleModel());
            customer.SetQuantityAndUnitTotal("name");
            Assert.AreEqual(string.Empty, customer.TempQuantity);
        }

        /// <summary>
        /// UpdateNumericUpDownCellTest
        /// </summary>
        [TestMethod()]
        public void UpdateNumericUpDownCellTest()
        {
            object quantity;
            object mealName;

            quantity = 1;
            mealName = "name";
            customer = new CustomerFormPresentationModel(new SaleModel());
            customer.Sale.Order.Orders.Add(new Meal("name", 1, "detail", "image", "category"));
            customer.UpdateNumericUpDownCell(mealName, quantity);
            Assert.AreEqual("1", customer.TempQuantity);
        }

        /// <summary>
        /// ClickDeleteCellTest
        /// </summary>
        [TestMethod()]
        public void ClickDeleteCellTest()
        {
            bool isDelete;

            customer = new CustomerFormPresentationModel(new SaleModel());
            isDelete = customer.ClickDeleteCell(0, 0);
            Assert.AreEqual(true, isDelete);

            isDelete = customer.ClickDeleteCell(-1, -1);
            Assert.AreEqual(false, isDelete);
        }
    }
}