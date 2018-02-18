using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication1 {
    class clsSupplier {
        public string supplierID, supplierName, contact, address, query;
        classDatabaseConnect dbcon = new classDatabaseConnect();
        public void InsertSupplier() {
            if (IsDuplicateSupplierName())
                System.Windows.Forms.MessageBox.Show("Supplier Name is existing. Please provide another one.", "Supplier");
            else {
                try {
                    dbcon.mysqlconnect.Open();
                    query = "INSERT INTO supplier SET supplier_name=@supplierName, supplier_contact=@contact, supplier_address=@address";
                    MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                    cmd.Parameters.AddWithValue("@supplierName", supplierName);
                    cmd.Parameters.AddWithValue("@contact",contact);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.CommandTimeout = 60;
                    cmd.ExecuteReader();
                    dbcon.mysqlconnect.Close();
                    System.Windows.Forms.MessageBox.Show("Added a new supplier", "Supplier");
                } catch (Exception) {
                    throw;
                }
            }
        }
        public void UpdateSupplier() {
            // to do: exempt the current prod id/name
            //if (IsDuplicateProdIdAndName())
            //    System.Windows.Forms.MessageBox.Show("Product ID/Name is existing. Please provide another one.", "Inventory");
            //else
            //{
            try {
                dbcon.mysqlconnect.Open();
                query = "UPDATE supplier SET supplier_name=@supplierName, supplier_contact=@contact, supplier_address=@address WHERE supplier_ID=@supplierID";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                cmd.Parameters.AddWithValue("@supplierName", supplierName);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@supplierID", supplierID);
                cmd.CommandTimeout = 60;
                cmd.ExecuteReader();
                dbcon.mysqlconnect.Close();
                System.Windows.Forms.MessageBox.Show("Updated supplier information", "Supplier");
            } catch (Exception) {
                throw;
            }
            //}
        }
        public void DeleteSupplier() {
            dbcon.mysqlconnect.Open();
            string query = "DELETE FROM supplier WHERE supplier_ID=@supplierID";
            MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
            cmd.Parameters.AddWithValue("@supplierID", supplierID);
            cmd.CommandTimeout = 60;
            cmd.ExecuteReader();
            dbcon.mysqlconnect.Close();
            System.Windows.Forms.MessageBox.Show("Deleted a supplier", "Supplier");
        }
        public bool IsDuplicateSupplierName() {
            dbcon.mysqlconnect.Open();
            query = "SELECT supplier_name FROM supplier WHERE supplier_name=@supplierName";
            MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
            cmd.Parameters.AddWithValue("@supplierName", supplierName);
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
