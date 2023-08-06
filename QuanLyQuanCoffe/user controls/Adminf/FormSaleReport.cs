using System;
using QuanLyQuanCoffe.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCoffe.Models;

namespace QuanLyQuanCoffe.user_controls.Adminf
{
    public partial class FormSaleReport : UserControl
    {
        private List<Promotion> listPromo;
        public FormSaleReport()
        {
            InitializeComponent();
            listPromo = PromotionDAO.Instance.GetListPromotion();
            listPromo.Insert(0, new Promotion("Không", new DateTime(1990, 01, 01), new DateTime(1990, 01, 02), "Không áp dụng giảm giá", 0));
            cbxPromo.DataSource = listPromo;// datasource của cbxPromo lấy từ listPromo
            cbxPromo.DisplayMember = "idPromo";// hiển thị cột idPromo

            label15.Hide();
            label16.Hide();
            PromoAmount.Hide();
            PromoDes.Hide();
            cbxPromo.Hide();

        }

        // thống kê theo số bill
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            label4.Show();
            label5.Show();

            label6.Show();

            label7.Show();
            label8.Show();
            label9.Show();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();

            label15.Hide();
            label16.Hide();
            PromoAmount.Hide();
            PromoDes.Hide();
            cbxPromo.Hide();

            // datagidview : hiển thị bảng dữ liệu từ kết nối SQL có thể tuỳ chỉnh theo SQL
            dataGridViewStat.DataSource = BillDAO.Instance.GetBillListByDateRange(DateTimeStart.Value.ToString("yyyy-MM-dd"), DateTimeEnd.Value.ToString("yyyy-MM-dd"));
            for (int i = 0; i < dataGridViewStat.Rows.Count; i++)
            {
                dataGridViewStat.Rows[i].HeaderCell.Value = (i + 1).ToString(); // thêm từng hàng dữ liệu dạng chuỗi vào dataGidview
            }
            dataGridViewSumPrice.Show();
            dataGridViewSumPrice.DataSource = BillDAO.Instance.GetSumPrice(DateTimeStart.Value.ToString("yyyy-MM-dd"), DateTimeEnd.Value.ToString("yyyy-MM-dd"));

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewStat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Thống kê theo Khuyến mại
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            label4.Show();
            label5.Show();

            label6.Show();

            label7.Show();
            label8.Show();
            label9.Show();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();

            label15.Show();
            label16.Show();
            PromoAmount.Show();
            PromoDes.Show();
            cbxPromo.Show();

            // datagidview : hiển thị bảng dữ liệu từ kết nối SQL có thể tuỳ chỉnh theo SQL
            // dataGridViewStat.DataSource : lấy ra bill theo khuyến mại qua đối tượng instance của lớp BillDAO 

            dataGridViewStat.DataSource = BillDAO.Instance.GetBillListByDateRangeKM(DateTimeStart.Value.ToString("yyyy-MM-dd"), DateTimeEnd.Value.ToString("yyyy-MM-dd"), listPromo[cbxPromo.SelectedIndex].IdPromo.ToString());
            for (int i = 0; i < dataGridViewStat.Rows.Count; i++)
            {
                dataGridViewStat.Rows[i].HeaderCell.Value = (i + 1).ToString();// thêm từng hàng dữ liệu dạng chuỗi vào dataGidview
            }
            dataGridViewSumPrice.Show();
            dataGridViewSumPrice.DataSource = BillDAO.Instance.GetSumPriceKM(DateTimeStart.Value.ToString("yyyy-MM-dd"), DateTimeEnd.Value.ToString("yyyy-MM-dd"), listPromo[cbxPromo.SelectedIndex].IdPromo.ToString());
            // dataGridViewSumPrice.DataSource : lấy ra tổng tiền theo khuyến mại qua đối tượng instance của lớp BillDAO
        }

        // Thống kê theo Sản phẩm
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();

            label10.Show();
            label11.Show();
            label12.Show();
            label13.Show();
            label14.Show();

            label15.Hide();
            label16.Hide();
            PromoAmount.Hide();
            PromoDes.Hide();
            cbxPromo.Hide();

            dataGridViewStat.DataSource = BillDAO.Instance.GetBillListByDateRangeSP(DateTimeStart.Value.ToString("yyyy-MM-dd"), DateTimeEnd.Value.ToString("yyyy-MM-dd"));
            for (int i = 0; i < dataGridViewStat.Rows.Count; i++)
            {
                dataGridViewStat.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            
            dataGridViewSumPrice.Hide();// dấu tổng tiền 


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewSumPrice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbxPromo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PromoAmount.Text = listPromo[cbxPromo.SelectedIndex].PricePromo.ToString()+ " VNĐ ";
            PromoDes.Text = listPromo[cbxPromo.SelectedIndex].Des.ToString();
        }

        private void FormSaleReport_Load(object sender, EventArgs e)
        {

        }
    }
}
