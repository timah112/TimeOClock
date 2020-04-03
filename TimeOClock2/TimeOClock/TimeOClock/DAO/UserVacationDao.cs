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
    class UserVacationDao
    {

        DatabaseConnectionSingleton dbConnection = DatabaseConnectionSingleton.getdbConnectionInstance();
        DomainModel domainModelInstance = DomainModel.getDomainModelInstance();
        UserVacationBean vacationBean = UserVacationBean.getVacationBeanInstance();
        UserInfoBean userBean = UserInfoBean.getUserInfoBeanInstance();
        AdminEmployeeBean adminEmployeeBeanInstance = AdminEmployeeBean.getAdminEmployeeBeanInstance();
        IndexFormModel indexFormModel = IndexFormModel.getInstance();
        SqlCommand sqlCommand;

        /** ON PAGE LOAD QUERY METHOD:
         *First select and check if there is enough balance.
         *Also check if there is a pending status already. If so, return false and disable request PTO button.
        **/

        /* 
         * SQL Method  to insert user Vacation information (Request from, to, status, balance   
         */
        public void insertVacationRequestQuery(long id, string fromDate, string toDate, int balance, string vacationStatus, int vacationAccrued)
        {
            if (fromDate.Length != 0 && toDate.Length !=0)
            {
                String persistVacationQuery = "INSERT INTO User_Vacation (vacation_balance, vacation_request_from, vacation_request_to, User_ID, vacation_status, vacation_accrued) " +
                    "VALUES (@balance, @fromDate, @toDate, @id, @vacationStatus, @vacationAccrued)";
                using (sqlCommand = new SqlCommand(persistVacationQuery, DatabaseConnectionSingleton.conn))
                {
                    try
                    {
                       // string searchTerm = string.Format("{0}%", id);
                        sqlCommand.Parameters.Add("@id", SqlDbType.BigInt).Value = id;
                        sqlCommand.Parameters.Add("@fromDate", SqlDbType.Date).Value = UserInfoDao.convertStrDateToSqlDate(fromDate);
                        sqlCommand.Parameters.Add("@toDate", SqlDbType.Date).Value = UserInfoDao.convertStrDateToSqlDate(toDate);
                        sqlCommand.Parameters.Add("@balance", SqlDbType.Int).Value = balance;
                        sqlCommand.Parameters.Add("@vacationStatus", SqlDbType.VarChar).Value = vacationStatus;
                        sqlCommand.Parameters.Add("@vacationAccrued", SqlDbType.Int).Value = vacationAccrued;

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

        public void getVacationAccruedQuery(long id)
        {
            String vacationAccruedQuery = "SELECT uv.vacation_accrued FROM User_Vacation uv, user_info ui " +
               "WHERE uv.User_Id = @id AND uv.User_Id = ui.id ORDER BY UV.ID DESC";

            using (sqlCommand = new SqlCommand(vacationAccruedQuery, DatabaseConnectionSingleton.conn))
            {
                try
                {
                    sqlCommand.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                    DatabaseConnectionSingleton.conn.Open();
                    sqlCommand.ExecuteNonQuery();

                    int sumOfVacationDays = 0;
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                sumOfVacationDays += reader.GetInt32(0);
                                Console.WriteLine(reader.GetInt32(0));
                                vacationBean.setVacationAccrued(sumOfVacationDays);
                                adminEmployeeBeanInstance.VacationAccruedDays = sumOfVacationDays;
                            }
                            
                        }
                    }
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

        /**
         * SQL Method that retrieves all information for Vacation Details and outputs them from the last requested time based 
         * on User ID:
        **/
        public void getLimitedVacationInfoQuery(long id)
        {
            String vacationDetailsQuery = "SELECT UV.vacation_request_from, UV.vacation_request_to, UV.vacation_status, UV.vacation_balance " +
                "FROM user_info ui, User_Vacation UV " +
                "WHERE UV.User_Id = @id ORDER BY UV.ID DESC";
            using (sqlCommand = new SqlCommand(vacationDetailsQuery, DatabaseConnectionSingleton.conn))
            {
                try
                {
                    sqlCommand.Parameters.Add("id", SqlDbType.BigInt).Value = id;
                    DatabaseConnectionSingleton.conn.Open();
                    sqlCommand.ExecuteNonQuery();
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        DateTime vacationRequestFromDate;
                        DateTime vacationRequestToDate;

                        while (reader.Read())
                        {                           
                            if (reader.GetDateTime(0) != null)
                            {
                                vacationRequestFromDate = reader.GetDateTime(0);
                                vacationBean.setVacationRequestFromDate(vacationRequestFromDate);
                                adminEmployeeBeanInstance.VacationRequestFromDate = vacationRequestFromDate;
                            }
                            if (reader.GetDateTime(1) != null)
                            {
                                vacationRequestToDate = reader.GetDateTime(1);
                                vacationBean.setVacationRequestToDate(vacationRequestToDate);
                                adminEmployeeBeanInstance.VacationRequestToDate = vacationRequestToDate;
                            }
                            String vacationStatus = reader.GetString(2);                           
                            if (vacationStatus.Length != 0)
                            {
                                vacationBean.setVacationStatus(vacationStatus);

                            }
                            if (!reader.IsDBNull(3))
                            {
                                int vacationBalance = reader.GetInt32(3);
                                vacationBean.setVacationBalance(vacationBalance);
                                adminEmployeeBeanInstance.VacationBalanceDays = vacationBalance;
                            }
                            break;
                        }
                    }
                    
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


        

        //If user wants to request another vacation time, they would have to go to details screen and cancel first and then request again (use delete and insert in SQL)

        //Once the status is approved of denied, update it in SQL. 
        //Use update method to update the balance once the status is approved or denied

    }
}
