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
        /// <summary>
        /// ClickBrowseButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickBrowseButton(object sender, EventArgs e)
        {
            OpenFileDialog openImageDialog = new OpenFileDialog();
            string project = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            openImageDialog.InitialDirectory = project;
            openImageDialog.Multiselect = false;
            openImageDialog.Filter = IMAGE_FILTER;
            DialogResult result = openImageDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Restaurant.ClickBrowseButton(openImageDialog.FileName);
                _mealImage.Text = Restaurant.RelativePath;
                _saveMealButton.Enabled = true;
            }
        }

        /// <summary>
        /// ClickAddNewMeal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickAddNewMeal(object sender, EventArgs e)
        {
            Restaurant.IsAddOrEditMeal = true;
            _mealListBox.ClearSelected();
            _deleteSelectedMeal.Enabled = false;
            _editMeal.Text = _editMeal.Text.Replace(EDIT, ADD);
            _editMeal.Enabled = true;
            _mealImage.Enabled = false;
            _saveMealButton.Text = ADD;
            _saveMealButton.Enabled = false;
            _mealName.Clear();
            _mealPrice.Clear();
            _mealImage.Clear();
            _mealDescription.Clear();
            SetCategoryIndex();
        }

        /// <summary>
        /// ClickAddNewCategory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickAddNewCategory(object sender, EventArgs e)
        {
            Restaurant.IsAddOrEditCategory = true;
            _categoryListBox.ClearSelected();
            _deleteSelectedCategory.Enabled = false;
            _editCategory.Text = _editCategory.Text.Replace(EDIT, ADD);
            _editCategory.Enabled = true;
            _saveCategoryButton.Text = ADD;
            _saveCategoryButton.Enabled = false;
            _categoryName.Clear();
            _mealsUsingThisCategory.Items.Clear();
        }

        /// <summary>
        /// SetCategoryIndex
        /// </summary>
        public void SetCategoryIndex()
        {
            if (Restaurant.Sale.Meals.Count > 0)
            {
                _mealCategory.SelectedIndex = 0;
            }
            else
            {
                _mealCategory.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// SelectTab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectTab(object sender, EventArgs e)
        {
            _editMeal.Enabled = false;
            _editCategory.Enabled = false;
            _mealListBox.SelectedIndex = -1;
            _categoryListBox.SelectedIndex = -1;
            _mealsUsingThisCategory.Items.Clear();
            _mealCategory.SelectedIndex = -1;
            _deleteSelectedMeal.Enabled = false;
            _deleteSelectedCategory.Enabled = false;
            _categoryName.Text = string.Empty;
            _mealName.Text = string.Empty;
            _mealPrice.Text = string.Empty;
            _mealImage.Text = string.Empty;
            _mealDescription.Text = string.Empty;
        }
    }
}
