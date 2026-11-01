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
    public partial class Form4 : Form
    {
        public Form4()
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

            cmd = new SqlCommand("insert into automotive_company(company_register_ID,company_name,contactperson,Business_type,credit_limit,customer_ID)" +
                " values('" + txtCompanyRegisterID.Text + "','" + txtCompanyName.Text + "','" + txtContactPerson.Text + "','" + cmbBusinessType.Text + "'," +
                "'" + txtCreditLimit.Text + "','" + cmbCustomerID.Text + "')", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("inserted successfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("update automotive_company set company_name = '" + txtCompanyName.Text + "', contactperson = '" + txtContactPerson.Text + "'," +
                " Business_type = '" + cmbBusinessType.Text + "', credit_limit = '" + txtCreditLimit.Text + "', customer_ID = '" + cmbCustomerID.Text + "' where company_register_ID = '" + txtCompanyRegisterID.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("delete from automotive_company where company_register_ID = '" + txtCompanyRegisterID.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted successfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCompanyRegisterID.Clear();
            txtCompanyName.Clear();
            txtContactPerson.Clear();
            cmbBusinessType.Text="";
            txtCreditLimit.Clear();
            cmbCustomerID.Text = "";
        }

        private void txtCompanyRegisterID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet32.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.e_Cey_companyDataSet32.customer);
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet.automotive_company' table. You can move, or remove it, as needed.
            this.automotive_companyTableAdapter.Fill(this.e_Cey_companyDataSet.automotive_company);
            SqlConnection con = new SqlConnection(Class1.connectionString);

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM automotive_company", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvAutomotiveCompany.DataSource = dt;

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            con.Open();

            cmd = new SqlCommand("select * from automotive_company where company_register_ID='" + txtCompanyRegisterID.Text + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtCompanyName.Text = dr.GetValue(1).ToString();
                txtContactPerson.Text = dr.GetValue(2).ToString();
                cmbBusinessType.Text = dr.GetValue(3).ToString();
                txtCreditLimit.Text = dr.GetValue(4).ToString();
                cmbCustomerID.Text = dr.GetValue(5).ToString();
            }

            con.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.automotive_companyTableAdapter.FillBy(this.e_Cey_companyDataSet.automotive_company);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvAutomotiveCompany.Visible = true;
        }

        private void cmbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
