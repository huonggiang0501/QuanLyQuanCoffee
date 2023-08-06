using QuanLyQuanCoffe.Controls;
using QuanLyQuanCoffe.Models;
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

namespace QuanLyQuanCoffe.View.Admin_Side
{
    public partial class fAddIncreOfFood : Form
    {
        private Food current;
        public fAddIncreOfFood(Food item)
        {
            InitializeComponent();
            current = item;
            txtidFood.Value = (decimal)current.ID;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTL_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                IncreOfFoodDAO.Instance.InsertIncreofFood(id.Text, (int)txtidFood.Value, txtIdCre.Text, (float)txtKL.Value);
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) //conflict primary key exception
                {
                    MessageBox.Show("Mã id bị trùng");
                    return;

                }

            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            id.Text = "";
            txtIdCre.Text = "";
            txtidFood.Value = (decimal)current.ID;
            txtKL.Value = 0;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtidFood_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
