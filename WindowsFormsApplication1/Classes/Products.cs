using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication1
{
    class Products
    {
        public string prodNo, prodName, prodDesc, category, oilType, query;

        classDatabaseConnect dbcon = new classDatabaseConnect();
        public void InsertProduct()
        {
            if (IsDuplicateProdIdAndName())
                System.Windows.Forms.MessageBox.Show("Product ID/Name is existing. Please provide another one.", "Inventory");
            else
            {
                try
                {
                    dbcon.mysqlconnect.Open();
                    query = "INSERT INTO products SET product_ID=@prodNo, product_name=@prodName, product_desc=@prodDesc, oil_type=@oilType, category_ID=(SELECT category.category_ID FROM category WHERE category_name=@category)";
                    MySqlCommand cmd = new MySqlCommand(query,dbcon.mysqlconnect);
                    cmd.Parameters.AddWithValue("@prodNo", prodNo);
                    cmd.Parameters.AddWithValue("@prodName", prodName);
                    cmd.Parameters.AddWithValue("@prodDesc", prodDesc);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("oilType", oilType);
                    cmd.CommandTimeout = 60;
                    cmd.ExecuteReader();
                    dbcon.mysqlconnect.Close();
                    System.Windows.Forms.MessageBox.Show("Added a product", "Inventory");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public void UpdateProduct()
        {
            // to do: exempt the current prod id/name
            //if (IsDuplicateProdIdAndName())
            //    System.Windows.Forms.MessageBox.Show("Product ID/Name is existing. Please provide another one.", "Inventory");
            //else
            //{
                try
                {
                    dbcon.mysqlconnect.Open();
                    query = "UPDATE products SET product_name=@prodName, product_desc=@prodDesc, oil_type=@oilType, category_ID=(SELECT category.category_ID FROM category WHERE category_name=@category) WHERE product_ID=@prodNo";
                    MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                    cmd.Parameters.AddWithValue("@prodNo", prodNo);
                    cmd.Parameters.AddWithValue("@prodName", prodName);
                    cmd.Parameters.AddWithValue("@prodDesc", prodDesc);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("oilType", oilType);
                    cmd.CommandTimeout = 60;
                    cmd.ExecuteReader();
                    dbcon.mysqlconnect.Close();
                System.Windows.Forms.MessageBox.Show("Updated a product", "Inventory");
                }
                catch (Exception)
                {
                    throw;
                }
            //}
        }
        public void DeleteProduct()
        {
            dbcon.mysqlconnect.Open();
            string query = "DELETE FROM products WHERE product_ID=@prodNo";
            MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
            cmd.Parameters.AddWithValue("@prodNo", prodNo);
            cmd.CommandTimeout = 60;
            cmd.ExecuteReader();
            dbcon.mysqlconnect.Close();
            System.Windows.Forms.MessageBox.Show("Deleted a product", "Inventory");
        }
        public bool IsDuplicateProdIdAndName()
        {
            dbcon.mysqlconnect.Open();
            query = "SELECT product_ID, product_name FROM products WHERE product_ID=@prodNo OR product_name=@prodName";
            MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
            cmd.Parameters.AddWithValue("@prodNo",prodNo);
            cmd.Parameters.AddWithValue("@prodName",prodName);
            cmd.CommandTimeout = 60;
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            bool res;
            if (reader.HasRows) {
                res = true;
            } else {
                res = false;
            }
            dbcon.mysqlconnect.Close();
            if (res)
                return true;
            else
                return false;
        }
    }
}
