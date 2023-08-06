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

namespace QuanLyQuanCoffe.user_controls
{
    public partial class PromotionItem : UserControl
    {
        private Promotion current;   // tạo ra 1 đối tượng current của lớp promotion

        public PromotionItem(Promotion item)
        {
            InitializeComponent();
            current = item; // gán khuyến mại vào hiện tại 

            itemPromoName.Text = item.IdPromo;
            itemPromoValidate.Text = item.StartDate.ToString("dd/MM/yyyy") + " - " + item.EndDate.ToString("dd/MM/yyyy");
        }

        private void PromotionItem_Load(object sender, EventArgs e)
        {

        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            fUpdatePromo fUP = new fUpdatePromo(current);
            fUP.ShowDialog();
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá mã này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                PromotionDAO.Instance.DeletePromo(current.IdPromo);
                MessageBox.Show("Đã xoá mã " + current.IdPromo);
            }
        }

        private void itemPromoName_Click(object sender, EventArgs e)
        {

        }
    }
}
