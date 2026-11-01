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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.Show();
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;

            cmd = new SqlCommand("insert into destination(destination_ID,contact_number,estimated_delivery_date,actual_delivery_date,destination_type) " +
                "values('" + txtDestinationID.Text + "','" + txtContactNumber.Text + "','" + dtpEstimatedDeliveryDate.Value.ToString("yyyy-MM-dd") + "'," +
                "'" + dtpActualDeliveryDate.Value.ToString("yyyy-MM-dd") + "','" + cmbDestinationType.Text + "')", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("inserted successfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("update destination set contact_number = '" + txtContactNumber.Text + "', estimated_delivery_date = '" + dtpEstimatedDeliveryDate.Value.ToString("yyyy-MM-dd") + "', " +
                "actual_delivery_date = '" + dtpActualDeliveryDate.Value.ToString("yyyy-MM-dd") + "', destination_type = '" + cmbDestinationType.Text + "' where destination_ID = '" + txtDestinationID.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("delete from destination where destination_ID = '" + txtDestinationID.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted successfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDestinationID.Clear();
            txtContactNumber.Clear();
            dtpEstimatedDeliveryDate.Value = DateTime.Now;
            dtpActualDeliveryDate.Value = DateTime.Now;
            cmbDestinationType.Text = "";
        }

        private void txtDestinationID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;

            con.Open();

            cmd = new SqlCommand("select * from destination where destination_ID='" + txtDestinationID.Text + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtContactNumber.Text = dr.GetValue(1).ToString();
                dtpEstimatedDeliveryDate.Value = Convert.ToDateTime(dr.GetValue(2));
                dtpActualDeliveryDate.Value = Convert.ToDateTime(dr.GetValue(3));
                cmbDestinationType.Text = dr.GetValue(4).ToString();
            }

            con.Close();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM destination", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvdistination.DataSource = dt;

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvdistination.Visible = true;
        }
    }
}
