using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication1
{
    public class clsPosItems // to do: change name -clsPointOfSale
    {
        public static string totalItems,totalServices,discount, total,totalDisc,custID,transID;
        public static ListView lvItems = new ListView();
        public static ListView lvServices = new ListView();
        classDatabaseConnect dbcon = new classDatabaseConnect();
        public System.Data.DataTable LoadData(string itemCode) {
            dbcon.mysqlconnect.Open();
            string query = "SELECT products.product_ID,product_name,product_desc,TRUNCATE(discounted_price,2),discount FROM products,product_price,stock WHERE products.product_ID=product_price.product_ID AND products.product_ID=stock.product_ID AND products.product_ID='" + itemCode + "' HAVING SUM(remaining_stocks)>0";

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, dbcon.mysqlconnect);
            System.Data.DataTable table = new System.Data.DataTable("myTable");
            mySqlDataAdapter.Fill(table);
            dbcon.mysqlconnect.Close();
            return table;
        }
        public List<string> CboItem() {
            dbcon.mysqlconnect.Open();
            string query = "SELECT CONCAT(gName,' ', mInitial, '. ',fName) FROM customer";
            MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
            cmd.CommandTimeout = 60;
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            List<string> myCollection = new List<string>();
            if (reader.HasRows) {
                while (reader.Read()) {
                    myCollection.Add(reader.GetString(0));
                }
            }
            dbcon.mysqlconnect.Close();
            return myCollection;
        }
        public List<string> CustInf(string custName) {
            string query = "SELECT customer_ID, contact_num, address FROM customer WHERE CONCAT(gName,' ', mInitial, '. ',fName) = '" + custName +"'";
            List<string> myCollection = new List<string>();
            myCollection = SelectRow(query);
            return myCollection;
        }
        public List<string> SelectInvoiceNo() {
            string query = "SELECT MAX(transac_ID)+1 FROM transaction";
            List<string> myCollection = new List<string>();
            myCollection = SelectRow(query);
            if (myCollection.Count==0) {
                myCollection.Add("10000001");
            } 
            return myCollection;
        }
        private List<string> SelectRow(string query) {
            dbcon.mysqlconnect.Open();
            MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
            cmd.CommandTimeout = 60;
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            List<string> myCollection = new List<string>();
            if (reader.HasRows) {
                while (reader.Read()) {
                    if (reader.IsDBNull(0)) ;
                    //myCollection.Add(null);
                    else {
                        for (int i = 0; i < reader.FieldCount; i++)
                            myCollection.Add(reader.GetString(i));
                    }
                }
            }
            dbcon.mysqlconnect.Close();
            return myCollection;
        }
    }
}
