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
    public partial class VehicleCreation : Form
    {
        string bodyType;
        string fuelType;
        string transType;

        public VehicleCreation()
        {
            InitializeComponent();
        }

        private void VehicleCreation_Load(object sender, EventArgs e)
        {
            txt_vinNo.Select();

            SetCBItemsBody();
            SetCBItemsFuel();
            setCBTransType();
        }

        private void btn_createVehicle_Click(object sender, EventArgs e)
        {
            CreateVehicle();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateVehicle()
        {
            WriteBodyTypetoVar();
            WriteFuelTypetoVar();
            WriteTransTypetoVar();

            string str_Connection = ConnectionVariables.str_connectionValue1;

            if ((txt_vinNo.Text).Length == 17 &&
                txt_make.Text != "" &&
                txt_model.Text != "" &&
                txt_regoNo.Text != "" &&
                (txt_regoExpiry.Text).Length >= 8)
            {
                string str_createVehicleQuery = "INSERT INTO [dbo].[Vehicles]" +
                                            "([vinNo], " +
                                            "[make], " +
                                            "[model], " +
                                            "[colour], " +
                                            "[transType], " +
                                            "[odometer], " +
                                            "[fuelType], " +
                                            "[regoNo], " +
                                            "[regoExpiry], " +
                                            "[dailyRate], " +
                                            "[hourlyRate], " +
                                            "[bodyType], " +
                                            "[accumulatedObsvs])" +

                                            "VALUES" +
                                            "('" + txt_vinNo.Text + "'," +
                                            "'" + txt_make.Text + "'," +
                                            "'" + txt_model.Text + "'," +
                                            "'" + txt_color.Text + "'," +
                                            "'" + transType + "'," +
                                            "'" + txt_odometer.Text + "'," +
                                            "'" + fuelType + "'," +
                                            "'" + txt_regoNo.Text + "'," +
                                            " Convert(date,'" + txt_regoExpiry.Text + "', 103) ," +
                                            "'" + txt_dailyRate.Text + "'," +
                                            "'" + txt_hourlyRate.Text + "'," +
                                            "'" + bodyType + "'," +
                                            "'" + txt_accumObvs.Text + "')";

                SqlConnection con = new SqlConnection(str_Connection);
                con.Open();
                try
                {
                    SqlCommand comm_CreateVehicle = new SqlCommand(str_createVehicleQuery, con);
                    comm_CreateVehicle.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Update Successful!");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Some details were not in correct format. Please check the:\n" +
                    "-The vin number is 17 digits\n" +
                    "-Make, Model and Rego Number are not empty\n" +
                    "-The expiry date is in correct format");
            }
        }

        void SetCBItemsBody()
        {
            cb_bodyType.Items.Insert(0, "Sedan");
            cb_bodyType.Items.Insert(1, "Hatch");
            cb_bodyType.Items.Insert(2, "Wagon");
            cb_bodyType.Items.Insert(3, "Ute");
            cb_bodyType.Items.Insert(4, "SUV");
            cb_bodyType.Items.Insert(5, "4x4");
        }

        void setCBTransType()
        {
            cb_transType.Items.Insert(0, "Manual");
            cb_transType.Items.Insert(1, "Automatic");
        }

        void SetCBItemsFuel()
        {
            cb_fuelType.Items.Insert(0, "Petrol");
            cb_fuelType.Items.Insert(1, "Diesel");
        }

        void WriteBodyTypetoVar()
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

        void WriteFuelTypetoVar()
        {
            switch (cb_fuelType.SelectedIndex)
            {
                case 0:
                    fuelType = "Petrol";
                    break;
                case 1:
                    fuelType = "Diesel";
                    break;
            }
        }

        void WriteTransTypetoVar()
        {
            switch (cb_fuelType.SelectedIndex)
            {
                case 0:
                    transType = "Manual";
                    break;
                case 1:
                    transType = "Automatic";
                    break;
            }
        }
    }
}
