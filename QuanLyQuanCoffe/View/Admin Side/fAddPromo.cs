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
    public partial class fAddPromo : Form
    {
        public fAddPromo()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                PromotionDAO.Instance.InsertPromo(txtName.Text, dateTimePickerStart.Value.ToString("yyyy-MM-dd"), dateTimePickerEnd.Value.ToString("yyyy-MM-dd"), txtPrice.Value, txtDes.Text);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) //conflict primary key exception
                {
                    MessageBox.Show("Mã giảm giá bị trùng");
                    return;
                }
            }
            MessageBox.Show("Thêm thành công");
            this.Close();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPrice.Value = 0;
            txtDes.Text = "";

            dateTimePickerStart.Value = DateTime.Today;
            dateTimePickerEnd.Value = DateTime.Today;
        }
    }
}
