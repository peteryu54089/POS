using DataGridViewNumericUpDownElements;
using POS.Models;
using POS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Views
{
    public partial class POSCustomerSideForm : Form
    {
        // for meal button
        private const int QUANTITY_CELL_INDEX = 5;
        private const string DASH = "_";
        private const string MEAL_BUTTON_NAME = "_mealButton";

        // for price
        private const string ENGLISH_UNIT = " NTD";

        // for cell
        private const string QUANTITY = "_quantity";
        private const string UNIT_NAME = "_unitName";
        private const string QUANTITY_VALUE = "_quantityValue";
        private const string UNIT_TOTAL = "_unitTotal";

        #region Attribute

        public CustomerFormPresentationModel Customer
        {
            get;
            set;
        }

        #endregion

        public POSCustomerSideForm(SaleModel sale)
        {
            InitializeComponent();
            Customer = new CustomerFormPresentationModel(sale);
            Customer.Sale._deleteMealEvent += new SaleModel.DeleteMealEventHandler(RefreshTabAndDataGrid);
            Customer.Sale._saveMealEvent += new SaleModel.SaveMealEventHandler(RefreshTabAndDataGrid);
            Customer.Sale._updateCategoryEvent += new SaleModel.UpdateCategoryEventHandler(RefreshTabAndDataGrid);
            RefreshTabAndDataGrid();
        }

        /// <summary>
        /// RefreshTabAndDataGrid
        /// </summary>
        public void RefreshTabAndDataGrid()
        {
            SetCategoryTabIndex();
            SetCategoryTab();
            SetDataGrid();
            SetPage();
        }

        /// <summary>
        /// 餐點總金額隨視窗大小縮放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ChangeTotalSize(object sender, EventArgs e)
        {
            _total.Font = new Font(_total.Font.FontFamily, _total.Height * 0.6f);
        }

        /// <summary>
        /// SetCategoryTabIndex
        /// </summary>
        public void SetCategoryTabIndex()
        {
            Customer.CategoryTabIndex = _categoryTab.SelectedIndex;
            Customer.SetNowPage();
        }

        /// <summary>
        /// 設定分類頁
        /// </summary>
        public void SetCategoryTab()
        {
            _categoryTab.Controls.Clear();
            foreach (KeyValuePair<string, int> nowPages in Customer.NowPages)
            {
                TabPage tabPage = new TabPage(nowPages.Key);
                tabPage.Name = DASH + nowPages.Key;
                tabPage.Text = nowPages.Key;
                _categoryTab.Controls.Add(tabPage);
            }
            _categoryTab.SelectedIndex = Customer.CategoryTabIndex;
            _categoryTab.SelectedIndex = _categoryTab.SelectedIndex == -1 ? 0 : _categoryTab.SelectedIndex;
            if (_categoryTab.TabPages.Count > 0)
            {
                _categoryTab.SelectedTab.Controls.Add(_mealList);
            }
        }

        /// <summary>
        /// SetDataGrid
        /// </summary>
        public void SetDataGrid()
        {
            _record.Rows.Clear();
            foreach (Meal meal in Customer.Sale.Order.Orders)
            {
                _record.Rows.Add(string.Empty, meal.Name, meal.Category.Name, meal.UnitPrice, meal.Quantity.ToString(), meal.Quantity, meal.UnitTotal + ENGLISH_UNIT);
                _record.CurrentCell = _record.Rows[0].Cells[QUANTITY];
                _record.Rows[0].Selected = true;
                _record.BeginEdit(true);
            }
            SetTotalPrice();
        }

        /// <summary>
        /// 設定餐點總金額
        /// </summary>
        public void SetTotalPrice()
        {
            Customer.SetTotalPrice();
            _total.Text = Customer.TotalPriceText;
        }

        /// <summary>
        /// 設定當前頁與總頁數並控制換頁按鈕可否點擊
        /// </summary>
        public void SetPage()
        {
            if (_categoryTab.TabPages.Count > 0)
            {
                if (_categoryTab.SelectedTab != null)
                {
                    Customer.SetPage(_categoryTab.SelectedTab.Name.Replace(DASH, string.Empty));
                }
                else
                {
                    Customer.SetPage(_categoryTab.TabPages[0].Name.Replace(DASH, string.Empty));
                }
            }
            else
            {
                Customer.SetPage(string.Empty);
            }
            RefreshPage();
            RefreshMealButton();
        }

        /// <summary>
        /// 刷新頁面
        /// </summary>
        public void RefreshPage()
        {
            _previous.Enabled = Customer.IsPreviousEnabled;
            _next.Enabled = Customer.IsNextEnabled;
            _add.Enabled = Customer.IsAddEnabled;
            _detail.Text = Customer.DetailText;
            _page.Text = Customer.PageText;
        }

        /// <summary>
        /// 刷新餐點按鈕
        /// </summary>
        public void RefreshMealButton()
        {
            foreach (Button mealButton in _mealList.Controls)
            {
                int index = Convert.ToInt32(mealButton.Name.Replace(MEAL_BUTTON_NAME, string.Empty));
                mealButton.Visible = Customer.Sale.MealButtons[index].Visible;
                mealButton.Text = Customer.Sale.MealButtons[index].Name;
                mealButton.BackgroundImage = Image.FromFile(Customer.Sale.MealButtons[index].Image);
            }
        }

        /// <summary>
        /// 點擊分類標籤觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickTab(object sender, EventArgs e)
        {
            if (_categoryTab.SelectedTab != null)
            {
                _categoryTab.SelectedTab.Controls.Add(_mealList);
                SetPage();
            }
        }

        /// <summary>
        /// 點擊前一頁按鈕觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickPrevious(object sender, EventArgs e)
        {
            Customer.ClickPrevious(_categoryTab.SelectedTab.Name.Replace(DASH, string.Empty));
            SetPage();
        }

        /// <summary>
        /// 點擊後一頁按鈕觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickNext(object sender, EventArgs e)
        {
            Customer.ClickNext(_categoryTab.SelectedTab.Name.Replace(DASH, string.Empty));
            SetPage();
        }

        /// <summary>
        /// 點擊餐點觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickMealButton(object sender, EventArgs e)
        {
            Customer.ClickMealButton((sender as Button).Text);
            _detail.Text = Customer.DetailText;
            _add.Enabled = Customer.IsAddEnabled;
            if (_record.CurrentCell != null)
            {
                _record.BeginEdit(true);
            }
        }

        /// <summary>
        /// 點擊添加餐點觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickAdd(object sender, EventArgs e)
        {
            if (!Customer.ClickAdd())
            {
                return;
            }
            _add.Enabled = Customer.IsAddEnabled;
            _detail.Text = Customer.DetailText;
            CreateOrUpdateRow();
            _record.BeginEdit(true);
            SetTotalPrice();
        }

        /// <summary>
        /// 判斷餐點是否存在以選擇創建或更新
        /// </summary>
        public void CreateOrUpdateRow()
        {
            if (!Customer.IsCreateOrUpdate)
            {
                AddNewMeal();
                return;
            }
            for (int i = 0; i < _record.Rows.Count; i++)
            {
                if (_record.Rows[i].Cells[UNIT_NAME].Value.ToString() == Customer.TempMeal.Name)
                {
                    SetQuantityAndUnitTotal(i);
                    _record.Rows[i].Selected = true;
                    _record.CurrentCell = _record.Rows[i].Cells[QUANTITY];
                    break;
                }
            }
        }

        /// <summary>
        /// AddNewMeal
        /// </summary>
        public void AddNewMeal()
        {
            _record.Rows.Add(string.Empty, Customer.TempMeal.Name, Customer.TempMeal.Category.Name, Customer.TempMeal.UnitPrice, Customer.TempMeal.Quantity.ToString(), Customer.TempMeal.Quantity, Customer.TempMeal.UnitTotal + ENGLISH_UNIT);
            _record.CurrentCell = _record.Rows[_record.Rows.Count - 1].Cells[QUANTITY];
        }

        /// <summary>
        /// SetQuantityAndUnitTotal
        /// </summary>
        public void SetQuantityAndUnitTotal(int index)
        {
            _record.Rows[index].Cells[QUANTITY_VALUE].Value = Customer.TempQuantity;
            _record.Rows[index].Cells[UNIT_TOTAL].Value = Customer.TempUnitTotal;
        }

        /// <summary>
        /// 更新餐點數量觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void UpdateCell(object sender, DataGridViewCellEventArgs e)
        {
            if (!(Customer != null && e.ColumnIndex == QUANTITY_CELL_INDEX && e.RowIndex >= 0))
            {
                return;
            }
            Customer.UpdateNumericUpDownCell(_record.Rows[e.RowIndex].Cells[UNIT_NAME].Value, _record.Rows[e.RowIndex].Cells[QUANTITY].Value);
            SetQuantityAndUnitTotal(e.RowIndex);
            SetTotalPrice();
        }

        /// <summary>
        /// 點擊刪除餐點觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickCell(object sender, DataGridViewCellEventArgs e)
        {
            if (Customer.ClickDeleteCell(e.RowIndex, e.ColumnIndex))
            {
                _record.Rows.RemoveAt(e.RowIndex);
                SetTotalPrice();
            }
            else if (e.RowIndex >= 0)
            {
                _record.CurrentCell = _record.Rows[e.RowIndex].Cells[QUANTITY];
                _record.BeginEdit(true);
            }
            if (e.ColumnIndex == QUANTITY_CELL_INDEX && e.RowIndex >= 0)
            {
                _record.EndEdit();
                _record.BeginEdit(true);
            }
        }
    }
}
