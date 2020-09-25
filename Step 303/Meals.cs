using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_303
{
    public class meal
    {
        public meal(string mainChoice) : this(mainChoice, "Coffee")
        {
        }
        public meal(string mainChoice, string beverage)
        {
            Drink = beverage;
            mainCourse = mainChoice;
        }
        public string Drink { get; set; }
        public string mainCourse { get; set; }
        public string Side { get; set; }
        public int Price { get; set; }

    }
}
