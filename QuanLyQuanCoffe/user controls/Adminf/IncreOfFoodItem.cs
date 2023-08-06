using QuanLyQuanCoffe.Controls;
using QuanLyQuanCoffe.Models;
using QuanLyQuanCoffe.View.Admin_Side;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCoffe.user_controls.Adminf
{
    public partial class IncreOfFoodItem : UserControl
    {
        private IncreOfFood current;
        public IncreOfFoodItem(IncreOfFood item)
        {
            InitializeComponent();
            current = item;
            Id.Text = item.Id;
            IdFood.Text = item.IdFood.ToString();
            IdNL.Text = item.IdCre;
            kl.Text = item.QuantityIncre.ToString();

        }

        private void MaNL_Click(object sender, EventArgs e)
        {

        }

        private void itemTL_Click(object sender, EventArgs e)
        {

        }

        private void IncreOfFoodItem_Load(object sender, EventArgs e)
        {

        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nguyên liệu ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                IncreOfFoodDAO.Instance.RemoveIncreOfFood(current.IdFood, current.IdCre);

                MessageBox.Show("xóa thành công");
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            fUpdateInCreOfFood f = new fUpdateInCreOfFood(current);
            f.ShowDialog();
        }
    }
}
