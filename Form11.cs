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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            form16.Show();
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("insert into logistic(logistic_ID,logistic_method,destination_type,dispatched_date,logistic_status,destination_ID) " +
                "values('" + txtLogisticID.Text + "','" + cmbLogisticMethod.Text + "','" + cmbDestinationType.Text + "','" + dtpDispatchedDate.Value.ToString("yyyy-MM-dd") + "'," +
                "'" + cmbLogisticStatus.Text + "','" + cmbDestinationID.Text + "')", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("inserted successfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("update logistic set logistic_method = '" + cmbLogisticMethod.Text + "', destination_type = '" + cmbDestinationType.Text + "'," +
                " dispatched_date = '" + dtpDispatchedDate.Value.ToString("yyyy-MM-dd") + "', logistic_status = '" + cmbLogisticStatus.Text + "', " +
                "destination_ID = '" + cmbDestinationID.Text + "' where logistic_ID = '" + txtLogisticID.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("delete from logistic where logistic_ID = '" + txtLogisticID.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted successfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLogisticID.Clear();
            cmbLogisticMethod.Text = "";
            cmbDestinationType.Text = "";
            dtpDispatchedDate.Value = DateTime.Now;
            cmbLogisticStatus.Text = "";
            cmbDestinationID.Text = "";
        }

        private void txtLogisticID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            con.Open();

            cmd = new SqlCommand("select * from logistic where logistic_ID='" + txtLogisticID.Text + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmbLogisticMethod.Text = dr.GetValue(1).ToString();
                cmbDestinationType.Text = dr.GetValue(2).ToString();
                dtpDispatchedDate.Value = Convert.ToDateTime(dr.GetValue(3));
                cmbLogisticStatus.Text = dr.GetValue(4).ToString();
                cmbDestinationID.Text = dr.GetValue(5).ToString();
            }

            con.Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet54.destination' table. You can move, or remove it, as needed.
            this.destinationTableAdapter.Fill(this.e_Cey_companyDataSet54.destination);
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet24.logistic' table. You can move, or remove it, as needed.
            this.logisticTableAdapter.Fill(this.e_Cey_companyDataSet24.logistic);
            SqlConnection con = new SqlConnection(Class1.connectionString);

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM logistic", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvlogistic.DataSource = dt;

            con.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.logisticTableAdapter.FillBy(this.e_Cey_companyDataSet24.logistic);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvlogistic.Visible = true;
        }
    }
}
