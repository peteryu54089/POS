using POS.Models;
using POS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Views
{
    public partial class POSRestaurantSideForm : Form
    {
        private const string CUSTOMER_SIDE_FORM = "POSCustomerSideForm";
        private const string IMAGE_FILTER = "Image|*.png;*.jpg;*.jpeg";
        private const string SAVE = "Save";
        private const string EDIT = "Edit";
        private const string ADD = "Add";
        private const string ERROR = "名稱已存在";

        #region Attribute

        public RestaurantFormPresentationModel Restaurant
        {
            get;
            set;
        }

        #endregion

        public POSRestaurantSideForm(SaleModel sale)
        {
            InitializeComponent();
            Restaurant = new RestaurantFormPresentationModel(sale);
            SetCategories();
        }

        /// <summary>
        /// SetCategories
        /// </summary>
        public void SetCategories()
        {
            foreach (Category category in Restaurant.Sale.Categories)
            {
                _mealCategory.Items.Add(category.Name);
                _categoryListBox.Items.Add(category.Name);
            }
            foreach (Meal meal in Restaurant.Sale.Meals)
            {
                _mealListBox.Items.Add(meal.Name);
            }
        }

        /// <summary>
        /// SelectListBoxItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectMealListBoxItem(object sender, EventArgs e)
        {
            if (_mealListBox.SelectedIndex >= 0)
            {
                Restaurant.IsAddOrEditMeal = false;
                _editMeal.Text = _editMeal.Text.Replace(ADD, EDIT);
                _deleteSelectedMeal.Enabled = true;
                _editMeal.Enabled = true;
                _mealImage.Enabled = false;
                _saveMealButton.Text = SAVE;
                _saveMealButton.Enabled = false;
                _mealName.Text = Restaurant.Sale.Meals[_mealListBox.SelectedIndex].Name;
                _mealPrice.Text = Restaurant.Sale.Meals[_mealListBox.SelectedIndex].UnitPrice.ToString();
                _mealImage.Text = Restaurant.Sale.Meals[_mealListBox.SelectedIndex].Image;
                _mealDescription.Text = Restaurant.Sale.Meals[_mealListBox.SelectedIndex].Detail;
                _mealCategory.SelectedIndex = Restaurant.Categories.Keys.ToList().IndexOf(Restaurant.Sale.Meals[_mealListBox.SelectedIndex].Category.Name);
            }
        }

        /// <summary>
        /// SelectListBoxItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectCategoryListBoxItem(object sender, EventArgs e)
        {
            if (_categoryListBox.SelectedIndex < 0)
            {
                return;
            }
            Restaurant.IsAddOrEditCategory = false;
            _editCategory.Text = _editCategory.Text.Replace(ADD, EDIT);
            _editCategory.Enabled = true;
            _saveCategoryButton.Text = SAVE;
            _saveCategoryButton.Enabled = false;
            _categoryName.Text = _categoryListBox.SelectedItem.ToString();
            SetMealsUsingThisCategory();
            _deleteSelectedCategory.Enabled = true;
        }

        /// <summary>
        /// SetMealsUsingThisCategory
        /// </summary>
        public void SetMealsUsingThisCategory()
        {
            if (!Restaurant.Categories.ContainsKey(_categoryName.Text))
            {
                return;
            }
            _mealsUsingThisCategory.Items.Clear();
            foreach (Meal meal in Restaurant.Categories[_categoryName.Text])
            {
                _mealsUsingThisCategory.Items.Insert(_mealsUsingThisCategory.Items.Count, meal.Name);
            }
        }

        /// <summary>
        /// ClickDeleteSelectedMeal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickDeleteSelectedMeal(object sender, EventArgs e)
        {
            string mealName = _mealListBox.SelectedItem.ToString();
            Restaurant.Sale.Meals.RemoveAt(_mealListBox.SelectedIndex);
            _mealListBox.Items.RemoveAt(_mealListBox.SelectedIndex);
            _deleteSelectedMeal.Enabled = false;
            _editMeal.Enabled = false;
            _mealName.Text = string.Empty;
            _mealPrice.Text = string.Empty;
            _mealImage.Text = string.Empty;
            _mealDescription.Text = string.Empty;
            _mealCategory.SelectedIndex = -1;
            Restaurant.SetCategories();
            Restaurant.Sale.RefreshCustomerSideFormAfterDeleteMeal(mealName);
        }

        /// <summary>
        /// SaveMealButton
        /// </summary>
        public void SaveMealButton(object sender, EventArgs e)
        {
            if (Restaurant.IsMealNameExist(_mealName.Text.ToString()))
            {
                MessageBox.Show(ERROR);
                return;
            }
            object oldMealName = _mealListBox.SelectedItem;
            Meal meal = new Meal(_mealName.Text, _mealPrice.Text, _mealDescription.Text, _mealImage.Text, _mealCategory.Text);
            Restaurant.AddOrEditMealButton(oldMealName, meal);
            AddOrEditMeal();
            Restaurant.SetCategories();
            Restaurant.Sale.RefreshCustomerSideFormAfterSaveMeal(oldMealName, meal);
            _editMeal.Enabled = false;
            _editMeal.Enabled = true;
            _saveMealButton.Enabled = false;
        }

        /// <summary>
        /// AddOrEditMeal
        /// </summary>
        public void AddOrEditMeal()
        {
            if (Restaurant.IsAddOrEditMeal)
            {
                _mealListBox.Items.Insert(_mealListBox.Items.Count, _mealName.Text.ToString());
                _mealListBox.SelectedItem = _mealListBox.Items[_mealListBox.Items.Count - 1];
            }
            else
            {
                int index = _mealListBox.Items.IndexOf(_mealListBox.SelectedItem.ToString());
                _mealListBox.Items.RemoveAt(index);
                _mealListBox.Items.Insert(index, _mealName.Text.ToString());
                _mealListBox.SelectedItem = _mealListBox.Items[index];
            }
        }

        /// <summary>
        /// SetMealsAfterUpdateCategories
        /// </summary>
        public void SetMealsAfterUpdateCategories()
        {
            _mealCategory.Items.Clear();
            _mealListBox.Items.Clear();
            foreach (KeyValuePair<string, IList<Meal>> categories in Restaurant.Categories)
            {
                _mealCategory.Items.Add(categories.Key);
            }
            foreach (Meal meal in Restaurant.Sale.Meals)
            {
                _mealListBox.Items.Add(meal.Name);
            }
        }

        /// <summary>
        /// ClickDeleteSelectedCategory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickDeleteSelectedCategory(object sender, EventArgs e)
        {
            Restaurant.ClickDeleteSelectedCategory(_categoryListBox.SelectedItem.ToString());
            _categoryListBox.Items.RemoveAt(_categoryListBox.SelectedIndex);
            _deleteSelectedCategory.Enabled = false;
            _editCategory.Enabled = false;
            _categoryName.Text = string.Empty;
            _mealsUsingThisCategory.Items.Clear();
            Restaurant.Sale.RefreshCustomerSideFormAfterUpdateCategory();
            SetMealsAfterUpdateCategories();
        }

        /// <summary>
        /// SaveCategoryButton
        /// </summary>
        public void SaveCategoryButton(object sender, EventArgs e)
        {
            if (Restaurant.IsCategoryNameExist(_categoryName.Text.ToString()))
            {
                MessageBox.Show(ERROR);
                return;
            }
            Restaurant.AddOrEditCategory(_categoryListBox.SelectedItem, _categoryName.Text);
            AddOrEditCategory();
            SetMealsAfterUpdateCategories();
            Restaurant.Sale.RefreshCustomerSideFormAfterUpdateCategory();
        }

        /// <summary>
        /// AddOrEditCategory
        /// </summary>
        public void AddOrEditCategory()
        {
            if (Restaurant.IsAddOrEditCategory)
            {
                _categoryListBox.Items.Insert(_categoryListBox.Items.Count, _categoryName.Text.ToString());
                _categoryListBox.SelectedItem = _categoryListBox.Items[_categoryListBox.Items.Count - 1];
            }
            else
            {
                int index = _categoryListBox.Items.IndexOf(_categoryListBox.SelectedItem.ToString());
                _categoryListBox.Items.RemoveAt(index);
                _categoryListBox.Items.Insert(index, _categoryName.Text.ToString());
                _categoryListBox.SelectedItem = _categoryListBox.Items[index];
            }
        }

        /// <summary>
        /// EnableSaveMealButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void EnableSaveMealButton(object sender, EventArgs e)
        {
            if (sender is TextBox || (sender is ComboBox && (sender as ComboBox).Focused))
            {
                _saveMealButton.Enabled = true;
            }
            DisableSaveMealButton(sender, e);
        }

        /// <summary>
        /// DisableSaveMealButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DisableSaveMealButton(object sender, EventArgs e)
        {
            IList<object> meal = new List<object>();
            meal.Add(_mealName);
            meal.Add(_mealPrice);
            meal.Add(_mealImage);
            foreach (TextBox attribute in meal)
            {
                if (string.IsNullOrWhiteSpace(attribute.Text.ToString()) || _mealCategory.SelectedIndex == -1 || !int.TryParse(_mealPrice.Text.ToString(), out int number))
                {
                    _saveMealButton.Enabled = false;
                }
            }
        }

        /// <summary>
        /// EnableSaveCategoryButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void EnableSaveCategoryButton(object sender, EventArgs e)
        {
            _saveCategoryButton.Enabled = true;
            DisableSaveCategoryButton(sender, e);
        }

        /// <summary>
        /// DisableSaveCategoryButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DisableSaveCategoryButton(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_categoryName.Text.ToString()))
            {
                _saveCategoryButton.Enabled = false;
            }
        }

        /// <summary>
        /// InputNumberOnly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputNumberOnly(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
