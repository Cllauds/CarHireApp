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
    public partial class CreateBooking : Form
    {
        public decimal dailyRate;
        DateTime todaysDate = DateTime.Today;

        public CreateBooking()
        {
            InitializeComponent();
        }

        private void CreateBooking_Load(object sender, EventArgs e)
        {
            dgv_custView.DataSource = GetCustomerBookingData();

            dgv_vehicleView.DataSource = GetVehicleBookingData();

            string str_Connection = ConnectionVariables.str_connectionValue1;

            string str_custSelectStmnt = "select * " +
                                    "from dbo.Customers; ";

            string str_vehSelectStmnt = "select * " +
                                    "from dbo.Vehicles; ";

            SqlConnection connection = new SqlConnection(str_Connection);

            SqlDataAdapter custAdapter = new SqlDataAdapter(str_custSelectStmnt, str_Connection);
            DataSet cust_DS = new DataSet();
            custAdapter.Fill(cust_DS);
            
            dgv_custView.ReadOnly = true;
            dgv_custView.DataSource = cust_DS.Tables[0];

            dgv_custView.Select();

            SqlDataAdapter vehAdapter = new SqlDataAdapter(str_vehSelectStmnt, str_Connection);
            DataSet veh_DS = new DataSet();
            vehAdapter.Fill(veh_DS);

            dgv_vehicleView.ReadOnly = true;
            dgv_vehicleView.DataSource = veh_DS.Tables[0];

            getCustData();
            getVehData();
        }

        private void dgv_custView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getCustData();
            txt_totalCost.Clear();
        }

        private void dgv_vehicleView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getVehData();
        }        

        private void btn_calcCost_Click(object sender, EventArgs e)
        {
            CalculateCost();
        }

        private void btn_submitBooking_Click(object sender, EventArgs e)
        {
            WriteBookingtoDB();
        }

        private void getCustData()
        {
            DataGridViewRow custRow = this.dgv_custView.Rows[dgv_custView.SelectedCells[0].RowIndex];
            txt_customerNo.Text = custRow.Cells["CustomerNo"].Value.ToString();
        }

        private void getVehData()
        {
            DataGridViewRow vehRow = this.dgv_vehicleView.Rows[dgv_vehicleView.SelectedCells[0].RowIndex];
            txt_vinNo.Text = vehRow.Cells["VinNo"].Value.ToString();
            txt_dailyRate.Text = vehRow.Cells["dailyRate"].Value.ToString();
            txt_odoOutBound.Text = vehRow.Cells["odometer"].Value.ToString();
        }

        public void WriteBookingtoDB()
        {
            if (dtp_pickupDate.Value >= todaysDate)
            {
                string str_writeBooking = "INSERT INTO[dbo].[Bookings]" +
                                            "([CustomerNo], " +
                                            "[EmpId], " +
                                            "[vin], " +
                                            "[pickupDate], " +
                                            "[pickupTime], " +
                                            "[returnDate], " +
                                            "[returnTime], " +
                                            "[observationsOutbound], " +
                                            "[observationsInbound], " +
                                            "[totalCost], " +
                                            "[odoReadingOutbound], " +
                                            "[odoReadingInbound]) " +

                                            "VALUES" +
                                            "('" + txt_customerNo.Text + "'," +
                                            "'" + txt_employeeID.Text + "'," +
                                            "'" + txt_vinNo.Text + "'," +
                                            "CONVERT(varchar(10), '" + dtp_pickupDate.Text + "', 111)," +
                                            "'" + txt_pickupTime.Text + "'," +
                                            "CONVERT(varchar(10), '" + dtp_returnDate.Text + "', 111)," +
                                            "'" + txt_returnTime.Text + "'," +
                                            "'" + txt_obsvOutbound.Text + "'," +
                                            "'" + txt_obsvInbound.Text + "'," +
                                            "'" + txt_totalCost.Text + "'," +
                                            "'" + txt_odoOutBound.Text + "'," +
                                            "'" + txt_odoInBound.Text + "')";

                string str_Connection = ConnectionVariables.str_connectionValue1;
                SqlConnection con = new SqlConnection(str_Connection);
                con.Open();
                try
                {
                    SqlCommand comm_CreateVehicle = new SqlCommand(str_writeBooking, con);
                    comm_CreateVehicle.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Booking Successful!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Date cannot be earlier than today");
            }
        }

        private void CalculateCost()
        {
            DateTime returnDate = dtp_returnDate.Value;
            DateTime pickupDate = dtp_pickupDate.Value;

            dailyRate = decimal.Parse(txt_dailyRate.Text);
            TimeSpan timeSpan = dtp_returnDate.Value - dtp_pickupDate.Value;
            var days = (int) Math.Ceiling(timeSpan.TotalDays);
            
            if (days == 0)
            {
                days = 1;
            }

            txt_totalCost.Text = (dailyRate * days).ToString();
            if (txt_totalCost.Text.Length > 0)
            {
                btn_submitBooking.Enabled = true;
            }
        }

        private DataTable GetCustomerBookingData()
        {
            DataTable dt_CBookings = new DataTable();

            return dt_CBookings;
        }

        private DataTable GetVehicleBookingData()
        {
            DataTable dt_VBookings = new DataTable();

            return dt_VBookings;
        }
    }
}
