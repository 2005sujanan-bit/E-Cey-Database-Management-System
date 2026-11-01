namespace E293997_new
{
    partial class Form5
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
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e_Cey_companyDataSet34 = new E293997_new.E_Cey_companyDataSet34();
            this.privatebuyersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e_Cey_companyDataSet1 = new E293997_new.E_Cey_companyDataSet1();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dgvPrivateBuyers = new System.Windows.Forms.DataGridView();
            this.private_buyersTableAdapter = new E293997_new.E_Cey_companyDataSet1TableAdapters.private_buyersTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.e_Cey_companyDataSet33 = new E293997_new.E_Cey_companyDataSet33();
            this.customerTableAdapter = new E293997_new.E_Cey_companyDataSet34TableAdapters.customerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.privatebuyersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivateBuyers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet33)).BeginInit();
            this.SuspendLayout();
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.IndianRed;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(1084, 34);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(196, 55);
            this.button11.TabIndex = 67;
            this.button11.Text = "Back";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Gray;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(1276, 182);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(192, 50);
            this.btnInsert.TabIndex = 66;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gray;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1276, 257);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(192, 50);
            this.btnUpdate.TabIndex = 65;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1276, 337);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(192, 50);
            this.btnDelete.TabIndex = 64;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1276, 412);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(192, 50);
            this.btnClear.TabIndex = 63;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.DataSource = this.customerBindingSource;
            this.cmbCustomerID.DisplayMember = "customer_ID";
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Location = new System.Drawing.Point(529, 412);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(268, 24);
            this.cmbCustomerID.TabIndex = 62;
            this.cmbCustomerID.ValueMember = "customer_ID";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.e_Cey_companyDataSet34;
            // 
            // e_Cey_companyDataSet34
            // 
            this.e_Cey_companyDataSet34.DataSetName = "E_Cey_companyDataSet34";
            this.e_Cey_companyDataSet34.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // privatebuyersBindingSource
            // 
            this.privatebuyersBindingSource.DataMember = "private_buyers";
            this.privatebuyersBindingSource.DataSource = this.e_Cey_companyDataSet1;
            // 
            // e_Cey_companyDataSet1
            // 
            this.e_Cey_companyDataSet1.DataSetName = "E_Cey_companyDataSet1";
            this.e_Cey_companyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(529, 336);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(268, 22);
            this.txtFullName.TabIndex = 61;
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(529, 258);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(268, 22);
            this.txtNIC.TabIndex = 60;
            this.txtNIC.TextChanged += new System.EventHandler(this.txtNIC_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 29);
            this.label5.TabIndex = 59;
            this.label5.Text = "Customer ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 29);
            this.label4.TabIndex = 58;
            this.label4.Text = "Customer full name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 29);
            this.label3.TabIndex = 57;
            this.label3.Text = "NIC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(521, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 46);
            this.label2.TabIndex = 56;
            this.label2.Text = "Private Buyers";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsearch.Location = new System.Drawing.Point(834, 258);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(77, 27);
            this.btnsearch.TabIndex = 68;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPrivateBuyers
            // 
            this.dgvPrivateBuyers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrivateBuyers.Location = new System.Drawing.Point(192, 483);
            this.dgvPrivateBuyers.Name = "dgvPrivateBuyers";
            this.dgvPrivateBuyers.RowHeadersWidth = 51;
            this.dgvPrivateBuyers.RowTemplate.Height = 24;
            this.dgvPrivateBuyers.Size = new System.Drawing.Size(605, 229);
            this.dgvPrivateBuyers.TabIndex = 70;
            this.dgvPrivateBuyers.Visible = false;
            // 
            // private_buyersTableAdapter
            // 
            this.private_buyersTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1276, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 49);
            this.button2.TabIndex = 80;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // e_Cey_companyDataSet33
            // 
            this.e_Cey_companyDataSet33.DataSetName = "E_Cey_companyDataSet33";
            this.e_Cey_companyDataSet33.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E293997_new.Properties.Resources.ChatGPT_Image_Sep_17__2026__11_02_01_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1544, 755);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvPrivateBuyers);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbCustomerID);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.privatebuyersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivateBuyers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet33)).EndInit();
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
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dgvPrivateBuyers;
        private E_Cey_companyDataSet1 e_Cey_companyDataSet1;
        private System.Windows.Forms.BindingSource privatebuyersBindingSource;
        private E_Cey_companyDataSet1TableAdapters.private_buyersTableAdapter private_buyersTableAdapter;
        private System.Windows.Forms.Button button2;
        private E_Cey_companyDataSet33 e_Cey_companyDataSet33;
        private E_Cey_companyDataSet34 e_Cey_companyDataSet34;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private E_Cey_companyDataSet34TableAdapters.customerTableAdapter customerTableAdapter;
    }
}