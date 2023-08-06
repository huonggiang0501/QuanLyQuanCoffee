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

namespace QuanLyQuanCoffe.View.Employee_Side
{
    public partial class fOrderProcess : Form
    {
        public List<Order> list = new List<Order>();
        private string Emp;
        private string cash;
        private string change;
        private string time;
        private string discount;
        private string promocode;

        private string filepath;
        public fOrderProcess(List<Order> list, string Emp, string cash, string change, string time, string discount, string promocode)
        {

            InitializeComponent();
            this.list = list;
            filepath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", string.Empty) + "View\\Employee Side\\Report1.rdlc";
            this.Emp = Emp;
            this.cash = cash;
            this.change = change;
            this.time = time;
            this.discount = discount;
            if (promocode.Equals("Không"))
            {
                this.promocode = "*Không có";
            }
            else
            {
                this.promocode = promocode;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fOrderProcess_Load(object sender, EventArgs e)
        {

            this.reportViewer1.LocalReport.ReportPath = filepath;
            OrderBindingSource.DataSource = list;
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("rptCash",this.cash),
                new Microsoft.Reporting.WinForms.ReportParameter("rptChange",this.change),
                new Microsoft.Reporting.WinForms.ReportParameter("rptEmp",this.Emp),
                new Microsoft.Reporting.WinForms.ReportParameter("rptTime",this.time),
                new Microsoft.Reporting.WinForms.ReportParameter("rptDiscount",this.discount),
                new Microsoft.Reporting.WinForms.ReportParameter("rptPromoCode",this.promocode)

            };
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void OrderBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
