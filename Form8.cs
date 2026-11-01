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
    public partial class Form8 : Form
    {
        public Form8()
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
            cmd = new SqlCommand("insert into order_details(OD_ID,quanitity,sub_total,order_ID,vehicle_model_ID) values('" + txtUniqueID.Text + "','" + txtQuantity.Text + "'," +
                "'" + txtSubTotal.Text + "','" + cmbOrderID.Text + "','" + cmbVehicleModelID.Text + "')", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("inserted successfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("update order_details set quanitity = '" + txtQuantity.Text + "', sub_total = '" + txtSubTotal.Text + "', " +
                "order_ID = '" + cmbOrderID.Text + "', vehicle_model_ID = '" + cmbVehicleModelID.Text + "' where OD_ID = '" + txtUniqueID.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("delete from order_details where OD_ID = '" + txtUniqueID.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted successfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUniqueID.Clear();
            txtQuantity.Clear();
            txtSubTotal.Clear();
            cmbOrderID.Text = "";
            cmbVehicleModelID.Text = "";
        }

        private void txtUniqueID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet42.order1' table. You can move, or remove it, as needed.
            this.order1TableAdapter.Fill(this.e_Cey_companyDataSet42.order1);
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet41.vehicle_model' table. You can move, or remove it, as needed.
            this.vehicle_modelTableAdapter.Fill(this.e_Cey_companyDataSet41.vehicle_model);
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet18.order_details' table. You can move, or remove it, as needed.
            this.order_detailsTableAdapter.Fill(this.e_Cey_companyDataSet18.order_details);
            SqlConnection con = new SqlConnection(Class1.connectionString);

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM order_details", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvOrderDetails.DataSource = dt;

            con.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            con.Open();

            cmd = new SqlCommand("select * from order_details where OD_ID ='" + txtUniqueID.Text + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtQuantity.Text = dr.GetValue(1).ToString();
                txtSubTotal.Text = dr.GetValue(2).ToString();
                cmbOrderID.Text = dr.GetValue(3).ToString();
                cmbVehicleModelID.Text = dr.GetValue(4).ToString();
            }

            con.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.order_detailsTableAdapter.FillBy(this.e_Cey_companyDataSet18.order_details);
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
                this.order_detailsTableAdapter.FillBy1(this.e_Cey_companyDataSet18.order_details);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvOrderDetails.Visible = true;
        }
    }
}
