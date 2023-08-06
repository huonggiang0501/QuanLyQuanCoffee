using QuanLyQuanCoffe.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffe.Controls
{

    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }
        public void InsertBill(string idEmp, string idPromo, int totalPrice)
        {
            DataProvide.Instace.ExcuteNonQuerry("exec USP_InsertBill @idEmp , @idPromo , @totalPrice", new object[] { idEmp, idPromo, totalPrice });
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvide.Instace.ExcuteScalar("SELECT MAX(id) FROM Bill");
            }
            catch
            {
                return 1;
            }
        }
        public string GetTimebyIDBill(int id)
        {
            DataTable data = DataProvide.Instace.ExcuteQuerry("SELECT * FROM dbo.Bill WHERE id = " + id);

            foreach (DataRow item in data.Rows)
            {
                return new Bill(item).Time.ToString();
            }

            return null;



        }



        public DataTable GetBillListByDateRange(string start, string end)// lấy ra bill theo thời gian
        {
            string command = "exec USP_GetListByDateRange1 '" + start + "' , '" + end + "'";
            return DataProvide.Instace.ExcuteQuerry(command);

        }
        public DataTable GetSumPrice(string start, string end)
        {
            string command = "exec USP_SumPrice '" + start + "' , '" + end + "'";
            return DataProvide.Instace.ExcuteQuerry(command);
        }
        public DataTable GetBillListByDateRangeKM(string start, string end, string MaKM)// lấy ra bill theo khuyến mại
        {
            string command = "exec USP_GetListByDateRangeKM '" + start + "' , '" + end + "' , '"+ MaKM + "'";
            return DataProvide.Instace.ExcuteQuerry(command);

        }
        public DataTable GetSumPriceKM(string start, string end, string MaKM)
        {
            string command = "exec USP_SumPriceKM '" + start + "' , '" + end + "' , '" + MaKM + "'";
            return DataProvide.Instace.ExcuteQuerry(command);
        }

        public DataTable GetBillListByDateRangeSP(string start, string end)// lấy ra bill theo sản phẩm
        {
            string command = "exec USP_GetListByDateRangeSP '" + start + "' , '" + end + "'";
            return DataProvide.Instace.ExcuteQuerry(command);

        }

    }

}
