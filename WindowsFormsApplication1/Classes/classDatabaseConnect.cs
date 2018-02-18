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
        public static string address=Properties.Settings.Default.DbAddress;
        public MySql.Data.MySqlClient.MySqlConnection mysqlconnect = new MySql.Data.MySqlClient.MySqlConnection ("Server='"+address+"'; User Id=root; Password= ;Database=algdb");
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
                //System.Windows.Forms.MessageBox.Show(ex.Message);
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
                //System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
          public string[] authenticate(string un,string pw)
             {
            try
            {
                mysqlconnect.Open();
                string query = @"SELECT userID,gname,user_type,login_status FROM users WHERE username=@un AND password=@pw";
                MySqlCommand myCommand = new MySqlCommand(query,mysqlconnect);
                myCommand.Parameters.AddWithValue("@un", un);
                myCommand.Parameters.AddWithValue("@pw", pw);
                myCommand.CommandTimeout = 60;
                MySqlDataReader reader;
                reader = myCommand.ExecuteReader();

                string[] result = new string[4];
                if (reader.HasRows) {
                    while (reader.Read())
                    {
                        result = new string[4] { reader.GetString(0), reader.GetString(1), reader.GetString(2),reader.GetString(3) };
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
                //System.Windows.Forms.MessageBox.Show("Please Provide Ip Address of the Server");
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
