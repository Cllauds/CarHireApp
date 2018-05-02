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
    public partial class CustomerCreation : Form
    {
        public CustomerCreation()
        {
            InitializeComponent();
        }       

        private void button1_Click(object sender, EventArgs e)
        {
            CreateCustomer();
        }                              

        private void CustomerCreation_Load(object sender, EventArgs e)
        {
            txt_fName.Focus();
        }

        private void CreateCustomer()
        {            
            if ((txt_driverLicenseNo.Text).Length == 7 && 
                (txt_cardNo.Text).Length == 16 && 
                (txt_cardExpiry.Text).Length >= 8 &&
                txt_fName.Text != "" && 
                txt_lName.Text != "")
            {
                string str_Connection = ConnectionVariables.str_connectionValue1;
                string str_createCustQuery = "INSERT INTO [dbo].[Customers]" +
                                            "([firstName], " +
                                            "[lastName], " +
                                            "[address], " +
                                            "[city], " +
                                            "[postCode], " +
                                            "[state], " +
                                            "[country], " +
                                            "[mobileNo], " +
                                            "[driverLicenseNo], " +
                                            "[paymentCardNo], " +
                                            "[creditCardType], " +
                                            "[cardExpDate], " +
                                            "[nameOnCard])" +

                                            "VALUES" +
                                            "('" + txt_fName.Text + "'," +
                                            "'" + txt_lName.Text + "'," +
                                            "'" + txt_streetNameNumber.Text + "'," +
                                            "'" + txt_City.Text + "'," +
                                            "'" + txt_postCode.Text + "'," +
                                            "'" + txt_State.Text + "'," +
                                            "'" + txt_Country.Text + "'," +
                                            "'" + txt_mobileNo.Text + "'," +
                                            "'" + txt_driverLicenseNo.Text + "'," +
                                            "'" + txt_cardNo.Text + "'," +
                                            "'" + txt_cardType.Text + "'," +
                                            " Convert(date,'" + txt_cardExpiry.Text + "', 103) ," +
                                            "'" + txt_nameOnCard.Text + "')";

                SqlConnection con = new SqlConnection(str_Connection);
                con.Open();
                try
                {
                    SqlCommand comm_CreateCust = new SqlCommand(str_createCustQuery, con);
                    comm_CreateCust.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Update Successful!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Some details were not in correct format. Please check:\n" +
                    "-Drivers licence number must be 7 digits\n" +
                    "-Payment card number must be 16 digits, with valid expiry date\n" +
                    "-First and last name cannot be empty");
            }
        }
    }
}
