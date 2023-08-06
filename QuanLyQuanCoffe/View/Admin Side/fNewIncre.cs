using QuanLyQuanCoffe.Controls;
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
    public partial class fNewIncre : Form
    {
        public fNewIncre()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtId.Text = "";
            txtPrice.Value = 0;
            txtTL.Value = 0 ;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                IncredientDAO.Instance.InsertIncre(txtId.Text, txtName.Text,(float)txtTL.Value,(float)txtPrice.Value);
                MessageBox.Show("Thêm thành công");
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
