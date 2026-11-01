namespace E293997_new
{
    partial class Form15
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
            this.cmbDestinationID = new System.Windows.Forms.ComboBox();
            this.port1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e_Cey_companyDataSet8 = new E293997_new.E_Cey_companyDataSet8();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbPortType = new System.Windows.Forms.ComboBox();
            this.txtPortID = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtClearing = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvport = new System.Windows.Forms.DataGridView();
            this.e_Cey_companyDataSet6 = new E293997_new.E_Cey_companyDataSet6();
            this.e_Cey_companyDataSet7 = new E293997_new.E_Cey_companyDataSet7();
            this.port1TableAdapter = new E293997_new.E_Cey_companyDataSet8TableAdapters.port1TableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.e_Cey_companyDataSet49 = new E293997_new.E_Cey_companyDataSet49();
            this.e_Cey_companyDataSet50 = new E293997_new.E_Cey_companyDataSet50();
            this.destinationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.destinationTableAdapter = new E293997_new.E_Cey_companyDataSet50TableAdapters.destinationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.port1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.IndianRed;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(1126, 41);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(157, 60);
            this.button11.TabIndex = 78;
            this.button11.Text = "Back";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // cmbDestinationID
            // 
            this.cmbDestinationID.DataSource = this.destinationBindingSource;
            this.cmbDestinationID.DisplayMember = "destination_ID";
            this.cmbDestinationID.FormattingEnabled = true;
            this.cmbDestinationID.Location = new System.Drawing.Point(912, 394);
            this.cmbDestinationID.Name = "cmbDestinationID";
            this.cmbDestinationID.Size = new System.Drawing.Size(293, 24);
            this.cmbDestinationID.TabIndex = 77;
            this.cmbDestinationID.ValueMember = "destination_ID";
            // 
            // port1BindingSource
            // 
            this.port1BindingSource.DataMember = "port1";
            this.port1BindingSource.DataSource = this.e_Cey_companyDataSet8;
            // 
            // e_Cey_companyDataSet8
            // 
            this.e_Cey_companyDataSet8.DataSetName = "E_Cey_companyDataSet8";
            this.e_Cey_companyDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Gray;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(1258, 199);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(192, 50);
            this.btnInsert.TabIndex = 76;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gray;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1258, 274);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(192, 50);
            this.btnUpdate.TabIndex = 75;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1258, 354);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(192, 50);
            this.btnDelete.TabIndex = 74;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1258, 429);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(192, 50);
            this.btnClear.TabIndex = 73;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbPortType
            // 
            this.cmbPortType.FormattingEnabled = true;
            this.cmbPortType.Items.AddRange(new object[] {
            "Sea port",
            "Dry port"});
            this.cmbPortType.Location = new System.Drawing.Point(912, 238);
            this.cmbPortType.Name = "cmbPortType";
            this.cmbPortType.Size = new System.Drawing.Size(293, 24);
            this.cmbPortType.TabIndex = 72;
            // 
            // txtPortID
            // 
            this.txtPortID.Location = new System.Drawing.Point(264, 245);
            this.txtPortID.Name = "txtPortID";
            this.txtPortID.Size = new System.Drawing.Size(293, 22);
            this.txtPortID.TabIndex = 71;
            this.txtPortID.TextChanged += new System.EventHandler(this.txtPortID_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(264, 313);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(293, 22);
            this.txtCity.TabIndex = 70;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(264, 401);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(293, 22);
            this.txtCountry.TabIndex = 69;
            // 
            // txtClearing
            // 
            this.txtClearing.Location = new System.Drawing.Point(912, 315);
            this.txtClearing.Name = "txtClearing";
            this.txtClearing.Size = new System.Drawing.Size(293, 22);
            this.txtClearing.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(724, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 67;
            this.label1.Text = "Destination ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(724, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 29);
            this.label7.TabIndex = 66;
            this.label7.Text = "Clearing agent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 29);
            this.label6.TabIndex = 65;
            this.label6.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 64;
            this.label5.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(724, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 29);
            this.label4.TabIndex = 63;
            this.label4.Text = "Port type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 46);
            this.label3.TabIndex = 62;
            this.label3.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 61;
            this.label2.Text = "Port ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 79;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvport
            // 
            this.dgvport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvport.Location = new System.Drawing.Point(81, 485);
            this.dgvport.Name = "dgvport";
            this.dgvport.RowHeadersWidth = 51;
            this.dgvport.RowTemplate.Height = 24;
            this.dgvport.Size = new System.Drawing.Size(900, 150);
            this.dgvport.TabIndex = 80;
            this.dgvport.Visible = false;
            // 
            // e_Cey_companyDataSet6
            // 
            this.e_Cey_companyDataSet6.DataSetName = "E_Cey_companyDataSet6";
            this.e_Cey_companyDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e_Cey_companyDataSet7
            // 
            this.e_Cey_companyDataSet7.DataSetName = "E_Cey_companyDataSet7";
            this.e_Cey_companyDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // port1TableAdapter
            // 
            this.port1TableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1258, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 49);
            this.button2.TabIndex = 104;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // e_Cey_companyDataSet49
            // 
            this.e_Cey_companyDataSet49.DataSetName = "E_Cey_companyDataSet49";
            this.e_Cey_companyDataSet49.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e_Cey_companyDataSet50
            // 
            this.e_Cey_companyDataSet50.DataSetName = "E_Cey_companyDataSet50";
            this.e_Cey_companyDataSet50.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // destinationBindingSource
            // 
            this.destinationBindingSource.DataMember = "destination";
            this.destinationBindingSource.DataSource = this.e_Cey_companyDataSet50;
            // 
            // destinationTableAdapter
            // 
            this.destinationTableAdapter.ClearBeforeFill = true;
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E293997_new.Properties.Resources.ChatGPT_Image_Sep_17__2026__11_02_01_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1501, 767);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.cmbDestinationID);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbPortType);
            this.Controls.Add(this.txtPortID);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtClearing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form15";
            this.Text = "Form15";
            this.Load += new System.EventHandler(this.Form15_Load);
            ((System.ComponentModel.ISupportInitialize)(this.port1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Cey_companyDataSet50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox cmbDestinationID;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbPortType;
        private System.Windows.Forms.TextBox txtPortID;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtClearing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvport;
        private E_Cey_companyDataSet6 e_Cey_companyDataSet6;
        private E_Cey_companyDataSet7 e_Cey_companyDataSet7;
        private E_Cey_companyDataSet8 e_Cey_companyDataSet8;
        private System.Windows.Forms.BindingSource port1BindingSource;
        private E_Cey_companyDataSet8TableAdapters.port1TableAdapter port1TableAdapter;
        private System.Windows.Forms.Button button2;
        private E_Cey_companyDataSet49 e_Cey_companyDataSet49;
        private E_Cey_companyDataSet50 e_Cey_companyDataSet50;
        private System.Windows.Forms.BindingSource destinationBindingSource;
        private E_Cey_companyDataSet50TableAdapters.destinationTableAdapter destinationTableAdapter;
    }
}