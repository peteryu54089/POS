using Microsoft.VisualStudio.TestTools.UnitTesting;
using POS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.ViewModels.Tests
{
    [TestClass()]
    public class StartUpFormPresentationModelTests
    {
        StartUpFormPresentationModel startUp = new StartUpFormPresentationModel();

        /// <summary>
        /// StartUpFormPresentationModelTest
        /// </summary>
        [TestMethod()]
        public void StartUpFormPresentationModelTest()
        {
            startUp = new StartUpFormPresentationModel();
            Assert.AreNotEqual(null, startUp.Sale);
            Assert.AreEqual(true, startUp.IsFrontEnabled);
            Assert.AreEqual(true, startUp.IsBackEnabled);
        }

        /// <summary>
        /// ClickFrontTest
        /// </summary>
        [TestMethod()]
        public void ClickFrontTest()
        {
            startUp.ClickFront();
            Assert.AreEqual(false, startUp.IsFrontEnabled);
        }

        /// <summary>
        /// ClickBackTest
        /// </summary>
        [TestMethod()]
        public void ClickBackTest()
        {
            startUp.ClickBack();
            Assert.AreEqual(false, startUp.IsBackEnabled);
        }

        /// <summary>
        /// CloseFrontTest
        /// </summary>
        [TestMethod()]
        public void CloseFrontTest()
        {
            startUp.CloseFront();
            Assert.AreEqual(true, startUp.IsFrontEnabled);
        }

        /// <summary>
        /// CloseBackTest
        /// </summary>
        [TestMethod()]
        public void CloseBackTest()
        {
            startUp.CloseBack();
            Assert.AreEqual(true, startUp.IsBackEnabled);
        }
    }
}
