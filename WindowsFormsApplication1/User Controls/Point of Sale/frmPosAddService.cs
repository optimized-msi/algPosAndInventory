using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmPosAddService : Form
    {
        classDatabaseConnect dbcon = new classDatabaseConnect(); string query = "";
        clsPosService clsposservice = new clsPosService();
        public frmPosAddService()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPosAddService_Load(object sender, EventArgs e)
        {
            LoadCheckList(); LoadServiceName();LoadVehicleType();
        }
        private void LoadCheckList()
        {
            checkedListBox.Items.Clear();
            string query = "SELECT CONCAT(emp_fName, ', ',emp_gName,' ,',emp_mInitial) FROM employee";
            dbcon.mysqlconnect.Open();
            MySqlCommand myCommand = new MySqlCommand(query, dbcon.mysqlconnect);
            myCommand.CommandTimeout = 60;
            MySqlDataReader reader;
            reader = myCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    checkedListBox.Items.Add(reader.GetString(0));
                }
            }
            dbcon.mysqlconnect.Close();
        }
        private void LoadServiceName()
        {
            string query = "SELECT service_name FROM service";
            dbcon.mysqlconnect.Open();
            MySqlCommand myCommand = new MySqlCommand(query, dbcon.mysqlconnect);
            myCommand.CommandTimeout = 60;
            MySqlDataReader reader;
            reader = myCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cboServiceName.Items.Add(reader.GetString(0));
                }
            }
            dbcon.mysqlconnect.Close();
        }
        private void LoadVehicleType()
        {
            string query = "SELECT vehicle_type FROM vehicle_type";
            dbcon.mysqlconnect.Open();
            MySqlCommand myCommand = new MySqlCommand(query, dbcon.mysqlconnect);
            myCommand.CommandTimeout = 60;
            MySqlDataReader reader;
            reader = myCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cboVehicleType.Items.Add(reader.GetString(0));
                }
            }
            dbcon.mysqlconnect.Close();
        }

        private void cboServiceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cboVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lblFee.Text == "")
                MessageBox.Show("Please choose a service for a vehicle type", "Point of sale");
            else if (txtPlateNo.Text == "")
            {
                MessageBox.Show("Please input the plate number of the vehicle", "Point of sale");
                txtPlateNo.Focus();
            }else if (checkedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select the employee/s that will service the vehicle", "Point of sale");
            }
            else
            {
                Checked();
                clsPosService.plateNo = txtPlateNo.Text; clsPosService.serviceName = cboServiceName.Text; clsPosService.vehicleType = cboVehicleType.Text; clsPosService.serviceFee = lblFee.Text;
                Close();
            }


        }
        private void Checked()
        {
            // Determine if there are any items checked.  
            if (checkedListBox.CheckedItems.Count != 0)
            {
                clsPosService.servicedBy = "";
                // If so, loop through all checked items and print results.  
                for (int x = 0; x <= checkedListBox.CheckedItems.Count - 1; x++)
                {
                    clsPosService.servicedBy=clsPosService.servicedBy + checkedListBox.CheckedItems[x].ToString() + "/";
                }
                //essageBox.Show(s);
            }
        }

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox.CheckedItems.Count != 0)
            {
                clsPosService.servicedBy = "";
                // If so, loop through all checked items and print results.  
                for (int x = 0; x <= checkedListBox.CheckedItems.Count - 1; x++)
                {
                    clsPosService.servicedBy = clsPosService.servicedBy + checkedListBox.CheckedItems[x].ToString() + "/";
                }
                //essageBox.Show(s);
            }
        }

        private void btnSelect_Click_1(object sender, EventArgs e)
        {

            if (lblFee.Text == "")
                MessageBox.Show("Please choose a service for a vehicle type", "Point of sale");
            else if (txtPlateNo.Text == "")
            {
                MessageBox.Show("Please input the plate number of the vehicle", "Point of sale");
                txtPlateNo.Focus();
            }
            else if (checkedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select the employee/s that will service the vehicle", "Point of sale");
            }
            else
            {
                Checked();
                clsPosService.plateNo = txtPlateNo.Text; clsPosService.serviceName = cboServiceName.Text; clsPosService.vehicleType = cboVehicleType.Text; clsPosService.serviceFee = lblFee.Text;
                Close();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void cboServiceName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT service_price_ID,service_fee FROM service_price,service,vehicle_type WHERE (SELECT service.service_ID FROM service WHERE service_name='" + cboServiceName.Text + "') = service_price.service_ID AND (SELECT vehicle_type.vehicletype_ID FROM vehicle_type WHERE vehicle_type='" + cboVehicleType.Text + "')=service_price.vehicletype_ID";
                dbcon.mysqlconnect.Open();
                MySqlCommand myCommand = new MySqlCommand(query, dbcon.mysqlconnect);
                myCommand.CommandTimeout = 60;
                MySqlDataReader reader;
                reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblFee.Text = (reader.GetString(0));
                    }
                }
                else
                    lblFee.Text = "";
                dbcon.mysqlconnect.Close();
            }
            catch (Exception)
            {
                lblFee.Text = "";
            }
        }

        private void cboVehicleType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT service_price_ID,service_fee FROM service_price,service,vehicle_type WHERE (SELECT service.service_ID FROM service WHERE service_name='" + cboServiceName.Text + "') = service_price.service_ID AND (SELECT vehicle_type.vehicletype_ID FROM vehicle_type WHERE vehicle_type='" + cboVehicleType.Text + "') = service_price.vehicletype_ID";
                dbcon.mysqlconnect.Open();
                MySqlCommand myCommand = new MySqlCommand(query, dbcon.mysqlconnect);
                myCommand.CommandTimeout = 60;
                MySqlDataReader reader;
                reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblFee.Text = (reader.GetString(1));
                        //(reader.GetString(0)); ->static variable to for the point of sale
                    }
                }
                else
                    lblFee.Text = "";
                dbcon.mysqlconnect.Close();
            }
            catch (Exception)
            {
                lblFee.Text = "";
            }
        }
    }
}
