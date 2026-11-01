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
    public partial class Form9 : Form
    {
        public Form9()
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
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("insert into vehicle_model(vehicle_model_ID,model_name,body_type,battery_type,battery_capacity,motor_power,charging_time,top_speed,drive_type,seating_capacity,price)" +
                " values('" + txtVehicleModelID.Text + "','" + txtModelName.Text + "','" + cmbBodyType.Text + "','" + cmbBatteryType.Text + "','" + txtBatteryCapacity.Text + "','" + txtMotorPower.Text + "'," +
                "'" + txtChargingTime.Text + "','" + txtTopSpeed.Text + "','" + cmbDriveType.Text + "','" + txtSeatingCapacity.Text + "','" + txtPrice.Text + "')", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("inserted successfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("update vehicle_model set model_name = '" + txtModelName.Text + "', body_type = '" + cmbBodyType.Text + "'," +
                " battery_type = '" + cmbBatteryType.Text + "', battery_capacity = '" + txtBatteryCapacity.Text + "', motor_power = '" + txtMotorPower.Text + "', charging_time = '" + txtChargingTime.Text + "'," +
                " top_speed = '" + txtTopSpeed.Text + "', drive_type = '" + cmbDriveType.Text + "', seating_capacity = '" + txtSeatingCapacity.Text + "', price = '" + txtPrice.Text + "' where vehicle_model_ID = '" + txtVehicleModelID.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("delete from vehicle_model where vehicle_model_ID = '" + txtVehicleModelID.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted successfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVehicleModelID.Clear();
            txtModelName.Clear();
            cmbBodyType.Text="";
            cmbBatteryType.Text = "";
            txtBatteryCapacity.Clear();
            txtMotorPower.Clear();
            txtChargingTime.Clear();
            txtTopSpeed.Clear();
            cmbDriveType.Text = "";
            txtSeatingCapacity.Clear();
            txtPrice.Clear();
        }

        private void txtVehicleModelID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            con.Open();

            cmd = new SqlCommand("select * from vehicle_model where vehicle_model_ID='" + txtVehicleModelID.Text + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtModelName.Text = dr.GetValue(1).ToString();
                cmbBodyType.Text = dr.GetValue(2).ToString();
                cmbBatteryType.Text = dr.GetValue(3).ToString();
                txtBatteryCapacity.Text = dr.GetValue(4).ToString();
                txtMotorPower.Text = dr.GetValue(5).ToString();
                txtChargingTime.Text = dr.GetValue(6).ToString();
                txtTopSpeed.Text = dr.GetValue(7).ToString();
                cmbDriveType.Text = dr.GetValue(8).ToString();
                txtSeatingCapacity.Text = dr.GetValue(9).ToString();
                txtPrice.Text = dr.GetValue(10).ToString();
            }

            con.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vehicle_model", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvvehiclemodel.DataSource = dt;

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvvehiclemodel.Visible = true;
        }
    }
}
