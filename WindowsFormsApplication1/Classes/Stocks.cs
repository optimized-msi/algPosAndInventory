using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication1
{
    class Stocks
    {
        public string stock_ID,product_ID,received_date,stock_quantity,deduct,supplier,supplier_price,query;

        classDatabaseConnect dbcon = new classDatabaseConnect();
        public void InsertStocks()
        {
            if (IsDuplicateStockID())
            {
                System.Windows.Forms.MessageBox.Show("Product ID/Name is existing. Please provide another one.", "Inventory");
            }else
            {
                try
                {
                    dbcon.mysqlconnect.Open();
                    query = "INSERT INTO stock SET stock_ID=@stockID, product_ID=@productID, remaining_stocks=@stockQuantity, total_stocks=@stockQuantity, supplier_ID=(SELECT supplier_ID FROM supplier WHERE supplier_name=@supplier), supplier_price=@supplierPrice";
                    MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                    cmd.Parameters.AddWithValue("@stockID", stock_ID);
                    cmd.Parameters.AddWithValue("@productID", product_ID);
                    cmd.Parameters.AddWithValue("@stockQuantity", stock_quantity);
                    cmd.Parameters.AddWithValue("@supplier", supplier);
                    cmd.Parameters.AddWithValue("@supplierPrice", supplier_price);
                    cmd.CommandTimeout = 60;
                    cmd.ExecuteReader();
                    dbcon.mysqlconnect.Close();
                    System.Windows.Forms.MessageBox.Show("Added a stock", "Inventory");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public void RemoveZero()
        {
            try
            {
                string query = "DELETE FROM stock WHERE stock_quantity=0";
                dbcon.ManipulateData(query);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void UpdateStock()
        {
            try
            {
                Int16 remaining=0,total=0,remresult=0,totresult=0;
                dbcon.mysqlconnect.Open();
                query = "SELECT total_stocks,remaining_stocks FROM stock WHERE stock_ID=@stockID";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                cmd.Parameters.AddWithValue("@stockID", stock_ID);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        total = Convert.ToInt16(reader.GetString(0));
                        remaining = Convert.ToInt16(reader.GetString(1));
                    }
                }
                totresult =(Int16)( Convert.ToInt16(stock_quantity) + total);
                remresult = (Int16)(Convert.ToInt16(stock_quantity) + remaining);
                dbcon.mysqlconnect.Close();

                dbcon.mysqlconnect.Open();
                query = "UPDATE stock SET total_stocks=@totresult,remaining_stocks=@remresult WHERE stock_ID=@stockID ";
                MySqlCommand cmd1 = new MySqlCommand(query,dbcon.mysqlconnect);
                cmd1.Parameters.AddWithValue("@totresult", totresult);
                cmd1.Parameters.AddWithValue("@remresult", remresult);
                cmd1.Parameters.AddWithValue("@stockID", stock_ID);
                cmd1.ExecuteReader();
                dbcon.mysqlconnect.Close();
                System.Windows.Forms.MessageBox.Show("Updated a stock", "Inventory");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ChangePrice() {
            try {
                dbcon.mysqlconnect.Open();
                query = "UPDATE stock SET supplier_price=@supplierPrice WHERE stock_ID=@stockID ";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                cmd.Parameters.AddWithValue("@supplierPrice", supplier_price);
                cmd.Parameters.AddWithValue("@stockID", stock_ID);
                cmd.CommandTimeout = 60;
                cmd.ExecuteReader();
                dbcon.mysqlconnect.Close();
                System.Windows.Forms.MessageBox.Show("Updated a price", "Inventory");
            } catch (Exception) {
                throw;
            }
        }
        public void DeductStock()
        {
            try
            {
                int res = Convert.ToInt16(stock_quantity) - Convert.ToInt16(deduct);
                if(res<0)
                    System.Windows.Forms.MessageBox.Show("Deduction should be lower than available stocks.","Inventory");
                else
                {
                    dbcon.mysqlconnect.Open();
                    query = "UPDATE stock SET remaining_stocks=@stockQuantity WHERE stock_ID=@stockID ";
                    MySqlCommand cmd = new MySqlCommand(query,dbcon.mysqlconnect);
                    cmd.Parameters.AddWithValue("@stockQuantity", res);
                    cmd.Parameters.AddWithValue("@stockID", stock_ID);
                    cmd.CommandTimeout = 60;
                    cmd.ExecuteReader();
                    dbcon.mysqlconnect.Close();
                    System.Windows.Forms.MessageBox.Show("Updated a stock", "Inventory");
                }
                
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void DeleteStock()
        {
            dbcon.mysqlconnect.Open();
            query = "DELETE FROM stock WHERE stock_ID=@stockID ";
            MySqlCommand cmd = new MySqlCommand(query,dbcon.mysqlconnect);
            cmd.Parameters.AddWithValue("@stockID", stock_ID);
            cmd.CommandTimeout = 60;
            cmd.ExecuteReader();
            dbcon.mysqlconnect.Close();
            System.Windows.Forms.MessageBox.Show("Deleted a stock", "Inventory");
        }
        public bool IsDuplicateStockID()
        {
            query = "SELECT stock_ID FROM stock WHERE stock_ID=@stockID";
            dbcon.mysqlconnect.Open();
            MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
            cmd.Parameters.AddWithValue("@stockID", stock_ID);
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
