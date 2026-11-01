namespace E293997_new
{
    partial class Form4
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
            this.cmbCustomerID = new System.Windows.Forms.ComboBox();
            this.automotivecompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e_Cey_companyDataSet = new E293997_new.E_Cey_companyDataSet();
            this.automotivecompanyBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.eCeycompanyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button11 = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbBusinessType = new System.Windows.Forms.ComboBox();
            this.txtCompanyRegisterID = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.txtCreditLimit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dgvAutomotiveCompany = new System.Windows.Forms.DataGridView();
            this.automotive_companyTableAdapter = new E293997_new.E_Cey_companyDataSetTableAdapters.automotive_companyTableAdapter();
            this.eCeycompanyDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.automotivecompanyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.automotivecompanyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.automotivecompanyBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.e_Cey_companyDataSet28 = new E293997_new.E_Cey_companyDataSet28();
            this.e_Cey_companyDataSet29 = new E293997_new.E_Cey_companyDataSet29();
            this.e_Cey_companyDataSet30 = new E293997_new.E_Cey_companyDataSet30();
            this.e_Cey_companyDataSet31 = new E293997_new.E_Cey_companyDataSet31();
            this.e_Cey_companyDataSet32 = new E293997_new.E_Cey_companyDataSet32();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new E293997_new.E_Cey_companyDataSet32TableAdapters.customerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.automotivecompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotivecompanyBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCeycompanyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomotiveCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCeycompanyDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotivecompanyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotivecompanyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotivecompanyBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.DataSource = this.customerBindingSource;
            this.cmbCustomerID.DisplayMember = "customer_ID";
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Location = new System.Drawing.Point(903, 357);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(235, 24);
            this.cmbCustomerID.TabIndex = 75;
            this.cmbCustomerID.ValueMember = "customer_ID";
            this.cmbCustomerID.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerID_SelectedIndexChanged);
            // 
            // automotivecompanyBindingSource
            // 
            this.automotivecompanyBindingSource.DataMember = "automotive_company";
            this.automotivecompanyBindingSource.DataSource = this.e_Cey_companyDataSet;
            // 
            // e_Cey_companyDataSet
            // 
            this.e_Cey_companyDataSet.DataSetName = "E_Cey_companyDataSet";
            this.e_Cey_companyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // automotivecompanyBindingSource4
            // 
            this.automotivecompanyBindingSource4.DataMember = "automotive_company";
            this.automotivecompanyBindingSource4.DataSource = this.eCeycompanyDataSetBindingSource;
            // 
            // eCeycompanyDataSetBindingSource
            // 
            this.eCeycompanyDataSetBindingSource.DataSource = this.e_Cey_companyDataSet;
            this.eCeycompanyDataSetBindingSource.Position = 0;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.IndianRed;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(1331, 30);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(199, 54);
            this.button11.TabIndex = 74;
            this.button11.Text = "Back";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Gray;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(1288, 202);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(192, 50);
            this.btnInsert.TabIndex = 73;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gray;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1288, 277);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(192, 50);
            this.btnUpdate.TabIndex = 72;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1288, 357);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(192, 50);
            this.btnDelete.TabIndex = 71;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1288, 432);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(192, 50);
            this.btnClear.TabIndex = 70;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbBusinessType
            // 
            this.cmbBusinessType.FormattingEnabled = true;
            this.cmbBusinessType.Items.AddRange(new object[] {
            "Automotive distributor",
            " Automotive dealers ",
            " Showrooms."});
            this.cmbBusinessType.Location = new System.Drawing.Point(903, 275);
            this.cmbBusinessType.Name = "cmbBusinessType";
            this.cmbBusinessType.Size = new System.Drawing.Size(235, 24);
            this.cmbBusinessType.TabIndex = 69;
            // 
            // txtCompanyRegisterID
            // 
            this.txtCompanyRegisterID.Location = new System.Drawing.Point(313, 203);
            this.txtCompanyRegisterID.Name = "txtCompanyRegisterID";
            this.txtCompanyRegisterID.Size = new System.Drawing.Size(235, 22);
            this.txtCompanyRegisterID.TabIndex = 68;
            this.txtCompanyRegisterID.TextChanged += new System.EventHandler(this.txtCompanyRegisterID_TextChanged);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(313, 282);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(235, 22);
            this.txtCompanyName.TabIndex = 67;
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Location = new System.Drawing.Point(313, 354);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(235, 22);
            this.txtContactPerson.TabIndex = 66;
            // 
            // txtCreditLimit
            // 
            this.txtCreditLimit.Location = new System.Drawing.Point(903, 211);
            this.txtCreditLimit.Name = "txtCreditLimit";
            this.txtCreditLimit.Size = new System.Drawing.Size(235, 22);
            this.txtCreditLimit.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 29);
            this.label8.TabIndex = 64;
            this.label8.Text = "Cotact person";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(686, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 29);
            this.label7.TabIndex = 63;
            this.label7.Text = "Credit limit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(686, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 29);
            this.label6.TabIndex = 62;
            this.label6.Text = "Business type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(386, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(420, 46);
            this.label5.TabIndex = 61;
            this.label5.Text = "Automotive Company";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 29);
            this.label4.TabIndex = 60;
            this.label4.Text = "Company register ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 29);
            this.label3.TabIndex = 59;
            this.label3.Text = "Company Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(686, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 58;
            this.label2.Text = "Customer ID";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsearch.Location = new System.Drawing.Point(563, 199);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(81, 31);
            this.btnsearch.TabIndex = 76;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvAutomotiveCompany
            // 
            this.dgvAutomotiveCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutomotiveCompany.Location = new System.Drawing.Point(70, 493);
            this.dgvAutomotiveCompany.Name = "dgvAutomotiveCompany";
            this.dgvAutomotiveCompany.RowHeadersWidth = 51;
            this.dgvAutomotiveCompany.RowTemplate.Height = 24;
            this.dgvAutomotiveCompany.Size = new System.Drawing.Size(904, 207);
            this.dgvAutomotiveCompany.TabIndex = 78;
            this.dgvAutomotiveCompany.Visible = false;
            this.dgvAutomotiveCompany.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // automotive_companyTableAdapter
            // 
            this.automotive_companyTableAdapter.ClearBeforeFill = true;
            // 
            // eCeycompanyDataSetBindingSource1
            // 
            this.eCeycompanyDataSetBindingSource1.DataSource = this.e_Cey_companyDataSet;
            this.eCeycompanyDataSetBindingSource1.Position = 0;
            // 
            // automotivecompanyBindingSource1
            // 
            this.automotivecompanyBindingSource1.DataMember = "automotive_company";
            this.automotivecompanyBindingSource1.DataSource = this.eCeycompanyDataSetBindingSource1;
            // 
            // automotivecompanyBindingSource2
            // 
            this.automotivecompanyBindingSource2.DataMember = "automotive_company";
            this.automotivecompanyBindingSource2.DataSource = this.eCeycompanyDataSetBindingSource;
            // 
            // automotivecompanyBindingSource3
            // 
            this.automotivecompanyBindingSource3.DataMember = "automotive_company";
            this.automotivecompanyBindingSource3.DataSource = this.eCeycompanyDataSetBindingSource;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1288, 493);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 49);
            this.button2.TabIndex = 79;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // e_Cey_companyDataSet28
            // 
            this.e_Cey_companyDataSet28.DataSetName = "E_Cey_companyDataSet28";
            this.e_Cey_companyDataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e_Cey_companyDataSet29
            // 
            this.e_Cey_companyDataSet29.DataSetName = "E_Cey_companyDataSet29";
            this.e_Cey_companyDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e_Cey_companyDataSet30
            // 
            this.e_Cey_companyDataSet30.DataSetName = "E_Cey_companyDataSet30";
            this.e_Cey_companyDataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e_Cey_companyDataSet31
            // 
            this.e_Cey_companyDataSet31.DataSetName = "E_Cey_companyDataSet31";
            this.e_Cey_companyDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e_Cey_companyDataSet32
            // 
            this.e_Cey_companyDataSet32.DataSetName = "E_Cey_companyDataSet32";
            this.e_Cey_companyDataSet32.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.e_Cey_companyDataSet32;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E293997_new.Properties.Resources.ChatGPT_Image_Sep_17__2026__11_02_01_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1570, 734);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvAutomotiveCompany);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.cmbCustomerID);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbBusinessType);
            this.Controls.Add(this.txtCompanyRegisterID);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtContactPerson);
            this.Controls.Add(this.txtCreditLimit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.automotivecompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotivecompanyBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCeycompanyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomotiveCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCeycompanyDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotivecompanyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotivecompanyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotivecompanyBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCustomerID;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbBusinessType;
        private System.Windows.Forms.TextBox txtCompanyRegisterID;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.TextBox txtCreditLimit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dgvAutomotiveCompany;
        private E_Cey_companyDataSet e_Cey_companyDataSet;
        private System.Windows.Forms.BindingSource eCeycompanyDataSetBindingSource;
        private System.Windows.Forms.BindingSource automotivecompanyBindingSource;
        private E_Cey_companyDataSetTableAdapters.automotive_companyTableAdapter automotive_companyTableAdapter;
        private System.Windows.Forms.BindingSource automotivecompanyBindingSource1;
        private System.Windows.Forms.BindingSource eCeycompanyDataSetBindingSource1;
        private System.Windows.Forms.BindingSource automotivecompanyBindingSource4;
        private System.Windows.Forms.BindingSource automotivecompanyBindingSource2;
        private System.Windows.Forms.BindingSource automotivecompanyBindingSource3;
        private System.Windows.Forms.Button button2;
        private E_Cey_companyDataSet28 e_Cey_companyDataSet28;
        private E_Cey_companyDataSet29 e_Cey_companyDataSet29;
        private E_Cey_companyDataSet30 e_Cey_companyDataSet30;
        private E_Cey_companyDataSet31 e_Cey_companyDataSet31;
        private E_Cey_companyDataSet32 e_Cey_companyDataSet32;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private E_Cey_companyDataSet32TableAdapters.customerTableAdapter customerTableAdapter;
    }
}