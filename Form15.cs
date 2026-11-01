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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("insert into port1(port_ID,city,country,port_type,clearing,destination_ID) " +
                "values('" + txtPortID.Text + "','" + txtCity.Text + "','" + txtCountry.Text + "','" + cmbPortType.Text + "','" + txtClearing.Text + "','" + cmbDestinationID.Text + "')", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("inserted successfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("update port1 set city = '" + txtCity.Text + "', country = '" + txtCountry.Text + "', port_type = '" + cmbPortType.Text + "', " +
                "clearing = '" + txtClearing.Text + "', destination_ID = '" + cmbDestinationID.Text + "' where port_ID = '" + txtPortID.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("delete from port1 where port_ID = '" + txtPortID.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted successfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPortID.Clear();
            txtCity.Clear();
            txtCountry.Clear();
            cmbPortType.SelectedIndex = -1;
            txtClearing.Clear();
            cmbDestinationID.SelectedIndex = -1;
        }

        private void txtPortID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.connectionString);
            SqlCommand cmd;
            con.Open();

            cmd = new SqlCommand("select * from port1 where port_ID='" + txtPortID.Text + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtCity.Text = dr.GetValue(1).ToString();
                txtCountry.Text = dr.GetValue(2).ToString();
                cmbPortType.Text = dr.GetValue(3).ToString();
                txtClearing.Text = dr.GetValue(4).ToString();
                cmbDestinationID.Text = dr.GetValue(5).ToString();
            }

            con.Close();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet50.destination' table. You can move, or remove it, as needed.
            this.destinationTableAdapter.Fill(this.e_Cey_companyDataSet50.destination);
            // TODO: This line of code loads data into the 'e_Cey_companyDataSet8.port1' table. You can move, or remove it, as needed.
            this.port1TableAdapter.Fill(this.e_Cey_companyDataSet8.port1);
            SqlConnection con = new SqlConnection(Class1.connectionString);

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM port1", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvport.DataSource = dt;

            con.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.port1TableAdapter.FillBy(this.e_Cey_companyDataSet8.port1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvport.Visible = true;
        }
    }
}
