using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporuim
{
    public class SpecialsClass : Product
    {
        public string SpecialID { get; set; }
        public string SpecialType { get; set; }
        public string SpecialDescription { get; set; }

        public SpecialsClass() { }

        public SpecialsClass(string theID, string theType, string theOrder)
        {
            SpecialID = theID;
            SpecialType = theType;
            SpecialDescription = theOrder;
        }

        public override string ToString()
        {
            string message = (SpecialPrice(SpecialType).ToString("C2") + " : " + SpecialType);
            return message;
        }
    }
}
