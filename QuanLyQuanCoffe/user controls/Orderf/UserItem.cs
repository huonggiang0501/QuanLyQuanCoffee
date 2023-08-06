using QuanLyQuanCoffe.Controls;
using QuanLyQuanCoffe.Models;
using QuanLyQuanCoffe.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCoffe.UserControls
{
    public partial class UserItem : UserControl
    {
        private Account current;
        public UserItem(Account item)
        {
            InitializeComponent();
            current = item;
            itemUserName.Text = item.UserName;
            itemType.Text = item.Type;
            txtMaNV.Text = item.IdEmployee;
            
        }
        private void ButtonUpdate_Click_1(object sender, EventArgs e)
        {
            fUpdateInfor fu = new fUpdateInfor(current);
          //  this.Hide();
            fu.Show();
         // this.Show();
        }

        private void ButtonRemove_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa người dùng?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                AccountDAO.Instance.RemoveUser(current.IdEmployee);
                UserDAO.Instance.RemoEmployee(current.IdEmployee);
                MessageBox.Show("xóa thành công");
            }
        }

        private void itemType_Click(object sender, EventArgs e)
        {

        }

        private void itemUserName_Click(object sender, EventArgs e)
        {

        }
    }
}
