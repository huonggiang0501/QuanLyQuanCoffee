using QuanLyQuanCoffe.Controls;
using QuanLyQuanCoffe.Models;
using QuanLyQuanCoffe.View;
using QuanLyQuanCoffe.UserControls;
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
    public partial class fUser : UserControl
    {
        //BindingSource accountlist= new BindingSource();
        public fUser()
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Clear();
            loadAllUser();
            // Load();
        }
        private void ReloadAction(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            loadAllUser();
        }

        private void guna2Button3_Click(object sender, EventArgs e)//guna2Button3
        {
            fNewUser fa = new fNewUser();
            fa.ButtonSave.Click += new EventHandler(ReloadAction);
            fa.ShowDialog();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           fNewUser fa=new fNewUser();
            this.Hide();
            fa.ShowDialog();
            this.Show();
        }
        void loadAllUser()
        {
            List<Account> AllUser = AccountDAO.Instance.GetListAccount();
            foreach (Account item in AllUser)
            {
                UserItem t = new UserItem(item);
                t.ButtonRemove.Click += new EventHandler(ReloadAction);
                flowLayoutPanel1.Controls.Add(t);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
