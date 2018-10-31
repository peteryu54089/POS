using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models
{
    public class Order
    {
        #region Attribute

        public int TotalPrice
        {
            get;
            set;
        }

        public Meal TempOrder
        {
            get;
            set;
        }

        public IList<Meal> Orders
        {
            get;
            set;
        }

        public string TempMealName
        {
            get;
            set;
        }

        public int TempMealPrice
        {
            get;
            set;
        }

        #endregion

        public Order()
        {
            Orders = new List<Meal>();
        }

        /// <summary>
        /// 設定點選餐點
        /// </summary>
        /// <param name="meals"></param>
        /// <param name="order"></param>
        public void SetTempOrder(IList<Meal> meals, string order)
        {
            const char WRAP = '\n';
            string orderName = order.Remove(order.IndexOf(WRAP), order.Length - order.IndexOf(WRAP));
            Meal meal = meals.FirstOrDefault(m => m.Name == orderName);
            TempOrder = new Meal(meal.Name, meal.UnitPrice, meal.Detail, meal.Image, meal.Category.Name);
        }

        /// <summary>
        /// 新增餐點
        /// </summary>
        public bool Create()
        {
            if (TempOrder != null)
            {
                TempMealName = TempOrder.Name;
                TempMealPrice = TempOrder.UnitPrice;
                if (Orders.Where(o => o.Name == TempMealName).Count() > 0)
                {
                    SetQuantityAndUnitTotal();
                }
                else
                {
                    Orders.Add(TempOrder);
                }
                TotalPrice += TempOrder.UnitTotal;
                TempOrder = null;
                return true;
            }
            return false;
        }

        /// <summary>
        /// SetQuantityAndUnitTotal
        /// </summary>
        public void SetQuantityAndUnitTotal()
        {
            Orders.FirstOrDefault(o => o.Name == TempMealName).Quantity++;
            Orders.FirstOrDefault(o => o.Name == TempMealName).UnitTotal += TempMealPrice;
        }

        /// <summary>
        /// 刪除餐點
        /// </summary>
        public void DeleteByIndex(int index)
        {
            if (Orders.Count > index)
            {
                TotalPrice -= Orders.ElementAt(index).UnitTotal;
                Orders.RemoveAt(index);
            }
        }

        /// <summary>
        /// DeleteByName
        /// </summary>
        /// <param name="mealName"></param>
        public void DeleteByName(string mealName)
        {
            foreach (Meal meal in Orders.ToArray())
            {
                if (meal.Name != mealName)
                {
                    continue;
                }
                TotalPrice -= meal.UnitTotal;
                Orders.Remove(meal);
            }
        }

        /// <summary>
        /// GetTempQuantity
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetTempQuantity(string name)
        {
            foreach (Meal meal in Orders)
            {
                TempMealName = meal.Name;
                if (IsNameEqual(name))
                {
                    return meal.Quantity.ToString();
                }
            }
            return string.Empty;
        }

        /// <summary>
        /// GetTempUnitTotal
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int GetTempUnitTotal(string name)
        {
            foreach (Meal meal in Orders)
            {
                TempMealName = meal.Name;
                if (IsNameEqual(name))
                {
                    return meal.UnitTotal;
                }
            }
            return 0;
        }

        /// <summary>
        /// GetTempUnitPrice
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int GetTempUnitPrice(string name)
        {
            foreach (Meal meal in Orders)
            {
                TempMealName = meal.Name;
                if (IsNameEqual(name))
                {
                    return meal.UnitPrice;
                }
            }
            return 0;
        }

        /// <summary>
        /// IsNameEqual
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool IsNameEqual(string name)
        {
            return TempMealName == name;
        }

        /// <summary>
        /// UpdateTotalPrice
        /// </summary>
        /// <param name="name"></param>
        /// <param name="quantity"></param>
        public void UpdateTotalPrice(string name, int quantity)
        {
            TotalPrice = TotalPrice - GetTempUnitTotal(name) + GetTempUnitPrice(name) * quantity;
        }
    }
}
