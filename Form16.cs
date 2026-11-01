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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("insert into logistic_logistic_vehicle(logistic_ID,vehicle_register_number) values('" + cmbLogisticID.Text + "','" + cmbVehicleRegisterNumber.Text + "')", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("inserted successfully");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("update logistic_logistic_vehicle set vehicle_register_number = '" + cmbVehicleRegisterNumber.Text + "' where logistic_ID = '" + cmbLogisticID.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated successfully");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("delete from logistic_logistic_vehicle where logistic_ID = '" + cmbLogisticID.Text + "' and vehicle_register_number = '" + cmbVehicleRegisterNumber.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmbLogisticID.SelectedIndex = -1;
            cmbVehicleRegisterNumber.SelectedIndex = -1;
        }

        private void cmbLogisticID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet48.logistic_vehicle' table. You can move, or remove it, as needed.
            this.logistic_vehicleTableAdapter.Fill(this.e_Cey_companyDataSet48.logistic_vehicle);
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet47.logistic' table. You can move, or remove it, as needed.
            this.logisticTableAdapter.Fill(this.e_Cey_companyDataSet47.logistic);
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM logistic_logistic_vehicle ", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvlogisticlogisticvehicle.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvlogisticlogisticvehicle.Visible = true;
        }
    }
}
