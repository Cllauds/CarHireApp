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
using System.Globalization;

/*
 * Developer: Claudio Ferreira
 * Completed: 23/04/2018 
 */

namespace CarHireForm1
{
    public partial class MainForm : Form
    {
        string str_vinNumber;
        double dailyRate;
        double oldOdo;
        double newOdo;
        public MainForm()
        {
            InitializeComponent();
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            LoadGridWithBookingDetails();

            dataGridView1.Select();
            GetBookingDetails();
            
            GetBookingVehicleDetails();

            btn_saveBookingChanges.Enabled = false;
            gb_editBooking.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerCreation cc_Form = new CustomerCreation();
            cc_Form.Show();

            dataGridView1.Select();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReviewCustomerDetails rcd_Form = new ReviewCustomerDetails();
            rcd_Form.Show();

            dataGridView1.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewVehicles vv_Form = new ViewVehicles();
            vv_Form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateBooking cb_Form = new CreateBooking();
            cb_Form.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetBookingDetails();
            GetBookingVehicleDetails();
        }

        private void GetBookingDetails()
        {
            CultureInfo MyCultureInfo = new CultureInfo("de-DE");
            string pickupDate;
            string returnDate;

            int currentRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.CurrentCell = dataGridView1.Rows[currentRow].Cells[0];

            string bookingID = dataGridView1.CurrentCell.Value.ToString();

            if (dataGridView1.CurrentCell.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                pickupDate = row.Cells["pickupDate"].Value.ToString();
                returnDate = row.Cells["returnDate"].Value.ToString();
                txt_pickupTime.Text = row.Cells["pickupTime"].Value.ToString();
                txt_returnTime.Text = row.Cells["returnTime"].Value.ToString();
                DateTime pickup = DateTime.Parse(pickupDate, MyCultureInfo);
                DateTime retrn = DateTime.Parse(returnDate, MyCultureInfo);
                dtp_pickup.Value = pickup;
                dtp_return.Value = retrn;                
            }

            txt_adjustedCost.Clear();
            btn_saveBookingChanges.Enabled = false;
            gb_editBooking.Visible = false;
        }

        void WriteBookingChanges()
        {
            string bookingID = (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value).ToString();
            int int_bookingID = Int32.Parse(bookingID);

            newOdo = double.Parse(txt_newOdo.Text);

            string str_Connection = ConnectionVariables.str_connectionValue1;
            if (newOdo >= oldOdo)
            {
                string str_editBookingQuery = "Update [dbo].[Bookings]" +
                                      "Set pickupDate = CONVERT(varchar(10), '" + dtp_pickup.Text + "', 111)," +
                                      "returnDate = CONVERT(varchar(10), '" + dtp_return.Text + "', 111)," +
                                      "pickupTime = '" + txt_pickupTime.Text + "', " +
                                      "returnTime = '" + txt_returnTime.Text + "'," +
                                      "totalCost = '" + txt_adjustedCost.Text + "'" +
                                      "Where BookingID = '" + int_bookingID.ToString() + "';";

                string str_updateVehicleOdo = "Update [dbo].[Vehicles] " +
                                      "Set odometer = '" + newOdo + "' " +
                                      "where vinNo = '" + str_vinNumber + "';";

                SqlConnection con = new SqlConnection(str_Connection);
                con.Open();
                try
                {
                    SqlCommand comm_editBooking = new SqlCommand(str_editBookingQuery, con);
                    SqlCommand comm_editVehicleOdo = new SqlCommand(str_updateVehicleOdo, con);
                    comm_editBooking.ExecuteNonQuery();
                    comm_editVehicleOdo.ExecuteNonQuery();
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
                MessageBox.Show("There was an error with the new data");
            }
        }

        private void btn_saveBookingChanges_Click(object sender, EventArgs e)
        {
            WriteBookingChanges();
            gb_editBooking.Visible = false;
            txt_adjustedCost.Clear();
        }

        public void GetBookingVehicleDetails()
        {
            str_vinNumber = (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["vin"].Value).ToString();
            string str_Connection = ConnectionVariables.str_connectionValue1;
            string str_selectStmnt2 = "select * " +
                                      "from dbo.Vehicles " +
                                      "where vinNo = '" + str_vinNumber + "';";

            SqlDataAdapter adapter2 = new SqlDataAdapter(str_selectStmnt2, str_Connection);
            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2);
            dgv_Vehicles.DataSource = ds2.Tables[0];

            DataGridViewRow row = this.dgv_Vehicles.Rows[dgv_Vehicles.SelectedCells[0].RowIndex];
            txt_model.Text = row.Cells["model"].Value.ToString();
            txt_dailyRate.Text = row.Cells["dailyRate"].Value.ToString();
            txt_newOdo.Text = row.Cells["odometer"].Value.ToString();

            oldOdo = double.Parse(txt_newOdo.Text);
        }

        void RecalculateCost()
        {
            DateTime returnDate = dtp_return.Value;
            DateTime pickupDate = dtp_pickup.Value;

            dailyRate = double.Parse(txt_dailyRate.Text);
            TimeSpan timeSpan = dtp_return.Value - dtp_pickup.Value;
            var days = timeSpan.TotalDays;

            txt_adjustedCost.Text = (dailyRate * days).ToString();
            if (txt_adjustedCost.Text.Length > 0)
            {
                btn_saveBookingChanges.Enabled = true;
            }
        }

        private void btn_adjustCost_Click(object sender, EventArgs e)
        {
            RecalculateCost();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gb_editBooking.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string str_bookingDate = "select * " +
                                "from [dbo].[Bookings] " +
                                "where pickupDate >= CONVERT(varchar(10), '" + dtp_searchDate.Text + "', 111);";

            string str_Connection = ConnectionVariables.str_connectionValue1;
            SqlConnection con = new SqlConnection(str_Connection);
            SqlDataAdapter adapter2 = new SqlDataAdapter(str_bookingDate, str_Connection);

            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2);

            dataGridView1.DataSource = ds2.Tables[0];

            //con.Open();
            //try
            //{
            //    SqlCommand comm_searchBookings = new SqlCommand(bookingDate, con);
            //    comm_searchBookings.ExecuteNonQuery();
            //    con.Close();
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        void LoadGridWithBookingDetails()
        {
            string str_Connection = ConnectionVariables.str_connectionValue1;
            string str_selectStmnt = "select bookingID, EmpID, Customers.firstName as 'First Name', Customers.lastName as 'Last Name', Customers.driverLicenseNo as 'License No,', vin, pickupDate, pickupTime, returnDate, returnTime, totalCost, odoReadingOutbound, odoReadingInbound " +
                                    "from Bookings "+
                                    "Inner JOIN Customers ON Bookings.CustomerNo = Customers.CustomerNo;";


            SqlConnection connection = new SqlConnection(str_Connection);
            SqlDataAdapter adapter1 = new SqlDataAdapter(str_selectStmnt, str_Connection);

            DataSet ds1 = new DataSet();
            adapter1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];

            dataGridView1.ReadOnly = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            LoadGridWithBookingDetails();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadGridWithBookingDetails();
        }
    }

    public class ConnectionVariables
    {
        public static string str_connectionValue1 = "Data Source = PaperWeight; Initial Catalog = CarRental; Integrated Security = True";
        //public static string str_connectionValue1 = "Data Source = MSSQL003; Initial Catalog = CarRental; Integrated Security = True";
        //public static string str_connectionValue1 = "Data Source = DESKTOP-53JUJGO; Initial Catalog = CarRental; Integrated Security = True";
    }
}

/* 
 
    To format a date value for insert into text box:
        string date = row.Cells["pickupDate"].Value.ToString();
        int spaceIndex = date.IndexOf(" ");
        date = date.Substring(0, spaceIndex);
        txt_pickupDate.Text = date;
     
*/
