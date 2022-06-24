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

namespace MOHAMMED_ABDULLAH_P00193895_Booking
{
    public partial class FrmRegister : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BOOKING.mdf;Integrated Security=True");

        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (
                txtName.Text.Length <= 0 ||
                txtAddress.Text.Length <= 0 ||
                txtEmail.Text.Length <= 0 ||
                txtMobile.Text.Length <= 0 ||
                txtPass.Text.Length <= 0
                )
            {
                MessageBox.Show("Please, Fill up all the fileds !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // confirm password validation
            if (txtPass.Text != txtConfPass.Text)
            {
                MessageBox.Show("Password doesn't match !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlCommand getUserName = new SqlCommand("select * from tblUser where name = '" + txtName.Text + "' or email = '" + txtEmail.Text + "'", con);
            con.Open();
            SqlDataReader rd = getUserName.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("User Already Exists !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            con.Close();

            SqlCommand cmd = new SqlCommand("INSERT INTO tblUser VALUES(@name,@pass,@address,@mobile,@email)", con);
            cmd.Parameters.AddWithValue("name", txtName.Text);
            cmd.Parameters.AddWithValue("pass", txtPass.Text);
            cmd.Parameters.AddWithValue("address", txtAddress.Text);
            cmd.Parameters.AddWithValue("mobile", txtMobile.Text);
            cmd.Parameters.AddWithValue("email", txtEmail.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            clearFields();

            MessageBox.Show("Data Inserted Successfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void clearFields()
        {
            txtName.Text = txtPass.Text = txtAddress.Text = txtMobile.Text = txtEmail.Text = txtConfPass.Text = "";
        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            //frmLogin frm = new frmLogin();
            //frm.ShowDialog();
        }
    }
}
