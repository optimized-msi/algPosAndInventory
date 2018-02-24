using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication1 {
    class clsProductPrice {
        public string productID, productPrice, discount, discountedPrice, query;
        public bool isPriceSet;
        classDatabaseConnect dbcon = new classDatabaseConnect();
        //to do: compute for the discountedPrice
        public void SetProductPrice() {
            if (!isPriceSet) {
                //====== insert product price
                try {
                    dbcon.mysqlconnect.Open();
                    query = "INSERT INTO product_price SET product_ID=@productID, product_price=@productPrice, discount=@discount, discounted_price=@discountedPrice";
                    MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                    cmd.Parameters.AddWithValue("@productID", productID);
                    cmd.Parameters.AddWithValue("@productPrice", productPrice);
                    cmd.Parameters.AddWithValue("@discount", discount);
                    cmd.Parameters.AddWithValue("@discountedPrice", discountedPrice);
                    cmd.CommandTimeout = 60;
                    cmd.ExecuteReader();
                    System.Windows.Forms.MessageBox.Show("Added product Price", "Inventory");
                } catch (Exception) {
                    System.Windows.Forms.MessageBox.Show("Error on setting price");
                } finally {
                    dbcon.mysqlconnect.Close();
                }
            } else {
                //====== UPDATE product price
                try {
                    dbcon.mysqlconnect.Open();
                    query = "UPDATE product_price SET product_price=@productPrice, discount=@discount, discounted_price=@discountedPrice WHERE product_ID=@productID";
                    MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                    cmd.Parameters.AddWithValue("@productID", productID);
                    cmd.Parameters.AddWithValue("@productPrice", productPrice);
                    cmd.Parameters.AddWithValue("@discount", discount);
                    cmd.Parameters.AddWithValue("@discountedPrice", discountedPrice);
                    cmd.CommandTimeout = 60;
                    cmd.ExecuteReader();
                    System.Windows.Forms.MessageBox.Show("Added product Price", "Inventory");
                } catch (Exception) {
                    throw;
                } finally {
                    dbcon.mysqlconnect.Close();
                }
            }
                
            }
    }
}
