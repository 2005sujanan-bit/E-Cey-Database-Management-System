namespace E293997_new
{
    partial class Form11
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
            this.cmbDestinationID = new System.Windows.Forms.ComboBox();
            this.destinationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e_Cey_companyDataSet54 = new E293997_new.E_Cey_companyDataSet54();
            this.logisticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e_Cey_companyDataSet24 = new E293997_new.E_Cey_companyDataSet24();
            this.cmbLogisticMethod = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtLogisticID = new System.Windows.Forms.TextBox();
            this.cmbDestinationType = new System.Windows.Forms.ComboBox();
            this.dtpDispatchedDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dgvlogistic = new System.Windows.Forms.DataGridView();
            this.logisticTableAdapter = new E293997_new.E_Cey_companyDataSet24TableAdapters.logisticTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbLogisticStatus = new System.Windows.Forms.ComboBox();
            this.e_Cey_companyDataSet53 = new E293997_new.E_Cey_companyDataSet53();
            this.destinationTableAdapter = new E293997_new.E_Cey_companyDataSet54TableAdapters.destinationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.destinationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlogistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet53)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(719, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 80;
            this.label1.Text = "Destination ID";
            // 
            // cmbDestinationID
            // 
            this.cmbDestinationID.DataSource = this.destinationBindingSource;
            this.cmbDestinationID.DisplayMember = "destination_ID";
            this.cmbDestinationID.FormattingEnabled = true;
            this.cmbDestinationID.Location = new System.Drawing.Point(924, 399);
            this.cmbDestinationID.Name = "cmbDestinationID";
            this.cmbDestinationID.Size = new System.Drawing.Size(261, 24);
            this.cmbDestinationID.TabIndex = 79;
            this.cmbDestinationID.ValueMember = "destination_ID";
            // 
            // destinationBindingSource
            // 
            this.destinationBindingSource.DataMember = "destination";
            this.destinationBindingSource.DataSource = this.e_Cey_companyDataSet54;
            // 
            // e_Cey_companyDataSet54
            // 
            this.e_Cey_companyDataSet54.DataSetName = "E_Cey_companyDataSet54";
            this.e_Cey_companyDataSet54.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logisticBindingSource
            // 
            this.logisticBindingSource.DataMember = "logistic";
            this.logisticBindingSource.DataSource = this.e_Cey_companyDataSet24;
            // 
            // e_Cey_companyDataSet24
            // 
            this.e_Cey_companyDataSet24.DataSetName = "E_Cey_companyDataSet24";
            this.e_Cey_companyDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbLogisticMethod
            // 
            this.cmbLogisticMethod.FormattingEnabled = true;
            this.cmbLogisticMethod.Items.AddRange(new object[] {
            "Ship ",
            "Train ",
            "Truck "});
            this.cmbLogisticMethod.Location = new System.Drawing.Point(259, 312);
            this.cmbLogisticMethod.Name = "cmbLogisticMethod";
            this.cmbLogisticMethod.Size = new System.Drawing.Size(261, 24);
            this.cmbLogisticMethod.TabIndex = 77;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(447, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(315, 60);
            this.button2.TabIndex = 76;
            this.button2.Text = "Logistic Logictic vehicle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.IndianRed;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(1341, 50);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(160, 46);
            this.button11.TabIndex = 75;
            this.button11.Text = "Back";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Gray;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(1341, 169);
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
            this.btnUpdate.Location = new System.Drawing.Point(1341, 244);
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
            this.btnDelete.Location = new System.Drawing.Point(1341, 324);
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
            this.btnClear.Location = new System.Drawing.Point(1341, 399);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(192, 50);
            this.btnClear.TabIndex = 71;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtLogisticID
            // 
            this.txtLogisticID.Location = new System.Drawing.Point(259, 238);
            this.txtLogisticID.Name = "txtLogisticID";
            this.txtLogisticID.Size = new System.Drawing.Size(261, 22);
            this.txtLogisticID.TabIndex = 70;
            this.txtLogisticID.TextChanged += new System.EventHandler(this.txtLogisticID_TextChanged);
            // 
            // cmbDestinationType
            // 
            this.cmbDestinationType.FormattingEnabled = true;
            this.cmbDestinationType.Items.AddRange(new object[] {
            "Showroom",
            "Port"});
            this.cmbDestinationType.Location = new System.Drawing.Point(259, 372);
            this.cmbDestinationType.Name = "cmbDestinationType";
            this.cmbDestinationType.Size = new System.Drawing.Size(261, 24);
            this.cmbDestinationType.TabIndex = 69;
            // 
            // dtpDispatchedDate
            // 
            this.dtpDispatchedDate.Location = new System.Drawing.Point(924, 237);
            this.dtpDispatchedDate.Name = "dtpDispatchedDate";
            this.dtpDispatchedDate.Size = new System.Drawing.Size(261, 22);
            this.dtpDispatchedDate.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 29);
            this.label7.TabIndex = 67;
            this.label7.Text = "Logistic ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(521, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 46);
            this.label6.TabIndex = 66;
            this.label6.Text = "Logistic";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 29);
            this.label5.TabIndex = 65;
            this.label5.Text = "Logistic method";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 29);
            this.label4.TabIndex = 64;
            this.label4.Text = "Destination type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(719, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 29);
            this.label3.TabIndex = 63;
            this.label3.Text = "Destination Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(719, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 29);
            this.label2.TabIndex = 62;
            this.label2.Text = "Logistic status";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsearch.Location = new System.Drawing.Point(551, 234);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(94, 30);
            this.btnsearch.TabIndex = 81;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dgvlogistic
            // 
            this.dgvlogistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlogistic.Location = new System.Drawing.Point(59, 536);
            this.dgvlogistic.Name = "dgvlogistic";
            this.dgvlogistic.RowHeadersWidth = 51;
            this.dgvlogistic.RowTemplate.Height = 24;
            this.dgvlogistic.Size = new System.Drawing.Size(925, 177);
            this.dgvlogistic.TabIndex = 82;
            this.dgvlogistic.Visible = false;
            // 
            // logisticTableAdapter
            // 
            this.logisticTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1341, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 49);
            this.button1.TabIndex = 101;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbLogisticStatus
            // 
            this.cmbLogisticStatus.FormattingEnabled = true;
            this.cmbLogisticStatus.Items.AddRange(new object[] {
            "Pending",
            "Dispatched",
            "In Transit",
            "Delivered",
            "Cancelled"});
            this.cmbLogisticStatus.Location = new System.Drawing.Point(924, 312);
            this.cmbLogisticStatus.Name = "cmbLogisticStatus";
            this.cmbLogisticStatus.Size = new System.Drawing.Size(261, 24);
            this.cmbLogisticStatus.TabIndex = 102;
            // 
            // e_Cey_companyDataSet53
            // 
            this.e_Cey_companyDataSet53.DataSetName = "E_Cey_companyDataSet53";
            this.e_Cey_companyDataSet53.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // destinationTableAdapter
            // 
            this.destinationTableAdapter.ClearBeforeFill = true;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E293997_new.Properties.Resources.ChatGPT_Image_Sep_17__2026__11_02_01_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1597, 752);
            this.Controls.Add(this.cmbLogisticStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvlogistic);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDestinationID);
            this.Controls.Add(this.cmbLogisticMethod);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtLogisticID);
            this.Controls.Add(this.cmbDestinationType);
            this.Controls.Add(this.dtpDispatchedDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.destinationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlogistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet53)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDestinationID;
        private System.Windows.Forms.ComboBox cmbLogisticMethod;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtLogisticID;
        private System.Windows.Forms.ComboBox cmbDestinationType;
        private System.Windows.Forms.DateTimePicker dtpDispatchedDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dgvlogistic;
        private E_Cey_companyDataSet24 e_Cey_companyDataSet24;
        private System.Windows.Forms.BindingSource logisticBindingSource;
        private E_Cey_companyDataSet24TableAdapters.logisticTableAdapter logisticTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbLogisticStatus;
        private E_Cey_companyDataSet53 e_Cey_companyDataSet53;
        private E_Cey_companyDataSet54 e_Cey_companyDataSet54;
        private System.Windows.Forms.BindingSource destinationBindingSource;
        private E_Cey_companyDataSet54TableAdapters.destinationTableAdapter destinationTableAdapter;
    }
}