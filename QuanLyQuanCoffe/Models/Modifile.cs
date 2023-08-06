using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyQuanCoffe.Models;
using QuanLyQuanCoffe.Controls;
namespace QuanLyQuanCoffe.Models
{
    class Modifile
    {

        //public List<Account> Accounts(string querry)
        //{
        //    List<Account> accounts = new List<Account>();
        //    using(DataProvide SqlConnection )
        //}
        public Modifile()
        {
        }
        SqlCommand SqlCommand;
        SqlDataReader SqlDataReader;// DUNG DE DOC DATA TRONG BANG 
        public List<Account> Accounts(string query)
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection conn = DataProvide.GetSqlConnection())
            {
                conn.Open();
                SqlCommand = new SqlCommand(query, conn);
                SqlDataReader = SqlCommand.ExecuteReader();
                while(SqlDataReader.Read())
                {
                    accounts.Add(new Account(SqlDataReader.GetString(0), SqlDataReader.GetString(1)));
                }    
                conn.Close();
            } 
                
                return accounts;
        }


    }
}
