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
    public partial class frmRegister : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BookingDB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public frmRegister()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin log = new frmLogin();
            log.ShowDialog();

        }

        private void btnsingup_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (txtUser.Text != "" || txtPassword.Text != "" || txtConPassword.Text != "")
            {
                if (txtPassword.Text == txtConPassword.Text)
                {
                    cmd = new SqlCommand("select * from tblUser where username='" + txtUser.Text + "'", conn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into tblUser values(@name,@password,@utype)", conn);
                        cmd.Parameters.AddWithValue("name", txtUser.Text);
                        cmd.Parameters.AddWithValue("password", txtPassword.Text);                   
                        cmd.Parameters.AddWithValue("utype", "user");

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else
            {
                MessageBox.Show("Please enter value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }
    }
}
