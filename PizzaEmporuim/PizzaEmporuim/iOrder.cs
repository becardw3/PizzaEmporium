using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporuim
{
    public interface iOrder
    {

        void AddItem();
        void SaveOrder();
        void DeleteItem();
        double CalculateTax();
        double TotalOrder();
    }
}
