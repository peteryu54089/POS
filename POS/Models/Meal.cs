using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models
{
    public class Meal
    {
        #region Attribute

        public string Name
        {
            get;
            set;
        }

        public int UnitPrice
        {
            get;
            set;
        }

        public string Detail
        {
            get;
            set;
        }

        public string Image
        {
            get;
            set;
        }

        public bool Visible
        {
            get;
            set;
        }

        public Category Category
        {
            get;
            set;
        }

        public int Quantity
        {
            get;
            set;
        }

        public int UnitTotal
        {
            get;
            set;
        }

        #endregion

        public Meal(string name, int unitPrice, string detail, string image, string category)
        {
            Name = name;
            UnitPrice = unitPrice;
            Detail = detail;
            Image = image;
            Category = new Category(category);
            Quantity = 1;
            SetUnitTotal();
        }

        public Meal(object name, object unitPrice, object detail, object image, object category)
        {
            Name = name.ToString();
            UnitPrice = Convert.ToInt32(unitPrice);
            Detail = detail.ToString();
            Image = image.ToString();
            Category = new Category(category.ToString());
            Quantity = 1;
            SetUnitTotal();
        }

        /// <summary>
        /// SetUnitTotal
        /// </summary>
        public void SetUnitTotal()
        {
            UnitTotal = Quantity * UnitPrice;
        }
    }
}
