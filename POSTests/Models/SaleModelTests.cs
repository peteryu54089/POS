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
    public class SaleModelTests
    {
        SaleModel sale = new SaleModel();

        /// <summary>
        /// SaleModelTest
        /// </summary>
        [TestMethod()]
        public void SaleModelTest()
        {
            sale = new SaleModel();
            Assert.AreNotEqual(null, sale.Order);
            Assert.AreNotEqual(0, sale.Meals.Count);
            Assert.AreNotEqual(0, sale.Categories.Count);
            Assert.AreNotEqual(0, sale.MealButtons.Count);
        }

        /// <summary>
        /// DefaultMealsTest
        /// </summary>
        [TestMethod()]
        public void DefaultMealsTest()
        {
            sale.Meals = new List<Meal>();
            sale.DefaultMeals();
            Assert.AreNotEqual(0, sale.Meals.Count);
        }

        /// <summary>
        /// SetDefaultMealsTest
        /// </summary>
        [TestMethod()]
        public void SetDefaultMealsTest()
        {
            sale.Meals = new List<Meal>();
            sale.SetDefaultMeals("rice");
            Assert.AreNotEqual(0, sale.Meals.Count);
        }

        /// <summary>
        /// SetCategoriesTest
        /// </summary>
        [TestMethod()]
        public void SetCategoriesTest()
        {
            sale.Categories = new List<Category>();
            sale.SetCategories();
            Assert.AreNotEqual(0, sale.Categories.Count);
        }

        /// <summary>
        /// IsCategoryExistTest
        /// </summary>
        [TestMethod()]
        public void IsCategoryExistTest()
        {
            Meal meal;
            bool isCategoryExist;

            sale.Categories = new List<Category>();
            meal = new Meal("name", 1, "detail", "image", "category");
            isCategoryExist = sale.IsCategoryExist(meal);
            Assert.AreEqual(false, isCategoryExist);

            meal = new Meal("name", 1, "detail", "image", "category");
            sale.Categories.Add(meal.Category);
            isCategoryExist = sale.IsCategoryExist(meal);
            meal = new Meal("name", 1, "detail", "image", "category");
            sale.Categories.Add(meal.Category);
            isCategoryExist = sale.IsCategoryExist(meal);
            Assert.AreEqual(1, sale.Categories.Count);
            Assert.AreEqual(true, isCategoryExist);
        }

        /// <summary>
        /// InitializeMealButtonsTest
        /// </summary>
        [TestMethod()]
        public void InitializeMealButtonsTest()
        {
            sale.InitializeMealButtons();
            Assert.AreNotEqual(0, sale.MealButtons.Count);
        }

        /// <summary>
        /// SetTotalPageTest
        /// </summary>
        [TestMethod()]
        public void SetTotalPageTest()
        {
            sale.Categories = new List<Category>();
            sale.SetTotalPage("name");
            Assert.AreEqual(1, sale.TotalPage);
        }

        /// <summary>
        /// SetMealButtonsTest
        /// </summary>
        [TestMethod()]
        public void SetMealButtonsTest()
        {
            sale.InitializeMealButtons();
            sale.Meals = new List<Meal>();
            sale.Meals.Add(new Meal("name", 1, "detail", "image", "category"));
            sale.SetMealButtons("category", 1);
            Assert.AreEqual(true, sale.MealButtons[0].Visible);
            Assert.AreEqual("name\n$1元", sale.MealButtons[0].Name);
        }

        /// <summary>
        /// ClickMealButtonTest
        /// </summary>
        [TestMethod()]
        public void ClickMealButtonTest()
        {
            IList<Meal> meals;

            sale.Order = new Order();
            meals = new List<Meal>();
            meals.Add(new Meal("name", 1, "detail", "image", "category"));
            sale.Order.SetTempOrder(meals, "name\n");
            Assert.AreNotEqual(null, sale.Order.TempOrder);
        }

        /// <summary>
        /// UpdateNumericUpDownCellTest
        /// </summary>
        [TestMethod()]
        public void UpdateNumericUpDownCellTest()
        {
            object quantity;

            quantity = 1;
            sale.Order = new Order();
            sale.Order.Orders = new List<Meal>();
            sale.Order.Orders.Add(new Meal("name", 1, "detail", "image", "category"));
            sale.Order.TotalPrice = 1;
            sale.UpdateNumericUpDownCell("name", quantity);
            Assert.AreEqual(1, sale.Order.TotalPrice);
            Assert.AreEqual(1, sale.Order.Orders[0].Quantity);
            Assert.AreEqual(1, sale.Order.Orders[0].UnitTotal);
        }

        /// <summary>
        /// RefreshCustomerSideFormAfterDeleteMealTest
        /// </summary>
        [TestMethod()]
        public void RefreshCustomerSideFormAfterDeleteMealTest()
        {
            sale.Order.Orders = new List<Meal>();
            sale.Order.Orders.Add(new Meal("name", 1, "detail", "image", "category"));
            sale.RefreshCustomerSideFormAfterDeleteMeal("name");
            Assert.AreEqual(0, sale.Order.Orders.Count);
        }

        /// <summary>
        /// RefreshCustomerSideFormAfterSaveMealTest
        /// </summary>
        [TestMethod()]
        public void RefreshCustomerSideFormAfterSaveMealTest()
        {
            Meal meal;
            object name;

            name = "name";
            meal = new Meal("name", 1, "detail", "image", "category");
            sale.Order.Orders = new List<Meal>();
            sale.Order.Orders.Add(meal);
            sale.Order.TotalPrice = 1;
            sale.RefreshCustomerSideFormAfterSaveMeal(name, meal);
            Assert.AreEqual(1, sale.Order.TotalPrice);
        }

        /// <summary>
        /// SetBaseOrderTest
        /// </summary>
        [TestMethod()]
        public void SetBaseOrderTest()
        {
            object oldMealName;
            Meal order;
            Meal meal;

            oldMealName = null;
            order = new Meal("name", 1, "detail", "image", "category");
            meal = new Meal("name2", 1, "detail", "image", "category");
            sale.SetBaseOrder(oldMealName, order, meal);
            Assert.AreEqual("name", order.Name);

            oldMealName = "name2";
            sale.SetBaseOrder(oldMealName, order, meal);
            Assert.AreEqual("name", order.Name);

            oldMealName = "name";
            sale.SetBaseOrder(oldMealName, order, meal);
            Assert.AreEqual("name2", order.Name);
        }

        /// <summary>
        /// RefreshCustomerSideFormAfterUpdateCategoryTest
        /// </summary>
        [TestMethod()]
        public void RefreshCustomerSideFormAfterUpdateCategoryTest()
        {
            sale.RefreshCustomerSideFormAfterUpdateCategory();
        }

        /// <summary>
        /// IsMealExistsInOrderTest
        /// </summary>
        [TestMethod()]
        public void IsMealExistsInOrderTest()
        {
            bool isMealExistsInOrder;

            sale.Meals = new List<Meal>();
            sale.Order.Orders = new List<Meal>();
            sale.Meals.Add(new Meal("name2", 1, "detail", "image", "category"));
            sale.Order.Orders.Add(new Meal("name", 1, "detail", "image", "category"));
            isMealExistsInOrder = sale.IsMealExistsInOrder(0);
            Assert.AreEqual(false, isMealExistsInOrder);

            sale.Order.Orders.Add(new Meal("name2", 1, "detail", "image", "category"));
            isMealExistsInOrder = sale.IsMealExistsInOrder(0);
            Assert.AreEqual(true, isMealExistsInOrder);
        }
    }
}
