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

namespace ANKAN_CHOWDHURY_P00194962_BOOKING
{
    public partial class frmLogin : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BookingDB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmRegister reg = new frmRegister();
            reg.ShowDialog();

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != String.Empty || txtUser.Text != String.Empty)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from tblUser where username = '" + txtUser.Text + "' and password ='" + txtPassword.Text + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    frmMenu menu = new frmMenu();
                    menu.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No account available with this username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Please enter value in all field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
