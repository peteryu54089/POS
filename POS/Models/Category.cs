﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models
{
    public class Category
    {
        #region Attribute

        public string Name
        {
            get;
            set;
        }

        #endregion

        public Category(string name)
        {
            Name = name;
        }
    }
}
