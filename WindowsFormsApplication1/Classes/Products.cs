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
        public string prodNo, prodName, prodDesc, viscosity, oilType,brand, volume, unit, wheelType, query;

        classDatabaseConnect dbcon = new classDatabaseConnect();
        public bool InsertedProduct()
        {
            if (IsDuplicateProdId()) {
                System.Windows.Forms.MessageBox.Show("Product ID is existing. Please provide another one.", "Inventory");
                return false;
            } else {
                try {
                    dbcon.mysqlconnect.Open();
                    query = "INSERT INTO products SET product_ID=@prodNo, product_name=@prodName, product_desc=@prodDesc, oil_type=@oilType, brand_ID=(SELECT brand_ID from brand WHERE brand_name=@brand), wheel_type=@wheelType, volume=@volume, unit=@unit, viscosity_ID=(SELECT viscosity.viscosity_ID FROM viscosity WHERE viscosity_name=@viscosity)";
                    MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                    cmd.Parameters.AddWithValue("@prodNo", prodNo);
                    cmd.Parameters.AddWithValue("@prodName", prodName);
                    cmd.Parameters.AddWithValue("@prodDesc", prodDesc);
                    cmd.Parameters.AddWithValue("@viscosity", viscosity);
                    cmd.Parameters.AddWithValue("@oilType", oilType);
                    cmd.Parameters.AddWithValue("@wheelType", wheelType);
                    cmd.Parameters.AddWithValue("@brand", brand);
                    cmd.Parameters.AddWithValue("@volume", volume);
                    cmd.Parameters.AddWithValue("@unit", unit);
                    cmd.CommandTimeout = 60;
                    cmd.ExecuteReader();
                    System.Windows.Forms.MessageBox.Show("Added a product", "Inventory");
                    return true;
                } catch (Exception ex) {
                    System.Windows.Forms.MessageBox.Show("Error on adding a new product." + "/n" + "Error message: " + ex.Message);
                    return false;
                } finally {
                    dbcon.mysqlconnect.Close();
                }
            }
        }
        public bool UpdatedProduct()
        {
            /*to do: exempt the current prod id / name
            if (IsDuplicateProdIdAndName())
                System.Windows.Forms.MessageBox.Show("Product ID/Name is existing. Please provide another one.", "Inventory");
            else {
                if (IsDuplicateProdName()) {
                    System.Windows.Forms.MessageBox.Show("Product Name is existing. Please provide another one.", "Inventory");
                }*/
                try
                {
                    dbcon.mysqlconnect.Open();
                    query = "UPDATE products SET product_name=@prodName, product_desc=@prodDesc, oil_type=@oilType, brand_ID=(SELECT brand_ID from brand WHERE brand_name=@brand), wheel_type=@wheelType, volume=@volume, unit=@unit, viscosity_ID=(SELECT viscosity.viscosity_ID FROM viscosity WHERE viscosity_name=@viscosity) WHERE product_ID=@prodNo";
                    MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                    cmd.Parameters.AddWithValue("@prodNo", prodNo);
                    cmd.Parameters.AddWithValue("@prodName", prodName);
                    cmd.Parameters.AddWithValue("@prodDesc", prodDesc);
                    cmd.Parameters.AddWithValue("@viscosity", viscosity);
                    cmd.Parameters.AddWithValue("@oilType", oilType);
                    cmd.Parameters.AddWithValue("@wheelType", wheelType);
                    cmd.Parameters.AddWithValue("@brand", brand);
                    cmd.Parameters.AddWithValue("@volume", volume);
                    cmd.Parameters.AddWithValue("@unit", unit);
                    cmd.CommandTimeout = 60;
                    cmd.ExecuteReader();
                System.Windows.Forms.MessageBox.Show("Updated a product", "Inventory");
                    return true;
                } catch (Exception ex) {
                    System.Windows.Forms.MessageBox.Show("Error on updating a new product." + "/n" + "Error message: " + ex.Message);
                    return false;
                } finally {
                    dbcon.mysqlconnect.Close();
                }
        }
        public void DeleteProduct()
        {
            //to do: soft delete
            dbcon.mysqlconnect.Open();
            string query;
            MySqlCommand cmd;
            var now = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
            query = "UPDATE products SET product_ID='" + now + "' WHERE product_ID=@prodNo";
            cmd = new MySqlCommand(query, dbcon.mysqlconnect);
            cmd.Parameters.AddWithValue("@prodNo", prodNo);
            cmd.CommandTimeout = 60;
                    cmd.ExecuteReader();
            dbcon.mysqlconnect.Close();
            System.Windows.Forms.MessageBox.Show("Deleted a product", "Inventory",System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
        public System.Data.DataTable LoadData() {
            dbcon.mysqlconnect.Open();
            string query;
            query = "SELECT product_ID,product_name,brand_name,product_desc,viscosity_name,oil_type, wheel_type, volume,unit FROM products,viscosity,brand WHERE products.viscosity_ID=viscosity.viscosity_ID AND products.brand_ID=brand.brand_ID AND date_deleted IS NULL";

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, dbcon.mysqlconnect);
            System.Data.DataTable table = new System.Data.DataTable("myTable");
            mySqlDataAdapter.Fill(table);
            dbcon.mysqlconnect.Close();
            return table;
        }
        public bool IsDuplicateProdId(){
            dbcon.mysqlconnect.Open();
            query = "SELECT product_ID FROM products WHERE product_ID=@prodNo";
            MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
            cmd.Parameters.AddWithValue("@prodNo", prodNo);
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
            return res;
        }
        public bool IsDuplicateProdName() {
            dbcon.mysqlconnect.Open();
            query = "SELECT product_name FROM products WHERE product_ID=@prodNo ";
            MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
            cmd.Parameters.AddWithValue("@prodNo", prodNo);
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
                return res;
        }
    }
}
