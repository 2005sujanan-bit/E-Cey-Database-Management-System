namespace E293997_new
{
    partial class Form16
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
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.cmbLogisticID = new System.Windows.Forms.ComboBox();
            this.logisticlogisticvehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e_Cey_companyDataSet23 = new E293997_new.E_Cey_companyDataSet23();
            this.cmbVehicleRegisterNumber = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logistic_logistic_vehicleTableAdapter = new E293997_new.E_Cey_companyDataSet23TableAdapters.logistic_logistic_vehicleTableAdapter();
            this.dgvlogisticlogisticvehicle = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.e_Cey_companyDataSet47 = new E293997_new.E_Cey_companyDataSet47();
            this.logisticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logisticTableAdapter = new E293997_new.E_Cey_companyDataSet47TableAdapters.logisticTableAdapter();
            this.e_Cey_companyDataSet48 = new E293997_new.E_Cey_companyDataSet48();
            this.logisticvehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logistic_vehicleTableAdapter = new E293997_new.E_Cey_companyDataSet48TableAdapters.logistic_vehicleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.logisticlogisticvehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlogisticlogisticvehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticvehicleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(962, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 50);
            this.button1.TabIndex = 65;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(962, 227);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(192, 50);
            this.button6.TabIndex = 64;
            this.button6.Text = "Update";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gray;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(962, 307);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(192, 50);
            this.button5.TabIndex = 63;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(962, 382);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 50);
            this.button4.TabIndex = 62;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.IndianRed;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(1215, 45);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(161, 52);
            this.button11.TabIndex = 61;
            this.button11.Text = "Back";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // cmbLogisticID
            // 
            this.cmbLogisticID.DataSource = this.logisticBindingSource;
            this.cmbLogisticID.DisplayMember = "logistic_ID";
            this.cmbLogisticID.FormattingEnabled = true;
            this.cmbLogisticID.Location = new System.Drawing.Point(593, 243);
            this.cmbLogisticID.Name = "cmbLogisticID";
            this.cmbLogisticID.Size = new System.Drawing.Size(261, 24);
            this.cmbLogisticID.TabIndex = 60;
            this.cmbLogisticID.ValueMember = "logistic_ID";
            this.cmbLogisticID.SelectedIndexChanged += new System.EventHandler(this.cmbLogisticID_SelectedIndexChanged);
            // 
            // logisticlogisticvehicleBindingSource
            // 
            this.logisticlogisticvehicleBindingSource.DataMember = "logistic_logistic_vehicle";
            this.logisticlogisticvehicleBindingSource.DataSource = this.e_Cey_companyDataSet23;
            // 
            // e_Cey_companyDataSet23
            // 
            this.e_Cey_companyDataSet23.DataSetName = "E_Cey_companyDataSet23";
            this.e_Cey_companyDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbVehicleRegisterNumber
            // 
            this.cmbVehicleRegisterNumber.DataSource = this.logisticvehicleBindingSource;
            this.cmbVehicleRegisterNumber.DisplayMember = "vehicle_register_number";
            this.cmbVehicleRegisterNumber.FormattingEnabled = true;
            this.cmbVehicleRegisterNumber.Location = new System.Drawing.Point(593, 311);
            this.cmbVehicleRegisterNumber.Name = "cmbVehicleRegisterNumber";
            this.cmbVehicleRegisterNumber.Size = new System.Drawing.Size(261, 24);
            this.cmbVehicleRegisterNumber.TabIndex = 59;
            this.cmbVehicleRegisterNumber.ValueMember = "vehicle_register_number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 32);
            this.label4.TabIndex = 58;
            this.label4.Text = "Vehicle registration number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(239, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 32);
            this.label2.TabIndex = 56;
            this.label2.Text = "Logistic ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 38);
            this.label1.TabIndex = 55;
            this.label1.Text = "Logistic Logistic vehicle";
            // 
            // logistic_logistic_vehicleTableAdapter
            // 
            this.logistic_logistic_vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // dgvlogisticlogisticvehicle
            // 
            this.dgvlogisticlogisticvehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlogisticlogisticvehicle.Location = new System.Drawing.Point(76, 427);
            this.dgvlogisticlogisticvehicle.Name = "dgvlogisticlogisticvehicle";
            this.dgvlogisticlogisticvehicle.RowHeadersWidth = 51;
            this.dgvlogisticlogisticvehicle.RowTemplate.Height = 24;
            this.dgvlogisticlogisticvehicle.Size = new System.Drawing.Size(439, 150);
            this.dgvlogisticlogisticvehicle.TabIndex = 66;
            this.dgvlogisticlogisticvehicle.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(962, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 49);
            this.button2.TabIndex = 105;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // e_Cey_companyDataSet47
            // 
            this.e_Cey_companyDataSet47.DataSetName = "E_Cey_companyDataSet47";
            this.e_Cey_companyDataSet47.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logisticBindingSource
            // 
            this.logisticBindingSource.DataMember = "logistic";
            this.logisticBindingSource.DataSource = this.e_Cey_companyDataSet47;
            // 
            // logisticTableAdapter
            // 
            this.logisticTableAdapter.ClearBeforeFill = true;
            // 
            // e_Cey_companyDataSet48
            // 
            this.e_Cey_companyDataSet48.DataSetName = "E_Cey_companyDataSet48";
            this.e_Cey_companyDataSet48.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logisticvehicleBindingSource
            // 
            this.logisticvehicleBindingSource.DataMember = "logistic_vehicle";
            this.logisticvehicleBindingSource.DataSource = this.e_Cey_companyDataSet48;
            // 
            // logistic_vehicleTableAdapter
            // 
            this.logistic_vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E293997_new.Properties.Resources.ChatGPT_Image_Sep_17__2026__11_02_01_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1454, 771);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvlogisticlogisticvehicle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.cmbLogisticID);
            this.Controls.Add(this.cmbVehicleRegisterNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form16";
            this.Text = "Form16";
            this.Load += new System.EventHandler(this.Form16_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logisticlogisticvehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlogisticlogisticvehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticvehicleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox cmbLogisticID;
        private System.Windows.Forms.ComboBox cmbVehicleRegisterNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private E_Cey_companyDataSet23 e_Cey_companyDataSet23;
        private System.Windows.Forms.BindingSource logisticlogisticvehicleBindingSource;
        private E_Cey_companyDataSet23TableAdapters.logistic_logistic_vehicleTableAdapter logistic_logistic_vehicleTableAdapter;
        private System.Windows.Forms.DataGridView dgvlogisticlogisticvehicle;
        private System.Windows.Forms.Button button2;
        private E_Cey_companyDataSet47 e_Cey_companyDataSet47;
        private System.Windows.Forms.BindingSource logisticBindingSource;
        private E_Cey_companyDataSet47TableAdapters.logisticTableAdapter logisticTableAdapter;
        private E_Cey_companyDataSet48 e_Cey_companyDataSet48;
        private System.Windows.Forms.BindingSource logisticvehicleBindingSource;
        private E_Cey_companyDataSet48TableAdapters.logistic_vehicleTableAdapter logistic_vehicleTableAdapter;
    }
}