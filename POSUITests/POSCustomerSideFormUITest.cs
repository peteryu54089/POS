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
    /// POSCustomerSideFormUITest 的摘要說明
    /// </summary>
    [CodedUITest]
    public class POSCustomerSideFormUITest
    {
        const string FILE_PATH = @"../../../POS/bin/Debug/POS.exe";
        private const string STARTUP_TITLE = "StartUp";
        private const string POS_CUSTOMER_SIDE_FORM_TITLE = "POSCustomerSideForm";

        /// <summary>
        /// Launches the StartUp
        /// </summary>
        [TestInitialize()]
        public void Initialize()
        {
            Robot.Initialize(FILE_PATH, STARTUP_TITLE);
            Robot.ClickButton("Start the Customer Program (Frontend)");
            Robot.SetForm(POS_CUSTOMER_SIDE_FORM_TITLE);
            Robot.AssertButtonEnable("Add", false);
            Robot.AssertButtonEnable("Previous", false);
            Robot.AssertButtonEnable("Next", true);
            Robot.AssertText("Page: 1/2", "Page: 1/2");
            Robot.AssertText("Total: 0元", "Total: 0元");
            Robot.AssertDataItemsInDataGridView("Table", 0);
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
        /// Tests that 切頁事件
        /// </summary>
        [TestMethod]
        public void SwitchPageTest()
        {
            // 下一頁
            Robot.ClickButton("Next");
            Robot.AssertButtonEnable("Previous", true);
            Robot.AssertButtonEnable("Next", false);
            Robot.AssertText("Page: 2/2", "Page: 2/2");

            // 上一頁
            Robot.ClickButton("Previous");
            Robot.AssertButtonEnable("Previous", false);
            Robot.AssertButtonEnable("Next", true);
            Robot.AssertText("Page: 1/2", "Page: 1/2");
        }

        /// <summary>
        /// Tests that 點餐事件
        /// </summary>
        [TestMethod]
        public void OrderTest()
        {
            // 點第一個餐點
            Robot.ClickButton("烤鯖魚押壽司\n$40元");
            Robot.AssertButtonEnable("Add", true);
            Robot.ClickButton("Add");
            Robot.AssertButtonEnable("Add", false);
            Robot.AssertDataItemsInDataGridView("Table", 1);
            string[] mealOne = { "X", "烤鯖魚押壽司", "rice", "40", "1", "1", "40 NTD" };
            Robot.AssertDataGridViewByIndex("Table", "1", mealOne);
            Robot.AssertText("Total: 40元", "Total: 40元");

            // 點第二個餐點
            Robot.ClickButton("稻荷天婦羅壽司\n$40元");
            Robot.AssertButtonEnable("Add", true);
            Robot.ClickButton("Add");
            Robot.AssertButtonEnable("Add", false);
            Robot.AssertDataItemsInDataGridView("Table", 2);
            string[] mealTwo = { "X", "稻荷天婦羅壽司", "rice", "40", "1", "1", "40 NTD" };
            Robot.AssertDataGridViewByIndex("Table", "2", mealTwo);
            Robot.AssertText("Total: 80元", "Total: 80元");

            // 刪除第一個餐點
            string[] deleteArguments = { "Table", POS_CUSTOMER_SIDE_FORM_TITLE, "X", "1" };
            Robot.DeleteDataGridViewByIndex(deleteArguments);
            Robot.AssertDataItemsInDataGridView("Table", 1);
            Robot.AssertDataGridViewByIndex("Table", "1", mealTwo);
            Robot.AssertText("Total: 40元", "Total: 40元");
        }

        /// <summary>
        /// Tests that 點擊分類事件
        /// </summary>
        [TestMethod]
        public void ClickCategoryTabTest()
        {
            Robot.ClickTabControl("dessert");
            Robot.AssertText("Page: 1/1", "Page: 1/1");
            Robot.ClickTabControl("drink");
            Robot.AssertText("Page: 1/1", "Page: 1/1");
            Robot.ClickTabControl("rice");
            Robot.AssertText("Page: 1/2", "Page: 1/2");
        }

        /// <summary>
        /// Tests that 點擊上下按鈕事件
        /// </summary>
        [TestMethod]
        public void ClickNumericUpDown()
        {
            Robot.ClickButton("烤鯖魚押壽司\n$40元");
            Robot.ClickButton("Add");
            Robot.SetNumericUpDown();
            string[] mealOne = { "X", "烤鯖魚押壽司", "rice", "40", "2", "2", "80 NTD" };
            Robot.AssertDataGridViewByIndex("Table", "1", mealOne);
            Robot.AssertNumericUpDown("Table", "1", mealOne);
        }
    }
}
