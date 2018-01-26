using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication1
{
    class classDatabaseConnect
    {
        public MySql.Data.MySqlClient.MySqlConnection mysqlconnect = new MySql.Data.MySqlClient.MySqlConnection ("Server=127.0.0.1; User Id=root; Password= ;Database=algdb");
        public string x { set; get; }       
        public bool connectDatabase()
        {
            try
            {
                mysqlconnect.Open();
                mysqlconnect.Close();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool insertData()
        {
            try
            {
                mysqlconnect.Open();
                string query = "INSERT INTO student(name) VALUES('third')";
                MySqlCommand myCommand = new MySqlCommand(query, mysqlconnect);
                myCommand.CommandTimeout = 60;
                MySqlDataReader reader;
                reader = myCommand.ExecuteReader();
                mysqlconnect.Close();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
             public string authenticate(string query)
             {
            try
            {
                mysqlconnect.Open();
                MySqlCommand myCommand = new MySqlCommand(query, mysqlconnect);
                myCommand.CommandTimeout = 60;
                MySqlDataReader reader;
                reader = myCommand.ExecuteReader();

                string result = "";
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //the result of select query is in array so thou shalt save it in an array, duh
                        // like this: string[] row = {reader.GetString(0) , reader.GetString(1), ... reader.GetString(n)}
                        //for now, only one record is expected
                        result = reader.GetString(0);
                    }
                }else{
                    result = "Invalid";
                }

                mysqlconnect.Close();
                return result;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                // return false;   'no result is returned
                return "empty";
            }
        }
    }
}
