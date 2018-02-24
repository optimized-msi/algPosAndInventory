using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication1
{
    public partial class ucServices : UserControl
    {
        classDatabaseConnect dbcon = new classDatabaseConnect(); bool sadd = false, sedit = false, padd = false, pedit = false, tadd = false, tedit = false;

        private void btnSAdd_Click(object sender, EventArgs e)
        {
            sadd = true; btnSAdd.Enabled = false; btnSSave.Enabled = true; txtServiceName.Enabled = true;
        }

        private void btnSDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this service?", "Services", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                query = "DELETE FROM service WHERE service_ID='" + txtServiceID.Text + "'";
                dbcon.ManipulateData(query);
                MessageBox.Show("Deleted a service", "Service");
                btnSClear.PerformClick();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnSEdit_Click(object sender, EventArgs e)
        {
            btnSEdit.Enabled = false; btnSSave.Enabled = true; sedit = true; btnSDelete.Enabled = false; txtServiceName.Enabled = true;
        }

        private void btnSSave_Click(object sender, EventArgs e)
        {
            if (txtServiceName.Text.Trim() == "")
            {
                MessageBox.Show("Please provide a service name");
                txtServiceName.Focus();
            }
            else
            {
                string id = txtServiceID.Text, name = txtServiceName.Text;
                if (sadd)
                {
                    sadd = false;
                    query = "INSERT INTO service(service_name) VALUES ('" + name + "')";
                    dbcon.ManipulateData(query);
                    MessageBox.Show("Added a new service.", "Services");
                }
                else if (sedit)
                {
                    sedit = false;
                    query = "UPDATE service SET service_name='" + name + "' WHERE service_ID='" + id + "'";
                    dbcon.ManipulateData(query);
                    MessageBox.Show("Updated a service.", "Services");
                }
                btnSClear.PerformClick();
            }
        }

        private void lvServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvServices.SelectedItems.Count > 0)
            {
                ListViewItem item = lvServices.SelectedItems[0];
                txtServiceID.Text = item.SubItems[0].Text;
                txtServiceName.Text = item.SubItems[1].Text;
                btnSAdd.Enabled = false; btnSEdit.Enabled = true;btnSDelete.Enabled = true;btnSSave.Enabled = false; sedit = false; sadd = false; txtServiceID.Enabled = false; txtServiceName.Enabled = false;
            }
            else
            {
                //
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        string query;
       
        public ucServices()
        {
            InitializeComponent();
        }
        private void btnSClear_Click(object sender, EventArgs e)
        {
            LoadServicesLV(); txtServiceID.Text = ""; txtServiceName.Text = ""; btnSAdd.Enabled = true; btnSSave.Enabled = false; btnSDelete.Enabled = false;btnSEdit.Enabled = false; txtServiceName.Enabled = false;
            btnPClear.PerformClick(); btnVClear.PerformClick();
        }

       

        private void ucServices_Load(object sender, EventArgs e)
        {
            btnSClear.PerformClick(); LoadPriceLV(); LoadVehicleTypeLV();LoadServiceCbo();LoadTypeCbo();
        }


        private void LoadServicesLV()
        {
            lvServices.Items.Clear();
            try
            {
                query = "SELECT * FROM service";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, dbcon.mysqlconnect);
                DataTable table = new DataTable("myTable");
                mySqlDataAdapter.Fill(table);
                lvServices.View = View.Details;
                ListViewItem iItem;
                foreach (DataRow row in table.Rows)
                {
                    iItem = new ListViewItem();
                    for (int i = 0; i < row.ItemArray.Length; i++)
                    {
                        if (i == 0)
                            iItem.Text = row.ItemArray[i].ToString();
                        else
                            iItem.SubItems.Add(row.ItemArray[i].ToString());
                    }
                    lvServices.Items.Add(iItem);
                }

                dbcon.mysqlconnect.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        //============= vehicle type ============
        private void btnVAdd_Click(object sender, EventArgs e)
        {
            tadd = true; btnVAdd.Enabled = false; btnVSave.Enabled = true; txtTypeName.Enabled = true;
        }
        private void btnVDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this vehicle type?", "Services", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                query = "DELETE FROM vehicle_type WHERE vehicletype_ID='" + txtTypeID.Text + "'";
                dbcon.ManipulateData(query);
                MessageBox.Show("Deleted a vehicle type", "Service");
                btnVClear.PerformClick();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

       
        private void btnVEdit_Click(object sender, EventArgs e)
        {
            btnVEdit.Enabled = false; btnVSave.Enabled = true; tedit = true; btnVDelete.Enabled = false; txtTypeName.Enabled = true;

        }
        private void btnVSave_Click(object sender, EventArgs e)
        {
            if (txtTypeName.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide a vehicle type name");
                txtTypeName.Focus();
            }
            else
            {
                string id = txtTypeID.Text, name = txtTypeName.Text;
                if (tadd)
                {
                    tadd = false;
                    query = "INSERT INTO vehicle_type(vehicle_type) VALUES ('" + name + "')";
                    dbcon.ManipulateData(query);
                    MessageBox.Show("Added a new vehicle type.", "Services");
                }
                else if (tedit)
                {
                    tedit = false;
                    query = "UPDATE vehicle_type SET vehicle_type='" + name + "' WHERE vehicletype_ID='" + id + "'";
                    dbcon.ManipulateData(query);
                    MessageBox.Show("Updated a vehicle type.", "Services");
                }
                btnVClear.PerformClick();
            }
        }
        private void btnVClear_Click(object sender, EventArgs e)
        {
            LoadVehicleTypeLV (); txtTypeID.Text = ""; txtTypeName.Text = ""; btnVAdd.Enabled = true; btnVSave.Enabled = false; btnVDelete.Enabled = false; btnVEdit.Enabled = false; txtTypeName.Enabled = false; LoadTypeCbo();
        }
        private void LoadVehicleTypeLV()
        {
            lvType.Items.Clear();
            try
            {
                query = "SELECT * FROM vehicle_type";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, dbcon.mysqlconnect);
                DataTable table = new DataTable("myTable");
                mySqlDataAdapter.Fill(table);
                lvType.View = View.Details;
                ListViewItem iItem;
                foreach (DataRow row in table.Rows)
                {
                    iItem = new ListViewItem();
                    for (int i = 0; i < row.ItemArray.Length; i++)
                    {
                        if (i == 0)
                            iItem.Text = row.ItemArray[i].ToString();
                        else
                            iItem.SubItems.Add(row.ItemArray[i].ToString());
                    }
                    lvType.Items.Add(iItem);
                }

                dbcon.mysqlconnect.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void lvType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvType.SelectedItems.Count > 0)
            {
                ListViewItem item = lvType.SelectedItems[0];
                txtTypeID.Text = item.SubItems[0].Text;
                txtTypeName.Text = item.SubItems[1].Text;
                btnVAdd.Enabled = false; btnVEdit.Enabled = true; btnVDelete.Enabled = true; btnVSave.Enabled = false;tedit = false;tadd = false;txtTypeID.Enabled = false; txtTypeName.Enabled = false;
            }
            else
            {
                //
            }
        }

     
        //============= SERVICE PRICE ============  
        private void btnPAdd_Click(object sender, EventArgs e)
        {
            padd = true; btnPAdd.Enabled = false; btnPSave.Enabled = true; numFee.Enabled = true; cboServiceName.Enabled = true; cboVehicleType.Enabled = true;
        }

        private void btnPDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this service price?", "Services", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                query = "DELETE FROM service_price WHERE service_price_ID='" + txtPriceID.Text + "'";
                dbcon.ManipulateData(query);
                MessageBox.Show("Deleted a service", "Service");
                btnPClear.PerformClick();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnPEdit_Click(object sender, EventArgs e)
        {
            btnPEdit.Enabled = false; btnPSave.Enabled = true; pedit = true; btnPDelete.Enabled = false; numFee.Enabled = true;
        }
        private bool IsDupServNameType()
        {

            string query = "SELECT * FROM service_price,service,vehicle_type WHERE (SELECT service_ID FROM service WHERE service_name='"+cboServiceName.Text+ "')=service_price.service_ID AND (SELECT vehicletype_ID FROM vehicle_type WHERE vehicle_type='" + cboVehicleType.Text + "')=service_price.vehicletype_ID";
            dbcon.mysqlconnect.Open();
            MySqlCommand myCommand = new MySqlCommand(query, dbcon.mysqlconnect);
            myCommand.CommandTimeout = 60;
            MySqlDataReader reader;
            reader = myCommand.ExecuteReader();
            bool has = false;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    has = true;
                }
            }
            dbcon.mysqlconnect.Close();
            return has;
        }
        private void btnPSave_Click(object sender, EventArgs e)
        {
            if (cboServiceName.Text.Trim() == "" ||cboVehicleType.Text.Trim() == "" || numFee.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide Service, Vehicle Type, and Service Fee", "Services");
                cboServiceName.Focus();
            } else if (IsDupServNameType() && !pedit)
                MessageBox.Show("Service for a particular vehicle type is existing","Services");
            else
            {
                if (padd)
                {
                    padd = false;
                    query = "INSERT INTO service_price(service_ID,vehicletype_ID,service_fee) VALUES ((SELECT service_ID FROM service WHERE service_name='"+cboServiceName.Text+"'),(SELECT vehicletype_ID FROM vehicle_type WHERE vehicle_type='"+cboVehicleType.Text+"'),'"+numFee.Value.ToString()+"')";
                    dbcon.ManipulateData(query);
                    MessageBox.Show("Added a new service price.", "Services");
                }
                else if (pedit)
                {
                    pedit = false;
                    query = "UPDATE service_price SET service_fee='" + numFee.Value.ToString() + "' WHERE service_price_ID='" + txtPriceID.Text + "'";
                    dbcon.ManipulateData(query);
                    MessageBox.Show("Updated a service price.", "Services");
                }
                btnPClear.PerformClick();
            }
        }

        private void ucServices_MouseMove(object sender, MouseEventArgs e) {
            frmMain.count = 0;

        }

        private void btnPrint_Click(object sender, EventArgs e) {

            try {
                string query = "SELECT service_price_ID,service_name,vehicle_type,service_fee FROM service_price,service,vehicle_type WHERE service_price.service_ID=service.service_ID AND service_price.vehicletype_ID=vehicle_type.vehicletype_ID";
                dbcon.mysqlconnect.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                MySqlDataAdapter adp = new MySqlDataAdapter();
                DataSet dt = new DataSet();
                adp.SelectCommand = cmd;
                adp.Fill(dt, "service_price");
                CrystalReport1 reporting = new CrystalReport1();
                reporting.SetDataSource(dt);
                frmReports frmreports = new frmReports();
                frmreports.crystalReportViewer.ReportSource = reporting;
                frmreports.crystalReportViewer.Refresh();
                cmd.Dispose(); adp.Dispose(); dt.Dispose(); dbcon.mysqlconnect.Close();
                frmreports.ShowDialog();
            } catch (Exception) {
                throw;
            }
           
        }

        private void btnPClear_Click(object sender, EventArgs e)
        {
            LoadPriceLV(); txtPriceID.Text = ""; cboServiceName.Text = ""; cboVehicleType.Text = ""; numFee.Text = ""; btnPAdd.Enabled = true; btnPSave.Enabled = false; btnPDelete.Enabled = false; btnPEdit.Enabled = false; LoadServiceCbo(); LoadTypeCbo(); cboServiceName.Enabled = false; cboVehicleType.Enabled = false; numFee.Enabled = false;
        }
        private void lvPrices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPrices.SelectedItems.Count > 0)
            {
                ListViewItem item = lvPrices.SelectedItems[0];
                txtPriceID.Text = item.SubItems[0].Text;
                cboServiceName.Text = item.SubItems[1].Text;
                cboVehicleType.Text = item.SubItems[2].Text;
                numFee.Value = Convert.ToDecimal(item.SubItems[3].Text);
                btnPAdd.Enabled = false; btnPEdit.Enabled = true; btnPDelete.Enabled = true; btnPSave.Enabled = false; padd = false; pedit = false; cboServiceName.Enabled = false; cboVehicleType.Enabled = false; numFee.Enabled = false;
            }
            else
            {
                //
            }
        }
        private void LoadPriceLV()
        {
            lvPrices.Items.Clear();
            try
            {
                query = "SELECT service_price_ID,service_name,vehicle_type,service_fee FROM service_price,service,vehicle_type WHERE service_price.service_ID=service.service_ID AND service_price.vehicletype_ID=vehicle_type.vehicletype_ID";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, dbcon.mysqlconnect);
                DataTable table = new DataTable("myTable");
                mySqlDataAdapter.Fill(table);
                lvPrices.View = View.Details;
                ListViewItem iItem;
                foreach (DataRow row in table.Rows)
                {
                    iItem = new ListViewItem();
                    for (int i = 0; i < row.ItemArray.Length; i++)
                    {
                        if (i == 0)
                            iItem.Text = row.ItemArray[i].ToString();
                        else
                            iItem.SubItems.Add(row.ItemArray[i].ToString());
                    }
                    lvPrices.Items.Add(iItem);
                }

                dbcon.mysqlconnect.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void LoadServiceCbo()
        {
            cboServiceName.Items.Clear();
            string query = "SELECT service_name FROM service";
            dbcon.mysqlconnect.Open();
            MySqlCommand myCommand = new MySqlCommand(query, dbcon.mysqlconnect);
            myCommand.CommandTimeout = 60;
            MySqlDataReader reader;
            reader = myCommand.ExecuteReader();
            //List<string> myCollection = new List<string>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cboServiceName.Items.Add(reader.GetString(0));
                }
                //drpCat.Items = myCollection.ToArray();
            }
            dbcon.mysqlconnect.Close();
        }
        private void LoadTypeCbo()
        {
            cboVehicleType.Items.Clear();
            string query = "SELECT vehicle_type FROM vehicle_type";
            dbcon.mysqlconnect.Open();
            MySqlCommand myCommand = new MySqlCommand(query, dbcon.mysqlconnect);
            myCommand.CommandTimeout = 60;
            MySqlDataReader reader;
            reader = myCommand.ExecuteReader();
            //List<string> myCollection = new List<string>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cboVehicleType.Items.Add(reader.GetString(0));
                }
                //drpCat.Items = myCollection.ToArray();
            }
            dbcon.mysqlconnect.Close();
        }
    }
}
