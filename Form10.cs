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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtVIN.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the VIN number.");
                return;
            }

            if (txtVIN.Text.Trim().Length != 17)
            {
                MessageBox.Show("VIN must contain exactly 17 characters.");
                return;
            }

            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("insert into vehicle(vehicle_ID,VIN,chassis_serial_number,motor_serial_number,colour,weight,manufacture_date,QC_status,order_ID,OD_ID) " +
                "values('" + txtVehicleID.Text + "','" + txtVIN.Text + "','" + txtChassisSerialNumber.Text + "','" + txtMotorSerialNumber.Text + "','" + txtColour.Text + "'," +
                "'" + txtWeight.Text + "','" + dtpManufactureDate.Value.ToString("yyyy-MM-dd") + "','" + cmbQCStatus.Text + "','" + cmbOrderID.Text + "','" + cmbUniqueID.Text + "')", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("inserted successfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("update vehicle set VIN = '" + txtVIN.Text + "', chassis_serial_number = '" + txtChassisSerialNumber.Text + "', motor_serial_number = '" + txtMotorSerialNumber.Text + "', " +
                "colour = '" + txtColour.Text + "', weight = '" + txtWeight.Text + "', manufacture_date = '" + dtpManufactureDate.Value.ToString("yyyy-MM-dd") + "', QC_status = '" + cmbQCStatus.Text + "', " +
                "order_ID = '" + cmbOrderID.Text + "', OD_ID = '" + cmbUniqueID.Text + "' where vehicle_ID = '" + txtVehicleID.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("delete from vehicle where vehicle_ID = '" + txtVehicleID.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted successfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVehicleID.Clear();
            txtVIN.Clear();
            txtChassisSerialNumber.Clear();
            txtMotorSerialNumber.Clear();
            txtColour.Clear();
            txtWeight.Clear();
            dtpManufactureDate.Value = DateTime.Now;
            cmbQCStatus.Text = "";
            cmbOrderID.Text = "";
            cmbUniqueID.Text = "";
        }

        private void txtVehicleID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            con.Open();

            cmd = new SqlCommand("select * from vehicle where vehicle_ID='" + txtVehicleID.Text + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtVIN.Text = dr.GetValue(1).ToString();
                txtChassisSerialNumber.Text = dr.GetValue(2).ToString();
                txtMotorSerialNumber.Text = dr.GetValue(3).ToString();
                txtColour.Text = dr.GetValue(4).ToString();
                txtWeight.Text = dr.GetValue(5).ToString();
                dtpManufactureDate.Value = Convert.ToDateTime(dr.GetValue(6));
                cmbQCStatus.Text = dr.GetValue(7).ToString();
                cmbOrderID.Text = dr.GetValue(8).ToString();
                cmbUniqueID.Text = dr.GetValue(9).ToString();
            }

            con.Close();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet45.order_details' table. You can move, or remove it, as needed.
            this.order_detailsTableAdapter.Fill(this.e_Cey_companyDataSet45.order_details);
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet44.order1' table. You can move, or remove it, as needed.
            this.order1TableAdapter.Fill(this.e_Cey_companyDataSet44.order1);
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet22.vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.e_Cey_companyDataSet22.vehicle);
            SqlConnection con = new SqlConnection(Class1.connectionString);

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vehicle", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvvehicle.DataSource = dt;

            con.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vehicleTableAdapter.FillBy(this.e_Cey_companyDataSet22.vehicle);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vehicleTableAdapter.FillBy1(this.e_Cey_companyDataSet22.vehicle);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvvehicle.Visible = true;
        }
    }
}
