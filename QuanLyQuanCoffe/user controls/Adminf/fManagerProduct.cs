using QuanLyQuanCoffe.Controls;
using QuanLyQuanCoffe.Models;
using QuanLyQuanCoffe.user_controls.Orderf;
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
    public partial class fManagerProduct : UserControl
    {
        public fManagerProduct()
        {
            InitializeComponent();
            flowLayoutPanelFoodList.Controls.Clear();
            loadAllFood();
        }
        private void UpdateAction(object sender, EventArgs e)
        {
            flowLayoutPanelFoodList.Controls.Clear();
            loadAllFood();
        }
        private void ReloadAction(object sender, EventArgs e)
        {
            flowLayoutPanelFoodList.Controls.Clear();
            loadAllFood();
        }

        List<Food> SearchFoodByName(string name)
        {
            List<Food> ListFood =FoodDAO.Instance.SearchFoodByName(name);
            return ListFood;
        }

      

        #region HandleFoodLoad
        //private void btnCfVn_Click(object sender, EventArgs e)
        //{
        //    flowLayoutPanelFoodList.Controls.Clear();
        //    List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btnCfVn.Text));
        //    foreach (Food item in listFood)
        //    {
        //        ProductEdit t = new ProductEdit(item);
        //        t.btnUpdate.Click += new EventHandler(UpdateAction);
        //        t.btnRemove.Click += new EventHandler(UpdateAction);
        //        flowLayoutPanelFoodList.Controls.Add(t);

        //    }
        //}
        //private void btnCfM_Click(object sender, EventArgs e)
        //{
        //    flowLayoutPanelFoodList.Controls.Clear();
        //    List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btnCfM.Text));
        //    foreach (Food item in listFood)
        //    {
        //        ProductEdit t = new ProductEdit(item);
        //        t.btnUpdate.Click += new EventHandler(UpdateAction);
        //        t.btnRemove.Click += new EventHandler(UpdateAction);
        //        flowLayoutPanelFoodList.Controls.Add(t);

        //    }
        //}

        //private void btnTs_Click(object sender, EventArgs e)
        //{
        //    flowLayoutPanelFoodList.Controls.Clear();
        //    List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btnTs.Text));
        //    foreach (Food item in listFood)
        //    {
        //        ProductEdit t = new ProductEdit(item);
        //        t.btnUpdate.Click += new EventHandler(UpdateAction);
        //        t.btnRemove.Click += new EventHandler(UpdateAction);
        //        flowLayoutPanelFoodList.Controls.Add(t);
        //    }
        //}

        //private void btnHt_Click(object sender, EventArgs e)
        //{
        //    flowLayoutPanelFoodList.Controls.Clear();
        //    List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btnHt.Text));
        //    foreach (Food item in listFood)
        //    {
        //        ProductEdit t = new ProductEdit(item);
        //        t.btnUpdate.Click += new EventHandler(UpdateAction);
        //        t.btnRemove.Click += new EventHandler(UpdateAction);
        //        flowLayoutPanelFoodList.Controls.Add(t);
        //    }
        //}
        //private void btnCake_Click(object sender, EventArgs e)
        //{
        //    flowLayoutPanelFoodList.Controls.Clear();
        //    List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btnCake.Text));
        //    foreach (Food item in listFood)
        //    {
        //        ProductEdit t = new ProductEdit(item);
        //        t.btnUpdate.Click += new EventHandler(UpdateAction);
        //        t.btnRemove.Click += new EventHandler(UpdateAction);
        //        flowLayoutPanelFoodList.Controls.Add(t);

        //    }
        //}
        void loadAllFood()
        {
            List<Food> AllFood = FoodDAO.Instance.GetListFood();
            foreach (Food item in AllFood)
            {
                ProductEdit t = new ProductEdit(item);
                t.btnUpdate.Click += new EventHandler(UpdateAction);
                t.btnRemove.Click += new EventHandler(UpdateAction);
                flowLayoutPanelFoodList.Controls.Add(t);

            }
        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {

            flowLayoutPanelFoodList.Controls.Clear();
            loadAllFood();
        }
        #endregion

        private void btnCfVn_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanelFoodList.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btnCfVn.Text));
            foreach (Food item in listFood)
            {
                ProductEdit t = new ProductEdit(item);
                t.btnUpdate.Click += new EventHandler(UpdateAction);
                t.btnRemove.Click += new EventHandler(UpdateAction);
                flowLayoutPanelFoodList.Controls.Add(t);

            }
        }

        private void ButtonAddProduct_Click_1(object sender, EventArgs e)
        {

            fAddProduct f = new fAddProduct();
            f.ButtonSave.Click += new EventHandler(ReloadAction);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnCfM_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanelFoodList.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btnCfM.Text));
            foreach (Food item in listFood)
            {
                ProductEdit t = new ProductEdit(item);
                t.btnUpdate.Click += new EventHandler(UpdateAction);
                t.btnRemove.Click += new EventHandler(UpdateAction);
                flowLayoutPanelFoodList.Controls.Add(t);

            }
        }

        private void btnTs_Click_1(object sender, EventArgs e)
        {

            flowLayoutPanelFoodList.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btnTs.Text));
            foreach (Food item in listFood)
            {
                ProductEdit t = new ProductEdit(item);
                t.btnUpdate.Click += new EventHandler(UpdateAction);
                t.btnRemove.Click += new EventHandler(UpdateAction);
                flowLayoutPanelFoodList.Controls.Add(t);
            }
        }

        private void btnHt_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanelFoodList.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btnHt.Text));
            foreach (Food item in listFood)
            {
                ProductEdit t = new ProductEdit(item);
                t.btnUpdate.Click += new EventHandler(UpdateAction);
                t.btnRemove.Click += new EventHandler(UpdateAction);
                flowLayoutPanelFoodList.Controls.Add(t);
            }
        }

        private void btnCake_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanelFoodList.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btnCake.Text));
            foreach (Food item in listFood)
            {
                ProductEdit t = new ProductEdit(item);
                t.btnUpdate.Click += new EventHandler(UpdateAction);
                t.btnRemove.Click += new EventHandler(UpdateAction);
                flowLayoutPanelFoodList.Controls.Add(t);

            }
        }

        private void fManagerProduct_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelFoodList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void butTim_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFoodList.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(TextSearch.Text);
            foreach (Food item in listFood)
            {
                ProductEdit t = new ProductEdit(item);
                t.btnUpdate.Click += new EventHandler(UpdateAction);
                t.btnRemove.Click += new EventHandler(UpdateAction);
                flowLayoutPanelFoodList.Controls.Add(t);

            }


        }
    }
}
