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
        string str_Connection = ConnectionVariables.str_connectionValue1;
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

            HideAll(true);
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

        public void CheckAvailability()
        {
            string datePU;
            string dateRET;            

            datePU = dtp_pickupDate.Value.ToString();
            int spaceIndex = datePU.IndexOf(" ");
            datePU = datePU.Substring(0, spaceIndex);

            dateRET = dtp_returnDate.Value.ToString();
            int spaceIndex2 = dateRET.IndexOf(" ");
            dateRET = dateRET.Substring(0, spaceIndex2);

            string str_dateSearch = "select * " +
                                    "from dbo.Bookings " +
                                    "where vin = '" + txt_vinNo.Text + "' AND " +
                                    "(pickupDate between convert(date, '" + datePU + "', 103) and convert(date, '" + dateRET + "', 103)) or" +
                                    "(returnDate between convert(date, '" + datePU + "', 103) and convert(date, '" + dateRET + "', 103))";

            SqlDataAdapter custAdapter = new SqlDataAdapter(str_dateSearch, str_Connection);
            DataSet cust_DS = new DataSet();
            custAdapter.Fill(cust_DS);

            dgv_custView.ReadOnly = true;
            dgv_custView.DataSource = cust_DS.Tables[0];

            dgv_custView.Select();

            if (cust_DS.Tables[0].Rows.Count >= 1)
            {
                MessageBox.Show("------------------------------------------------------------------------------------\n" +
                            " There is a conflict with the selected dates and a current booking.\n" +
                            "------------------------------------------------------------------------------------");
            }


            if (cust_DS.Tables[0].Rows.Count == 0)
            {
                HideAll(false);
                loadCustData();
            }

            
        }

        public void HideAll(bool value)
        {
            txt_obsvOutbound.Visible = !value;
            txt_obsvInbound.Visible = !value;
            label7.Visible = !value;
            label8.Visible = !value;
            label1.Visible = !value;
            label2.Visible = !value;
            label3.Visible = !value;
            label4.Visible = !value;
            label9.Visible = !value;
            label12.Visible = !value;
            btn_calcCost.Visible = !value;
            btn_submitBooking.Visible = !value;
            txt_customerNo.Visible = !value;
            txt_employeeID.Visible = !value;
            txt_vinNo.Visible = !value;
            txt_dailyRate.Visible = !value;
            txt_odoOutBound.Visible = !value;
            txt_totalCost.Visible = !value;
            label14.Visible = !value;

            btn_checkAvailable.Visible = value;
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

        private void btn_checkAvailable_Click(object sender, EventArgs e)
        {
            CheckAvailability();
        }

        private void dtp_pickupDate_ValueChanged(object sender, EventArgs e)
        {
            HideAll(true);
        }

        private void dtp_returnDate_ValueChanged(object sender, EventArgs e)
        {
            HideAll(true);
        }

        void loadCustData()
        {
            string str_custSelectStmnt = "select * " +
                                    "from dbo.Customers; ";

            SqlDataAdapter custAdapter = new SqlDataAdapter(str_custSelectStmnt, str_Connection);
            DataSet cust_DS = new DataSet();
            custAdapter.Fill(cust_DS);

            dgv_custView.ReadOnly = true;
            dgv_custView.DataSource = cust_DS.Tables[0];

            dgv_custView.Select();
        }
    }
}
