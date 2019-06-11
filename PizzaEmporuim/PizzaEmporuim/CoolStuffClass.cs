using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporuim
{
    public class CoolStuffClass : Product
    {
        public string ShirtID { get; set; }
        public string ShirtSize { get; set; }
        public string ShirtDescription { get; set; }


        public CoolStuffClass() { }

        public CoolStuffClass(string theID, string theSize, string theDesc)
        {
            ShirtID = theID;
            ShirtSize = theSize;
            ShirtDescription = theDesc;
        }

        public override string ToString()
        {
            string message = (ShirtPrice().ToString("C2") + " : " + ShirtSize + " " + ShirtDescription);
            return message;
        }
    }
}
