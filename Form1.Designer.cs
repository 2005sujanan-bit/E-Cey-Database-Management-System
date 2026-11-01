namespace E293997_new
{
    partial class Form1
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
            this.btncancel = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.chksh = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.txtun = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(435, 615);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(197, 46);
            this.btncancel.TabIndex = 21;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(145, 615);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(195, 44);
            this.btnlogin.TabIndex = 19;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            this.btnlogin.MouseEnter += new System.EventHandler(this.btnlogin_MouseEnter);
            this.btnlogin.MouseLeave += new System.EventHandler(this.btnlogin_MouseLeave);
            // 
            // chksh
            // 
            this.chksh.AutoSize = true;
            this.chksh.BackColor = System.Drawing.Color.Transparent;
            this.chksh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chksh.ForeColor = System.Drawing.Color.Black;
            this.chksh.Location = new System.Drawing.Point(435, 549);
            this.chksh.Name = "chksh";
            this.chksh.Size = new System.Drawing.Size(159, 26);
            this.chksh.TabIndex = 24;
            this.chksh.Text = "Show password";
            this.chksh.UseVisualStyleBackColor = false;
            this.chksh.CheckedChanged += new System.EventHandler(this.chksh_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Elephant", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(776, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(656, 103);
            this.label6.TabIndex = 25;
            this.label6.Text = "Welcome Back";
            // 
            // txtpwd
            // 
            this.txtpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpwd.Location = new System.Drawing.Point(372, 510);
            this.txtpwd.Multiline = true;
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.Size = new System.Drawing.Size(300, 33);
            this.txtpwd.TabIndex = 23;
            // 
            // txtun
            // 
            this.txtun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtun.Location = new System.Drawing.Point(372, 429);
            this.txtun.Name = "txtun";
            this.txtun.Size = new System.Drawing.Size(300, 30);
            this.txtun.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(138, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 44);
            this.label7.TabIndex = 18;
            this.label7.Text = "User name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(137, 501);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 44);
            this.label8.TabIndex = 20;
            this.label8.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E293997_new.Properties.Resources.login_backround_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1550, 761);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.chksh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtun);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.CheckBox chksh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.TextBox txtun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

