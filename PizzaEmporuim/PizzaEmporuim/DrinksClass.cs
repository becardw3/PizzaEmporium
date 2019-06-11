using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporuim
{
    public class DrinksClass : Product
    {
        public string DrinkID { get; set; }
        public string DrinkSize { get; set; }
        public string DrinkDescription { get; set; }

        public DrinksClass() { }

        public DrinksClass(string theID, string theSize, string theFlavor)
        {
            DrinkID = theID;
            DrinkSize = theSize;
            DrinkDescription = theFlavor;
        }

        public override string ToString()
        {
            string message = (DrinkPrice(DrinkSize).ToString("C2") + " : " + DrinkSize + " drink with " + DrinkDescription);
            return message;
        }
    }
}
