using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E293997_new
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
         "Are you sure you want to logout?",
         "Logout Confirmation",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
