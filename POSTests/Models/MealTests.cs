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
    public class MealTests
    {
        /// <summary>
        /// MealTest
        /// </summary>
        [TestMethod()]
        public void MealTest()
        {
            Meal meal;

            meal = new Meal("name", 1, "detail", "image", "category");
            Assert.AreEqual("name", meal.Name);
            Assert.AreEqual(1, meal.UnitPrice);
            Assert.AreEqual("detail", meal.Detail);
            Assert.AreEqual("image", meal.Image);
            Assert.AreEqual("category", meal.Category.Name);
            Assert.AreEqual(1, meal.Quantity);
            Assert.AreEqual(1, meal.UnitTotal);

            meal.Visible = true;
            Assert.AreEqual(true, meal.Visible);
        }

        /// <summary>
        /// MealTest1
        /// </summary>
        [TestMethod()]
        public void MealTest1()
        {
            Meal meal;
            object name = "name";
            object unitPrice = 1;
            object detail = "detail";
            object image = "image";
            object category = "category";

            meal = new Meal(name, unitPrice, detail, image, category);
            Assert.AreEqual("name", meal.Name);
            Assert.AreEqual(1, meal.UnitPrice);
            Assert.AreEqual("detail", meal.Detail);
            Assert.AreEqual("image", meal.Image);
            Assert.AreEqual("category", meal.Category.Name);
            Assert.AreEqual(1, meal.Quantity);
            Assert.AreEqual(1, meal.UnitTotal);
        }

        /// <summary>
        /// SetUnitTotalTest
        /// </summary>
        [TestMethod()]
        public void SetUnitTotalTest()
        {
            Meal meal;

            meal = new Meal("name", 0, "detail", "image", "category");
            Assert.AreEqual(0, meal.UnitTotal);
        }
    }
}
