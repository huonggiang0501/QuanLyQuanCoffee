using System;
using QuanLyQuanCoffe.Models;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffe.Controls
{   

    internal class UserDAO
    {
        private static UserDAO instance;
        public static UserDAO Instance
        {
            get { if (instance == null) instance = new UserDAO(); return instance; }
            private set => instance = value;
        }
        private UserDAO()
        {

        }
        public User GetUserByID(string ID)
        {
            User x = null;
            string querry = "Select * From dbo.Employee Where IdEmployee=\'" + ID + "\'";
            DataTable result = DataProvide.Instace.ExcuteQuerry(querry);
            foreach (DataRow item in result.Rows)
            {
                User t = new User(item);
                return t;
            }

            return x;
        }
        public void UpdateInfor(String idEmp, string name, String gender, String add, string phone, String email, int salary, string start)
        {
            string querry = " exec USP_UpdateInfor '" + idEmp + "' , N'" + name + "' , N'" + gender + "' , N'" + add + "' , '" + phone + "' , '" + email + "' , " + salary + " , '" + start + "'";
            DataProvide.Instace.ExcuteNonQuerry(querry);
        }

        public void AddEmployee(String id, string name, String gender, String add, string phone, String email, int salary, string start)
        {
            string querry = " exec USP_AddEmployee '" + id + "' , N'" + name + "' , N'" + gender + "' , N'" + add + "' , '" + phone + "' , '" + email + "' , " + salary + " , '" + start + "'";
            DataProvide.Instace.ExcuteNonQuerry(querry);
        }

        public void RemoEmployee(String id)
        {
            string querry = "DELETE FROM [dbo].[Employee] where idEmployee = '" + id + "'";
            DataProvide.Instace.ExcuteNonQuerry(querry);
        }
    }
}
