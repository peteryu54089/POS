using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models
{
    public class SaleModel
    {
        // RefreshCustomerSideFormAfterDeleteMeal
        public delegate void DeleteMealEventHandler();
        public event DeleteMealEventHandler _deleteMealEvent;

        // RefreshCustomerSideFormAfterSaveMeal
        public delegate void SaveMealEventHandler();
        public event SaveMealEventHandler _saveMealEvent;

        // RefreshCustomerSideFormAfterUpdateCategory
        public delegate void UpdateCategoryEventHandler();
        public event UpdateCategoryEventHandler _updateCategoryEvent;

        // for meal's button
        private const int MEAL_BUTTON_COUNT = 9;
        private const string START = "\n$";
        private const string UNIT = "元";

        // for meal's category
        private const string RICE = "rice";
        private const string DESSERT = "dessert";
        private const string DRINK = "drink";

        #region Attribute

        public IList<Meal> Meals
        {
            get;
            set;
        }

        public Order Order
        {
            get;
            set;
        }

        public int TotalPage
        {
            get;
            set;
        }

        public IList<Category> Categories
        {
            get;
            set;
        }

        public IList<Meal> MealButtons
        {
            get;
            set;
        }

        #endregion

        public SaleModel()
        {
            Meals = new List<Meal>();
            Order = new Order();
            Categories = new List<Category>();
            DefaultMeals();
            SetCategories();
            InitializeMealButtons();
        }

        /// <summary>
        /// 預設菜單
        /// </summary>
        public void DefaultMeals()
        {
            SetDefaultMeals(RICE);
            SetDefaultMeals(DESSERT);
            SetDefaultMeals(DRINK);
        }

        /// <summary>
        /// 設定預設菜單
        /// </summary>
        /// <param name="category"></param>
        public void SetDefaultMeals(string category)
        {
            DefaultMeals defaultMeals = new DefaultMeals(category);
            foreach (Meal meal in defaultMeals.Meals)
            {
                Meals.Add(meal);
            }
        }

        /// <summary>
        /// SetCategories
        /// </summary>
        public void SetCategories()
        {
            foreach (Meal meal in Meals)
            {
                Categories.Add(meal.Category);
                if (IsCategoryExist(meal))
                {
                    continue;
                }
            }
        }

        /// <summary>
        /// 檢查分類是否存在
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public bool IsCategoryExist(Meal meal)
        {
            int count = 0;
            foreach (Category category in Categories)
            {
                if (category.Name == meal.Category.Name)
                {
                    count++;
                }
                if (count > 1)
                {
                    Categories.Remove(meal.Category);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 初始餐點按鈕
        /// </summary>
        public void InitializeMealButtons()
        {
            MealButtons = new List<Meal>();
            for (int i = 0; i < MEAL_BUTTON_COUNT; i++)
            {
                MealButtons.Add(new Meal(string.Empty, 0, string.Empty, string.Empty, string.Empty));
            }
        }

        /// <summary>
        /// SetTotalPage
        /// </summary>
        /// <param name="category"></param>
        public void SetTotalPage(string category)
        {
            TotalPage = (Meals.Where(m => m.Category.Name == category).Count() / (MEAL_BUTTON_COUNT + 1)) + 1;
        }

        /// <summary>
        /// 設定餐點按鈕
        /// </summary>
        public void SetMealButtons(string category, int nowPage)
        {
            MealButtons.Where(m => m.Visible).ToList().ForEach(mm => mm.Visible = false);
            IList<Meal> meals = Meals.Where(m => m.Category.Name == category).ToList();
            for (int i = MEAL_BUTTON_COUNT * (nowPage - 1), j = 0; i < meals.Count && j < MEAL_BUTTON_COUNT; i++, j++)
            {
                MealButtons[i % MEAL_BUTTON_COUNT].Visible = true;
                MealButtons[i % MEAL_BUTTON_COUNT].Name = meals[i].Name + START + meals[i].UnitPrice + UNIT;
                MealButtons[i % MEAL_BUTTON_COUNT].Image = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + meals[i].Image;
            }
        }

        /// <summary>
        /// 點擊餐點觸發事件
        /// </summary>
        /// <param name="meals"></param>
        public void ClickMealButton(string button)
        {
            Order.SetTempOrder(Meals, button);
        }

        /// <summary>
        /// 更新NumericUpDownCell觸發事件
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public void UpdateNumericUpDownCell(string name, object mealQuantity)
        {
            int unitPrice = Order.GetTempUnitPrice(name);
            int quantity = Convert.ToInt32(mealQuantity);
            int sum = unitPrice * quantity;
            Order.UpdateTotalPrice(name, quantity);
            Order.Orders.FirstOrDefault(m => m.Name == name).Quantity = quantity;
            Order.Orders.FirstOrDefault(m => m.Name == name).UnitTotal = sum;
        }

        /// <summary>
        /// RefreshCustomerSideFormAfterDeleteMeal
        /// </summary>
        /// <param name="mealName"></param>
        public void RefreshCustomerSideFormAfterDeleteMeal(string mealName)
        {
            Order.DeleteByName(mealName);
            if (_deleteMealEvent != null)
            {
                _deleteMealEvent();
            }
        }

        /// <summary>
        /// RefreshCustomerSideFormAfterSaveMeal
        /// </summary>
        /// <param name="oldMealName"></param>
        /// <param name="meal"></param>
        public void RefreshCustomerSideFormAfterSaveMeal(object oldMealName, Meal meal)
        {
            foreach (Meal order in Order.Orders.ToArray())
            {
                Order.TotalPrice -= order.UnitTotal;
                SetBaseOrder(oldMealName, order, new Meal(meal.Name, meal.UnitPrice, meal.Detail, meal.Image, meal.Category.Name));
                Order.TotalPrice += order.UnitTotal;
            }
            if (_saveMealEvent != null)
            {
                _saveMealEvent();
            }
        }

        /// <summary>
        /// SetBaseOrder
        /// </summary>
        /// <param name="oldMealName"></param>
        /// <param name="order"></param>
        /// <param name="meal"></param>
        public void SetBaseOrder(object oldMealName, Meal order, Meal meal)
        {
            if (!(oldMealName != null && order.Name == oldMealName.ToString()))
            {
                return;
            }
            order.Name = meal.Name;
            order.UnitPrice = meal.UnitPrice;
            order.Category = meal.Category;
            order.Image = meal.Image;
            order.Detail = meal.Detail;
            order.SetUnitTotal();
        }

        /// <summary>
        /// RefreshCustomerSideFormAfterUpdateCategory
        /// </summary>
        public void RefreshCustomerSideFormAfterUpdateCategory()
        {
            if (_updateCategoryEvent != null)
            {
                _updateCategoryEvent();
            }
        }

        /// <summary>
        /// IsMealExistsInOrder
        /// </summary>
        /// <param name="mealIndex"></param>
        /// <returns></returns>
        public bool IsMealExistsInOrder(int mealIndex)
        {
            foreach (Meal meal in Order.Orders)
            {
                if (IsMealNameEqual(meal.Name, mealIndex))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// IsMealNameEqual
        /// </summary>
        /// <param name="mealName"></param>
        /// <param name="mealIndex"></param>
        /// <returns></returns>
        public bool IsMealNameEqual(string mealName, int mealIndex)
        {
            return mealName == Meals[mealIndex].Name;
        }
    }
}
