using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffe.Models
{
    public class Incredient
    {
        public Incredient(string idCre, string NameCre, float Quantity, float Price)
        {
            this.idCre = idCre;
            this.NameCre = NameCre;
            this.Quantity = Quantity;
            this.Price = Price;
        }
        public Incredient(DataRow row)
        {
            this.idCre = row["idCre"].ToString();
            this.NameCre = row["NameCre"].ToString();
            this.Quantity = (float)Convert.ToDouble(row["Quantity"].ToString());
            this.Price = (float)Convert.ToDouble(row["Price"].ToString());
        }
        private string idCre;
        public string IdCre 
        {
            get { return idCre; } 
            set { idCre = value; } 
        }
        
        private string nameCre;
        public string NameCre
        {
            get { return nameCre; }
            set { nameCre = value; }
        }
        private float quantity;
        public float Quantity 
        { 
            get { return quantity; } 
            set { quantity = value; }
        }
        private float price;
        public float Price 
        { 
            get { return price; }
            set { price = value; }
        }
        
    }
    

}
