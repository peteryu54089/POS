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
    public class RestaurantFormPresentationModelTests
    {
        RestaurantFormPresentationModel restaurant = new RestaurantFormPresentationModel(new SaleModel());

        /// <summary>
        /// RestaurantFormPresentationModelTest
        /// </summary>
        [TestMethod()]
        public void RestaurantFormPresentationModelTest()
        {
            restaurant = new RestaurantFormPresentationModel(new SaleModel());
            Assert.AreNotEqual(null, restaurant.Sale);
            Assert.AreEqual(3, restaurant.Categories.Count);
        }

        /// <summary>
        /// SetCategoriesTest
        /// </summary>
        [TestMethod()]
        public void SetCategoriesTest()
        {
            restaurant.SetCategories();
            Assert.AreEqual(3, restaurant.Categories.Count);
            Assert.AreEqual(15, restaurant.Categories["rice"].Count);
        }

        /// <summary>
        /// IsMealNameExistTest
        /// </summary>
        [TestMethod()]
        public void IsMealNameExistTest()
        {
            bool isMealNameExist;

            restaurant.Sale.Meals = new List<Meal>();
            isMealNameExist = restaurant.IsMealNameExist("name");
            Assert.AreEqual(false, isMealNameExist);

            restaurant = new RestaurantFormPresentationModel(new SaleModel());
            restaurant.IsAddOrEditMeal = true;
            restaurant.Sale.Meals.Add(new Meal("name", 1, "detail", "image", "category"));
            restaurant.Sale.Meals.Add(new Meal("name", 1, "detail", "image", "category"));
            isMealNameExist = restaurant.IsMealNameExist("name");
            Assert.AreEqual(true, isMealNameExist);
        }

        /// <summary>
        /// AddOrEditMealButtonTest
        /// </summary>
        [TestMethod()]
        public void AddOrEditMealButtonTest()
        {
            Meal meal;
            object oldMealName;

            oldMealName = "name";
            meal = new Meal("name", 1, "detail", "image", "category");
            restaurant.IsAddOrEditMeal = true;
            restaurant.Sale.Meals = new List<Meal>();
            restaurant.AddOrEditMealButton(oldMealName, meal);
            Assert.AreEqual(1, restaurant.Sale.Meals.Count);

            restaurant.IsAddOrEditMeal = false;
            restaurant.Sale.Meals = new List<Meal>();
            restaurant.Sale.Meals.Add(meal);
            meal = new Meal("name2", 1, "detail", "image", "category");
            restaurant.AddOrEditMealButton(oldMealName, meal);
            Assert.AreEqual("name2", restaurant.Sale.Meals[0].Name);
        }

        /// <summary>
        /// SaveMealButtonTest
        /// </summary>
        [TestMethod()]
        public void SaveMealButtonTest()
        {
            Meal meal;
            object oldMealName;
            
            oldMealName = "name";
            meal = new Meal("name", 1, "detail", "image", "category");
            restaurant.Sale.Meals = new List<Meal>();
            restaurant.Sale.Meals.Add(meal);
            meal = new Meal("name2", 1, "detail", "image", "category");
            restaurant.SaveMealButton(oldMealName, meal, 0);
            Assert.AreEqual("name2", restaurant.Sale.Meals[0].Name);
        }

        /// <summary>
        /// ClickDeleteSelectedCategoryTest
        /// </summary>
        [TestMethod()]
        public void ClickDeleteSelectedCategoryTest()
        {
            restaurant = new RestaurantFormPresentationModel(new SaleModel());
            restaurant.Sale.Order.Orders.Add(new Meal("name", 1, "detail", "image", "category"));
            restaurant.ClickDeleteSelectedCategory("rice");
            Assert.AreEqual(2, restaurant.Sale.Categories.Count);
        }

        /// <summary>
        /// RemoveMealTest
        /// </summary>
        [TestMethod()]
        public void RemoveMealTest()
        {
            Meal meal;
            string compareName;
            string categoryName;

            compareName = "rice";
            categoryName = "rice";
            meal = new Meal("name", 1, "detail", "image", "category");
            restaurant = new RestaurantFormPresentationModel(new SaleModel());
            restaurant.RemoveMeal(meal, categoryName, compareName);
            Assert.AreEqual(27, restaurant.Sale.Meals.Count);
        }

        /// <summary>
        /// RemoveOrderTest
        /// </summary>
        [TestMethod()]
        public void RemoveOrderTest()
        {
            Meal meal;
            string compareName;
            string categoryName;

            compareName = "rice";
            categoryName = "rice";
            meal = new Meal("name", 1, "detail", "image", "category");
            restaurant.Sale.Order.TotalPrice = 1;
            restaurant.Sale.Order.Orders = new List<Meal>();
            restaurant.Sale.Order.Orders.Add(meal);
            restaurant.RemoveOrder(meal, categoryName, compareName);
            Assert.AreEqual(0, restaurant.Sale.Order.TotalPrice);
            Assert.AreEqual(0, restaurant.Sale.Order.Orders.Count);
        }

        /// <summary>
        /// GetOldCategoryTest
        /// </summary>
        [TestMethod()]
        public void GetOldCategoryTest()
        {
            Category category;

            restaurant = new RestaurantFormPresentationModel(new SaleModel());
            category = restaurant.GetOldCategory("rice");
            Assert.AreEqual("rice", category.Name);
        }

        /// <summary>
        /// IsCategoryNameExistTest
        /// </summary>
        [TestMethod()]
        public void IsCategoryNameExistTest()
        {
            object name;
            bool isCategoryNameExist;

            name = "name";
            restaurant = new RestaurantFormPresentationModel(new SaleModel());
            isCategoryNameExist = restaurant.IsCategoryNameExist(name);
            Assert.AreEqual(false, isCategoryNameExist);

            name = "rice";
            restaurant.IsAddOrEditCategory = false;
            isCategoryNameExist = restaurant.IsCategoryNameExist(name);
            Assert.AreEqual(false, isCategoryNameExist);
        }

        /// <summary>
        /// AddOrEditCategoryTest
        /// </summary>
        [TestMethod()]
        public void AddOrEditCategoryTest()
        {
            object oldCategoryName;
            object newCategoryName;

            oldCategoryName = "rice";
            newCategoryName = "name2";
            restaurant = new RestaurantFormPresentationModel(new SaleModel());
            restaurant.IsAddOrEditCategory = true;
            restaurant.AddOrEditCategory(oldCategoryName, newCategoryName);
            Assert.AreEqual(4, restaurant.Sale.Categories.Count);

            restaurant = new RestaurantFormPresentationModel(new SaleModel());
            restaurant.IsAddOrEditCategory = false;
            restaurant.Sale.Order.Orders.Add(new Meal("name", 1, "detail", "image", "rice"));
            restaurant.AddOrEditCategory(oldCategoryName, newCategoryName);
            Assert.AreEqual(3, restaurant.Sale.Categories.Count);
        }

        /// <summary>
        /// UpdateCategoriesTest
        /// </summary>
        [TestMethod()]
        public void UpdateCategoriesTest()
        {
            string oldName;
            string newName;

            oldName = "rice";
            newName = "rice";
            restaurant = new RestaurantFormPresentationModel(new SaleModel());
            restaurant.UpdateCategories(oldName, newName);
            Assert.AreEqual(3, restaurant.Sale.Categories.Count);
        }

        /// <summary>
        /// ClickBrowseButtonTest
        /// </summary>
        [TestMethod()]
        public void ClickBrowseButtonTest()
        {
            string path;

            path = "rice";
            restaurant.ClickBrowseButton(path);
            Assert.AreNotEqual(string.Empty, restaurant.RelativePath);
        }
    }
}