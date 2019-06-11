using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporuim
{
    public class SaladsClass : Product
    {
        public string SaladID { get; set; }
        public int SaladServings { get; set; }
        public string SaladType { get; set; }


        public SaladsClass() { }

        public SaladsClass(string theID, int theServings, string theType)
        {
            SaladID = theID;
            SaladServings = theServings;
            SaladType = theType;
        }

        public override string ToString()
        {
            string message = (SaladPrice(SaladServings).ToString("C2") + " : " + SaladServings + " servings of " + SaladType + " salad");
            return message;
        }
    }
}
