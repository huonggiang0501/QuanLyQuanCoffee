using QuanLyQuanCoffe.Controls;
using QuanLyQuanCoffe.Models;
using QuanLyQuanCoffe.user_controls.Adminf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCoffe.View.Admin_Side
{
    public partial class fIncreOfFood : Form
    {
        private Food current;
        public fIncreOfFood(Food item)
        {
            InitializeComponent();
            current = item;
            flowLayoutPanel1.Controls.Clear();
            LoadIncreOfFood(current.ID);
        }

        private void LoadIncreOfFood(int iD)
        {
            List<IncreOfFood> list = IncreOfFoodDAO.Instance.GetListIncreOfFood(iD);
            foreach(IncreOfFood item in list)
            {
                IncreOfFoodItem t = new IncreOfFoodItem(item);
                flowLayoutPanel1.Controls.Add(t);
                t.ButtonRemove.Click += new EventHandler(ReloadAction);
                t.ButtonUpdate.Click += new EventHandler(ReloadAction);


            }
        }
        public void ReloadAction(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadIncreOfFood(current.ID);
        }


        private void fIncreOfFood_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddAcount_Click(object sender, EventArgs e)
        {
            fAddIncreOfFood f = new fAddIncreOfFood(current);
            f.ButtonSave.Click += new EventHandler(ReloadAction);
            f.ShowDialog();

        }
    }
}
