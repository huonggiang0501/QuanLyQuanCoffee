using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffe.Models
{
    internal class User
    {
        private string idEmp;
        private string name;
        private string gender;
        private string add;
        private string phone;
        private string email;
        private int salary;
        private DateTime start;

        public User(string idEmp, string name, string gender, string add, string phone, string email, int salary, DateTime start)
        {
            this.idEmp = idEmp;
            this.name = name;
            this.gender = gender;
            this.add = add;

            this.phone = phone;
            this.email = email;
            this.salary = salary;
            this.start = start;


        }
        public User(DataRow row)
        {
            this.IdEmp = row["IdEmployee"].ToString();
            this.Name = row["Name"].ToString();
            this.Gender = row["Gender"].ToString();
            this.Add = row["Address"].ToString();
            this.Phone = row["Phone"].ToString();
            this.Email = row["Email"].ToString();
            this.Salary = Int32.Parse(row["Salary"].ToString());
            this.Start = (DateTime)row["StartDay"];

        }
        public string IdEmp { get => idEmp; set => idEmp = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Add { get => add; set => add = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public int Salary { get => salary; set => salary = value; }
        public DateTime Start { get => start; set => start = value; }
    }
}
