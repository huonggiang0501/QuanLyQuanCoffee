using QuanLyQuanCoffe.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffe.Controls
{
    public class IncredientDAO
    {
        private static IncredientDAO instance;
        public static IncredientDAO Instance
        {
            get {if (instance == null) instance = new IncredientDAO(); return IncredientDAO.instance; }
            private set { IncredientDAO.instance = value; }

        }
        private IncredientDAO() { }

        public List<Incredient> GetListIncredient()
        {
            List<Incredient> List = new List<Incredient> ();

            string query = "Select * from Incredient";

            DataTable data = DataProvide.Instace.ExcuteQuerry(query);

            foreach (DataRow item in data.Rows)
            {
                Incredient incredient = new Incredient(item);
                List.Add(incredient);
            }

            return List;
        }
        public List<Incredient> GetListIncredientQuantity()
        {
            List<Incredient> List = new List<Incredient>();

            string query = "Select * from Incredient where Quantity < 8 ";

            DataTable data = DataProvide.Instace.ExcuteQuerry(query);

            foreach (DataRow item in data.Rows)
            {
                Incredient incredient = new Incredient(item);
                List.Add(incredient);
            }

            return List;
        }

        public void InsertIncre(string idCre, string NameCre, float Quantity, float Price)
        {
            string query = " exec USP_InsertIncre N'" + idCre + "','" + NameCre + "'," + Quantity + "," + Price ;
            DataProvide.Instace.ExcuteNonQuerry(query);
        }
        public void UpdateIncre(string id, string NameCre, float Quantity, float Price)
        {
            string query = " exec USP_UpdateIncre N'" + id + "','" + NameCre + "'," + Quantity + "," + Price ;
            DataProvide.Instace.ExcuteNonQuerry(query);
        }
        public void RemoveIncre(string idCre)
        {
            string query = "DELETE FROM [dbo].[Incredient] where idCre = '" + idCre + "'";
            DataProvide.Instace.ExcuteNonQuerry(query);
        }

    }
}
