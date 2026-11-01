using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E293997_new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login Completed Successfully");
            if (txtun.Text == "sujanan" && txtpwd.Text == "2005")
            {
                Form2 fr2 = new Form2();
                fr2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid user name or password");

            }
        }
        private void btnlogin_MouseEnter(object sender, EventArgs e)
        {
            btnlogin.BackColor = Color.LightBlue;
        }

        private void btnlogin_MouseLeave(object sender, EventArgs e)
        {
            btnlogin.BackColor = SystemColors.Control;
        }
        private void chksh_CheckedChanged(object sender, EventArgs e)
        {
            if (chksh.Checked)
                txtpwd.UseSystemPasswordChar = true;
            else
                txtpwd.UseSystemPasswordChar = false;
        }

       

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Are you sure you want to exit?",
       "Exit",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
