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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("insert into private_buyers(NIC,full_name,customer_ID) values('" + txtNIC.Text + "','" + txtFullName.Text + "','" + cmbCustomerID.Text + "')", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("inserted successfully");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("update private_buyers set full_name = '" + txtFullName.Text + "', customer_ID = '" + cmbCustomerID.Text + "' where NIC = '" + txtNIC.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("delete from private_buyers where NIC = '" + txtNIC.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted successfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNIC.Clear();
            txtFullName.Clear();
            cmbCustomerID.Text = "";
        }

        private void txtNIC_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet34.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.e_Cey_companyDataSet34.customer);
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet1.private_buyers' table. You can move, or remove it, as needed.
            this.private_buyersTableAdapter.Fill(this.e_Cey_companyDataSet1.private_buyers);
            SqlConnection con = new SqlConnection(Class1.connectionString);

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM private_buyers", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvPrivateBuyers.DataSource = dt;

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            con.Open();

            cmd = new SqlCommand("select * from private_buyers where NIC='" + txtNIC.Text + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtFullName.Text = dr.GetValue(1).ToString();
                cmbCustomerID.Text = dr.GetValue(2).ToString();
            }

            con.Close();

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.private_buyersTableAdapter.FillBy(this.e_Cey_companyDataSet1.private_buyers);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvPrivateBuyers.Visible = true;
        }
    }
}
