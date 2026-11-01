namespace E293997_new
{
    partial class Form7
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
            this.button11 = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbCustomerID = new System.Windows.Forms.ComboBox();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e_Cey_companyDataSet21 = new E293997_new.E_Cey_companyDataSet21();
            this.e_Cey_companyDataSet12 = new E293997_new.E_Cey_companyDataSet12();
            this.cmbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.txtDueAmount = new System.Windows.Forms.TextBox();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.e_Cey_companyDataSet15 = new E293997_new.E_Cey_companyDataSet15();
            this.e_Cey_companyDataSet16 = new E293997_new.E_Cey_companyDataSet16();
            this.e_Cey_companyDataSet20 = new E293997_new.E_Cey_companyDataSet20();
            this.paymentTableAdapter = new E293997_new.E_Cey_companyDataSet21TableAdapters.paymentTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbOrderID = new System.Windows.Forms.ComboBox();
            this.e_Cey_companyDataSet38 = new E293997_new.E_Cey_companyDataSet38();
            this.e_Cey_companyDataSet39 = new E293997_new.E_Cey_companyDataSet39();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new E293997_new.E_Cey_companyDataSet39TableAdapters.customerTableAdapter();
            this.e_Cey_companyDataSet40 = new E293997_new.E_Cey_companyDataSet40();
            this.order1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order1TableAdapter = new E293997_new.E_Cey_companyDataSet40TableAdapters.order1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.IndianRed;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(1287, 32);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(156, 57);
            this.button11.TabIndex = 75;
            this.button11.Text = "Back";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Gray;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(1287, 166);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(192, 50);
            this.btnInsert.TabIndex = 74;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gray;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1287, 241);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(192, 50);
            this.btnUpdate.TabIndex = 73;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1287, 321);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(192, 50);
            this.btnDelete.TabIndex = 72;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1287, 396);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(192, 50);
            this.btnClear.TabIndex = 71;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.DataSource = this.customerBindingSource;
            this.cmbCustomerID.DisplayMember = "customer_ID";
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Location = new System.Drawing.Point(895, 290);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(268, 24);
            this.cmbCustomerID.TabIndex = 70;
            this.cmbCustomerID.ValueMember = "customer_ID";
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "payment";
            this.paymentBindingSource.DataSource = this.e_Cey_companyDataSet21;
            // 
            // e_Cey_companyDataSet21
            // 
            this.e_Cey_companyDataSet21.DataSetName = "E_Cey_companyDataSet21";
            this.e_Cey_companyDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e_Cey_companyDataSet12
            // 
            this.e_Cey_companyDataSet12.DataSetName = "E_Cey_companyDataSet12";
            this.e_Cey_companyDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbPaymentStatus
            // 
            this.cmbPaymentStatus.FormattingEnabled = true;
            this.cmbPaymentStatus.Items.AddRange(new object[] {
            "Pending",
            "Complete"});
            this.cmbPaymentStatus.Location = new System.Drawing.Point(895, 216);
            this.cmbPaymentStatus.Name = "cmbPaymentStatus";
            this.cmbPaymentStatus.Size = new System.Drawing.Size(268, 24);
            this.cmbPaymentStatus.TabIndex = 68;
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.Location = new System.Drawing.Point(257, 194);
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.Size = new System.Drawing.Size(268, 22);
            this.txtPaymentID.TabIndex = 67;
            this.txtPaymentID.TextChanged += new System.EventHandler(this.txtPaymentID_TextChanged);
            // 
            // txtDueAmount
            // 
            this.txtDueAmount.Location = new System.Drawing.Point(257, 352);
            this.txtDueAmount.Name = "txtDueAmount";
            this.txtDueAmount.Size = new System.Drawing.Size(268, 22);
            this.txtDueAmount.TabIndex = 66;
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(257, 274);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(268, 22);
            this.txtPaymentAmount.TabIndex = 65;
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Location = new System.Drawing.Point(257, 434);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(268, 22);
            this.dtpPaymentDate.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(502, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 46);
            this.label9.TabIndex = 63;
            this.label9.Text = "Payment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 29);
            this.label8.TabIndex = 62;
            this.label8.Text = "Payment ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 29);
            this.label7.TabIndex = 61;
            this.label7.Text = "Payment amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 29);
            this.label6.TabIndex = 60;
            this.label6.Text = "Due amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 29);
            this.label5.TabIndex = 59;
            this.label5.Text = "Payment Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(681, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 58;
            this.label4.Text = "Payment status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(681, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 29);
            this.label3.TabIndex = 57;
            this.label3.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(690, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 56;
            this.label2.Text = "Order ID";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsearch.Location = new System.Drawing.Point(531, 193);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(78, 27);
            this.btnsearch.TabIndex = 76;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dgvPayment
            // 
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Location = new System.Drawing.Point(63, 514);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.RowHeadersWidth = 51;
            this.dgvPayment.RowTemplate.Height = 24;
            this.dgvPayment.Size = new System.Drawing.Size(1005, 150);
            this.dgvPayment.TabIndex = 77;
            this.dgvPayment.Visible = false;
            // 
            // e_Cey_companyDataSet15
            // 
            this.e_Cey_companyDataSet15.DataSetName = "E_Cey_companyDataSet15";
            this.e_Cey_companyDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e_Cey_companyDataSet16
            // 
            this.e_Cey_companyDataSet16.DataSetName = "E_Cey_companyDataSet16";
            this.e_Cey_companyDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e_Cey_companyDataSet20
            // 
            this.e_Cey_companyDataSet20.DataSetName = "E_Cey_companyDataSet20";
            this.e_Cey_companyDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1287, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 49);
            this.button2.TabIndex = 82;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbOrderID
            // 
            this.cmbOrderID.DataSource = this.order1BindingSource;
            this.cmbOrderID.DisplayMember = "order_ID";
            this.cmbOrderID.FormattingEnabled = true;
            this.cmbOrderID.Location = new System.Drawing.Point(895, 374);
            this.cmbOrderID.Name = "cmbOrderID";
            this.cmbOrderID.Size = new System.Drawing.Size(268, 24);
            this.cmbOrderID.TabIndex = 83;
            this.cmbOrderID.ValueMember = "order_ID";
            // 
            // e_Cey_companyDataSet38
            // 
            this.e_Cey_companyDataSet38.DataSetName = "E_Cey_companyDataSet38";
            this.e_Cey_companyDataSet38.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e_Cey_companyDataSet39
            // 
            this.e_Cey_companyDataSet39.DataSetName = "E_Cey_companyDataSet39";
            this.e_Cey_companyDataSet39.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.e_Cey_companyDataSet39;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // e_Cey_companyDataSet40
            // 
            this.e_Cey_companyDataSet40.DataSetName = "E_Cey_companyDataSet40";
            this.e_Cey_companyDataSet40.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order1BindingSource
            // 
            this.order1BindingSource.DataMember = "order1";
            this.order1BindingSource.DataSource = this.e_Cey_companyDataSet40;
            // 
            // order1TableAdapter
            // 
            this.order1TableAdapter.ClearBeforeFill = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E293997_new.Properties.Resources.ChatGPT_Image_Sep_17__2026__11_02_01_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1556, 765);
            this.Controls.Add(this.cmbOrderID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvPayment);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbCustomerID);
            this.Controls.Add(this.cmbPaymentStatus);
            this.Controls.Add(this.txtPaymentID);
            this.Controls.Add(this.txtDueAmount);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.dtpPaymentDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbCustomerID;
        private System.Windows.Forms.ComboBox cmbPaymentStatus;
        private System.Windows.Forms.TextBox txtPaymentID;
        private System.Windows.Forms.TextBox txtDueAmount;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dgvPayment;
        private E_Cey_companyDataSet12 e_Cey_companyDataSet12;
        private E_Cey_companyDataSet17 e_Cey_companyDataSet17;
        private E_Cey_companyDataSet15 e_Cey_companyDataSet15;
        private E_Cey_companyDataSet16 e_Cey_companyDataSet16;
        private E_Cey_companyDataSet20 e_Cey_companyDataSet20;
        private E_Cey_companyDataSet21 e_Cey_companyDataSet21;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private E_Cey_companyDataSet21TableAdapters.paymentTableAdapter paymentTableAdapter;
        private E_Cey_companyDataSet17TableAdapters.paymentTableAdapter paymentTableAdapter1;
        private E_Cey_companyDataSet17TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbOrderID;
        private E_Cey_companyDataSet38 e_Cey_companyDataSet38;
        private E_Cey_companyDataSet39 e_Cey_companyDataSet39;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private E_Cey_companyDataSet39TableAdapters.customerTableAdapter customerTableAdapter;
        private E_Cey_companyDataSet40 e_Cey_companyDataSet40;
        private System.Windows.Forms.BindingSource order1BindingSource;
        private E_Cey_companyDataSet40TableAdapters.order1TableAdapter order1TableAdapter;
    }
}