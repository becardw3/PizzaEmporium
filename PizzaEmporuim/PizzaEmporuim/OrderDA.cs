using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaEmporuim
{
    public class OrderDA
    {

        public static void AddOrder()
        {
            SqlConnection conn = OrderDB.GetConnection();

            //string insertStatement = "INSERT summerOrder (Id, SellDate, BranchName, TotalOrder)" +
            //    " values(@id, @sellDate, @branchName, @totalOrder)";
            string insertStatement = "INSERT summerOrder (SellDate, BranchName, TotalOrder)" +
    " values(@sellDate, @branchName, @totalOrder)";

            // need a command Object
            SqlCommand insertCommand = new SqlCommand(insertStatement, conn);

            //fill the parameters with values
            //insertCommand.Parameters.AddWithValue("@id", Order.Id);
            insertCommand.Parameters.AddWithValue("@sellDate", Order.SellDate);
            insertCommand.Parameters.AddWithValue("@branchName", Order.BranchName);
            insertCommand.Parameters.AddWithValue("@totalOrder", Order.TotalOrder);

            try
            {
                conn.Open();
                int numRows;
                numRows = insertCommand.ExecuteNonQuery();
                string selectStatement = "select Ident_Current('Id') from summerOrder";
                // command object
                SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

                int orderId = Convert.ToInt16(selectCommand.ExecuteScalar());

                Order.Id = orderId;


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
