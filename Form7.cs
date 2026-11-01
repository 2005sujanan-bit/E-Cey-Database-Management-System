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
    public partial class Form7 : Form
    {
        public Form7()
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
            cmd = new SqlCommand("insert into payment(payment_ID,payment_amount,due_amount,payment_date,payment_status,customer_ID,order_ID) " +
                "values('" + txtPaymentID.Text + "','" + txtPaymentAmount.Text + "','" + txtDueAmount.Text + "','" + dtpPaymentDate.Value.ToString("yyyy-MM-dd") + "','" + cmbPaymentStatus.Text + "'," +
                "'" + cmbCustomerID.Text + "','" + cmbOrderID.Text + "')", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("inserted successfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            decimal totalAmount = 0;

            SqlCommand cmdCheck = new SqlCommand(
                "SELECT total_ordre_amount FROM order1 WHERE order_ID = '" + cmbOrderID.Text + "'", con);

            con.Open();

            SqlDataReader dr = cmdCheck.ExecuteReader();

            if (dr.Read())
            {
                totalAmount = Convert.ToDecimal(dr["total_ordre_amount"]);
            }
            else
            {
                dr.Close();
                con.Close();

                MessageBox.Show("Order ID not found.");
                return;
            }

            dr.Close();
            con.Close();

            decimal paymentAmount = Convert.ToDecimal(txtPaymentAmount.Text);

            if (paymentAmount < totalAmount * 0.50m)
            {
                MessageBox.Show("Advance payment must be at least 50% of the total order amount.");
                return;
            }


            
            cmd = new SqlCommand("update payment set payment_amount = '" + txtPaymentAmount.Text + "', due_amount = '" + txtDueAmount.Text + "'," +
                " payment_date = '" + dtpPaymentDate.Text + "', payment_status = '" + cmbPaymentStatus.Text + "', customer_ID = '" + cmbCustomerID.Text + "', " +
                "order_ID = '" + cmbOrderID.Text + "' where payment_ID = '" + dtpPaymentDate.Value.ToString("yyyy-MM-dd") + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("delete from payment where payment_ID = '" + txtPaymentID.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted successfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtPaymentID.Clear();
            txtPaymentAmount.Clear();
            txtDueAmount.Clear();
            dtpPaymentDate.Value = DateTime.Now;
            cmbPaymentStatus.Text="";
            cmbCustomerID.Text = "";
            cmbOrderID.Text = "";
        }

        private void txtPaymentID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            con.Open();

            cmd = new SqlCommand("select * from payment where payment_ID='" + txtPaymentID.Text + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtPaymentAmount.Text = dr.GetValue(1).ToString();
                txtDueAmount.Text = dr.GetValue(2).ToString();
                dtpPaymentDate.Text = dr.GetValue(3).ToString();
                cmbPaymentStatus.Text = dr.GetValue(4).ToString();
                cmbCustomerID.Text = dr.GetValue(5).ToString();
                cmbOrderID.Text = dr.GetValue(6).ToString();
            }

            con.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet40.order1' table. You can move, or remove it, as needed.
            this.order1TableAdapter.Fill(this.e_Cey_companyDataSet40.order1);
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet39.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.e_Cey_companyDataSet39.customer);
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet21.payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.e_Cey_companyDataSet21.payment);
            SqlConnection con = new SqlConnection(Class1.connectionString);

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM payment", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvPayment.DataSource = dt;

            con.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.paymentTableAdapter.FillBy(this.e_Cey_companyDataSet21.payment);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.paymentTableAdapter1.FillBy(this.e_Cey_companyDataSet17.payment);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvPayment.Visible = true;
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.paymentTableAdapter1.FillBy1(this.e_Cey_companyDataSet17.payment);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
