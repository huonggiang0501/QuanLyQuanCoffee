using QuanLyQuanCoffe.Controls;
using QuanLyQuanCoffe.Models;
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

namespace QuanLyQuanCoffe.View.Admin_Side
{
    public partial class fUpdateProduct : Form
    {
        private Food current;
        private string selectedImage;
        public fUpdateProduct(Food item)
        {
            InitializeComponent();
            current = item;
            string filepath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", string.Empty) + "Asset\\Resources\\FoodIMG\\";
            itemImage.ImageLocation = filepath + current.Image;
            txtName.Text = current.Name;
            txtPrice.Value = (decimal)current.Price;
            cbType.DataSource = CategoryDAO.Instance.GetListCategory();
            cbType.DisplayMember = "groupName";
            cbType.SelectedIndex = current.CategoryID - 1;



        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonChangeImage_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn cập nhật thông tin?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {


                if (selectedImage != null)
                {
                    string filepath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", string.Empty) + "Asset\\Resources\\FoodIMG\\";

                    if (File.Exists(filepath + current.Image))
                    {
                        File.Delete(filepath + current.Image);
                    }

                    if (!File.Exists(filepath + Path.GetFileName(selectedImage)))
                    {
                        File.Copy(selectedImage, filepath + Path.GetFileName(selectedImage));
                    }



                    FoodDAO.Instance.UpdateFood(current.ID, txtName.Text, cbType.SelectedIndex + 1, Int32.Parse(txtPrice.Value.ToString()), Path.GetFileName(selectedImage));
                }
                else
                {
                    FoodDAO.Instance.UpdateFood(current.ID, txtName.Text, cbType.SelectedIndex + 1, Int32.Parse(txtPrice.Value.ToString()), current.Image);
                }

                MessageBox.Show("Cập nhật thành công");
            }

            this.Close();
        }

        private void ButtonChangeImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                itemImage.Image = new Bitmap(open.FileName);
                // image file path  
                itemImage.ImageLocation = open.FileName;
                selectedImage = open.FileName;

            }
        }

        private void ButtonReset_Click_1(object sender, EventArgs e)
        {
            string filepath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", string.Empty) + "Asset\\Resources\\FoodIMG\\";
            itemImage.ImageLocation = filepath + current.Image;
            txtName.Text = current.Name;
            txtPrice.Value = (decimal)0;
            txtPrice.Value = (decimal)current.Price;
            cbType.DataSource = CategoryDAO.Instance.GetListCategory();
            cbType.DisplayMember = "groupName";
            cbType.SelectedIndex = current.CategoryID - 1;
        }

        private void ButtonBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
             fIncreOfFood f = new fIncreOfFood(current);
            f.ShowDialog();
        }
    }
}
