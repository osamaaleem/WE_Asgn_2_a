using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WE_Asgn_2_a.Models;

namespace WE_Asgn_2_a.DAL
{
    public class UserEntity
    {
        private int IsAdminBn { get; set; }
        public string exMsg { get; set; }
        public int AddUser(MUser mUser)
        {
            int rowsAffected = 0;
            int IsAdmin() => mUser.IsAdmin ? 1 : 0;
            //{
            //    return mUser.IsAdmin ? 1 : 0;
            //}
            IsAdminBn = IsAdmin();
            try
            {
                string dbConnection = @"data source = OSAMA-PC\SQLEXPRESS; initial catalog = WebEngineering; integrated security = True";
                SqlConnection connection = new SqlConnection(dbConnection);
                connection.Open();
                string sqlQuery = "INSERT INTO dbo.RegisterUser VALUES ('"+mUser.Name+"','"+mUser.Phone+"','"+mUser.Email+"','"+mUser.Password+"','"+mUser.Gender+"','"+mUser.Country+"','"+this.IsAdminBn+"')";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                rowsAffected = cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                exMsg = ex.Message;
                rowsAffected = 0;
            }
            return rowsAffected;
        }
    }
}