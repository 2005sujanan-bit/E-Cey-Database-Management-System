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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void txtVehicleRegisterNumber_Click(object sender, EventArgs e)
        {

        }

        private void cmbVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRegisterCompany_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnInsert_Click(object sender, EventArgs e)
        
        {
            using (SqlConnection con = new SqlConnection(Class1.connectionString))
            {
                try
                {
                    con.Open();

                    // Check duplicate Vehicle Register Number
                    string checkQuery = @"SELECT COUNT(*)
                                  FROM logistic_vehicle
                                  WHERE vehicle_register_number = @RegisterNumber";

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue(
                            "@RegisterNumber",
                            txtVehicleRegisterNumber.Text.Trim()
                        );

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show(
                                "insert Successfull "
                               
                            );

                            return;
                        }
                    }

                    // Insert new vehicle
                    string insertQuery = @"INSERT INTO logistic_vehicle
                (vehicle_register_number, vehicle_type, brand, model,
                 power_sourse, manufacturing_year, register_company)
                VALUES
                (@RegisterNumber, @VehicleType, @Brand, @Model,
                 @PowerSource, @ManufacturingYear, @RegisterCompany)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@RegisterNumber",
                            txtVehicleRegisterNumber.Text.Trim()
                        );

                        cmd.Parameters.AddWithValue(
                            "@VehicleType",
                            cmbVehicleType.Text.Trim()
                        );

                        cmd.Parameters.AddWithValue(
                            "@Brand",
                            txtBrand.Text.Trim()
                        );

                        cmd.Parameters.AddWithValue(
                            "@Model",
                            txtModel.Text.Trim()
                        );

                        cmd.Parameters.AddWithValue(
                            "@PowerSource",
                            txtPowerSource.Text.Trim()
                        );

                        cmd.Parameters.Add(
                            "@ManufacturingYear",
                            SqlDbType.Date
                        ).Value = dtpManufacturingYear.Value.Date;

                        cmd.Parameters.AddWithValue(
                            "@RegisterCompany",
                            txtRegisterCompany.Text.Trim()
                        );

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Vehicle inserted successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(
                        "Database Error: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;

            cmd = new SqlCommand("update logistic_vehicle set vehicle_type='"
                + cmbVehicleType.Text + "',brand='"
                + txtBrand.Text + "',model='"
                + txtModel.Text + "',power_sourse='"
                + txtPowerSource.Text + "',manufacturing_year='"
                + dtpManufacturingYear.Value.ToString("yyyy-MM-dd") + "',register_company='"
                + txtRegisterCompany.Text + "' where vehicle_register_number='"
                + txtVehicleRegisterNumber.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("updated successfully");
        }       

        private void btnDelete_Click(object sender, EventArgs e)
        
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);

            try
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM logistic_vehicle WHERE vehicle_register_number = @RegisterNumber",
                    con);

                cmd.Parameters.AddWithValue(
                    "@RegisterNumber",
                    txtVehicleRegisterNumber.Text.Trim());

                con.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show(
                        "Vehicle deleted successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "Vehicle Register Number not found!",
                        "Delete Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show(
                        "Delete Successfull");
                       
                }
                else
                {
                    MessageBox.Show(
                        "Database Error: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            {
                txtVehicleRegisterNumber.Text="";
                cmbVehicleType.Text="";
                txtBrand.Text = ""; ;
                txtModel.Text = "";
                txtPowerSource.Text = "";
                dtpManufacturingYear.Value = DateTime.Now;
                txtRegisterCompany.Text = ""; 
            }
        }

        private void dtpManufacturingYear_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPowerSource_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            con.Open();

            cmd = new SqlCommand("select * from logistic_vehicle where vehicle_register_number='" + txtVehicleRegisterNumber.Text + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmbVehicleType.Text = dr.GetValue(1).ToString();
                txtBrand.Text = dr.GetValue(2).ToString();
                txtModel.Text = dr.GetValue(3).ToString();
                txtPowerSource.Text = dr.GetValue(4).ToString();
                dtpManufacturingYear.Value = Convert.ToDateTime(dr.GetValue(5));
                txtRegisterCompany.Text = dr.GetValue(6).ToString();
            }

            con.Close();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM logistic_vehicle", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvlogisticvehicle.DataSource = dt;

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvlogisticvehicle.Visible = true;
        }
    }
}
