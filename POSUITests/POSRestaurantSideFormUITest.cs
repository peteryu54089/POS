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
    /// POSRestaurantSideFormUITest 的摘要說明
    /// </summary>
    [CodedUITest]
    public class POSRestaurantSideFormUITest
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
            Robot.ClickButton("Start the Customer Program (Frontend)");
            Robot.SetForm(POS_CUSTOMER_SIDE_FORM_TITLE);
            Robot.ClickButton("烤鯖魚押壽司\n$40元");
            Robot.ClickButton("Add");
            Robot.SetForm(STARTUP_TITLE);
            Robot.ClickButton("Start the Restaurant Program (Backend)");
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
        /// Tests that 點選餐點事件
        /// </summary>
        [TestMethod]
        public void SelectMealTest()
        {
            Robot.ClickListViewByValue(POS_RESTAURANT_SIDE_FORM_TITLE, "烤鯖魚押壽司");
            Robot.SetForm(POS_RESTAURANT_SIDE_FORM_TITLE);
            Robot.AssertComboBox("ComboBox", "rice");
            Robot.AssertEdit(string.Empty, "烤鯖魚押壽司是藏壽司菜單上的推薦壽司，烤過的鯖魚腹肉入口即化。");
            Robot.AssertButtonEnable("Delete Selected Meal", false);
            Robot.AssertButtonEnable("Save", false);

            // 編輯餐點
            Robot.SetOtherFormEdit(POS_RESTAURANT_SIDE_FORM_TITLE, string.Empty, "test");
            Robot.AssertOtherFormButtonEnable(POS_RESTAURANT_SIDE_FORM_TITLE, "Save", true);
            Robot.ClickButton("Save");
            Robot.SetForm(POS_CUSTOMER_SIDE_FORM_TITLE);
            Robot.ClickButton("烤鯖魚押壽司\n$40元");
            Robot.AssertOtherFormEdit(POS_RESTAURANT_SIDE_FORM_TITLE, string.Empty, "test");

            // 更改分類
            Robot.SetForm(POS_RESTAURANT_SIDE_FORM_TITLE);
            Robot.SetComboBox("ComboBox", "dessert");
            Robot.AssertButtonEnable("Save", true);
            Robot.ClickButton("Save");
            Robot.SetForm(POS_CUSTOMER_SIDE_FORM_TITLE);
            string[] mealOne = { "X", "烤鯖魚押壽司", "dessert", "40", "1", "1", "40 NTD" };
            Robot.AssertDataGridViewByIndex("Table", "1", mealOne);
        }

        /// <summary>
        /// Tests that 新增餐點事件
        /// </summary>
        [TestMethod]
        public void AddNewMealTest()
        {
            Robot.ClickOtherFormButton(POS_RESTAURANT_SIDE_FORM_TITLE, "Add New Meal");
            Robot.SetForm(POS_RESTAURANT_SIDE_FORM_TITLE);
            Robot.AssertButtonEnable("Add", false);
            Robot.SetNewMeal();
            Robot.ClickButton("Browse...");
            Robot.SetImagePath();
            Robot.SetEdit(string.Empty, "test");
            Robot.ClickTabs();

            Robot.SetForm(POS_CUSTOMER_SIDE_FORM_TITLE);
            Robot.ClickButton("Next");
            Robot.ClickButton("1\n$1元");
            Robot.ClickButton("Add");
            string[] mealOne = { "X", "1", "rice", "1", "1", "1", "1 NTD" };
            Robot.AssertDataGridViewByIndex("Table", "2", mealOne);
        }

        /// <summary>
        /// Tests that 新增類別事件
        /// </summary>
        [TestMethod]
        public void AddNewCategory()
        {
            Robot.SetForm(POS_RESTAURANT_SIDE_FORM_TITLE);
            Robot.ClickTabControl("Category Manager");
            Robot.ClickButton("Add Category");
            Robot.AddNewCategory();
            Robot.SetForm(POS_CUSTOMER_SIDE_FORM_TITLE);
            Robot.ClickTabControl("1");
            Robot.SetForm(POS_RESTAURANT_SIDE_FORM_TITLE);
            Robot.ClickTabControl("Category Manager");
            string[] categoryOne = { "rice", "dessert", "drink", "1" };
            Robot.AssertListViewByValue(POS_RESTAURANT_SIDE_FORM_TITLE, categoryOne);

            // 編輯類別事件
            Robot.UpdateCategoryName();
            Robot.SetForm(POS_CUSTOMER_SIDE_FORM_TITLE);
            Robot.ClickTabControl("2");
        }

        /// <summary>
        /// Tests that 刪除類別事件
        /// </summary>
        [TestMethod]
        public void DeleteCategory()
        {
            Robot.SetForm(POS_RESTAURANT_SIDE_FORM_TITLE);
            Robot.ClickTabControl("Category Manager");
            Robot.ClickListViewByValue(POS_RESTAURANT_SIDE_FORM_TITLE, "dessert");
            Robot.ClickButton("Delete Selected Category");
            Robot.ClickListViewByValue(POS_RESTAURANT_SIDE_FORM_TITLE, "drink");
            Robot.ClickButton("Delete Selected Category");
            Robot.ClickTabControl("Meal Manager");
            string[] categoryOne = { "烤鯖魚押壽司", "稻荷天婦羅壽司", "鯖魚押壽司", "大甲葉花枝", "炙烤起司長鰭鯖魚", "特選長鰭鮪魚", "長鰭鮪魚", "炙烤鮪魚腹鱒魚卵", "柚子胡椒醃漬生鮮蝦", "炙烤照燒鮮蝦", "竹姬壽司蔥花鮪魚", "熟成鮪魚", "炙烤照燒鮭魚", "黃金酥脆捲", "酥脆炸蝦捲" };
            Robot.AssertListViewByValue(POS_RESTAURANT_SIDE_FORM_TITLE, categoryOne);
        }
    }
}
