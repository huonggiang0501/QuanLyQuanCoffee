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

namespace QuanLyQuanCoffe.View
{
    public partial class fNewUser : Form
    {
        public fNewUser()
        {
            InitializeComponent();
           
        }
        private void dtgvAccount_Load(object sender, EventArgs e)
        {

        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(txtConfirmPassword.Text))
            {

                try
                {
                    // UserDAO.Instance.AddEmployee(txtIdEmployee.Text, "hoten", "moi", "moi", "moi", "moi", 0, DateTime.Today.ToString("yyyy-MM-dd"));
                    UserDAO.Instance.AddEmployee(txtIdEmployee.Text, txtName.Text, "0/1", "Hà Nội", "09828765", "@.gmail.com", 20000, DateTime.Today.ToString("yyyy-MM-dd"));
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) //conflict primary key exception
                    {
                        MessageBox.Show("Mã nhân viên bị trùng");
                        return;
                    }
                }


                try
                {
                    AccountDAO.Instance.AddNewUser(txtName.Text, txtPassword.Text, cbRole.SelectedItem.ToString(), txtIdEmployee.Text);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) //conflict primary key exception
                    {
                        MessageBox.Show("Tên đăng nhập bị trùng");
                        return;
                    }
                }


                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Mật khẩu không trùng");
            }
            this.Close();
        }
    

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtIdEmployee.Text = "";
            cbRole.SelectedIndex = 0;
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
