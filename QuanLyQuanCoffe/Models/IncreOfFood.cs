using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffe.Models
{
    
    public class IncreOfFood
    {
        

        public IncreOfFood(string id, int idFood, string idCre, float quantityIncre)
        {
            this.id = id;
            this.idFood = idFood;
            this.idCre = idCre;
            this.QuantityIncre = quantityIncre;

        }
        public IncreOfFood(DataRow row)
        {
            this.id = row["id"].ToString();
            this.idFood = (int)Convert.ToDouble(row["idFood"].ToString());
            this.idCre = row["idCre"].ToString();
            this.quantityIncre = (float)Convert.ToDouble(row["QuantityIncre"].ToString());
        }
        public string Id { get { return id; } set { id = value; } }
        public int IdFood { get { return idFood; } set { idFood = value; } }
        private string id;
        private int idFood;
        private float quantityIncre;
        public float QuantityIncre { get { return quantityIncre; } set { quantityIncre = value; } }
        private string idCre;
        public string IdCre { get { return idCre; } set { idCre = value; } }

        
    }
    
}
