using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporuim
{
    public class PizzaClass : Product
    {
        public string PizzaID { get; set; }
        public string PizzaSize { get; set; }
        public string PizzaDescription { get; set; }
        //public double PizzaPrice = 0.0;

        public PizzaClass(){ }
        
        public PizzaClass(string theID, string theSize, string theToppings):base(theID, theSize, theToppings)
        {
            PizzaID = theID;
            PizzaSize = theSize;
            PizzaDescription = theToppings;
            productID = PizzaID;
            productSize = PizzaSize;
            productDescription = PizzaDescription;
            productPrice = Convert.ToDecimal(PizzaPrice(PizzaSize));
            
        }

        public override string ToString()
        {
            string message = (PizzaPrice(PizzaSize).ToString("C2") + " : " + PizzaSize + " pizza with " + PizzaDescription);
            return message;
        }
    }
}
