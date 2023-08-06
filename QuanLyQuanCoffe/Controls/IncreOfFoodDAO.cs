using QuanLyQuanCoffe.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffe.Controls
{
    public class IncreOfFoodDAO
    {
        private static IncreOfFoodDAO instance;
        public static IncreOfFoodDAO Instance 
        {
            get { if (instance == null) instance = new IncreOfFoodDAO(); return IncreOfFoodDAO.instance; }
            private set { IncreOfFoodDAO.instance = value; }
        }
        private IncreOfFoodDAO() { }
        
        public List<IncreOfFood> GetListIncreOfFood(int id)
        {
            List<IncreOfFood> list = new List<IncreOfFood>();
            string query = "exec USP_GetListInCreOfFood " + id;
            DataTable data = DataProvide.Instace.ExcuteQuerry(query);
            
            foreach (DataRow item in data.Rows)
            {
                IncreOfFood Incre = new IncreOfFood(item);
                list.Add(Incre);
            }    

            return list;
        }
        public void InsertIncreofFood(string id, int idFood, string idCre, float Quantity)
        {
            string query = "exec USP_InsertIncreOfFood '" + id + "' ," + idFood + " ,'" + idCre + "', " + Quantity;
            DataProvide.Instace.ExcuteNonQuerry(query);
        }
        public void UpdateQuantityIncreofFood(int idFood, string idCre, float Quantity)
        {
            string query = "exec USP_UpdateQuantityIncreOfFood "  + idFood + " ,'" + idCre + "' ," + Quantity;
            DataProvide.Instace.ExcuteNonQuerry(query);
        }
        public void RemoveIncreOfFood(int idFood, string idCre)
        {
            string query = "exec USP_RemoveIncreofFood " + idFood + " ,'" + idCre + "'";
            DataProvide.Instace.ExcuteNonQuerry(query);
        }


    }
}
