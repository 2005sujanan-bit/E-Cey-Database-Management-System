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
    public partial class Form6 : Form
    {
        public Form6()
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
            cmd = new SqlCommand("insert into order1(order_ID,total_ordre_amount,order_placement_data,order_complete_date,order_status,customer_ID,logistic_ID) " +
                "values('" + txtOrderID.Text + "','" + txtTotalOrderAmount.Text + "','" + dtpOrderPlacementDate.Value.ToString("yyyy-MM-dd") + "','" + dtpOrderCompleteDate.Value.ToString("yyyy-MM-dd") + "'," +
                "'" + cmbOrderStatus.Text + "','" + cmbCustomerID.Text + "','" + cmbLogisticID.Text + "')", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("inserted successfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("update order1 set total_ordre_amount = '" + txtTotalOrderAmount.Text + "', order_placement_data = '" + dtpOrderPlacementDate.Value.ToString("yyyy-MM-dd") + "', " +
                "order_complete_date = '" + dtpOrderCompleteDate.Value.ToString("yyyy-MM-dd") + "', order_status = '" + cmbOrderStatus.Text + "', customer_ID = '" + cmbCustomerID.Text + "'," +
                " logistic_ID = '" + cmbLogisticID.Text + "' where order_ID = '" + txtOrderID.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("delete from order1 where order_ID = '" + txtOrderID.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted successfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOrderID.Clear();
            txtTotalOrderAmount.Clear();
            dtpOrderPlacementDate.Value = DateTime.Now;
            dtpOrderCompleteDate.Value = DateTime.Now;
            cmbOrderStatus.Text = "";
            cmbCustomerID.Text = "";
            cmbLogisticID.Text="";
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            con.Open();

            cmd = new SqlCommand("select * from order1 where order_ID='" + txtOrderID.Text + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtTotalOrderAmount.Text = dr.GetValue(1).ToString();
                dtpOrderPlacementDate.Value = Convert.ToDateTime(dr.GetValue(2));
                dtpOrderCompleteDate.Value = Convert.ToDateTime(dr.GetValue(3));
                cmbOrderStatus.Text = dr.GetValue(4).ToString();
                cmbCustomerID.Text = dr.GetValue(5).ToString();
                cmbLogisticID.Text = dr.GetValue(6).ToString();
            }

            con.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet37.logistic' table. You can move, or remove it, as needed.
            this.logisticTableAdapter.Fill(this.e_Cey_companyDataSet37.logistic);
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet36.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.e_Cey_companyDataSet36.customer);
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet11.order1' table. You can move, or remove it, as needed.
            this.order1TableAdapter.Fill(this.e_Cey_companyDataSet11.order1);
            SqlConnection con = new SqlConnection(Class1.connectionString);

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM order1", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvOrder.DataSource = dt;

            con.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.order1TableAdapter.FillBy(this.e_Cey_companyDataSet11.order1);
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
                this.order1TableAdapter.FillBy1(this.e_Cey_companyDataSet11.order1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvOrder.Visible = true;
        }
    }
}
