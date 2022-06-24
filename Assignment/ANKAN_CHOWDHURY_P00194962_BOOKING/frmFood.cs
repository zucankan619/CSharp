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
    public partial class frmFood : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BookingDB.mdf;Integrated Security=True");
        DataSet ds;
        

        public frmFood()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmFood_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;

            LoadData();

        }

        private void LoadData()
        {
            SqlCommand cmd1 = new SqlCommand("Select * from tblFood", conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);

            conn.Close();

            GV.AutoGenerateColumns=false;

            GV.Columns[0].DataPropertyName = "Id";
            GV.Columns[1].DataPropertyName = "name";
            GV.Columns[2].DataPropertyName = "description";
            GV.Columns[3].DataPropertyName = "price";

            GV.DataSource = dt;
            GV.AllowUserToAddRows = false;  
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panel1.Visible=true;

            

        }

        private void clearFields()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtDesc.Text = "";
            txtPrice.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (btnInsert.Text=="Insert")
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tblFood VALUES(@name,@desc,@price)", conn);
                cmd.Parameters.AddWithValue("name", txtName.Text);
                cmd.Parameters.AddWithValue("desc", txtDesc.Text);
                cmd.Parameters.AddWithValue("price", txtPrice.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                clearFields();

                MessageBox.Show("Data Inserted Successfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();

            }
            else
            {

                int idedit = Int32.Parse(txtId.Text);

                SqlCommand cmd = new SqlCommand("Update tblFood SET name=@name,description=@desc,price=@price where id="+idedit, conn);
                cmd.Parameters.AddWithValue("name", txtName.Text);
                cmd.Parameters.AddWithValue("desc", txtDesc.Text);
                cmd.Parameters.AddWithValue("price", txtPrice.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                clearFields();

                MessageBox.Show("Data Updated Successfully", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }

            panel1.Visible = false;
            
        }

        private void GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 4:
                        panel1.Visible = true;
                        btnInsert.Text = "Update";

                        txtId.Text = GV.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn = Int32.Parse(txtId.Text);

                        SqlCommand cmd1 = new SqlCommand("Select * from tblFood where id="+ idn, conn);
                        conn.Open();
                        SqlDataReader rd = cmd1.ExecuteReader();
                        if (rd.Read())
                        {
                            txtName.Text= rd.GetString(1);
                            txtDesc.Text = rd.GetString(2);
                            txtPrice.Text = rd.GetValue(3).ToString();

                        }
                        conn.Close();


                        break;

                    case 5:
                        txtId.Text = GV.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int iddel = Int32.Parse(txtId.Text);

                        SqlCommand cmd2 = new SqlCommand("Delete from tblFood where id=" + iddel, conn);
                        conn.Open();
                        cmd2.ExecuteNonQuery();                       
                        conn.Close();

                        LoadData();

                        MessageBox.Show("Data deleted succecfully");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Error"+ex1);
                
            }
        }
    }
}
