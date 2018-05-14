namespace CarHireForm1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Customer = new System.Windows.Forms.GroupBox();
            this.gb_tableDetails = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_saveBookingChanges = new System.Windows.Forms.Button();
            this.txt_returnTime = new System.Windows.Forms.TextBox();
            this.txt_pickupTime = new System.Windows.Forms.TextBox();
            this.dtp_pickup = new System.Windows.Forms.DateTimePicker();
            this.dtp_return = new System.Windows.Forms.DateTimePicker();
            this.btn_adjustCost = new System.Windows.Forms.Button();
            this.txt_dailyRate = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_adjustedCost = new System.Windows.Forms.TextBox();
            this.dgv_Vehicles = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_editBooking = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_newOdo = new System.Windows.Forms.TextBox();
            this.dtp_searchDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_searchDate = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_Customer.SuspendLayout();
            this.gb_tableDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vehicles)).BeginInit();
            this.gb_editBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.Font = new System.Drawing.Font("Calibri", 8.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create a Booking";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.Font = new System.Drawing.Font("Calibri", 8.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(18, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "View all Vehicles";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Azure;
            this.button3.Font = new System.Drawing.Font("Calibri", 8.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(18, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Create New Customer";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Azure;
            this.button5.Font = new System.Drawing.Font("Calibri", 8.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(18, 29);
            this.button5.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "View all Customers";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(44, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(820, 27);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Car Hire Main Page";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 82);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(820, 168);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(44, 380);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(820, 170);
            this.textBox2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "All Current Bookings:";
            // 
            // gb_Customer
            // 
            this.gb_Customer.Controls.Add(this.button2);
            this.gb_Customer.Controls.Add(this.button3);
            this.gb_Customer.Controls.Add(this.button5);
            this.gb_Customer.Location = new System.Drawing.Point(50, 387);
            this.gb_Customer.Name = "gb_Customer";
            this.gb_Customer.Size = new System.Drawing.Size(191, 156);
            this.gb_Customer.TabIndex = 9;
            this.gb_Customer.TabStop = false;
            this.gb_Customer.Text = "View/Edit Tables:";
            // 
            // gb_tableDetails
            // 
            this.gb_tableDetails.Controls.Add(this.button1);
            this.gb_tableDetails.Controls.Add(this.button4);
            this.gb_tableDetails.Location = new System.Drawing.Point(250, 387);
            this.gb_tableDetails.Name = "gb_tableDetails";
            this.gb_tableDetails.Size = new System.Drawing.Size(191, 156);
            this.gb_tableDetails.TabIndex = 10;
            this.gb_tableDetails.TabStop = false;
            this.gb_tableDetails.Text = "Booking Tasks:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Azure;
            this.button4.Font = new System.Drawing.Font("Calibri", 8.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(18, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "Edit Booking";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_saveBookingChanges
            // 
            this.btn_saveBookingChanges.BackColor = System.Drawing.Color.Azure;
            this.btn_saveBookingChanges.Font = new System.Drawing.Font("Calibri", 8.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveBookingChanges.Location = new System.Drawing.Point(305, 110);
            this.btn_saveBookingChanges.Name = "btn_saveBookingChanges";
            this.btn_saveBookingChanges.Size = new System.Drawing.Size(92, 40);
            this.btn_saveBookingChanges.TabIndex = 4;
            this.btn_saveBookingChanges.Text = "Save Booking Changes";
            this.btn_saveBookingChanges.UseVisualStyleBackColor = false;
            this.btn_saveBookingChanges.Click += new System.EventHandler(this.btn_saveBookingChanges_Click);
            // 
            // txt_returnTime
            // 
            this.txt_returnTime.Location = new System.Drawing.Point(73, 123);
            this.txt_returnTime.Name = "txt_returnTime";
            this.txt_returnTime.Size = new System.Drawing.Size(89, 20);
            this.txt_returnTime.TabIndex = 11;
            // 
            // txt_pickupTime
            // 
            this.txt_pickupTime.Location = new System.Drawing.Point(73, 57);
            this.txt_pickupTime.Name = "txt_pickupTime";
            this.txt_pickupTime.Size = new System.Drawing.Size(89, 20);
            this.txt_pickupTime.TabIndex = 12;
            // 
            // dtp_pickup
            // 
            this.dtp_pickup.CustomFormat = "yyyy-MM-dd";
            this.dtp_pickup.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_pickup.Location = new System.Drawing.Point(73, 25);
            this.dtp_pickup.Name = "dtp_pickup";
            this.dtp_pickup.Size = new System.Drawing.Size(145, 20);
            this.dtp_pickup.TabIndex = 13;
            // 
            // dtp_return
            // 
            this.dtp_return.CustomFormat = "yyyy-MM-dd";
            this.dtp_return.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_return.Location = new System.Drawing.Point(73, 90);
            this.dtp_return.Name = "dtp_return";
            this.dtp_return.Size = new System.Drawing.Size(145, 20);
            this.dtp_return.TabIndex = 13;
            // 
            // btn_adjustCost
            // 
            this.btn_adjustCost.Location = new System.Drawing.Point(234, 79);
            this.btn_adjustCost.Name = "btn_adjustCost";
            this.btn_adjustCost.Size = new System.Drawing.Size(84, 27);
            this.btn_adjustCost.TabIndex = 15;
            this.btn_adjustCost.Text = "Adjust Cost";
            this.btn_adjustCost.UseVisualStyleBackColor = true;
            this.btn_adjustCost.Click += new System.EventHandler(this.btn_adjustCost_Click);
            // 
            // txt_dailyRate
            // 
            this.txt_dailyRate.Location = new System.Drawing.Point(50, 341);
            this.txt_dailyRate.Name = "txt_dailyRate";
            this.txt_dailyRate.Size = new System.Drawing.Size(43, 20);
            this.txt_dailyRate.TabIndex = 16;
            this.txt_dailyRate.Visible = false;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(296, 18);
            this.txt_model.Name = "txt_model";
            this.txt_model.ReadOnly = true;
            this.txt_model.Size = new System.Drawing.Size(100, 20);
            this.txt_model.TabIndex = 17;
            // 
            // txt_adjustedCost
            // 
            this.txt_adjustedCost.Location = new System.Drawing.Point(341, 83);
            this.txt_adjustedCost.Name = "txt_adjustedCost";
            this.txt_adjustedCost.ReadOnly = true;
            this.txt_adjustedCost.Size = new System.Drawing.Size(55, 20);
            this.txt_adjustedCost.TabIndex = 18;
            // 
            // dgv_Vehicles
            // 
            this.dgv_Vehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Vehicles.Location = new System.Drawing.Point(44, 286);
            this.dgv_Vehicles.Name = "dgv_Vehicles";
            this.dgv_Vehicles.Size = new System.Drawing.Size(820, 86);
            this.dgv_Vehicles.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "$";
            // 
            // gb_editBooking
            // 
            this.gb_editBooking.Controls.Add(this.label8);
            this.gb_editBooking.Controls.Add(this.label7);
            this.gb_editBooking.Controls.Add(this.label6);
            this.gb_editBooking.Controls.Add(this.label5);
            this.gb_editBooking.Controls.Add(this.label4);
            this.gb_editBooking.Controls.Add(this.label3);
            this.gb_editBooking.Controls.Add(this.txt_newOdo);
            this.gb_editBooking.Controls.Add(this.dtp_pickup);
            this.gb_editBooking.Controls.Add(this.label2);
            this.gb_editBooking.Controls.Add(this.txt_returnTime);
            this.gb_editBooking.Controls.Add(this.txt_pickupTime);
            this.gb_editBooking.Controls.Add(this.txt_adjustedCost);
            this.gb_editBooking.Controls.Add(this.dtp_return);
            this.gb_editBooking.Controls.Add(this.txt_model);
            this.gb_editBooking.Controls.Add(this.btn_adjustCost);
            this.gb_editBooking.Controls.Add(this.btn_saveBookingChanges);
            this.gb_editBooking.Location = new System.Drawing.Point(451, 387);
            this.gb_editBooking.Name = "gb_editBooking";
            this.gb_editBooking.Size = new System.Drawing.Size(405, 156);
            this.gb_editBooking.TabIndex = 21;
            this.gb_editBooking.TabStop = false;
            this.gb_editBooking.Text = "Edit Booking";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Return Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Return Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Pickup Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "Odometer \r\n Inbound:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "Vehicle \r\n Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Pickup Date:";
            // 
            // txt_newOdo
            // 
            this.txt_newOdo.Location = new System.Drawing.Point(296, 50);
            this.txt_newOdo.Name = "txt_newOdo";
            this.txt_newOdo.Size = new System.Drawing.Size(100, 20);
            this.txt_newOdo.TabIndex = 21;
            // 
            // dtp_searchDate
            // 
            this.dtp_searchDate.CustomFormat = "yyyy-MM-dd";
            this.dtp_searchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_searchDate.Location = new System.Drawing.Point(159, 258);
            this.dtp_searchDate.Name = "dtp_searchDate";
            this.dtp_searchDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_searchDate.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 26);
            this.label9.TabIndex = 23;
            this.label9.Text = "Select Date to Display\r\n    Bookings From:";
            // 
            // btn_searchDate
            // 
            this.btn_searchDate.Location = new System.Drawing.Point(366, 257);
            this.btn_searchDate.Name = "btn_searchDate";
            this.btn_searchDate.Size = new System.Drawing.Size(75, 23);
            this.btn_searchDate.TabIndex = 24;
            this.btn_searchDate.Text = "Search";
            this.btn_searchDate.UseVisualStyleBackColor = true;
            this.btn_searchDate.Click += new System.EventHandler(this.button6_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(451, 257);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 25;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(789, 256);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 26;
            this.button7.Text = "Refresh";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(909, 566);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_searchDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtp_searchDate);
            this.Controls.Add(this.gb_editBooking);
            this.Controls.Add(this.dgv_Vehicles);
            this.Controls.Add(this.gb_tableDetails);
            this.Controls.Add(this.gb_Customer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_dailyRate);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_Customer.ResumeLayout(false);
            this.gb_tableDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vehicles)).EndInit();
            this.gb_editBooking.ResumeLayout(false);
            this.gb_editBooking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_Customer;
        private System.Windows.Forms.GroupBox gb_tableDetails;
        private System.Windows.Forms.Button btn_saveBookingChanges;
        private System.Windows.Forms.TextBox txt_returnTime;
        private System.Windows.Forms.TextBox txt_pickupTime;
        private System.Windows.Forms.DateTimePicker dtp_pickup;
        private System.Windows.Forms.DateTimePicker dtp_return;
        private System.Windows.Forms.Button btn_adjustCost;
        private System.Windows.Forms.TextBox txt_dailyRate;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_adjustedCost;
        private System.Windows.Forms.DataGridView dgv_Vehicles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox gb_editBooking;
        private System.Windows.Forms.TextBox txt_newOdo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_searchDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_searchDate;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}