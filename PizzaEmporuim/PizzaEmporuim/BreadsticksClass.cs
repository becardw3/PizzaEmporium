using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporuim
{
    public class BreadsticksClass : Product
    {
        public string BreadstickID { get; set; }
        public string BreadstickCount { get; set; }
        public string BreadstickDescription { get; set; }

        public BreadsticksClass() { }

        public BreadsticksClass(string theID, string theCount, string theFlavor)
        {
            BreadstickID = theID;
            BreadstickCount = theCount;
            BreadstickDescription = theFlavor;
        }

        public override string ToString()
        {
            string message = (BreadstickPrice(BreadstickCount).ToString("C2") + " : " + BreadstickCount + " " + BreadstickDescription + " breadsticks");
            return message;
        }
    }
}
