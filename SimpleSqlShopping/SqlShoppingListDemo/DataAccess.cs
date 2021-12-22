using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace FORMUI
{
    public class DataAccess
    {
        // Retrieves everything in the DB as a List and returns the List.
        public List<ProductClass> GetProducts()
        {
            // Uses the Helper Class to access the Connection String and is how the program communicates with SQL
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ShoppingListDB")))
            {
                var output = connection.Query<ProductClass>("SELECT Product FROM Groceries").ToList();
                return output;
            }
        }

        // Adds any product typed into the search field to the DB, unless it's a duplicate
        public void AddProduct(string product)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ShoppingListDB")))
            {
                // if/else to look for duplicates
                var output = connection.Query<ProductClass>($"SELECT Product FROM Groceries WHERE Product ='{product}'").ToList();
                if (output.Count != 0)
                {
                    //Console.WriteLine("in DB");
                    MessageBox.Show("This product is already on your list!","Duplicate Error");
                    return;
                }
                else
                {
                    connection.Query<ProductClass>($"INSERT INTO [ShoppingList].[dbo].[Groceries] (Product) VALUES('{product}')");
                    //Console.WriteLine("not in DB");
                }
                return;
                
            }
        }

        // Functionality for the "Clear List" button.
        public void ClearList()
        {
            // Asks for confirmation from the User before truncating the table
            DialogResult res = MessageBox.Show("Are you sure you want to Remove EVERYTHING from the list?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                //Console.WriteLine("Truncated DB");
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ShoppingListDB")))
                {
                    connection.Query<ProductClass>("TRUNCATE TABLE dbo.Groceries");
                }

            }
            if (res == DialogResult.Cancel)
            {
                //Console.WriteLine("Did not truncate DB");
            }
            
        }

        // Finds the index of the checked items in the CheckedItemsList, and removes the matching items from the DB
        public void ClearChecked(string product)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ShoppingListDB")))
            {
                var output = connection.Query<ProductClass>($"DELETE FROM Groceries WHERE Product = '{ product }'");
                return;
            }

        }

      
    }
}
