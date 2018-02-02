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
      
        public bool ManipulateData(string query)
        {
            try
            {
                mysqlconnect.Open();
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
          public string[] authenticate(string query)
             {
            try
            {
                mysqlconnect.Open();
                MySqlCommand myCommand = new MySqlCommand(query, mysqlconnect);
                myCommand.CommandTimeout = 60;
                MySqlDataReader reader;
                reader = myCommand.ExecuteReader();

                string[] result = new string[3];
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result = new string[3] { reader.GetString(0), reader.GetString(1), reader.GetString(2) };
                    }
                }else{
                    result = null;
                }

                mysqlconnect.Close();
                return result;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                // return false;   'no result is returned
                return null;
            }
        }
        public bool isDuplicate(string query)
        {
            try
            {
                mysqlconnect.Open();
                MySqlCommand myCommand = new MySqlCommand(query, mysqlconnect);
                myCommand.CommandTimeout = 60;
                MySqlDataReader reader;
                reader = myCommand.ExecuteReader();
                bool res;
                if (reader.HasRows)
                {
                    res= true;
                }
                else
                {
                    res = false;
                }
                mysqlconnect.Close();
                return res;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                // return false;   'no result is returned
                return true;
            }
        }
    }
}
