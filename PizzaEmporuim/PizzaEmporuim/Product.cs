using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporuim
{
    public abstract class Product
    {
        public static string productID { get; set; }
        public static string productSize { get; set; }
        public static string productDescription { get; set; }
        public static decimal productPrice;
        public static List<Decimal> allOrderPrices = new List<Decimal>();

        public Product() { }

        public Product(string theId, string theSize, string theDescription)
        {
            productID = theId;
            productSize = theSize;
            productDescription = theDescription;

        }
        public static decimal GetPrice()
        {
            decimal price = productPrice;

            return price;
        }

        public void SetPrice(List<Product> items)
        {
            if (productID == "Pizza")
            {
                productPrice = Convert.ToDecimal(PizzaPrice(productSize));
            }
            else if (productID == "Drink")
            {
                productPrice = Convert.ToDecimal(DrinkPrice(productSize));
            }
            else if (productID == "Salad")
            {
                productPrice = (Convert.ToInt16(productSize));
            }
            else if (productID == "Breadstick")
            {
                productPrice = Convert.ToDecimal(BreadstickPrice(productSize));
            }
            else if (productID == "Special")
            {
                productPrice = Convert.ToDecimal(SpecialPrice(productSize));
            }
            else if (productID == "Shirt")
            {
                productPrice = Convert.ToDecimal(ShirtPrice());
            }
        }

        public double ShirtPrice()
        {
            double price = 25.0;
            return price;
        }
        public double PizzaPrice(string size)
        {
            double price = 0.0;
            if (size == "Small")
            {
                price = 8.0;
            }
            else if (size == "Medium")
            {
                price = 12.0;
            }
            else if (size == "Large")
            {
                price = 16.0;
            }
            return price;
        }

        public double DrinkPrice(string size)
        {
            double price = 0.0;
            if (size == "Small")
            {
                price = 1.0;
            }
            else if (size == "Medium")
            {
                price = 1.5;
            }
            else if (size == "Large")
            {
                price = 2.0;
            }
            return price;
        }

        public double SaladPrice(int servings)
        {
            double price = 0.0;
            price = (servings * 2.0);
            return price;
        }

        public double BreadstickPrice(string count)
        {
            double price = 0.0;
            if (count == "Four")
            {
                price = 2.0;
            }
            else if (count == "Eight")
            {
                price = 4.0;
            }
            else if (count == "Twelve")
            {
                price = 5.0;
            }
            return price;
        }

        public double SpecialPrice(string type)
        {
            double price = 0.0;
            if (type == "Tuesday Special")
            {
                price = 10.0;
            }
            else if (type == "Dinner Special")
            {
                price = 15.75;
            }
            else if (type == "Party Special")
            {
                price = 65.0;
            }
            return price;
        }

        public override string ToString()
        {
            string message = (productPrice.ToString("C2") + " : " + productSize + " " + productID + " " + productDescription);
            return message;
        }
    }
}
