using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace IoTSolutionsDAL
{
    public class UserOperationsDAL
    {
        string _dbConnectionString = string.Empty;
        public UserOperationsDAL()
        {
            _dbConnectionString = ConfigurationManager.ConnectionStrings["IoTSolutionsDBConnection"].ConnectionString;
        }

        #region Insert Into Database
        public void InsertUser(UserDetail userDetails)
        {
            using (SqlConnection sqlcon = new SqlConnection(_dbConnectionString))
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlcon;
                command.CommandText = "Insert into BaggCountUser(Name,Email)Values(@name, @email)";
                SqlParameter sqlParameterName = new SqlParameter("@name", SqlDbType.NVarChar);
                sqlParameterName.Value = userDetails.UserName;
                command.Parameters.Add(sqlParameterName);
                SqlParameter sqlParameterEmail = new SqlParameter("@email", SqlDbType.NVarChar);
                sqlParameterEmail.Value = userDetails.Email;
                command.Parameters.Add(sqlParameterEmail);
                command.ExecuteNonQuery();
            } 
        }
        #endregion Insert Into Database

        #region Update Database
        public void UpdateUser(UserDetail userDetails)
        {
            using (SqlConnection sqlcon = new SqlConnection(_dbConnectionString))
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlcon;
                command.CommandText = "Update BaggCountUser set Name = @name where Email= @email";
                SqlParameter sqlParameterName = new SqlParameter("@name", SqlDbType.NVarChar);
                sqlParameterName.Value = userDetails.UserName;
                command.Parameters.Add(sqlParameterName);
                SqlParameter sqlParameterEmail = new SqlParameter("@email", SqlDbType.NVarChar);
                sqlParameterEmail.Value = userDetails.Email;
                command.Parameters.Add(sqlParameterEmail);
                command.ExecuteNonQuery();
            }
        }
        #endregion Update Database

        #region Delete DataBase
        public void DeleteUser(UserDetail userDetails)
        {
            using (SqlConnection sqlcon = new SqlConnection(_dbConnectionString))
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlcon;
                command.CommandText = "Delete from BaggCountUser where Email= @email";
                SqlParameter sqlParameterEmail = new SqlParameter("@email", SqlDbType.NVarChar);
                sqlParameterEmail.Value = userDetails.Email;
                command.Parameters.Add(sqlParameterEmail);
                command.ExecuteNonQuery();
            }
        }
        #endregion Delete Database

        #region Get From Database
        public UserDetail GetUser(string email)
        {
            UserDetail userDetail = null;
            using (SqlConnection sqlcon = new SqlConnection(_dbConnectionString))
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlcon;
                command.CommandText = "select Name, Email from BaggCountUser where Email= @email";
                SqlParameter sqlParameterEmail = new SqlParameter("@email", SqlDbType.NVarChar);
                sqlParameterEmail.Value = email;
                command.Parameters.Add(sqlParameterEmail);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count == 1)
                {
                    userDetail = new UserDetail();
                    userDetail.UserName = dataTable.Rows[0]["Name"].ToString();
                    userDetail.Email = dataTable.Rows[0]["Email"].ToString();
                }
            }
            return userDetail;
        }
        #endregion Get From Database

    }
}
