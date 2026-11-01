namespace E293997_new
{
    partial class Form17
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
            this.cmbCustomerID = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e_Cey_companyDataSet46 = new E293997_new.E_Cey_companyDataSet46();
            this.customercontactnumberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e_Cey_companyDataSet27 = new E293997_new.E_Cey_companyDataSet27();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.e_Cey_companyDataSet26 = new E293997_new.E_Cey_companyDataSet26();
            this.customer_contact_numberTableAdapter = new E293997_new.E_Cey_companyDataSet27TableAdapters.customer_contact_numberTableAdapter();
            this.dgvcuscontact = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.customerTableAdapter = new E293997_new.E_Cey_companyDataSet46TableAdapters.customerTableAdapter();
            this.customercontactnumberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.e_Cey_companyDataSet52 = new E293997_new.E_Cey_companyDataSet52();
            this.customer_contact_numberTableAdapter1 = new E293997_new.E_Cey_companyDataSet52TableAdapters.customer_contact_numberTableAdapter();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customercontactnumberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuscontact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customercontactnumberBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet52)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(927, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 50);
            this.button1.TabIndex = 64;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(927, 211);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(192, 50);
            this.button6.TabIndex = 63;
            this.button6.Text = "Update";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gray;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(927, 291);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(192, 50);
            this.button5.TabIndex = 62;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(927, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 50);
            this.button4.TabIndex = 61;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.IndianRed;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(1228, 35);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(153, 53);
            this.button11.TabIndex = 60;
            this.button11.Text = "Back";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.DataSource = this.customerBindingSource;
            this.cmbCustomerID.DisplayMember = "customer_ID";
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Location = new System.Drawing.Point(531, 223);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(258, 24);
            this.cmbCustomerID.TabIndex = 58;
            this.cmbCustomerID.ValueMember = "customer_ID";
            this.cmbCustomerID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.e_Cey_companyDataSet46;
            // 
            // e_Cey_companyDataSet46
            // 
            this.e_Cey_companyDataSet46.DataSetName = "E_Cey_companyDataSet46";
            this.e_Cey_companyDataSet46.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customercontactnumberBindingSource
            // 
            this.customercontactnumberBindingSource.DataMember = "customer_contact_number";
            this.customercontactnumberBindingSource.DataSource = this.e_Cey_companyDataSet27;
            // 
            // e_Cey_companyDataSet27
            // 
            this.e_Cey_companyDataSet27.DataSetName = "E_Cey_companyDataSet27";
            this.e_Cey_companyDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 32);
            this.label3.TabIndex = 57;
            this.label3.Text = "Contact number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 32);
            this.label2.TabIndex = 56;
            this.label2.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 42);
            this.label1.TabIndex = 55;
            this.label1.Text = "Customer contact number";
            // 
            // e_Cey_companyDataSet26
            // 
            this.e_Cey_companyDataSet26.DataSetName = "E_Cey_companyDataSet26";
            this.e_Cey_companyDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customer_contact_numberTableAdapter
            // 
            this.customer_contact_numberTableAdapter.ClearBeforeFill = true;
            // 
            // dgvcuscontact
            // 
            this.dgvcuscontact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcuscontact.Location = new System.Drawing.Point(194, 392);
            this.dgvcuscontact.Name = "dgvcuscontact";
            this.dgvcuscontact.RowHeadersWidth = 51;
            this.dgvcuscontact.RowTemplate.Height = 24;
            this.dgvcuscontact.Size = new System.Drawing.Size(381, 150);
            this.dgvcuscontact.TabIndex = 66;
            this.dgvcuscontact.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(927, 435);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 49);
            this.button3.TabIndex = 100;
            this.button3.Text = "View";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customercontactnumberBindingSource1
            // 
            this.customercontactnumberBindingSource1.DataMember = "customer_contact_number";
            this.customercontactnumberBindingSource1.DataSource = this.e_Cey_companyDataSet52;
            // 
            // e_Cey_companyDataSet52
            // 
            this.e_Cey_companyDataSet52.DataSetName = "E_Cey_companyDataSet52";
            this.e_Cey_companyDataSet52.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customer_contact_numberTableAdapter1
            // 
            this.customer_contact_numberTableAdapter1.ClearBeforeFill = true;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(531, 306);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(258, 22);
            this.txtContactNumber.TabIndex = 102;
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E293997_new.Properties.Resources.ChatGPT_Image_Sep_17__2026__11_02_01_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1449, 771);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvcuscontact);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.cmbCustomerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form17";
            this.Text = "Form17";
            this.Load += new System.EventHandler(this.Form17_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customercontactnumberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuscontact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customercontactnumberBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet52)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox cmbCustomerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private E_Cey_companyDataSet26 e_Cey_companyDataSet26;
        private E_Cey_companyDataSet27 e_Cey_companyDataSet27;
        private System.Windows.Forms.BindingSource customercontactnumberBindingSource;
        private E_Cey_companyDataSet27TableAdapters.customer_contact_numberTableAdapter customer_contact_numberTableAdapter;
        private System.Windows.Forms.DataGridView dgvcuscontact;
        private System.Windows.Forms.Button button3;
        private E_Cey_companyDataSet46 e_Cey_companyDataSet46;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private E_Cey_companyDataSet46TableAdapters.customerTableAdapter customerTableAdapter;
        private E_Cey_companyDataSet52 e_Cey_companyDataSet52;
        private System.Windows.Forms.BindingSource customercontactnumberBindingSource1;
        private E_Cey_companyDataSet52TableAdapters.customer_contact_numberTableAdapter customer_contact_numberTableAdapter1;
        private System.Windows.Forms.TextBox txtContactNumber;
    }
}