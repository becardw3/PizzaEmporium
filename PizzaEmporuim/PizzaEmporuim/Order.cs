using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporuim
{
    public static class Order
    {
        //CalculateTax()
        //TotalOrder()
        //AddItem()
        //SaveOrder()
        //DeleteItem()
        //Id, SellDate, BranchName, TotalOrder
        public static int theId = 665;
        public static int Id = orderId();
        public static DateTime SellDate = orderSellDate();
        public static string BranchName = orderBranchName();
        public static decimal TotalOrder = CalculateTax(CalculateTotal());

        public static int orderId()
        {
            theId++;
            return theId;
        }
        public static DateTime orderSellDate()
        {
            DateTime today = DateTime.Today;
            return today;
        }
        public static string orderBranchName()
        {
            string branchName = "BenCardwell";
            return branchName;
        }

        public static decimal CalculateTax(decimal total)
        {
            decimal tax = .07m;
            total = ((total * tax) + total);
            return total;
        }

        public static decimal CalculateTotal()
        {
            decimal total = 0.0m;
            List<decimal> items = Product.allOrderPrices;
            foreach (decimal d in items)
            {
                total += d;
            }
            CalculateTax(total);
            return total;
        }
    }
}
