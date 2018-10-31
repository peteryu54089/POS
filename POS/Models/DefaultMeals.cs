using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models
{
    public class DefaultMeals
    {
        private const char SPACE = ' ';
        private const string PATH = "\\Assets\\";
        private const string FILE = "\\default.txt";

        #region Attribute

        public string[] Prices
        {
            get;
            set;
        }

        public string[] Names
        {
            get;
            set;
        }

        public string[] Details
        {
            get;
            set;
        }

        public string[] Images
        {
            get;
            set;
        }

        public IList<Meal> Meals
        {
            get;
            set;
        }

        #endregion

        public DefaultMeals()
        {
            Meals = new List<Meal>();
        }

        public DefaultMeals(string category) : this()
        {
            string project = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            StreamReader file = new StreamReader(project + PATH + category + FILE);
            ReadFile(file, project);
            SetMeals(category);
        }

        /// <summary>
        /// ReadFile
        /// </summary>
        /// <param name="file"></param>
        /// <param name="project"></param>
        public void ReadFile(StreamReader file, string project)
        {
            while ((project = file.ReadLine()) != null)
            {
                Prices = Prices ?? SplitMeal(ref project);
                Names = Names ?? SplitMeal(ref project);
                Details = Details ?? SplitMeal(ref project);
                Images = Images ?? SplitMeal(ref project);
            }
        }

        /// <summary>
        /// 切割餐點資訊
        /// </summary>
        /// <param name="meal"></param>
        /// <returns></returns>
        public string[] SplitMeal(ref string meal)
        {
            string[] temp = meal != null ? meal.Split(SPACE) : null;
            meal = null;
            return temp;
        }

        /// <summary>
        /// SetMeals
        /// </summary>
        /// <param name="category"></param>
        public void SetMeals(string category)
        {
            for (int i = 0; i < Names.Count(); i++)
            {
                Meals.Add(new Meal(Names[i], Convert.ToInt32(Prices[i]), Details[i], Images[i], category));
            }
        }
    }
}
