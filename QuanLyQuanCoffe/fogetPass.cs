using QuanLyQuanCoffe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCoffe
{
    public partial class fogetPass : Form
    {
        public fogetPass()
        {
            InitializeComponent();
        }
        Modifile Modifile = new Modifile();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string id = guna2TextBox1.Text;
            if (id.Trim() == "") { MessageBox.Show("Nhập userName của bạn : "); }
            else
            {
                string query = "Select * from Account where username = '" + id + "'";
                if (Modifile.Accounts(query).Count != 0)
                {
                    label3.ForeColor = Color.Blue;
                    label3.Text = "Mật Khẩu của bạn là: " + Modifile.Accounts(query)[0].Password;
                }
                else
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "Không có tên đăng nhập này! ";
                }

            }
        }
    }
}
