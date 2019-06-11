using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporuim
{
    public class OrderDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=pizzaEmporium.db.2823567.hostedresource.com;Initial Catalog=pizzaEmporium;User ID=pizzaEmporium;Password=C#1434!spring";

            SqlConnection conn = new SqlConnection(connectionString);

            return conn;


        }
    }
}
