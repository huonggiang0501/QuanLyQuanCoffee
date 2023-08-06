using QuanLyQuanCoffe.Controls;
using QuanLyQuanCoffe.Models;
using QuanLyQuanCoffe.View.Admin_Side;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyQuanCoffe.user_controls.Adminf
{
    public partial class fManageIncredient : UserControl
    {
        

        public fManageIncredient()
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Clear();
            loadAllIncre();
        }

        private void loadAllIncre()
        {
            List<Incredient> AllIncre = IncredientDAO.Instance.GetListIncredient();
            foreach (Incredient item in AllIncre)
            {
                IncreItem t = new IncreItem(item);
                flowLayoutPanel1.Controls.Add(t);
                t.ButtonRemove.Click += new EventHandler(ReloadAction);
                t.ButtonUpdate.Click += new EventHandler(ReloadAction);
                


            }    
        }
        public void ReloadAction(object sender,EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            loadAllIncre();
        }

        private void AddAcount_Click(object sender, EventArgs e)
        {
            fNewIncre fn = new fNewIncre();
            fn.ButtonSave.Click += new EventHandler(ReloadAction);
            fn.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Incredient> AllIncre = IncredientDAO.Instance.GetListIncredientQuantity();
            foreach (Incredient item in AllIncre)
            {
                IncreItem t = new IncreItem(item);
                flowLayoutPanel1.Controls.Add(t);
                t.ButtonRemove.Click += new EventHandler(ReloadAction);
                t.ButtonUpdate.Click += new EventHandler(ReloadAction);

            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            loadAllIncre();
        }
    }
}
