using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E293997_new
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(
        @"Data Source=LAPTOP-K43AJN0I\SQLEXPRESS;Initial Catalog=E_Cey_company;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void btnAutomotiveCompany_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void btnprivatebuyers_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void btnCustomerContactNumber_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            form17.Show();
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            {
                if (txtCustomerID.Text == "" ||
                    txtEmail.Text == "" ||
                    txtAddress1.Text == "" ||
                    txtAddress2.Text == "" ||
                    txtCity.Text == "" ||
                    txtProvince.Text == "" ||
                    txtZipcode.Text == "" ||
                    txtCountry.Text == "" ||
                    txtCurrency.Text == "" ||
                    cmbCustomerType.Text == "")
                {
                    MessageBox.Show("Please fill all the fields.");
                }
                else
                    try
                    {
                        SqlConnection con = new SqlConnection(Class1.connectionString);
                        SqlCommand cmd;

                        cmd = new SqlCommand("insert into customer(customer_ID,Email,address_Line_1,address_line_2,city,province,zip_code,country,curreuncy,customer_type) values('" + txtCustomerID.Text + "','" + txtEmail.Text + "','" + txtAddress1.Text + "','" + txtAddress2.Text + "','" + txtCity.Text + "','" + txtProvince.Text + "','" + txtZipcode.Text + "','" + txtCountry.Text + "','" + txtCurrency.Text + "','" + cmbCustomerType.Text + "')", con);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("inserted successfully");
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627 || ex.Number == 2601)
                        {
                            MessageBox.Show("This Customer ID already exists.");
                        }
                        else
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("update customer set Email = '" + txtEmail.Text + "', address_Line_1 = '" + txtAddress1.Text + "', address_line_2 = '" + txtAddress2.Text + "', city = '" + txtCity.Text + "', province = '" + txtProvince.Text + "', zip_code = '" + txtZipcode.Text + "', country = '" + txtCountry.Text + "', curreuncy = '" + txtCurrency.Text + "', customer_type = '" + cmbCustomerType.Text + "' where customer_ID = '" + txtCustomerID.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("delete from customer where customer_ID = '" + txtCustomerID.Text + "'", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Deleted successfully");
            }
            catch (SqlException)
            {
                con.Close();

                MessageBox.Show("This customer cannot be deleted because it is referenced by another record.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtEmail.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtCity.Clear();
            txtProvince.Clear();
            txtZipcode.Clear();
            txtCountry.Clear();
            txtCurrency.Clear();

            cmbCustomerType.Text = "";
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            con.Open();

            cmd = new SqlCommand("select * from customer where customer_ID='" + txtCustomerID.Text + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();

            bool found = false;

            while (dr.Read())
            {
                found = true;

                txtEmail.Text = dr.GetValue(1).ToString();
                txtAddress1.Text = dr.GetValue(2).ToString();
                txtAddress2.Text = dr.GetValue(3).ToString();
                txtCity.Text = dr.GetValue(4).ToString();
                txtProvince.Text = dr.GetValue(5).ToString();
                txtZipcode.Text = dr.GetValue(6).ToString();
                txtCountry.Text = dr.GetValue(7).ToString();
                txtCurrency.Text = dr.GetValue(8).ToString();
                cmbCustomerType.Text = dr.GetValue(9).ToString();
            }

            dr.Close();
            con.Close();

            if (found == true)
            {
                MessageBox.Show("Customer ID found.");
            }
            else
            {
                MessageBox.Show("Customer not found.");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM customer", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvcustomer.DataSource = dt;

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM customer", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvcustomer.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvcustomer.Visible = true;
        }
    }
}
