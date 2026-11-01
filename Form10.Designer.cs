namespace E293997_new
{
    partial class Form10
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUniqueID = new System.Windows.Forms.ComboBox();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e_Cey_companyDataSet22 = new E293997_new.E_Cey_companyDataSet22();
            this.button11 = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbOrderID = new System.Windows.Forms.ComboBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtMotorSerialNumber = new System.Windows.Forms.TextBox();
            this.txtChassisSerialNumber = new System.Windows.Forms.TextBox();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.txtVehicleID = new System.Windows.Forms.TextBox();
            this.dtpManufactureDate = new System.Windows.Forms.DateTimePicker();
            this.cmbQCStatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dgvvehicle = new System.Windows.Forms.DataGridView();
            this.e_Cey_companyDataSet13 = new E293997_new.E_Cey_companyDataSet13();
            this.vehicleTableAdapter = new E293997_new.E_Cey_companyDataSet22TableAdapters.vehicleTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.e_Cey_companyDataSet43 = new E293997_new.E_Cey_companyDataSet43();
            this.e_Cey_companyDataSet44 = new E293997_new.E_Cey_companyDataSet44();
            this.order1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order1TableAdapter = new E293997_new.E_Cey_companyDataSet44TableAdapters.order1TableAdapter();
            this.e_Cey_companyDataSet45 = new E293997_new.E_Cey_companyDataSet45();
            this.orderdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_detailsTableAdapter = new E293997_new.E_Cey_companyDataSet45TableAdapters.order_detailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(679, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 83;
            this.label1.Text = "OD ID";
            // 
            // cmbUniqueID
            // 
            this.cmbUniqueID.DataSource = this.orderdetailsBindingSource;
            this.cmbUniqueID.DisplayMember = "OD_ID";
            this.cmbUniqueID.FormattingEnabled = true;
            this.cmbUniqueID.Location = new System.Drawing.Point(917, 477);
            this.cmbUniqueID.Name = "cmbUniqueID";
            this.cmbUniqueID.Size = new System.Drawing.Size(251, 24);
            this.cmbUniqueID.TabIndex = 82;
            this.cmbUniqueID.ValueMember = "OD_ID";
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "vehicle";
            this.vehicleBindingSource.DataSource = this.e_Cey_companyDataSet22;
            // 
            // e_Cey_companyDataSet22
            // 
            this.e_Cey_companyDataSet22.DataSetName = "E_Cey_companyDataSet22";
            this.e_Cey_companyDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.IndianRed;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(1223, 16);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(160, 50);
            this.button11.TabIndex = 81;
            this.button11.Text = "Back";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Gray;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(1291, 176);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(192, 50);
            this.btnInsert.TabIndex = 80;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gray;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1291, 251);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(192, 50);
            this.btnUpdate.TabIndex = 79;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1291, 331);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(192, 50);
            this.btnDelete.TabIndex = 78;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1291, 406);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(192, 50);
            this.btnClear.TabIndex = 77;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbOrderID
            // 
            this.cmbOrderID.DataSource = this.order1BindingSource;
            this.cmbOrderID.DisplayMember = "order_ID";
            this.cmbOrderID.FormattingEnabled = true;
            this.cmbOrderID.Location = new System.Drawing.Point(917, 406);
            this.cmbOrderID.Name = "cmbOrderID";
            this.cmbOrderID.Size = new System.Drawing.Size(251, 24);
            this.cmbOrderID.TabIndex = 76;
            this.cmbOrderID.ValueMember = "order_ID";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(917, 187);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(251, 22);
            this.txtWeight.TabIndex = 75;
            // 
            // txtMotorSerialNumber
            // 
            this.txtMotorSerialNumber.Location = new System.Drawing.Point(326, 384);
            this.txtMotorSerialNumber.Name = "txtMotorSerialNumber";
            this.txtMotorSerialNumber.Size = new System.Drawing.Size(251, 22);
            this.txtMotorSerialNumber.TabIndex = 74;
            // 
            // txtChassisSerialNumber
            // 
            this.txtChassisSerialNumber.Location = new System.Drawing.Point(326, 306);
            this.txtChassisSerialNumber.Name = "txtChassisSerialNumber";
            this.txtChassisSerialNumber.Size = new System.Drawing.Size(251, 22);
            this.txtChassisSerialNumber.TabIndex = 73;
            // 
            // txtVIN
            // 
            this.txtVIN.Location = new System.Drawing.Point(326, 245);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(251, 22);
            this.txtVIN.TabIndex = 72;
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(326, 453);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(251, 22);
            this.txtColour.TabIndex = 71;
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.Location = new System.Drawing.Point(326, 189);
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.Size = new System.Drawing.Size(251, 22);
            this.txtVehicleID.TabIndex = 70;
            this.txtVehicleID.TextChanged += new System.EventHandler(this.txtVehicleID_TextChanged);
            // 
            // dtpManufactureDate
            // 
            this.dtpManufactureDate.Location = new System.Drawing.Point(917, 260);
            this.dtpManufactureDate.Name = "dtpManufactureDate";
            this.dtpManufactureDate.Size = new System.Drawing.Size(251, 22);
            this.dtpManufactureDate.TabIndex = 69;
            // 
            // cmbQCStatus
            // 
            this.cmbQCStatus.FormattingEnabled = true;
            this.cmbQCStatus.Items.AddRange(new object[] {
            "Pending",
            "Pass"});
            this.cmbQCStatus.Location = new System.Drawing.Point(917, 329);
            this.cmbQCStatus.Name = "cmbQCStatus";
            this.cmbQCStatus.Size = new System.Drawing.Size(251, 24);
            this.cmbQCStatus.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(679, 406);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 29);
            this.label11.TabIndex = 67;
            this.label11.Text = "Order ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(679, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 29);
            this.label10.TabIndex = 66;
            this.label10.Text = "QC status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(92, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 29);
            this.label9.TabIndex = 65;
            this.label9.Text = "Vehicle ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(113, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 29);
            this.label8.TabIndex = 64;
            this.label8.Text = "VIN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 29);
            this.label7.TabIndex = 63;
            this.label7.Text = "Chassis serial number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(563, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 46);
            this.label6.TabIndex = 62;
            this.label6.Text = "Vehicle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 29);
            this.label5.TabIndex = 61;
            this.label5.Text = "Motor serial Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(679, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 60;
            this.label4.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 59;
            this.label3.Text = "Colour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(679, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 29);
            this.label2.TabIndex = 58;
            this.label2.Text = "Manufacture date";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsearch.Location = new System.Drawing.Point(583, 189);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 84;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dgvvehicle
            // 
            this.dgvvehicle.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvvehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvehicle.Location = new System.Drawing.Point(12, 550);
            this.dgvvehicle.Name = "dgvvehicle";
            this.dgvvehicle.RowHeadersWidth = 51;
            this.dgvvehicle.RowTemplate.Height = 24;
            this.dgvvehicle.Size = new System.Drawing.Size(1058, 189);
            this.dgvvehicle.TabIndex = 85;
            this.dgvvehicle.Visible = false;
            // 
            // e_Cey_companyDataSet13
            // 
            this.e_Cey_companyDataSet13.DataSetName = "E_Cey_companyDataSet13";
            this.e_Cey_companyDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1291, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 49);
            this.button2.TabIndex = 100;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // e_Cey_companyDataSet43
            // 
            this.e_Cey_companyDataSet43.DataSetName = "E_Cey_companyDataSet43";
            this.e_Cey_companyDataSet43.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e_Cey_companyDataSet44
            // 
            this.e_Cey_companyDataSet44.DataSetName = "E_Cey_companyDataSet44";
            this.e_Cey_companyDataSet44.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order1BindingSource
            // 
            this.order1BindingSource.DataMember = "order1";
            this.order1BindingSource.DataSource = this.e_Cey_companyDataSet44;
            // 
            // order1TableAdapter
            // 
            this.order1TableAdapter.ClearBeforeFill = true;
            // 
            // e_Cey_companyDataSet45
            // 
            this.e_Cey_companyDataSet45.DataSetName = "E_Cey_companyDataSet45";
            this.e_Cey_companyDataSet45.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderdetailsBindingSource
            // 
            this.orderdetailsBindingSource.DataMember = "order_details";
            this.orderdetailsBindingSource.DataSource = this.e_Cey_companyDataSet45;
            // 
            // order_detailsTableAdapter
            // 
            this.order_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E293997_new.Properties.Resources.ChatGPT_Image_Sep_17__2026__11_02_01_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1547, 780);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvvehicle);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUniqueID);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbOrderID);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtMotorSerialNumber);
            this.Controls.Add(this.txtChassisSerialNumber);
            this.Controls.Add(this.txtVIN);
            this.Controls.Add(this.txtColour);
            this.Controls.Add(this.txtVehicleID);
            this.Controls.Add(this.dtpManufactureDate);
            this.Controls.Add(this.cmbQCStatus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUniqueID;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbOrderID;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtMotorSerialNumber;
        private System.Windows.Forms.TextBox txtChassisSerialNumber;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.TextBox txtVehicleID;
        private System.Windows.Forms.DateTimePicker dtpManufactureDate;
        private System.Windows.Forms.ComboBox cmbQCStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dgvvehicle;
        private E_Cey_companyDataSet13 e_Cey_companyDataSet13;
        private E_Cey_companyDataSet22 e_Cey_companyDataSet22;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private E_Cey_companyDataSet22TableAdapters.vehicleTableAdapter vehicleTableAdapter;
        private System.Windows.Forms.Button button2;
        private E_Cey_companyDataSet43 e_Cey_companyDataSet43;
        private E_Cey_companyDataSet44 e_Cey_companyDataSet44;
        private System.Windows.Forms.BindingSource order1BindingSource;
        private E_Cey_companyDataSet44TableAdapters.order1TableAdapter order1TableAdapter;
        private E_Cey_companyDataSet45 e_Cey_companyDataSet45;
        private System.Windows.Forms.BindingSource orderdetailsBindingSource;
        private E_Cey_companyDataSet45TableAdapters.order_detailsTableAdapter order_detailsTableAdapter;
    }
}