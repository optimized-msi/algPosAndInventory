using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Stocks
    {
        public string stock_ID,product_ID,received_date,stock_quantity,deduct ,query;

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
                    DateTime time;
                    DateTime.TryParse(received_date, out time);
                    query = "INSERT INTO stock(stock_ID,product_ID,stock_quantity) VALUES('" + stock_ID + "','" + product_ID + "','" + stock_quantity + "')";
                    dbcon.ManipulateData(query);
                    System.Windows.Forms.MessageBox.Show("Added a stock", "Inventory");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public void UpdateStock()
        {
            try
            {
                query = "UPDATE stock SET stock_quantity='"+stock_quantity+"' WHERE stock_ID='"+stock_ID+"' ";
                dbcon.ManipulateData(query);
                System.Windows.Forms.MessageBox.Show("Updated a stock", "Inventory");
            }
            catch (Exception)
            {
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
                    query = "UPDATE stock SET stock_quantity='" + res + "' WHERE stock_ID='" + stock_ID + "' ";
                dbcon.ManipulateData(query);
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
            string query = "DELETE FROM stock WHERE stock_ID='" + stock_ID + "'";
            dbcon.ManipulateData(query);
            System.Windows.Forms.MessageBox.Show("Deleted a stock", "Inventory");
        }
        public bool IsDuplicateStockID()
        {
            query = "SELECT stock_ID FROM stock WHERE stock_ID='" + stock_ID + "'";
            if (dbcon.isDuplicate(query))
                return true;
            else
                return false;
                
        }
    }
}
