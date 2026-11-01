using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E293997_new
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           
         

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("insert into customer_contact_number(customer_ID,contact_number) values('" + cmbCustomerID.Text + "','" + txtContactNumber.Text + "')", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("inserted successfully");
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("update customer_contact_number set contact_number = '" + txtContactNumber.Text + "' where customer_ID = '" + cmbCustomerID.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated successfully");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("delete from customer_contact_number where customer_ID = '" + cmbCustomerID.Text + "' and contact_number = '" + txtContactNumber.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted successfully");
          
        
    }
    }
}
