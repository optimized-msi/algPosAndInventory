using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication1 {
    class clsItems {
        classDatabaseConnect dbcon = new classDatabaseConnect();
        public List<string> CboItem() {
            dbcon.mysqlconnect.Open();
            string query = "SELECT product_name FROM products";
            MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
            cmd.CommandTimeout = 60;
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            List<string> myCollection = new List<string>();
            if (reader.HasRows) {
                while (reader.Read()) {

                    myCollection.Add(reader.GetString(0));
                }
                //drpCat.Items = myCollection.ToArray();
            }
            dbcon.mysqlconnect.Close();
            return myCollection;
        }
    }
}
