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
    public class CategoryTests
    {
        /// <summary>
        /// CategoryTest
        /// </summary>
        [TestMethod()]
        public void CategoryTest()
        {
            Category category;

            category = new Category("category");
            Assert.AreEqual("category", category.Name);
        }
    }
}
