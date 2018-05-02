namespace CarHireForm1
{
    partial class ViewVehicles
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_vinNo = new System.Windows.Forms.TextBox();
            this.lbl_14 = new System.Windows.Forms.Label();
            this.lbl_13 = new System.Windows.Forms.Label();
            this.lbl_11 = new System.Windows.Forms.Label();
            this.lbl_10 = new System.Windows.Forms.Label();
            this.lbl_9 = new System.Windows.Forms.Label();
            this.lbl_8 = new System.Windows.Forms.Label();
            this.lbl_7 = new System.Windows.Forms.Label();
            this.lbl_6 = new System.Windows.Forms.Label();
            this.lbl_5 = new System.Windows.Forms.Label();
            this.lbl_4 = new System.Windows.Forms.Label();
            this.lbl_12 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.txt_accumObvs = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_dailyRate = new System.Windows.Forms.TextBox();
            this.txt_hourlyRate = new System.Windows.Forms.TextBox();
            this.txt_regoNo = new System.Windows.Forms.TextBox();
            this.txt_regoExpiry = new System.Windows.Forms.TextBox();
            this.txt_fuelType = new System.Windows.Forms.TextBox();
            this.txt_odometer = new System.Windows.Forms.TextBox();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.txt_transmission = new System.Windows.Forms.TextBox();
            this.txt_bodyType = new System.Windows.Forms.TextBox();
            this.txt_make = new System.Windows.Forms.TextBox();
            this.btn_saveChanges = new System.Windows.Forms.Button();
            this.cb_bodyType = new System.Windows.Forms.ComboBox();
            this.cb_transType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(560, 144);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add New Vehicle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_vinNo
            // 
            this.txt_vinNo.Location = new System.Drawing.Point(127, 162);
            this.txt_vinNo.Name = "txt_vinNo";
            this.txt_vinNo.ReadOnly = true;
            this.txt_vinNo.Size = new System.Drawing.Size(128, 20);
            this.txt_vinNo.TabIndex = 83;
            // 
            // lbl_14
            // 
            this.lbl_14.AutoSize = true;
            this.lbl_14.Location = new System.Drawing.Point(36, 165);
            this.lbl_14.Name = "lbl_14";
            this.lbl_14.Size = new System.Drawing.Size(68, 13);
            this.lbl_14.TabIndex = 82;
            this.lbl_14.Text = "Vin Number :";
            // 
            // lbl_13
            // 
            this.lbl_13.AutoSize = true;
            this.lbl_13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_13.Location = new System.Drawing.Point(36, 350);
            this.lbl_13.Name = "lbl_13";
            this.lbl_13.Padding = new System.Windows.Forms.Padding(0, 0, 3, 2);
            this.lbl_13.Size = new System.Drawing.Size(87, 32);
            this.lbl_13.TabIndex = 81;
            this.lbl_13.Text = "Accumulated\r\nObservations :";
            // 
            // lbl_11
            // 
            this.lbl_11.AutoSize = true;
            this.lbl_11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_11.Location = new System.Drawing.Point(36, 323);
            this.lbl_11.Name = "lbl_11";
            this.lbl_11.Padding = new System.Windows.Forms.Padding(0, 0, 3, 2);
            this.lbl_11.Size = new System.Drawing.Size(80, 17);
            this.lbl_11.TabIndex = 80;
            this.lbl_11.Text = "Hourly Rate :";
            // 
            // lbl_10
            // 
            this.lbl_10.AutoSize = true;
            this.lbl_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_10.Location = new System.Drawing.Point(36, 291);
            this.lbl_10.Name = "lbl_10";
            this.lbl_10.Padding = new System.Windows.Forms.Padding(0, 0, 3, 2);
            this.lbl_10.Size = new System.Drawing.Size(72, 17);
            this.lbl_10.TabIndex = 79;
            this.lbl_10.Text = "Daily Rate :";
            // 
            // lbl_9
            // 
            this.lbl_9.AutoSize = true;
            this.lbl_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_9.Location = new System.Drawing.Point(331, 316);
            this.lbl_9.Name = "lbl_9";
            this.lbl_9.Padding = new System.Windows.Forms.Padding(0, 0, 3, 2);
            this.lbl_9.Size = new System.Drawing.Size(79, 32);
            this.lbl_9.TabIndex = 78;
            this.lbl_9.Text = "Registration \r\n     Expiry :";
            // 
            // lbl_8
            // 
            this.lbl_8.AutoSize = true;
            this.lbl_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_8.Location = new System.Drawing.Point(331, 292);
            this.lbl_8.Name = "lbl_8";
            this.lbl_8.Padding = new System.Windows.Forms.Padding(0, 0, 3, 2);
            this.lbl_8.Size = new System.Drawing.Size(101, 17);
            this.lbl_8.TabIndex = 77;
            this.lbl_8.Text = "Registration No :";
            // 
            // lbl_7
            // 
            this.lbl_7.AutoSize = true;
            this.lbl_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_7.Location = new System.Drawing.Point(35, 259);
            this.lbl_7.Name = "lbl_7";
            this.lbl_7.Padding = new System.Windows.Forms.Padding(0, 0, 3, 2);
            this.lbl_7.Size = new System.Drawing.Size(69, 17);
            this.lbl_7.TabIndex = 76;
            this.lbl_7.Text = "Fuel Type :";
            // 
            // lbl_6
            // 
            this.lbl_6.AutoSize = true;
            this.lbl_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_6.Location = new System.Drawing.Point(331, 228);
            this.lbl_6.Name = "lbl_6";
            this.lbl_6.Padding = new System.Windows.Forms.Padding(0, 0, 3, 2);
            this.lbl_6.Size = new System.Drawing.Size(71, 17);
            this.lbl_6.TabIndex = 75;
            this.lbl_6.Text = "Odometer :";
            // 
            // lbl_5
            // 
            this.lbl_5.AutoSize = true;
            this.lbl_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_5.Location = new System.Drawing.Point(35, 228);
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Padding = new System.Windows.Forms.Padding(0, 0, 3, 2);
            this.lbl_5.Size = new System.Drawing.Size(90, 17);
            this.lbl_5.TabIndex = 74;
            this.lbl_5.Text = "Transmission :";
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_4.Location = new System.Drawing.Point(331, 195);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Padding = new System.Windows.Forms.Padding(0, 0, 3, 2);
            this.lbl_4.Size = new System.Drawing.Size(45, 17);
            this.lbl_4.TabIndex = 73;
            this.lbl_4.Text = "Color :";
            // 
            // lbl_12
            // 
            this.lbl_12.AutoSize = true;
            this.lbl_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_12.Location = new System.Drawing.Point(331, 260);
            this.lbl_12.Name = "lbl_12";
            this.lbl_12.Padding = new System.Windows.Forms.Padding(0, 0, 3, 2);
            this.lbl_12.Size = new System.Drawing.Size(72, 17);
            this.lbl_12.TabIndex = 72;
            this.lbl_12.Text = "Body Type :";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.Location = new System.Drawing.Point(35, 195);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Padding = new System.Windows.Forms.Padding(0, 0, 3, 2);
            this.lbl_2.Size = new System.Drawing.Size(54, 17);
            this.lbl_2.TabIndex = 71;
            this.lbl_2.Text = "Model : ";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(331, 163);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 2);
            this.lbl_1.Size = new System.Drawing.Size(47, 17);
            this.lbl_1.TabIndex = 70;
            this.lbl_1.Text = "Make :";
            // 
            // txt_accumObvs
            // 
            this.txt_accumObvs.Location = new System.Drawing.Point(127, 358);
            this.txt_accumObvs.Multiline = true;
            this.txt_accumObvs.Name = "txt_accumObvs";
            this.txt_accumObvs.Size = new System.Drawing.Size(305, 70);
            this.txt_accumObvs.TabIndex = 69;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(127, 194);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(100, 20);
            this.txt_model.TabIndex = 68;
            // 
            // txt_dailyRate
            // 
            this.txt_dailyRate.Location = new System.Drawing.Point(127, 290);
            this.txt_dailyRate.Name = "txt_dailyRate";
            this.txt_dailyRate.Size = new System.Drawing.Size(100, 20);
            this.txt_dailyRate.TabIndex = 67;
            // 
            // txt_hourlyRate
            // 
            this.txt_hourlyRate.Location = new System.Drawing.Point(127, 322);
            this.txt_hourlyRate.Name = "txt_hourlyRate";
            this.txt_hourlyRate.Size = new System.Drawing.Size(100, 20);
            this.txt_hourlyRate.TabIndex = 66;
            // 
            // txt_regoNo
            // 
            this.txt_regoNo.Location = new System.Drawing.Point(433, 291);
            this.txt_regoNo.Name = "txt_regoNo";
            this.txt_regoNo.Size = new System.Drawing.Size(100, 20);
            this.txt_regoNo.TabIndex = 65;
            // 
            // txt_regoExpiry
            // 
            this.txt_regoExpiry.Location = new System.Drawing.Point(433, 323);
            this.txt_regoExpiry.Name = "txt_regoExpiry";
            this.txt_regoExpiry.Size = new System.Drawing.Size(100, 20);
            this.txt_regoExpiry.TabIndex = 64;
            // 
            // txt_fuelType
            // 
            this.txt_fuelType.Location = new System.Drawing.Point(127, 258);
            this.txt_fuelType.Name = "txt_fuelType";
            this.txt_fuelType.Size = new System.Drawing.Size(100, 20);
            this.txt_fuelType.TabIndex = 63;
            // 
            // txt_odometer
            // 
            this.txt_odometer.Location = new System.Drawing.Point(433, 227);
            this.txt_odometer.Name = "txt_odometer";
            this.txt_odometer.Size = new System.Drawing.Size(100, 20);
            this.txt_odometer.TabIndex = 62;
            // 
            // txt_color
            // 
            this.txt_color.Location = new System.Drawing.Point(433, 194);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(100, 20);
            this.txt_color.TabIndex = 61;
            // 
            // txt_transmission
            // 
            this.txt_transmission.Location = new System.Drawing.Point(12, 385);
            this.txt_transmission.Name = "txt_transmission";
            this.txt_transmission.Size = new System.Drawing.Size(100, 20);
            this.txt_transmission.TabIndex = 60;
            // 
            // txt_bodyType
            // 
            this.txt_bodyType.Location = new System.Drawing.Point(12, 408);
            this.txt_bodyType.Name = "txt_bodyType";
            this.txt_bodyType.Size = new System.Drawing.Size(100, 20);
            this.txt_bodyType.TabIndex = 59;
            this.txt_bodyType.Visible = false;
            // 
            // txt_make
            // 
            this.txt_make.Location = new System.Drawing.Point(433, 162);
            this.txt_make.Name = "txt_make";
            this.txt_make.Size = new System.Drawing.Size(100, 20);
            this.txt_make.TabIndex = 58;
            // 
            // btn_saveChanges
            // 
            this.btn_saveChanges.Location = new System.Drawing.Point(470, 364);
            this.btn_saveChanges.Name = "btn_saveChanges";
            this.btn_saveChanges.Size = new System.Drawing.Size(102, 27);
            this.btn_saveChanges.TabIndex = 84;
            this.btn_saveChanges.Text = "Save Changes";
            this.btn_saveChanges.UseVisualStyleBackColor = true;
            this.btn_saveChanges.Click += new System.EventHandler(this.btn_saveChanges_Click);
            // 
            // cb_bodyType
            // 
            this.cb_bodyType.FormattingEnabled = true;
            this.cb_bodyType.Location = new System.Drawing.Point(433, 259);
            this.cb_bodyType.Name = "cb_bodyType";
            this.cb_bodyType.Size = new System.Drawing.Size(100, 21);
            this.cb_bodyType.TabIndex = 85;
            this.cb_bodyType.SelectedIndexChanged += new System.EventHandler(this.cb_bodyType_SelectedIndexChanged);
            // 
            // cb_transType
            // 
            this.cb_transType.FormattingEnabled = true;
            this.cb_transType.Location = new System.Drawing.Point(127, 225);
            this.cb_transType.Name = "cb_transType";
            this.cb_transType.Size = new System.Drawing.Size(100, 21);
            this.cb_transType.TabIndex = 86;
            // 
            // ViewVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(584, 436);
            this.Controls.Add(this.cb_transType);
            this.Controls.Add(this.cb_bodyType);
            this.Controls.Add(this.btn_saveChanges);
            this.Controls.Add(this.txt_vinNo);
            this.Controls.Add(this.lbl_14);
            this.Controls.Add(this.lbl_13);
            this.Controls.Add(this.lbl_11);
            this.Controls.Add(this.lbl_10);
            this.Controls.Add(this.lbl_9);
            this.Controls.Add(this.lbl_8);
            this.Controls.Add(this.lbl_7);
            this.Controls.Add(this.lbl_6);
            this.Controls.Add(this.lbl_5);
            this.Controls.Add(this.lbl_4);
            this.Controls.Add(this.lbl_12);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.txt_accumObvs);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.txt_dailyRate);
            this.Controls.Add(this.txt_hourlyRate);
            this.Controls.Add(this.txt_regoNo);
            this.Controls.Add(this.txt_regoExpiry);
            this.Controls.Add(this.txt_fuelType);
            this.Controls.Add(this.txt_odometer);
            this.Controls.Add(this.txt_color);
            this.Controls.Add(this.txt_transmission);
            this.Controls.Add(this.txt_bodyType);
            this.Controls.Add(this.txt_make);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewVehicles";
            this.Text = "ViewVehicles";
            this.Load += new System.EventHandler(this.ViewVehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_vinNo;
        private System.Windows.Forms.Label lbl_14;
        private System.Windows.Forms.Label lbl_13;
        private System.Windows.Forms.Label lbl_11;
        private System.Windows.Forms.Label lbl_10;
        private System.Windows.Forms.Label lbl_9;
        private System.Windows.Forms.Label lbl_8;
        private System.Windows.Forms.Label lbl_7;
        private System.Windows.Forms.Label lbl_6;
        private System.Windows.Forms.Label lbl_5;
        private System.Windows.Forms.Label lbl_4;
        private System.Windows.Forms.Label lbl_12;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.TextBox txt_accumObvs;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_dailyRate;
        private System.Windows.Forms.TextBox txt_hourlyRate;
        private System.Windows.Forms.TextBox txt_regoNo;
        private System.Windows.Forms.TextBox txt_regoExpiry;
        private System.Windows.Forms.TextBox txt_fuelType;
        private System.Windows.Forms.TextBox txt_odometer;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.TextBox txt_transmission;
        private System.Windows.Forms.TextBox txt_bodyType;
        private System.Windows.Forms.TextBox txt_make;
        private System.Windows.Forms.Button btn_saveChanges;
        private System.Windows.Forms.ComboBox cb_bodyType;
        private System.Windows.Forms.ComboBox cb_transType;
    }
}