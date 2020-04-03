using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeOClock.Dbo;
using TimeOClock.model;
using System.Data.SqlClient;
using System.Data;
using TimeOClock.Bean;

namespace TimeOClock.Dao
{
    class UserCommentsDao
    {
        DatabaseConnectionSingleton dbConnection = DatabaseConnectionSingleton.getdbConnectionInstance();
        AdminEmployeeBean adminEmployeeBean =  AdminEmployeeBean.getAdminEmployeeBeanInstance();
        DomainModel domainModelInstance = DomainModel.getDomainModelInstance();
        IndexFormModel indexFormModel = IndexFormModel.getInstance();
        SqlCommand sqlCommand;

        public void insertCommentsQuery(String userId, int pin, string comment)
        {
            if(userId.Length !=0 && pin != 0 && comment.Length != 0)
            {
                String persistCommentsQuery = "INSERT INTO User_Comments (Comment, User_ID) VALUES (@comment, (SELECT id from user_info WHERE email like @userId and pin = @pin))";
                using (sqlCommand = new SqlCommand(persistCommentsQuery, DatabaseConnectionSingleton.conn))
                {
                    try
                    {
                        string searchTerm = string.Format("{0}%", userId);
                        sqlCommand.Parameters.Add("@UserId", SqlDbType.VarChar).Value = searchTerm;
                        sqlCommand.Parameters.Add("@pin", SqlDbType.Float).Value = pin;
                        sqlCommand.Parameters.Add("@comment", SqlDbType.VarChar).Value = comment;

                        DatabaseConnectionSingleton.conn.Open();
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                        Console.WriteLine("EXCEPTION WAS CALLED");
                    }
                    finally
                    {
                        DatabaseConnectionSingleton.conn.Close();
                    }
                }
                
            }           
        }

        public Boolean getCommentsQuery(long id)
        {
            String commentQuery = "SELECT Comment FROM User_Comments WHERE User_Id = @id";
            using (sqlCommand = new SqlCommand(commentQuery, DatabaseConnectionSingleton.conn))
            {

                try
                {
                    //string searchTerm = string.Format("{0}%", dob);
                    sqlCommand.Parameters.Add("@id", SqlDbType.BigInt).Value = id;
                    DatabaseConnectionSingleton.conn.Open();
                    sqlCommand.ExecuteNonQuery();
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String comment = reader.GetString(0);
                            adminEmployeeBean.Comment = comment;
                        }
                    }

                }
                catch (SqlException)
                {
                    Console.WriteLine("EXCEPTION WAS CALLED");
                    return false;
                }
                finally
                {
                    DatabaseConnectionSingleton.conn.Close();
                }
            }
            return true;
        }

    }
}
