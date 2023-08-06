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
    public partial class fUpdateIncre : Form
    {
        private Incredient current;
        public fUpdateIncre(Incredient item)
        {
            InitializeComponent();
            current = item;

            txtName.Text = current.NameCre;
            txtId.Text = current.IdCre;
            txtPrice.Value = (decimal)current.Price;
            txtTL.Value = (decimal)current.Quantity;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = current.NameCre;
            txtId.Text = current.IdCre;
            txtPrice.Value = (decimal)current.Price;
            txtTL.Value = (decimal)current.Quantity;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                IncredientDAO.Instance.UpdateIncre(txtId.Text, txtName.Text, (float)txtTL.Value, (float)txtPrice.Value);
                MessageBox.Show("Sửa thành công");
                this.Close();

            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) //conflict primary key exception
                {
                    MessageBox.Show("Mã nguyên liệu bị trùng");
                    return;

                }
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
