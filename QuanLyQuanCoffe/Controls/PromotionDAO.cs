using QuanLyQuanCoffe.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffe.Controls
{
    public class PromotionDAO
    {
        private static PromotionDAO instance;

        public static PromotionDAO Instance 
        {
            get { if (instance == null) instance = new PromotionDAO(); //get và set cho đối tượng instance
                return PromotionDAO.instance; }
            private set { PromotionDAO.instance = value; }
        }
        public List<Promotion> GetListPromotion() // lấy ra dsach các mã khuyến mãi
        {
            List<Promotion> list = new List<Promotion>(); // tạo ra 1 dsach mới 

            string query = "select * from Promotion"; // tạo query để lấy tất cả khuyến mãi 

            DataTable data = DataProvide.Instace.ExcuteQuerry(query); // chạy query ở trên thông qua đối tượng instance của lớp dataprovide 

            foreach (DataRow item in data.Rows)
            {
                if (!item["idPromotion"].Equals("Không"))
                {
                    Promotion promo = new Promotion(item);
                    list.Add(promo);
                }

            } // với mỗi hàng dữ liệu thì add vào list

            return list;
        }
        public List<Promotion> GetListPromotionAvailable()
        {
            List<Promotion> list = new List<Promotion>();

            string query = "select * from Promotion";

            DataTable data = DataProvide.Instace.ExcuteQuerry(query);

            DateTime today = DateTime.Today;
            foreach (DataRow item in data.Rows)
            {
                Promotion promo = new Promotion(item);
                if ((promo.StartDate <= today) && (today <= promo.EndDate))
                {
                    list.Add(promo);
                }

            }

            return list;
        }

        public void UpdatePromo(string newId, string start, string end, decimal price, string des, string Id)
        {
            string querry = "exec USP_UpdatePromo '" + newId + "' , '" + start + "' , '" + end + "' , " + price + " , N'" + des + "' , '" + Id + "'";
            DataProvide.Instace.ExcuteNonQuerry(querry);
        }

        public void InsertPromo(string newId, string start, string end, decimal price, string des)
        {
            string querry = "exec USP_InsertPromo '" + newId + "' , '" + start + "' , '" + end + "' , " + price + " , N'" + des + "'";
            DataProvide.Instace.ExcuteNonQuerry(querry);
        }

        public void DeletePromo(string id)
        {
            string querry = "DELETE FROM Promotion WHERE idPromotion =  '" + id + "'";
            DataProvide.Instace.ExcuteNonQuerry(querry);
        }
    }
}
