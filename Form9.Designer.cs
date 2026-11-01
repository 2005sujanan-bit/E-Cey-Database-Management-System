namespace E293997_new
{
    partial class Form9
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
            this.cmbBodyType = new System.Windows.Forms.ComboBox();
            this.button11 = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSeatingCapacity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMotorPower = new System.Windows.Forms.TextBox();
            this.txtTopSpeed = new System.Windows.Forms.TextBox();
            this.txtBatteryCapacity = new System.Windows.Forms.TextBox();
            this.txtVehicleModelID = new System.Windows.Forms.TextBox();
            this.txtChargingTime = new System.Windows.Forms.TextBox();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.cmbDriveType = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBatteryType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvvehiclemodel = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvehiclemodel)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBodyType
            // 
            this.cmbBodyType.FormattingEnabled = true;
            this.cmbBodyType.Items.AddRange(new object[] {
            "SUV",
            "",
            "MPV",
            "",
            "Coupe",
            "",
            "Convertible",
            "",
            "Van",
            "",
            "Wagon",
            "",
            "Crossover",
            "",
            "Roadster",
            "",
            "Minivan",
            "",
            "Limousine"});
            this.cmbBodyType.Location = new System.Drawing.Point(352, 349);
            this.cmbBodyType.Name = "cmbBodyType";
            this.cmbBodyType.Size = new System.Drawing.Size(223, 24);
            this.cmbBodyType.TabIndex = 94;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.IndianRed;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(1206, 29);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(148, 49);
            this.button11.TabIndex = 93;
            this.button11.Text = "Back";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Gray;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(1310, 181);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(192, 50);
            this.btnInsert.TabIndex = 92;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gray;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1310, 256);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(192, 50);
            this.btnUpdate.TabIndex = 91;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1310, 336);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(192, 50);
            this.btnDelete.TabIndex = 90;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1310, 411);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(192, 50);
            this.btnClear.TabIndex = 89;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSeatingCapacity
            // 
            this.txtSeatingCapacity.Location = new System.Drawing.Point(980, 393);
            this.txtSeatingCapacity.Name = "txtSeatingCapacity";
            this.txtSeatingCapacity.Size = new System.Drawing.Size(223, 22);
            this.txtSeatingCapacity.TabIndex = 88;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(352, 422);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(223, 22);
            this.txtPrice.TabIndex = 87;
            // 
            // txtMotorPower
            // 
            this.txtMotorPower.Location = new System.Drawing.Point(980, 195);
            this.txtMotorPower.Name = "txtMotorPower";
            this.txtMotorPower.Size = new System.Drawing.Size(223, 22);
            this.txtMotorPower.TabIndex = 86;
            // 
            // txtTopSpeed
            // 
            this.txtTopSpeed.Location = new System.Drawing.Point(980, 333);
            this.txtTopSpeed.Name = "txtTopSpeed";
            this.txtTopSpeed.Size = new System.Drawing.Size(223, 22);
            this.txtTopSpeed.TabIndex = 85;
            // 
            // txtBatteryCapacity
            // 
            this.txtBatteryCapacity.Location = new System.Drawing.Point(352, 494);
            this.txtBatteryCapacity.Name = "txtBatteryCapacity";
            this.txtBatteryCapacity.Size = new System.Drawing.Size(223, 22);
            this.txtBatteryCapacity.TabIndex = 84;
            // 
            // txtVehicleModelID
            // 
            this.txtVehicleModelID.Location = new System.Drawing.Point(352, 214);
            this.txtVehicleModelID.Name = "txtVehicleModelID";
            this.txtVehicleModelID.Size = new System.Drawing.Size(223, 22);
            this.txtVehicleModelID.TabIndex = 83;
            this.txtVehicleModelID.TextChanged += new System.EventHandler(this.txtVehicleModelID_TextChanged);
            // 
            // txtChargingTime
            // 
            this.txtChargingTime.Location = new System.Drawing.Point(980, 266);
            this.txtChargingTime.Name = "txtChargingTime";
            this.txtChargingTime.Size = new System.Drawing.Size(223, 22);
            this.txtChargingTime.TabIndex = 82;
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(352, 283);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(223, 22);
            this.txtModelName.TabIndex = 81;
            // 
            // cmbDriveType
            // 
            this.cmbDriveType.FormattingEnabled = true;
            this.cmbDriveType.Items.AddRange(new object[] {
            "FWD",
            "RWD",
            "AWD",
            "4WD ",
            " Dual Motor AWD"});
            this.cmbDriveType.Location = new System.Drawing.Point(980, 467);
            this.cmbDriveType.Name = "cmbDriveType";
            this.cmbDriveType.Size = new System.Drawing.Size(223, 24);
            this.cmbDriveType.TabIndex = 79;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(123, 283);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(152, 29);
            this.label15.TabIndex = 78;
            this.label15.Text = "Model Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(123, 349);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 29);
            this.label14.TabIndex = 77;
            this.label14.Text = "Body type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(123, 422);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 29);
            this.label13.TabIndex = 76;
            this.label13.Text = "price";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(123, 494);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 29);
            this.label12.TabIndex = 75;
            this.label12.Text = "Battery capacity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(766, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 29);
            this.label11.TabIndex = 74;
            this.label11.Text = "Motor power";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(123, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 29);
            this.label10.TabIndex = 73;
            this.label10.Text = "Vehicle Model ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(766, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 29);
            this.label9.TabIndex = 72;
            this.label9.Text = "Charging time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(766, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 29);
            this.label8.TabIndex = 71;
            this.label8.Text = "Top speed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(766, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 29);
            this.label7.TabIndex = 70;
            this.label7.Text = "Seating capacity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(766, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 29);
            this.label6.TabIndex = 69;
            this.label6.Text = "Drive type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(476, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 46);
            this.label3.TabIndex = 67;
            this.label3.Text = "Vehicle model";
            // 
            // cmbBatteryType
            // 
            this.cmbBatteryType.FormattingEnabled = true;
            this.cmbBatteryType.Items.AddRange(new object[] {
            " Lithium-Ion",
            "Lithium Iron Phosphate",
            " Nickel Manganese Cobalt ",
            " Nickel Cobalt Aluminium"});
            this.cmbBatteryType.Location = new System.Drawing.Point(980, 541);
            this.cmbBatteryType.Name = "cmbBatteryType";
            this.cmbBatteryType.Size = new System.Drawing.Size(223, 24);
            this.cmbBatteryType.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(766, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 95;
            this.label1.Text = "Battery type";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearch.Location = new System.Drawing.Point(592, 213);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 97;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvvehiclemodel
            // 
            this.dgvvehiclemodel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvehiclemodel.Location = new System.Drawing.Point(12, 595);
            this.dgvvehiclemodel.Name = "dgvvehiclemodel";
            this.dgvvehiclemodel.RowHeadersWidth = 51;
            this.dgvvehiclemodel.RowTemplate.Height = 24;
            this.dgvvehiclemodel.Size = new System.Drawing.Size(1319, 178);
            this.dgvvehiclemodel.TabIndex = 98;
            this.dgvvehiclemodel.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1310, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 49);
            this.button2.TabIndex = 99;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E293997_new.Properties.Resources.ChatGPT_Image_Sep_17__2026__11_02_01_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1569, 785);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvvehiclemodel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbBatteryType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBodyType);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSeatingCapacity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtMotorPower);
            this.Controls.Add(this.txtTopSpeed);
            this.Controls.Add(this.txtBatteryCapacity);
            this.Controls.Add(this.txtVehicleModelID);
            this.Controls.Add(this.txtChargingTime);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.cmbDriveType);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvehiclemodel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBodyType;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSeatingCapacity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMotorPower;
        private System.Windows.Forms.TextBox txtTopSpeed;
        private System.Windows.Forms.TextBox txtBatteryCapacity;
        private System.Windows.Forms.TextBox txtVehicleModelID;
        private System.Windows.Forms.TextBox txtChargingTime;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.ComboBox cmbDriveType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBatteryType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvvehiclemodel;
        private System.Windows.Forms.Button button2;
    }
}