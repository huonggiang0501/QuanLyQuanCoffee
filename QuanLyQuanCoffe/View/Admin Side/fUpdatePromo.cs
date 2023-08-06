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
    public partial class fUpdatePromo : Form
    {




        private Promotion current;
        public fUpdatePromo(Promotion item)
        {
            InitializeComponent();
            current = item;

            txtName.Text = item.IdPromo;
            txtPrice.Value = (decimal)item.PricePromo;
            txtDes.Text = item.Des;

            dateTimePickerStart.Value = item.StartDate;
            dateTimePickerEnd.Value = item.EndDate;
        }

        private void fUpdatePromo_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn cập nhật thông tin?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    PromotionDAO.Instance.UpdatePromo(txtName.Text, dateTimePickerStart.Value.ToString("yyyy-MM-dd"), dateTimePickerEnd.Value.ToString("yyyy-MM-dd"), txtPrice.Value, txtDes.Text, current.IdPromo);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) //conflict primary key exception
                    {
                        MessageBox.Show("Mã giảm giá bị trùng");
                        return;
                    }
                }
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            txtName.Text = current.IdPromo;
            txtPrice.Value = (decimal)current.PricePromo;
            txtDes.Text = current.Des;

            dateTimePickerStart.Value = current.StartDate;
            dateTimePickerEnd.Value = current.EndDate;
        }

        private void txtDes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
