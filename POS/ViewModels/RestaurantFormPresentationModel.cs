using POS.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.ViewModels
{
    public class RestaurantFormPresentationModel
    {
        #region Attribute

        public SaleModel Sale
        {
            get;
            set;
        }

        public IDictionary<string, IList<Meal>> Categories
        {
            get;
            set;
        }

        public bool IsAddOrEditMeal
        {
            get;
            set;
        }

        public bool IsAddOrEditCategory
        {
            get;
            set;
        }

        public string RelativePath
        {
            get;
            set;
        }

        #endregion

        public RestaurantFormPresentationModel(SaleModel sale)
        {
            Sale = sale;
            SetCategories();
        }

        /// <summary>
        /// SetCategories
        /// </summary>
        public void SetCategories()
        {
            Categories = new Dictionary<string, IList<Meal>>();
            foreach (Category category in Sale.Categories)
            {
                Categories.Add(category.Name, new List<Meal>());
            }
            foreach (Meal meal in Sale.Meals)
            {
                Categories[meal.Category.Name].Add(meal);
            }
        }

        /// <summary>
        /// IsNameExist
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool IsMealNameExist(string name)
        {
            int count = 0;
            foreach (Meal meal in Sale.Meals)
            {
                if (meal.Name == name)
                {
                    count++;
                }
                if ((meal.Name == name && IsAddOrEditMeal) || (count > 1))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// AddMealButton
        /// </summary>
        /// <param name="meal"></param>
        public void AddOrEditMealButton(object oldMealName, Meal meal)
        {
            if (IsAddOrEditMeal)
            {
                Sale.Meals.Add(meal);
                return;
            }
            for (int i = 0; i < Sale.Meals.Count; i++)
            {
                SaveMealButton(oldMealName, meal, i);
            }
        }

        /// <summary>
        /// SaveMealButton
        /// </summary>
        public void SaveMealButton(object oldMealName, Meal meal, int index)
        {
            if (Sale.Meals[index].Name == oldMealName.ToString())
            {
                Sale.Meals[index] = meal;
            }
        }

        /// <summary>
        /// ClickDeleteSelectedCategory
        /// </summary>
        /// <param name="name"></param>
        public void ClickDeleteSelectedCategory(string name)
        {
            Sale.Categories.Remove(GetOldCategory(name));
            Categories.Remove(name);
            foreach (Meal meal in Sale.Meals.ToArray())
            {
                RemoveMeal(meal, meal.Category.Name, name);
            }
            foreach (Meal meal in Sale.Order.Orders.ToArray())
            {
                RemoveOrder(meal, meal.Category.Name, name);
            }
        }

        /// <summary>
        /// RemoveMeal
        /// </summary>
        /// <param name="categoryName"></param>
        /// <param name="compareName"></param>
        /// <param name="meal"></param>
        public void RemoveMeal(Meal meal, string categoryName, string compareName)
        {
            if (categoryName == compareName)
            {
                Sale.Meals.Remove(meal);
            }
        }

        /// <summary>
        /// RemoveOrder
        /// </summary>
        /// <param name="categoryName"></param>
        /// <param name="compareName"></param>
        /// <param name="meal"></param>
        public void RemoveOrder(Meal meal, string categoryName, string compareName)
        {
            if (categoryName == compareName)
            {
                Sale.Order.TotalPrice -= meal.UnitTotal;
                Sale.Order.Orders.Remove(meal);
            }
        }

        /// <summary>
        /// GetOldCategory
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Category GetOldCategory(string name)
        {
            return Sale.Categories.FirstOrDefault(c => c.Name == name);
        }

        /// <summary>
        /// IsNameExist
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool IsCategoryNameExist(object name)
        {
            return (Categories.ContainsKey(name.ToString()) && IsAddOrEditCategory);
        }

        /// <summary>
        /// AddOrEditCategory
        /// </summary>
        /// <param name="oldCategoryName"></param>
        /// <param name="newCategoryName"></param>
        public void AddOrEditCategory(object oldCategoryName, object newCategoryName)
        {
            if (IsAddOrEditCategory)
            {
                Categories.Add(newCategoryName.ToString(), new List<Meal>());
                Sale.Categories.Add(new Category(newCategoryName.ToString()));
            }
            else
            {
                Sale.Meals.Where(m => m.Category.Name == oldCategoryName.ToString()).ToList().ForEach(m => m.Category = new Category(newCategoryName.ToString()));
                Sale.Order.Orders.Where(m => m.Category.Name == oldCategoryName.ToString()).ToList().ForEach(m => m.Category = new Category(newCategoryName.ToString()));
                Sale.Categories.Where(c => c.Name == oldCategoryName.ToString()).ToList().ForEach(c => c.Name = newCategoryName.ToString());
                UpdateCategories(oldCategoryName.ToString(), newCategoryName.ToString());
            }
        }

        /// <summary>
        /// UpdateCategories
        /// </summary>
        /// <param name="oldName"></param>
        /// <param name="newName"></param>
        public void UpdateCategories(string oldName, string newName)
        {
            IList<string> categoryNames = new List<string>();
            foreach (KeyValuePair<string, IList<Meal>> categories in Categories)
            {
                string name = categories.Key == oldName ? newName : categories.Key;
                categoryNames.Add(name);
            }
            Categories = new Dictionary<string, IList<Meal>>();
            foreach (string name in categoryNames)
            {
                Categories.Add(name, new List<Meal>());
            }
            foreach (Meal meal in Sale.Meals)
            {
                Categories[meal.Category.Name].Add(meal);
            }
        }

        /// <summary>
        /// ClickBrowseButton
        /// </summary>
        /// <param name="name"></param>
        /// <param name="path"></param>
        public void ClickBrowseButton(string path)
        {
            string project = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            RelativePath = path.Replace(project, string.Empty);
        }
    }
}
