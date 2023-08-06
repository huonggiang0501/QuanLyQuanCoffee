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
    public partial class IncreItem : UserControl
    {
        private Incredient current;
        public IncreItem(Incredient item)
        {
            InitializeComponent();
            current = item;

            itemName.Text = item.NameCre;
            itemTL.Text = item.Quantity.ToString();
            txtgia.Text = item.Price.ToString();
            MaNL.Text = item.IdCre.ToString();
            if (item.Quantity < 8)
            {
                itemName.ForeColor = Color.Red;
                itemTL.ForeColor = Color.Red;
                txtgia.ForeColor = Color.Red;
                MaNL.ForeColor = Color.Red;

            }


        }
        private void IncreItem_Load(object sender, EventArgs e)
        {
            
        }

        private void itemType_Click(object sender, EventArgs e)
        {

        }

        private void itemName_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nguyên liệu ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                IncredientDAO.Instance.RemoveIncre(current.IdCre);
                
                MessageBox.Show("xóa thành công");
            }

        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            fUpdateIncre f = new fUpdateIncre(current);

            f.ShowDialog();
        }

        private void txtgia_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
