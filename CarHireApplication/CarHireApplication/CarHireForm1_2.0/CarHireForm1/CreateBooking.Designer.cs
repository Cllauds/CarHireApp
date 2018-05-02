namespace CarHireForm1
{
    partial class CreateBooking
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
            this.dgv_custView = new System.Windows.Forms.DataGridView();
            this.dgv_vehicleView = new System.Windows.Forms.DataGridView();
            this.txt_dailyRate = new System.Windows.Forms.TextBox();
            this.txt_customerNo = new System.Windows.Forms.TextBox();
            this.txt_employeeID = new System.Windows.Forms.TextBox();
            this.txt_vinNo = new System.Windows.Forms.TextBox();
            this.txt_totalCost = new System.Windows.Forms.TextBox();
            this.txt_pickupTime = new System.Windows.Forms.TextBox();
            this.txt_returnTime = new System.Windows.Forms.TextBox();
            this.txt_obsvOutbound = new System.Windows.Forms.TextBox();
            this.txt_obsvInbound = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_pickupDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_returnDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_submitBooking = new System.Windows.Forms.Button();
            this.txt_odoOutBound = new System.Windows.Forms.TextBox();
            this.txt_odoInBound = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_calcCost = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_custView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehicleView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_custView
            // 
            this.dgv_custView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_custView.Location = new System.Drawing.Point(12, 12);
            this.dgv_custView.MultiSelect = false;
            this.dgv_custView.Name = "dgv_custView";
            this.dgv_custView.ReadOnly = true;
            this.dgv_custView.Size = new System.Drawing.Size(820, 123);
            this.dgv_custView.TabIndex = 0;
            this.dgv_custView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_custView_CellClick);
            // 
            // dgv_vehicleView
            // 
            this.dgv_vehicleView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vehicleView.Location = new System.Drawing.Point(12, 141);
            this.dgv_vehicleView.MultiSelect = false;
            this.dgv_vehicleView.Name = "dgv_vehicleView";
            this.dgv_vehicleView.ReadOnly = true;
            this.dgv_vehicleView.Size = new System.Drawing.Size(820, 125);
            this.dgv_vehicleView.TabIndex = 1;
            this.dgv_vehicleView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vehicleView_CellClick);
            // 
            // txt_dailyRate
            // 
            this.txt_dailyRate.Location = new System.Drawing.Point(99, 400);
            this.txt_dailyRate.Name = "txt_dailyRate";
            this.txt_dailyRate.ReadOnly = true;
            this.txt_dailyRate.Size = new System.Drawing.Size(100, 20);
            this.txt_dailyRate.TabIndex = 2;
            // 
            // txt_customerNo
            // 
            this.txt_customerNo.Location = new System.Drawing.Point(99, 281);
            this.txt_customerNo.Name = "txt_customerNo";
            this.txt_customerNo.ReadOnly = true;
            this.txt_customerNo.Size = new System.Drawing.Size(100, 20);
            this.txt_customerNo.TabIndex = 3;
            // 
            // txt_employeeID
            // 
            this.txt_employeeID.Location = new System.Drawing.Point(99, 322);
            this.txt_employeeID.Name = "txt_employeeID";
            this.txt_employeeID.Size = new System.Drawing.Size(100, 20);
            this.txt_employeeID.TabIndex = 4;
            // 
            // txt_vinNo
            // 
            this.txt_vinNo.Location = new System.Drawing.Point(99, 362);
            this.txt_vinNo.Name = "txt_vinNo";
            this.txt_vinNo.ReadOnly = true;
            this.txt_vinNo.Size = new System.Drawing.Size(200, 20);
            this.txt_vinNo.TabIndex = 5;
            // 
            // txt_totalCost
            // 
            this.txt_totalCost.Location = new System.Drawing.Point(732, 320);
            this.txt_totalCost.Name = "txt_totalCost";
            this.txt_totalCost.ReadOnly = true;
            this.txt_totalCost.Size = new System.Drawing.Size(100, 20);
            this.txt_totalCost.TabIndex = 6;
            // 
            // txt_pickupTime
            // 
            this.txt_pickupTime.Location = new System.Drawing.Point(414, 320);
            this.txt_pickupTime.Name = "txt_pickupTime";
            this.txt_pickupTime.Size = new System.Drawing.Size(100, 20);
            this.txt_pickupTime.TabIndex = 7;
            // 
            // txt_returnTime
            // 
            this.txt_returnTime.Location = new System.Drawing.Point(414, 401);
            this.txt_returnTime.Name = "txt_returnTime";
            this.txt_returnTime.Size = new System.Drawing.Size(100, 20);
            this.txt_returnTime.TabIndex = 8;
            // 
            // txt_obsvOutbound
            // 
            this.txt_obsvOutbound.Location = new System.Drawing.Point(100, 441);
            this.txt_obsvOutbound.Multiline = true;
            this.txt_obsvOutbound.Name = "txt_obsvOutbound";
            this.txt_obsvOutbound.Size = new System.Drawing.Size(240, 64);
            this.txt_obsvOutbound.TabIndex = 9;
            // 
            // txt_obsvInbound
            // 
            this.txt_obsvInbound.Location = new System.Drawing.Point(451, 441);
            this.txt_obsvInbound.Multiline = true;
            this.txt_obsvInbound.Name = "txt_obsvInbound";
            this.txt_obsvInbound.Size = new System.Drawing.Size(240, 64);
            this.txt_obsvInbound.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dailyrate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "CustomerNo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "EmployeeID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "VinNo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "PickUp Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Return Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "Observations\r\nOutbound:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "Observations\r\nInbound:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(663, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Total Cost:";
            // 
            // dtp_pickupDate
            // 
            this.dtp_pickupDate.CustomFormat = "yyyy-MM-dd";
            this.dtp_pickupDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_pickupDate.Location = new System.Drawing.Point(414, 281);
            this.dtp_pickupDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_pickupDate.Name = "dtp_pickupDate";
            this.dtp_pickupDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_pickupDate.TabIndex = 20;
            // 
            // dtp_returnDate
            // 
            this.dtp_returnDate.CustomFormat = "yyyy-MM-dd";
            this.dtp_returnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_returnDate.Location = new System.Drawing.Point(414, 361);
            this.dtp_returnDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_returnDate.Name = "dtp_returnDate";
            this.dtp_returnDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_returnDate.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(337, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "PickUp Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(337, 364);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Return Date:";
            // 
            // btn_submitBooking
            // 
            this.btn_submitBooking.Enabled = false;
            this.btn_submitBooking.Location = new System.Drawing.Point(732, 404);
            this.btn_submitBooking.Name = "btn_submitBooking";
            this.btn_submitBooking.Size = new System.Drawing.Size(100, 36);
            this.btn_submitBooking.TabIndex = 24;
            this.btn_submitBooking.Text = "Submit\r\nBooking:";
            this.btn_submitBooking.UseVisualStyleBackColor = true;
            this.btn_submitBooking.Click += new System.EventHandler(this.btn_submitBooking_Click);
            // 
            // txt_odoOutBound
            // 
            this.txt_odoOutBound.Location = new System.Drawing.Point(732, 281);
            this.txt_odoOutBound.Name = "txt_odoOutBound";
            this.txt_odoOutBound.ReadOnly = true;
            this.txt_odoOutBound.Size = new System.Drawing.Size(100, 20);
            this.txt_odoOutBound.TabIndex = 25;
            // 
            // txt_odoInBound
            // 
            this.txt_odoInBound.Location = new System.Drawing.Point(108, 157);
            this.txt_odoInBound.Name = "txt_odoInBound";
            this.txt_odoInBound.Size = new System.Drawing.Size(100, 20);
            this.txt_odoInBound.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(638, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Outbound Odom:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Inbound Odom:";
            // 
            // btn_calcCost
            // 
            this.btn_calcCost.Location = new System.Drawing.Point(732, 355);
            this.btn_calcCost.Name = "btn_calcCost";
            this.btn_calcCost.Size = new System.Drawing.Size(100, 36);
            this.btn_calcCost.TabIndex = 29;
            this.btn_calcCost.Text = "Calculate Cost:";
            this.btn_calcCost.UseVisualStyleBackColor = true;
            this.btn_calcCost.Click += new System.EventHandler(this.btn_calcCost_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(718, 322);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 15);
            this.label14.TabIndex = 30;
            this.label14.Text = "$";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(520, 323);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Eg. 9:00/21:00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(520, 405);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Eg. 9:00/21:00";
            // 
            // CreateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 521);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_calcCost);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_odoOutBound);
            this.Controls.Add(this.btn_submitBooking);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtp_returnDate);
            this.Controls.Add(this.dtp_pickupDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_obsvInbound);
            this.Controls.Add(this.txt_obsvOutbound);
            this.Controls.Add(this.txt_returnTime);
            this.Controls.Add(this.txt_pickupTime);
            this.Controls.Add(this.txt_totalCost);
            this.Controls.Add(this.txt_vinNo);
            this.Controls.Add(this.txt_employeeID);
            this.Controls.Add(this.txt_customerNo);
            this.Controls.Add(this.txt_dailyRate);
            this.Controls.Add(this.dgv_vehicleView);
            this.Controls.Add(this.dgv_custView);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_odoInBound);
            this.Name = "CreateBooking";
            this.Text = "CreateBooking";
            this.Load += new System.EventHandler(this.CreateBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_custView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehicleView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_custView;
        private System.Windows.Forms.DataGridView dgv_vehicleView;
        private System.Windows.Forms.TextBox txt_dailyRate;
        private System.Windows.Forms.TextBox txt_customerNo;
        private System.Windows.Forms.TextBox txt_employeeID;
        private System.Windows.Forms.TextBox txt_vinNo;
        private System.Windows.Forms.TextBox txt_totalCost;
        private System.Windows.Forms.TextBox txt_pickupTime;
        private System.Windows.Forms.TextBox txt_returnTime;
        private System.Windows.Forms.TextBox txt_obsvOutbound;
        private System.Windows.Forms.TextBox txt_obsvInbound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_pickupDate;
        private System.Windows.Forms.DateTimePicker dtp_returnDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_submitBooking;
        private System.Windows.Forms.TextBox txt_odoOutBound;
        private System.Windows.Forms.TextBox txt_odoInBound;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_calcCost;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}