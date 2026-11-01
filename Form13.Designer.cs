namespace E293997_new
{
    partial class Form13
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
            this.cmbDestinationType = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.dtpActualDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEstimatedDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.txtDestinationID = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dgvdistination = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdistination)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDestinationType
            // 
            this.cmbDestinationType.FormattingEnabled = true;
            this.cmbDestinationType.Items.AddRange(new object[] {
            "Showroom ",
            "Port"});
            this.cmbDestinationType.Location = new System.Drawing.Point(1008, 352);
            this.cmbDestinationType.Name = "cmbDestinationType";
            this.cmbDestinationType.Size = new System.Drawing.Size(260, 24);
            this.cmbDestinationType.TabIndex = 82;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(742, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 50);
            this.button3.TabIndex = 81;
            this.button3.Text = "Showroom";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1058, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 50);
            this.button2.TabIndex = 80;
            this.button2.Text = "Port";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.IndianRed;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(1143, 33);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(160, 59);
            this.button11.TabIndex = 79;
            this.button11.Text = "Back";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // dtpActualDeliveryDate
            // 
            this.dtpActualDeliveryDate.Location = new System.Drawing.Point(1008, 257);
            this.dtpActualDeliveryDate.Name = "dtpActualDeliveryDate";
            this.dtpActualDeliveryDate.Size = new System.Drawing.Size(260, 22);
            this.dtpActualDeliveryDate.TabIndex = 78;
            // 
            // dtpEstimatedDeliveryDate
            // 
            this.dtpEstimatedDeliveryDate.Location = new System.Drawing.Point(320, 389);
            this.dtpEstimatedDeliveryDate.Name = "dtpEstimatedDeliveryDate";
            this.dtpEstimatedDeliveryDate.Size = new System.Drawing.Size(260, 22);
            this.dtpEstimatedDeliveryDate.TabIndex = 77;
            // 
            // txtDestinationID
            // 
            this.txtDestinationID.Location = new System.Drawing.Point(320, 221);
            this.txtDestinationID.Name = "txtDestinationID";
            this.txtDestinationID.Size = new System.Drawing.Size(260, 22);
            this.txtDestinationID.TabIndex = 76;
            this.txtDestinationID.TextChanged += new System.EventHandler(this.txtDestinationID_TextChanged);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(320, 298);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(260, 22);
            this.txtContactNumber.TabIndex = 75;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Gray;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(1322, 192);
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
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1322, 267);
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
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1322, 347);
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
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1322, 422);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(192, 50);
            this.btnClear.TabIndex = 71;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 29);
            this.label9.TabIndex = 70;
            this.label9.Text = "Destination ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 29);
            this.label8.TabIndex = 69;
            this.label8.Text = "Contact number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 29);
            this.label7.TabIndex = 68;
            this.label7.Text = "Estimated delivery date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(723, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 29);
            this.label6.TabIndex = 67;
            this.label6.Text = "Actual delivery data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(723, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 29);
            this.label5.TabIndex = 66;
            this.label5.Text = "Destination type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 46);
            this.label3.TabIndex = 65;
            this.label3.Text = "Destination";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsearch.Location = new System.Drawing.Point(597, 220);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 83;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dgvdistination
            // 
            this.dgvdistination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdistination.Location = new System.Drawing.Point(105, 548);
            this.dgvdistination.Name = "dgvdistination";
            this.dgvdistination.RowHeadersWidth = 51;
            this.dgvdistination.RowTemplate.Height = 24;
            this.dgvdistination.Size = new System.Drawing.Size(746, 172);
            this.dgvdistination.TabIndex = 84;
            this.dgvdistination.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1322, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 49);
            this.button1.TabIndex = 102;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E293997_new.Properties.Resources.ChatGPT_Image_Sep_17__2026__11_02_01_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1644, 757);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvdistination);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.cmbDestinationType);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.dtpActualDeliveryDate);
            this.Controls.Add(this.dtpEstimatedDeliveryDate);
            this.Controls.Add(this.txtDestinationID);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Name = "Form13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form13";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdistination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDestinationType;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DateTimePicker dtpActualDeliveryDate;
        private System.Windows.Forms.DateTimePicker dtpEstimatedDeliveryDate;
        private System.Windows.Forms.TextBox txtDestinationID;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dgvdistination;
        private System.Windows.Forms.Button button1;
    }
}