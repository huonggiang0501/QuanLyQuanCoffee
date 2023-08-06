using QuanLyQuanCoffe.Controls;
using QuanLyQuanCoffe.Models;
using QuanLyQuanCoffe.View.Admin_Side;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCoffe.user_controls.Orderf
{
    public partial class ProductEdit : UserControl
    {
        private Food current;
        public ProductEdit(Models.Food item)
        {
            InitializeComponent();
            string filepath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", string.Empty) + "Asset\\Resources\\FoodIMG\\";
            itemImage.ImageLocation = filepath + item.Image;
            itemName.Text = item.Name;
            itemPrice.Text = item.Price.ToString();
            current = item;
        }

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    fUpdateProduct fUP = new fUpdateProduct(current);
        //    fUP.ShowDialog();

        //}

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                FoodDAO.Instance.RemoveFood(current.ID.ToString());

                string filepath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", string.Empty) + "Asset\\Resources\\FoodIMG\\";

                if (File.Exists(filepath + current.Image))
                if (File.Exists(filepath + current.Image))
                {
                    File.Delete(filepath + current.Image);
                }

                MessageBox.Show("Xóa thành công");
            }
        }

        private void itemName_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                FoodDAO.Instance.RemoveFood(current.ID.ToString());

                string filepath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", string.Empty) + "Asset\\Resources\\FoodIMG\\";

                if (File.Exists(filepath + current.Image))
                    if (File.Exists(filepath + current.Image))
                    {
                        File.Delete(filepath + current.Image);
                    }

                MessageBox.Show("Xóa thành công");
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

            fUpdateProduct fUP = new fUpdateProduct(current);
            fUP.ShowDialog();
        }
    }
}
