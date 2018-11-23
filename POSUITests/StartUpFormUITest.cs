using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace POSUITests
{
    /// <summary>
    /// StartUpFormUITest 的摘要說明
    /// </summary>
    [CodedUITest]
    public class StartUpFormUITest
    {
        const string FILE_PATH = @"../../../POS/bin/Debug/POS.exe";
        private const string STARTUP_TITLE = "StartUp";
        private const string POS_CUSTOMER_SIDE_FORM_TITLE = "POSCustomerSideForm";
        private const string POS_RESTAURANT_SIDE_FORM_TITLE = "POSRestaurantSideForm";

        /// <summary>
        /// Launches the StartUp
        /// </summary>
        [TestInitialize()]
        public void Initialize()
        {
            Robot.Initialize(FILE_PATH, STARTUP_TITLE);
            Robot.AssertWindow(STARTUP_TITLE);
            Robot.AssertButtonEnable("Start the Customer Program (Frontend)", true);
            Robot.AssertButtonEnable("Start the Restaurant Program (Backend)", true);
            Robot.AssertButtonEnable("Exit", true);
            Robot.SetDelayBetweenActions(600);
        }

        /// <summary>
        /// Closes the launched program
        /// </summary>
        [TestCleanup()]
        public void Cleanup()
        {
            Robot.CleanUp();
        }

        /// <summary>
        /// Tests that 點擊Frontend按鈕觸發事件
        /// </summary>
        [TestMethod]
        public void ClickFrontTest()
        {
            Robot.ClickButton("Start the Customer Program (Frontend)");
            Robot.AssertWindow(POS_CUSTOMER_SIDE_FORM_TITLE);
            Robot.AssertButtonEnable("Start the Customer Program (Frontend)", false);
            Robot.CloseWindow(POS_CUSTOMER_SIDE_FORM_TITLE);
            Robot.AssertButtonEnable("Start the Customer Program (Frontend)", true);
        }

        /// <summary>
        /// Tests that 點擊Backend按鈕觸發事件
        /// </summary>
        [TestMethod]
        public void ClickBackTest()
        {
            Robot.ClickButton("Start the Restaurant Program (Backend)");
            Robot.AssertWindow(POS_RESTAURANT_SIDE_FORM_TITLE);
            Robot.AssertButtonEnable("Start the Restaurant Program (Backend)", false);
            Robot.CloseWindow(POS_RESTAURANT_SIDE_FORM_TITLE);
            Robot.AssertButtonEnable("Start the Restaurant Program (Backend)", true);
        }

        /// <summary>
        /// Tests that 點擊Exit按鈕觸發事件
        /// </summary>
        [TestMethod]
        public void ClickExitTest()
        {
            Robot.ClickButton("Exit");
        }
    }
}
