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
    public partial class fPromotion : UserControl
    {
        public fPromotion()
        {
            
            InitializeComponent();
            flowLayoutPanelPromotion.Controls.Clear();
            LoadAllPromo();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadAllPromo()
        {
            List<Promotion> listPromo = PromotionDAO.Instance.GetListPromotion(); // tạo ra list promotion lưu các khuyến mại 
            foreach (Promotion item in listPromo)
            {
                PromotionItem t = new PromotionItem(item);
                flowLayoutPanelPromotion.Controls.Add(t);
                t.ButtonUpdate.Click += new EventHandler(ReloadAction);// khi click update thì sẽ thực hiện hđ reload
                t.ButtonRemove.Click += new EventHandler(ReloadAction);
            }
        }
        private void fPromotion_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelPromotion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReloadAction(object sender, EventArgs e)
        {
            flowLayoutPanelPromotion.Controls.Clear();
            LoadAllPromo();
        }

        private void ButtonAddPromo_Click(object sender, EventArgs e)
        {
            fAddPromo fAP = new fAddPromo(); // mở form addpromo
            fAP.ButtonSave.Click += new EventHandler(ReloadAction);// hành động click vào btn save thì sẽ relead lại form
            fAP.ShowDialog();
        }
    }
}
