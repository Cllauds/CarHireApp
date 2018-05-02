using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarHireForm1
{
    public partial class ViewVehicles : Form
    {
        Int64 int_vinNo;
        string bodyType;
        string transType;

        public ViewVehicles()
        {
            InitializeComponent();
        }

        private void ViewVehicles_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetVehicleData();

            string str_Connection = ConnectionVariables.str_connectionValue1;
            string str_selectStmnt = "select * " +
                                    "from dbo.Vehicles;";
               
            SqlConnection con = new SqlConnection(str_Connection);
            SqlDataAdapter adap = new SqlDataAdapter(str_selectStmnt, str_Connection);

            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Select();

            RetrieveDetails();

            CreateComboBoxItems();
            CreateTransComboBoxItems();

            SetComboBoxValue(bodyType);
            SetTransCBValue(transType);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VehicleCreation vc_Form = new VehicleCreation();
            vc_Form.Show();
        }

        private DataTable GetVehicleData()
        {
            DataTable dtVehicles = new DataTable();

            return dtVehicles;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RetrieveDetails();
            SetComboBoxValue(bodyType);
            SetTransCBValue(transType);
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            UpdateDetails();
        }

        void RetrieveDetails()
        {
            int currentRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.CurrentCell = dataGridView1.Rows[currentRow].Cells[0];

            string vinNo = dataGridView1.CurrentCell.Value.ToString();
            int_vinNo = Int64.Parse(vinNo);

            if (dataGridView1.SelectedCells[0].RowIndex >= 0)
            {
                //DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                DataGridViewRow row = this.dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                string date = row.Cells["regoExpiry"].Value.ToString();
                int spaceIndex = date.IndexOf(" ");
                date = date.Substring(0, spaceIndex);

                txt_vinNo.Text = row.Cells["vinNo"].Value.ToString();
                txt_make.Text = row.Cells["make"].Value.ToString();
                txt_model.Text = row.Cells["model"].Value.ToString();
                txt_color.Text = row.Cells["colour"].Value.ToString();
                transType = row.Cells["transType"].Value.ToString();
                txt_odometer.Text = row.Cells["odometer"].Value.ToString();
                txt_fuelType.Text = row.Cells["fuelType"].Value.ToString();
                bodyType = row.Cells["bodyType"].Value.ToString();
                txt_dailyRate.Text = row.Cells["dailyRate"].Value.ToString();
                txt_hourlyRate.Text = row.Cells["hourlyRate"].Value.ToString();
                txt_regoNo.Text = row.Cells["regoNo"].Value.ToString();
                txt_regoExpiry.Text = date;
                txt_accumObvs.Text = row.Cells["accumulatedObsvs"].Value.ToString();
            }
        }

        void UpdateDetails()
        {
            WriteNewBodyTypeToVar();
            WriteNewTranstoVar();

            string str_Connection = ConnectionVariables.str_connectionValue1;
            string detailsUpdate = "Update [dbo].[Vehicles]" +
                                    "Set make = '" + txt_make.Text + "', " +
                                    "model = '" + txt_model.Text + "', " +
                                    "colour = '" + txt_color.Text + "', " +
                                    "transType = '" + transType + "', " +
                                    "odometer = '" + txt_odometer.Text + "', " +
                                    "fuelType = '" + txt_fuelType.Text + "', " +
                                    "bodyType = '" + bodyType + "'," +
                                    "dailyRate = '" + txt_dailyRate.Text + "'," +
                                    "hourlyRate = '" + txt_hourlyRate.Text + "'," +
                                    "regoNo = '" + txt_regoNo.Text + "'," +
                                    "regoExpiry = Convert(date,'" + txt_regoExpiry.Text + "', 103) ," +
                                    "accumulatedObsvs = '" + txt_accumObvs.Text + "'" +
                                    "Where vinNo = '" + int_vinNo.ToString() + "';";

            SqlConnection con = new SqlConnection(str_Connection);
            con.Open();
            try
            {
                SqlCommand infoUpdate = new SqlCommand(detailsUpdate, con);
                infoUpdate.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update Successful!");
            }
            catch (SqlException ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        void CreateComboBoxItems()
        {
            cb_bodyType.Items.Insert(0, "Sedan");
            cb_bodyType.Items.Insert(1, "Hatch");
            cb_bodyType.Items.Insert(2, "Wagon");
            cb_bodyType.Items.Insert(3, "Ute");
            cb_bodyType.Items.Insert(4, "SUV");
            cb_bodyType.Items.Insert(5, "4x4");
        }

        void CreateTransComboBoxItems()
        {
            cb_transType.Items.Insert(0, "Manual");
            cb_transType.Items.Insert(1, "Automatic");
        }

        void SetComboBoxValue(string type)
        {
            //if (type == "Sedan")
            //{
            //    cb_bodyType.SelectedIndex = 0;
            //}
            //else if (type == "Hatch")
            //{
            //    cb_bodyType.SelectedIndex = 1;
            //}
            //if (type == "Wagon")
            //{
            //    cb_bodyType.SelectedIndex = 2;
            //}
            //if (type == "Ute")
            //{
            //    cb_bodyType.SelectedIndex = 3;
            //}
            //if (type == "SUV")
            //{
            //    cb_bodyType.SelectedIndex = 4;
            //}
            //if (type == "4x4")
            //{
            //    cb_bodyType.SelectedIndex = 5;
            //}

            switch (type)
            {
                case "Sedan":
                    cb_bodyType.SelectedIndex = 0;
                    break;
                case "Hatch":
                    cb_bodyType.SelectedIndex = 1;
                    break;
                case "Wagon":
                    cb_bodyType.SelectedIndex = 2;
                    break;
                case "Ute":
                    cb_bodyType.SelectedIndex = 3;
                    break;
                case "SUV":
                    cb_bodyType.SelectedIndex = 4;
                    break;
                case "4x4":
                    cb_bodyType.SelectedIndex = 5;
                    break;
            }
        }
        void SetTransCBValue(string type)
        {
            switch (type)
            {
                case "Manual":
                    cb_transType.SelectedIndex = 0;
                    break;
                case "Auto":
                    cb_transType.SelectedIndex = 1;
                    break;
                case "Automatic":
                    cb_transType.SelectedIndex = 1;
                    break;
            }
        }

        void WriteNewTranstoVar()
        {
            switch (cb_transType.SelectedIndex)
            {
                case 0:
                    transType = "Manual";
                    break;
                case 1:
                    transType = "Automatic";
                    break;
            }
        }

        void WriteNewBodyTypeToVar()
        {
            switch (cb_bodyType.SelectedIndex)
            {
                case 0:
                    bodyType = "Sedan";
                    break;
                case 1:
                    bodyType = "Hatch";
                    break;
                case 2:
                    bodyType = "Wagon";
                    break;
                case 3:
                    bodyType = "Ute";
                    break;
                case 4:
                    bodyType = "SUV";
                    break;
                case 5:
                    bodyType = "4x4";
                    break;
            }
        }

        private void cb_bodyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
