
using QuanLyQuanCoffe.Models;
using QuanLyQuanCoffe.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using QuanLyQuanCoffe.user_controls.Orderf;
using QuanLyQuanCoffe.View.Employee_Side;

namespace QuanLyQuanCoffe
{
    public partial class fOrders : Form
    {
        private Account CurrentSession;
        private List<Promotion> listPromo;

        public fOrders()
        {
        }

        public fOrders(Models.Account session)
        {
            InitializeComponent();
            CurrentSession = session;
            string currentSessionUserDisplay = AccountDAO.Instance.GetNameFromID(CurrentSession.IdEmployee);
            txtSessionUser.Text = currentSessionUserDisplay;
            flowLayoutPanelFoodMenu.Controls.Clear();
            Thread.CurrentThread.CurrentCulture = (new CultureInfo("vi-VN"));// đổi fomat languge của luồng này thành VN

            listPromo = PromotionDAO.Instance.GetListPromotionAvailable();
            listPromo.Insert(0, new Promotion("Không", new DateTime(1990, 01, 01), new DateTime(1990, 01, 02), "Không áp dụng giảm giá", 0));
            cbxPromo.DataSource = listPromo;// datasource của cbxPromo lấy từ listPromo
            cbxPromo.DisplayMember = "idPromo";// hiển thị cột idPromo
            flowLayoutPanelFoodMenu.Controls.Clear();
            loadAllFood();
            
        }
        void loadAllFood()
        {
            List<Food> AllFood = FoodDAO.Instance.GetListFood();
            foreach (Food item in AllFood)
            {
                ItemOrder t = new ItemOrder(item);
                flowLayoutPanelFoodMenu.Controls.Add(t);
                t.btnAdd.Click += new EventHandler(order_Click);// sự kiện khi click vào btnadd thì nhảy đến order_click
                t.btnAdd.Tag = item;// lưu item

            }
        }
        void order_Click(object sender, EventArgs e)//sender mang kiểu dữ liệu object: kiểu dl tổng quát
        {
            ItemStandbyOrder t = new ItemStandbyOrder((sender as Button).Tag as Food);// tạo ra 1 itemorder
            int id = ((sender as Button).Tag as Food).ID; // lấy ra id của món 
            
            //string names = ((sender as Button).Tag as Food).Name;// lấy ra name của món ăn để  xét sp trùng , trong list order
            t.Name = id.ToString();// lấy ra id của món ăn dạng chuỗi để xét sp trùng, trong list order

            t.btnDown.Click += new EventHandler(calcTotalPay);
            t.btnUp.Click += new EventHandler(calcTotalPay);

            if (!flowLayoutPanelOrderList.Controls.ContainsKey(t.Name))//nếu trong list ko chứa item nào có tên là name hiện tại thì add
            {
                flowLayoutPanelOrderList.Controls.Add(t);
                calcTotalPay(sender, e);
            }



        }
        private void calcTotalPay(object sender, EventArgs e)
        {
            float pay = 0;

            Control.ControlCollection controlsarr = flowLayoutPanelOrderList.Controls;// tạo 1 bảng đk là controlsarr chứa các điều khiển ( các item) trong order list)
            foreach (Control t in controlsarr)
            {
                pay += Int32.Parse((t as ItemStandbyOrder).txtAmount.Text) * Int32.Parse((t as ItemStandbyOrder).itemPrice.Text);

            }
            this.LabelTotal.Text = pay.ToString("c", new CultureInfo("vi-VN"));
        }
        private void ButtonCalculateChange_Click(object sender, EventArgs e)
        {
            string temp = LabelTotal.Text.Replace(",00 ₫", string.Empty);// tổng tiền 
            temp = temp.Replace(".", string.Empty);
            string discount = PromoAmount.Text.Replace("-", string.Empty);// khuyến mại 
            //       dư      = khách trả             -  tổng tiền                  +     khuyến mại
            decimal changeMon = CustomerPayment.Value - (decimal)Int32.Parse(temp) + (decimal)Int32.Parse(discount);// còn dư

            

            if ((decimal)Int32.Parse(temp) < (decimal)Int32.Parse(discount))
            {
                LabelChange.Text = CustomerPayment.Value.ToString("c", new CultureInfo("vi-VN"));
                return;
            }
            if (changeMon < 0)
            {
                MessageBox.Show("Tiền trả nhỏ hơn lượng cần thanh toán!");
                LabelChange.Text = 0.ToString("c", new CultureInfo("vi-VN"));
            }
            else
            {
                LabelChange.Text = changeMon.ToString("c", new CultureInfo("vi-VN"));// c là currency , đơn vị tiền tệ
            }

        }
        private void ButtonProccess_Click(object sender, EventArgs e)
        {


        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fChangePassword f = new fChangePassword(CurrentSession);
            f.ShowDialog();

        }
        #region handleFoodLoad
        private void btnCafeMay_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFoodMenu.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btnCafeMay.Text));
            foreach (Food item in listFood)
            {
                ItemOrder t = new ItemOrder(item);
                flowLayoutPanelFoodMenu.Controls.Add(t);
                t.btnAdd.Click += new EventHandler(order_Click);
                t.btnAdd.Tag = item;
            }
        }

        private void btnhongtra_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFoodMenu.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btnhongtra.Text));
            foreach (Food item in listFood)
            {
                ItemOrder t = new ItemOrder(item);
                flowLayoutPanelFoodMenu.Controls.Add(t);
                t.btnAdd.Click += new EventHandler(order_Click);
                t.btnAdd.Tag = item;
            }
        }

        private void btntrasua_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFoodMenu.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btntrasua.Text));
            foreach (Food item in listFood)
            {
                ItemOrder t = new ItemOrder(item);
                flowLayoutPanelFoodMenu.Controls.Add(t);
                t.btnAdd.Click += new EventHandler(order_Click);
                t.btnAdd.Tag = item;
            }
        }

        private void btncake_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFoodMenu.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btncake.Text));
            foreach (Food item in listFood)
            {
                ItemOrder t = new ItemOrder(item);
                flowLayoutPanelFoodMenu.Controls.Add(t);
                t.btnAdd.Click += new EventHandler(order_Click);
                t.btnAdd.Tag = item;
            }
        }

        private void btncafevietnam_Click(object sender, EventArgs e)
        {

        }
        #endregion
        // button Xoa
        private void button1_Click(object sender, EventArgs e)
        {
            Control.ControlCollection controlsarr = flowLayoutPanelOrderList.Controls;

            foreach (Control t in controlsarr)
            {
                if ((t as ItemStandbyOrder).orderSelect.Checked)
                {

                    flowLayoutPanelOrderList.Controls.Remove(t);


                }

            }


            calcTotalPay(sender, e);

        }
        
        private void ButtonNewOrder_Click(object sender, EventArgs e)
        {
            flowLayoutPanelOrderList.Controls.Clear();
            calcTotalPay(sender, e);
            CustomerPayment.Value = 0;
            LabelChange.Text = 0.ToString("c", new CultureInfo("vi-VN"));
            cbxPromo.SelectedIndex = 0;
            flowLayoutPanelFoodMenu.Controls.Clear();
            loadAllFood();
        }

        private void btncafevn_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFoodMenu.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btncafevn.Text));
            foreach (Food item in listFood)
            {
                ItemOrder t = new ItemOrder(item);
                flowLayoutPanelFoodMenu.Controls.Add(t);
                t.btnAdd.Click += new EventHandler(order_Click);
                t.btnAdd.Tag = item;
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            flowLayoutPanelOrderList.Controls.Clear();
            loadAllFood();

        }

        private void PromoAmount_Click(object sender, EventArgs e)
        {

           
        }

        private void CustomerPayment_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxPromo_SelectedIndexChanged(object sender, EventArgs e)// khi user chọn lại mã KM
        {
            PromoAmount.Text = "-" + listPromo[cbxPromo.SelectedIndex].PricePromo.ToString();
            PromoDes.Text = listPromo[cbxPromo.SelectedIndex].Des.ToString();

            string temp = LabelTotal.Text.Replace(",00 ₫", string.Empty);// tổng tiền
            temp = temp.Replace(".", string.Empty);
            string discount = PromoAmount.Text.Replace("-", string.Empty);// khuyến mại
                                                                          //      dư        =   khách trả          - tổng tiền                   + khuyến mại
            decimal changeMon = CustomerPayment.Value - (decimal)Int32.Parse(temp) + (decimal)Int32.Parse(discount);

            float tt = 0;
            tt = Int32.Parse((CustomerPayment.Value - changeMon).ToString());
            this.labeltt.Text = tt.ToString("c", new CultureInfo("vi-VN"));
        }

        private void ButtonProccess_Click_1(object sender, EventArgs e)
        {
            ButtonCalculateChange_Click(sender, e);
            Control.ControlCollection controlsarr = flowLayoutPanelOrderList.Controls;
            if (controlsarr.Count == 0)
            {
                MessageBox.Show("Order trống!", "Thông báo", MessageBoxButtons.OKCancel);

            }
            else
            {
                if (MessageBox.Show("Bạn muốn thanh toán và xuất hoá đơn?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    string temp = LabelTotal.Text.Replace(",00 ₫", string.Empty);// tổng tiền
                    temp = temp.Replace(".", string.Empty);
                    string discount = PromoAmount.Text.Replace("-", string.Empty);// khuyến mại
                    //      dư        =   khách trả          - tổng tiền                   + khuyến mại
                    decimal changeMon = CustomerPayment.Value - (decimal)Int32.Parse(temp) + (decimal)Int32.Parse(discount);
                    if (changeMon < 0)
                    {
                        MessageBox.Show("Tiền trả nhỏ hơn lượng cần thanh toán!");
                        LabelChange.Text = 0.ToString("c", new CultureInfo("vi-VN"));
                    }
                    else
                    {
                        List<Order> listConfirmed = new List<Order>(); // danh sách order

                        int price;// giá sau Khuyến mại = tổng tiền  - KM
                        if ((CustomerPayment.Value - changeMon) < 0)
                        {
                            price = 0;
                        }
                        else
                        {
                            price = Int32.Parse((CustomerPayment.Value - changeMon).ToString());
                        }


                        BillDAO.Instance.InsertBill(CurrentSession.IdEmployee, listPromo[cbxPromo.SelectedIndex].IdPromo.ToString(), price);

                        foreach (Control t in controlsarr)
                        {
                            ItemStandbyOrder StandbyOrder = (t as ItemStandbyOrder);

                            BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), StandbyOrder.item.ID, Int32.Parse(StandbyOrder.txtAmount.Text));

                            listConfirmed.Add(new Order(StandbyOrder.item.Name, StandbyOrder.item.Price, Int32.Parse(StandbyOrder.txtAmount.Text)));

                        }


                         fOrderProcess fPO = new fOrderProcess(listConfirmed, CurrentSession.IdEmployee, CustomerPayment.Value.ToString("c", new CultureInfo("vi-VN")),
                             LabelChange.Text.ToString(), BillDAO.Instance.GetTimebyIDBill(BillDAO.Instance.GetMaxIDBill()), PromoAmount.Text, listPromo[cbxPromo.SelectedIndex].IdPromo.ToString());
                         fPO.ShowDialog();

                    }
                }
            }



        }

        private void butTim_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFoodMenu.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(TextSearch.Text);
            foreach (Food item in listFood)
            {
                ItemOrder t = new ItemOrder(item);
                //flowLayoutPanelFoodMenu.Controls.Add(t);
                t.btnAdd.Click += new EventHandler(order_Click);
                t.btnAdd.Tag = item;
                flowLayoutPanelFoodMenu.Controls.Add(t);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void flowLayoutPanelFoodMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



