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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("insert into showroom(showroom_ID,name,contact_number_person,address_Line_1,address_line_2,city,province,zip_code,country,destination_ID)" +
                " values('" + txtShowroomID.Text + "','" + txtName.Text + "','" + txtContactNumberPerson.Text + "','" + txtAddress1.Text + "','" + txtAddress2.Text + "'," +
                "'" + txtCity.Text + "','" + txtProvince.Text + "','" + txtZipcode.Text + "','" + txtCountry.Text + "','" + cmbDestinationID.Text + "')", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("inserted successfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("update showroom set name = '" + txtName.Text + "', contact_number_person = '" + txtContactNumberPerson.Text + "'," +
                " address_Line_1 = '" + txtAddress1.Text + "', address_line_2 = '" + txtAddress2.Text + "', city = '" + txtCity.Text + "', province = '" + txtProvince.Text + "', " +
                "zip_code = '" + txtZipcode.Text + "', country = '" + txtCountry.Text + "', destination_ID = '" + cmbDestinationID.Text + "' where showroom_ID = '" + txtShowroomID.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("delete from showroom where showroom_ID = '" + txtShowroomID.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted successfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtShowroomID.Clear();
            txtName.Clear();
            txtContactNumberPerson.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtCity.Clear();
            txtProvince.Clear();
            txtZipcode.Clear();
            txtCountry.Clear();
            cmbDestinationID.Text = "";
        }

        private void txtShowroomID_TextChanged(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
            this.Hide();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            con.Open();

            cmd = new SqlCommand("select * from showroom where showroom_ID='" + txtShowroomID.Text + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtName.Text = dr.GetValue(1).ToString();
                txtContactNumberPerson.Text = dr.GetValue(2).ToString();
                txtAddress1.Text = dr.GetValue(3).ToString();
                txtAddress2.Text = dr.GetValue(4).ToString();
                txtCity.Text = dr.GetValue(5).ToString();
                txtProvince.Text = dr.GetValue(6).ToString();
                txtZipcode.Text = dr.GetValue(7).ToString();
                txtCountry.Text = dr.GetValue(8).ToString();
                cmbDestinationID.Text = dr.GetValue(9).ToString();
            }

            con.Close();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet5.showroom' table. You can move, or remove it, as needed.
            this.showroomTableAdapter.Fill(this.e_Cey_companyDataSet5.showroom);
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet.automotive_company' table. You can move, or remove it, as needed.
            this.automotive_companyTableAdapter.Fill(this.e_Cey_companyDataSet.automotive_company);
            SqlConnection con = new SqlConnection(Class1.connectionString);

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM showroom", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvshowroom.DataSource = dt;

            con.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.showroomTableAdapter.FillBy(this.e_Cey_companyDataSet5.showroom);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvshowroom.Visible = true;
        }
    }
}
