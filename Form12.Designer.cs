namespace E293997_new
{
    partial class Form12
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtVehicleRegisterNumber = new System.Windows.Forms.Label();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.txtRegisterCompany = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dtpManufacturingYear = new System.Windows.Forms.DateTimePicker();
            this.txtPowerSource = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dgvlogisticvehicle = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlogisticvehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(366, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 22);
            this.textBox1.TabIndex = 80;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtVehicleRegisterNumber
            // 
            this.txtVehicleRegisterNumber.AutoSize = true;
            this.txtVehicleRegisterNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtVehicleRegisterNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleRegisterNumber.Location = new System.Drawing.Point(67, 222);
            this.txtVehicleRegisterNumber.Name = "txtVehicleRegisterNumber";
            this.txtVehicleRegisterNumber.Size = new System.Drawing.Size(283, 29);
            this.txtVehicleRegisterNumber.TabIndex = 79;
            this.txtVehicleRegisterNumber.Text = "Vehicle Register Number";
            this.txtVehicleRegisterNumber.Click += new System.EventHandler(this.txtVehicleRegisterNumber_Click);
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Items.AddRange(new object[] {
            "Ship",
            "Train",
            "Truck"});
            this.cmbVehicleType.Location = new System.Drawing.Point(366, 300);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(272, 24);
            this.cmbVehicleType.TabIndex = 78;
            this.cmbVehicleType.SelectedIndexChanged += new System.EventHandler(this.cmbVehicleType_SelectedIndexChanged);
            // 
            // txtRegisterCompany
            // 
            this.txtRegisterCompany.Location = new System.Drawing.Point(980, 427);
            this.txtRegisterCompany.Name = "txtRegisterCompany";
            this.txtRegisterCompany.Size = new System.Drawing.Size(272, 22);
            this.txtRegisterCompany.TabIndex = 77;
            this.txtRegisterCompany.TextChanged += new System.EventHandler(this.txtRegisterCompany_TextChanged);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.IndianRed;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(1120, 31);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(165, 49);
            this.button11.TabIndex = 76;
            this.button11.Text = "Back";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Gray;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(1292, 169);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(192, 50);
            this.btnInsert.TabIndex = 75;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gray;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1292, 244);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(192, 50);
            this.btnUpdate.TabIndex = 74;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1292, 324);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(192, 50);
            this.btnDelete.TabIndex = 73;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1292, 399);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(192, 50);
            this.btnClear.TabIndex = 72;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dtpManufacturingYear
            // 
            this.dtpManufacturingYear.Location = new System.Drawing.Point(980, 346);
            this.dtpManufacturingYear.MinDate = new System.DateTime(2000, 9, 24, 0, 0, 0, 0);
            this.dtpManufacturingYear.Name = "dtpManufacturingYear";
            this.dtpManufacturingYear.Size = new System.Drawing.Size(272, 22);
            this.dtpManufacturingYear.TabIndex = 71;
            this.dtpManufacturingYear.Value = new System.DateTime(2000, 9, 24, 0, 0, 0, 0);
            this.dtpManufacturingYear.ValueChanged += new System.EventHandler(this.dtpManufacturingYear_ValueChanged);
            // 
            // txtPowerSource
            // 
            this.txtPowerSource.Location = new System.Drawing.Point(980, 275);
            this.txtPowerSource.Name = "txtPowerSource";
            this.txtPowerSource.Size = new System.Drawing.Size(272, 22);
            this.txtPowerSource.TabIndex = 70;
            this.txtPowerSource.TextChanged += new System.EventHandler(this.txtPowerSource_TextChanged);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(366, 440);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(272, 22);
            this.txtModel.TabIndex = 69;
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(366, 376);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(272, 22);
            this.txtBrand.TabIndex = 68;
            this.txtBrand.TextChanged += new System.EventHandler(this.txtBrand_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(67, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 29);
            this.label9.TabIndex = 67;
            this.label9.Text = "Vehicle type";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(80, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 29);
            this.label8.TabIndex = 66;
            this.label8.Text = "Brand";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 29);
            this.label7.TabIndex = 65;
            this.label7.Text = "Model";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(732, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 29);
            this.label6.TabIndex = 64;
            this.label6.Text = "Power source";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(732, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 29);
            this.label5.TabIndex = 63;
            this.label5.Text = "Manufactured year";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(732, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 29);
            this.label4.TabIndex = 62;
            this.label4.Text = "Registered Company";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(484, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 46);
            this.label3.TabIndex = 61;
            this.label3.Text = "Logistic vehicle";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsearch.Location = new System.Drawing.Point(669, 228);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 81;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dgvlogisticvehicle
            // 
            this.dgvlogisticvehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlogisticvehicle.Location = new System.Drawing.Point(12, 535);
            this.dgvlogisticvehicle.Name = "dgvlogisticvehicle";
            this.dgvlogisticvehicle.RowHeadersWidth = 51;
            this.dgvlogisticvehicle.RowTemplate.Height = 24;
            this.dgvlogisticvehicle.Size = new System.Drawing.Size(1062, 168);
            this.dgvlogisticvehicle.TabIndex = 82;
            this.dgvlogisticvehicle.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1292, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 49);
            this.button2.TabIndex = 100;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E293997_new.Properties.Resources.ChatGPT_Image_Sep_17__2026__11_02_01_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1736, 763);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvlogisticvehicle);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtVehicleRegisterNumber);
            this.Controls.Add(this.cmbVehicleType);
            this.Controls.Add(this.txtRegisterCompany);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dtpManufacturingYear);
            this.Controls.Add(this.txtPowerSource);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form12";
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlogisticvehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtVehicleRegisterNumber;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.TextBox txtRegisterCompany;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dtpManufacturingYear;
        private System.Windows.Forms.TextBox txtPowerSource;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dgvlogisticvehicle;
        private System.Windows.Forms.Button button2;
    }
}