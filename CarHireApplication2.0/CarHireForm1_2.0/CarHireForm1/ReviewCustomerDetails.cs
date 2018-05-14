using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarHireForm1
{
    public partial class ReviewCustomerDetails : Form
    {
        int int_custNo;

        public ReviewCustomerDetails()
        {
            InitializeComponent();
        }

        private void ReviewCustomerDetails_Load(object sender, EventArgs e)
        {
            string str_Connection = ConnectionVariables.str_connectionValue1;
            string str_selectStmnt = "select * " +
                                    "from dbo.Customers; ";

            SqlConnection connection = new SqlConnection(str_Connection);
            SqlDataAdapter adapter = new SqlDataAdapter(str_selectStmnt, str_Connection);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridView1.ReadOnly = false;
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Select();

            RetrieveCustData();
        }

        private void btn_saveReviewChanges_Click(object sender, EventArgs e)
        {
            WriteChanges();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RetrieveCustData();
        }

        private void WriteChanges()
        {
            string str_Connection = ConnectionVariables.str_connectionValue1;
            string detailsUpdate = "Update [dbo].[Customers]" +
                                    "Set firstName = '" + txt_fName.Text + "'," +
                                    "lastName = '" + txt_lName.Text + "', " +
                                    "address = '" + txt_streetNameNumber.Text + "', " +
                                    "City = '" + txt_City.Text + "', " +
                                    "postCode = '" + txt_postCode.Text + "', " +
                                    "state = '" + txt_State.Text + "', " +
                                    "Country = '" + txt_Country.Text + "', " +
                                    "mobileNo = '" + txt_mobileNo.Text + "'," +
                                    "driverLicenseNo = '" + txt_driverLicenseNo.Text + "'," +
                                    "paymentCardNo = '" + txt_cardNo.Text + "'," +
                                    "creditCardType = '" + txt_cardType.Text + "'," +
                                    "cardExpDate = Convert(date,'" + txt_cardExpiry.Text + "', 103) ," +
                                    "nameOnCard = '" + txt_nameOnCard.Text + "'" +
                                    "Where CustomerNo = '" + int_custNo.ToString() + "';";

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

        private void RetrieveCustData()
        {
            //int currentRow = dataGridView1.CurrentCell.RowIndex;
            //dataGridView1.CurrentCell = dataGridView1.Rows[currentRow].Cells[0];
            //string custNo = dataGridView1.CurrentCell.Value.ToString();       //Long way to do the CustNo assigning below

            string custNo = (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value).ToString();

            int_custNo = Int32.Parse(custNo);

            if (dataGridView1.CurrentCell.RowIndex >= 0)
            {
                string date;
                DataGridViewRow row = this.dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                txt_fName.Text = row.Cells["firstName"].Value.ToString();
                txt_lName.Text = row.Cells["lastName"].Value.ToString();
                txt_streetNameNumber.Text = row.Cells["address"].Value.ToString();
                txt_City.Text = row.Cells["City"].Value.ToString();
                txt_State.Text = row.Cells["state"].Value.ToString();
                txt_postCode.Text = row.Cells["postCode"].Value.ToString();
                txt_Country.Text = row.Cells["country"].Value.ToString();
                txt_mobileNo.Text = row.Cells["mobileNo"].Value.ToString();
                txt_driverLicenseNo.Text = row.Cells["driverLicenseNo"].Value.ToString();
                txt_cardNo.Text = row.Cells["paymentCardNo"].Value.ToString();
                txt_cardType.Text = row.Cells["creditCardType"].Value.ToString();
                date = row.Cells["cardExpDate"].Value.ToString();
                int spaceIndex = date.IndexOf(" ");
                date = date.Substring(0, spaceIndex);
                txt_cardExpiry.Text = date;
                txt_nameOnCard.Text = row.Cells["nameOnCard"].Value.ToString();
            }
        }
    }    
}
