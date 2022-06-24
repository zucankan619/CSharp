using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string fnum = textBox1.Text;
                string snum = textBox2.Text;

                int n1 = Int32.Parse(fnum);
                int n2 = Int32.Parse(snum);

                int n3 = n1 + n2;

                lblResult.Text = "Addition is : " + n3.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Tomer Bhul Hoyeche !!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                string fnum = textBox1.Text;
                string snum = textBox2.Text;

                int n1 = Int32.Parse(fnum);
                int n2 = Int32.Parse(snum);

                int n3 = n1 - n2;

                lblResult.Text = "Subtraction is : " + n3.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            string fnum = textBox1.Text;
            string snum = textBox2.Text;

            int n1 = Int32.Parse(fnum);
            int n2 = Int32.Parse(snum);

            int n3 = n1 * n2;

            lblResult.Text = "Multiplication is : " + n3.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            string fnum = textBox1.Text;
            string snum = textBox2.Text;

            int n1 = Int32.Parse(fnum);
            int n2 = Int32.Parse(snum);

            int n3 = n1 / n2;

            lblResult.Text = "Division is : " + n3.ToString();
        }
    }
}
