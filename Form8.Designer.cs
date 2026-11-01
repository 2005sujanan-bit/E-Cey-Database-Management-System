namespace E293997_new
{
    partial class Form8
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
            this.cmbVehicleModelID = new System.Windows.Forms.ComboBox();
            this.orderdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e_Cey_companyDataSet18 = new E293997_new.E_Cey_companyDataSet18();
            this.cmbOrderID = new System.Windows.Forms.ComboBox();
            this.button11 = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtUniqueID = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.e_Cey_companyDataSet14 = new E293997_new.E_Cey_companyDataSet14();
            this.order_detailsTableAdapter = new E293997_new.E_Cey_companyDataSet18TableAdapters.order_detailsTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.e_Cey_companyDataSet41 = new E293997_new.E_Cey_companyDataSet41();
            this.vehiclemodelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicle_modelTableAdapter = new E293997_new.E_Cey_companyDataSet41TableAdapters.vehicle_modelTableAdapter();
            this.e_Cey_companyDataSet42 = new E293997_new.E_Cey_companyDataSet42();
            this.order1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order1TableAdapter = new E293997_new.E_Cey_companyDataSet42TableAdapters.order1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclemodelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVehicleModelID
            // 
            this.cmbVehicleModelID.DataSource = this.vehiclemodelBindingSource;
            this.cmbVehicleModelID.DisplayMember = "vehicle_model_ID";
            this.cmbVehicleModelID.FormattingEnabled = true;
            this.cmbVehicleModelID.Location = new System.Drawing.Point(934, 256);
            this.cmbVehicleModelID.Name = "cmbVehicleModelID";
            this.cmbVehicleModelID.Size = new System.Drawing.Size(231, 24);
            this.cmbVehicleModelID.TabIndex = 73;
            this.cmbVehicleModelID.ValueMember = "vehicle_model_ID";
            // 
            // orderdetailsBindingSource
            // 
            this.orderdetailsBindingSource.DataMember = "order_details";
            this.orderdetailsBindingSource.DataSource = this.e_Cey_companyDataSet18;
            // 
            // e_Cey_companyDataSet18
            // 
            this.e_Cey_companyDataSet18.DataSetName = "E_Cey_companyDataSet18";
            this.e_Cey_companyDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbOrderID
            // 
            this.cmbOrderID.DataSource = this.order1BindingSource;
            this.cmbOrderID.DisplayMember = "order_ID";
            this.cmbOrderID.FormattingEnabled = true;
            this.cmbOrderID.Location = new System.Drawing.Point(934, 344);
            this.cmbOrderID.Name = "cmbOrderID";
            this.cmbOrderID.Size = new System.Drawing.Size(231, 24);
            this.cmbOrderID.TabIndex = 72;
            this.cmbOrderID.ValueMember = "order_ID";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.IndianRed;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(1126, 39);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(155, 54);
            this.button11.TabIndex = 71;
            this.button11.Text = "Back";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Gray;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(1281, 168);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(192, 50);
            this.btnInsert.TabIndex = 70;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gray;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1281, 243);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(192, 50);
            this.btnUpdate.TabIndex = 69;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1281, 323);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(192, 50);
            this.btnDelete.TabIndex = 68;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1281, 398);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(192, 50);
            this.btnClear.TabIndex = 67;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(265, 389);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(231, 22);
            this.txtSubTotal.TabIndex = 66;
            // 
            // txtUniqueID
            // 
            this.txtUniqueID.Location = new System.Drawing.Point(265, 249);
            this.txtUniqueID.Name = "txtUniqueID";
            this.txtUniqueID.Size = new System.Drawing.Size(231, 22);
            this.txtUniqueID.TabIndex = 65;
            this.txtUniqueID.TextChanged += new System.EventHandler(this.txtUniqueID_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(265, 318);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(231, 22);
            this.txtQuantity.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(397, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 46);
            this.label6.TabIndex = 63;
            this.label6.Text = "Order details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 29);
            this.label5.TabIndex = 62;
            this.label5.Text = "OD ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 61;
            this.label4.Text = "Sub total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 60;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(728, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 29);
            this.label2.TabIndex = 59;
            this.label2.Text = "Vehicle Model ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(728, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 58;
            this.label1.Text = "Order ID";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsearch.Location = new System.Drawing.Point(520, 248);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(72, 32);
            this.btnsearch.TabIndex = 74;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Location = new System.Drawing.Point(109, 475);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.RowHeadersWidth = 51;
            this.dgvOrderDetails.RowTemplate.Height = 24;
            this.dgvOrderDetails.Size = new System.Drawing.Size(762, 150);
            this.dgvOrderDetails.TabIndex = 75;
            this.dgvOrderDetails.Visible = false;
            // 
            // e_Cey_companyDataSet14
            // 
            this.e_Cey_companyDataSet14.DataSetName = "E_Cey_companyDataSet14";
            this.e_Cey_companyDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_detailsTableAdapter
            // 
            this.order_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1281, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 49);
            this.button2.TabIndex = 83;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // e_Cey_companyDataSet41
            // 
            this.e_Cey_companyDataSet41.DataSetName = "E_Cey_companyDataSet41";
            this.e_Cey_companyDataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiclemodelBindingSource
            // 
            this.vehiclemodelBindingSource.DataMember = "vehicle_model";
            this.vehiclemodelBindingSource.DataSource = this.e_Cey_companyDataSet41;
            // 
            // vehicle_modelTableAdapter
            // 
            this.vehicle_modelTableAdapter.ClearBeforeFill = true;
            // 
            // e_Cey_companyDataSet42
            // 
            this.e_Cey_companyDataSet42.DataSetName = "E_Cey_companyDataSet42";
            this.e_Cey_companyDataSet42.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order1BindingSource
            // 
            this.order1BindingSource.DataMember = "order1";
            this.order1BindingSource.DataSource = this.e_Cey_companyDataSet42;
            // 
            // order1TableAdapter
            // 
            this.order1TableAdapter.ClearBeforeFill = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E293997_new.Properties.Resources.ChatGPT_Image_Sep_17__2026__11_02_01_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1567, 750);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvOrderDetails);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.cmbVehicleModelID);
            this.Controls.Add(this.cmbOrderID);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtUniqueID);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclemodelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVehicleModelID;
        private System.Windows.Forms.ComboBox cmbOrderID;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtUniqueID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private E_Cey_companyDataSet14 e_Cey_companyDataSet14;
        private E_Cey_companyDataSet18 e_Cey_companyDataSet18;
        private System.Windows.Forms.BindingSource orderdetailsBindingSource;
        private E_Cey_companyDataSet18TableAdapters.order_detailsTableAdapter order_detailsTableAdapter;
        private System.Windows.Forms.Button button2;
        private E_Cey_companyDataSet41 e_Cey_companyDataSet41;
        private System.Windows.Forms.BindingSource vehiclemodelBindingSource;
        private E_Cey_companyDataSet41TableAdapters.vehicle_modelTableAdapter vehicle_modelTableAdapter;
        private E_Cey_companyDataSet42 e_Cey_companyDataSet42;
        private System.Windows.Forms.BindingSource order1BindingSource;
        private E_Cey_companyDataSet42TableAdapters.order1TableAdapter order1TableAdapter;
    }
}