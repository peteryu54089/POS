using POS.Models;
using POS.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.ViewModels
{
    public class CustomerFormPresentationModel
    {
        // for meal's button
        public const int MEAL_BUTTON_COUNT = 9;
        public const int QUANTITY_CELL_INDEX = 5;

        // for meal's page
        public const string PAGE = "Page: ";
        public const string SLASH = "/";

        // for meal's price
        public const string TOTAL = "Total: ";
        public const string START = "\n$";
        public const string UNIT = "元";
        public const string ENGLISH_UNIT = " NTD";

        // for meal's picture
        public const string PATH = "\\Assets\\";
        public const string FILE = ".png";

        #region Attribute

        public SaleModel Sale
        {
            get;
            set;
        }

        public IDictionary<string, int> NowPages
        {
            get;
            set;
        }

        public string TotalPriceText
        {
            get;
            set;
        }

        public bool IsPreviousEnabled
        {
            get;
            set;
        }

        public bool IsNextEnabled
        {
            get;
            set;
        }

        public bool IsAddEnabled
        {
            get;
            set;
        }

        public string DetailText
        {
            get;
            set;
        }

        public string PageText
        {
            get;
            set;
        }

        public int CategoryTabIndex
        {
            get;
            set;
        }

        public Meal TempMeal
        {
            get;
            set;
        }

        public int TempOrdersCount
        {
            get;
            set;
        }

        public object TempQuantity
        {
            get;
            set;
        }

        public object TempUnitTotal
        {
            get;
            set;
        }

        public bool IsCreateOrUpdate
        {
            get;
            set;
        }

        #endregion

        public CustomerFormPresentationModel(SaleModel sale)
        {
            Sale = sale;
            SetNowPage();
        }

        /// <summary>
        /// 設定當前頁
        /// </summary>
        public void SetNowPage()
        {
            NowPages = new Dictionary<string, int>();
            foreach (Category category in Sale.Categories)
            {
                NowPages.Add(category.Name, 1);
            }
        }

        /// <summary>
        /// 設定餐點總金額
        /// </summary>
        public void SetTotalPrice()
        {
            TotalPriceText = TOTAL + Sale.Order.TotalPrice + UNIT;
        }

        /// <summary>
        /// 設定當前頁與總頁數並控制換頁按鈕可否點擊
        /// </summary>
        /// <param name="page"></param>
        public void SetPage(string category)
        {
            Sale.SetTotalPage(category);
            IsPreviousEnabled = false;
            IsNextEnabled = false;
            IsAddEnabled = false;
            DetailText = string.Empty;
            PageText = PAGE + 1 + SLASH + 1;
            Sale.SetMealButtons(category, 1);
            if (NowPages.ContainsKey(category))
            {
                IsPreviousEnabled = NowPages[category] != 1;
                IsNextEnabled = NowPages[category] != Sale.TotalPage;
                PageText = PAGE + NowPages[category] + SLASH + Sale.TotalPage;
                Sale.SetMealButtons(category, NowPages[category]);
            }
        }

        /// <summary>
        /// 點擊前一頁按鈕觸發事件
        /// </summary>
        public void ClickPrevious(string category)
        {
            Sale.Order.TempOrder = null;
            NowPages[category]--;
        }

        /// <summary>
        /// 點擊後一頁按鈕觸發事件
        /// </summary>
        public void ClickNext(string category)
        {
            Sale.Order.TempOrder = null;
            NowPages[category]++;
        }

        /// <summary>
        /// 點擊餐點觸發事件
        /// </summary>
        /// <param name="button"></param>
        public void ClickMealButton(string button)
        {
            Sale.ClickMealButton(button);
            DetailText = Sale.Order.TempOrder.Detail;
            IsAddEnabled = true;
        }

        /// <summary>
        /// 點擊添加餐點觸發事件
        /// </summary>
        public bool ClickAdd()
        {
            TempMeal = Sale.Order.TempOrder;
            TempOrdersCount = Sale.Order.Orders.Count;
            if (!Sale.Order.Create())
            {
                return false;
            }
            IsAddEnabled = false;
            DetailText = string.Empty;
            SetIsCreateOrUpdate();
            SetQuantityAndUnitTotal(TempMeal.Name);
            return true;
        }

        /// <summary>
        /// SetIsCreateOrUpdate
        /// </summary>
        public void SetIsCreateOrUpdate()
        {
            IsCreateOrUpdate = TempOrdersCount == Sale.Order.Orders.Count;
        }

        /// <summary>
        /// SetQuantityAndUnitTotal
        /// </summary>
        public void SetQuantityAndUnitTotal(string name)
        {
            TempQuantity = Sale.Order.GetTempQuantity(name);
            TempUnitTotal = Sale.Order.GetTempUnitTotal(name) + ENGLISH_UNIT;
        }

        /// <summary>
        /// 更新NumericUpDownCell觸發事件
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public void UpdateNumericUpDownCell(object mealName, object quantity)
        {
            string name = mealName.ToString();
            Sale.UpdateNumericUpDownCell(name, quantity);
            SetQuantityAndUnitTotal(name);
        }

        /// <summary>
        /// 點擊刪除餐點觸發事件
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public bool ClickDeleteCell(int row, int column)
        {
            if (column == 0 && row >= 0)
            {
                Sale.Order.DeleteByIndex(row);
                return true;
            }
            return false;
        }
    }
}
