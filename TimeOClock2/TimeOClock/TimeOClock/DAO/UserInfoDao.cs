using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using TimeOClock.Bean;
using TimeOClock.Dbo;
using System.Data.SqlClient;
using TimeOClock.model;
using System.Data;

namespace TimeOClock.Dao
{
    public class UserInfoDao 
    {
        UserInfoBean userInfoBeanInstance = UserInfoBean.getUserInfoBeanInstance();
        AdminEmployeeBean adminEmployeeBeanInstance = AdminEmployeeBean.getAdminEmployeeBeanInstance();
        DatabaseConnectionSingleton dbConnection = DatabaseConnectionSingleton.getdbConnectionInstance();
        RegisterFormModel registermModel = RegisterFormModel.getRegisterFormInstance();
        String isAdminOrEmployee = null;
        String persistAllUserInfoQuery;
        SqlCommand sqlCommand;

        public String getIsAdminOrEmployee()
        {
            if (userInfoBeanInstance.getIsEmployee())
            {
                isAdminOrEmployee = "Employee";
            }
            else
            {
                isAdminOrEmployee = "Admin";
            }
            return isAdminOrEmployee;
        }
        public void executeDb()
        {
            DatabaseConnectionSingleton.conn.Open();
            sqlCommand.ExecuteNonQuery();
        }
        public void persistUser()
        {
            persistAllUserInfoQuery = "insert into dbo.User_Info (first_name, last_name, dob, pay, cell_phone, manager_firstName, manager_lastName, email," +
                "pin, employer, is_admin_or_employee, password, points, manager_email, employment_start_date) values('" + registermModel.getFirstName() + "','" + registermModel.getLastName() + "','" + registermModel.getDob() + "','" + registermModel.getPay() + "','" + registermModel.getCellPhoneNum()
                + "','" + registermModel.getManagerFirstName() + "','" + registermModel.getManagerLastName() + "','" + registermModel.getEmail() + "','" + registermModel.getPin() + "','" + registermModel.getEmployer() + "','" + getIsAdminOrEmployee()
                + "','"+ registermModel.getPassword() + "','" + registermModel.getPoints() + "','" + registermModel.getManagerEmail() + "','" + registermModel.getEmploymentStartDate() + "'); ";
            using (sqlCommand = new SqlCommand(persistAllUserInfoQuery, DatabaseConnectionSingleton.conn))
            {
                try
                {
                    executeDb();
                    Console.WriteLine(userInfoBeanInstance.getFirstName());
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
        //Query Method that retrieves pay based on User's ID and PIN Number:
        public void getGenericInfoQuery(long id)
        {
            String payQuery = "SELECT pay, manager_firstName, manager_lastName, employment_start_date FROM user_info WHERE id = @id";
            using (sqlCommand = new SqlCommand(payQuery, DatabaseConnectionSingleton.conn))
            {
                try
                {
                    
                    sqlCommand.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                    executeDb();
                    DateTime employmentStartDate;
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long result = reader.GetInt64(0);
                            String managerFirstName = reader.GetString(1);
                            String managerLastName = reader.GetString(2);
                            if (!reader.IsDBNull(3))
                            {
                                employmentStartDate = reader.GetDateTime(3);
                                userInfoBeanInstance.setEmployeeStartDate(employmentStartDate);
                            }
                            userInfoBeanInstance.setPay(result);
                            userInfoBeanInstance.setManagerFirstName(managerFirstName);
                            userInfoBeanInstance.setManagerLastName(managerLastName);                            
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
         * SQL Method that Verifies if the user exists using a query that passes in User ID and Pin
         * It also gets and sets the Unique ID of the user:
         **/
        public Boolean verifyLoginQuery(String userId, int pin)
        {
            String firstNameResult = null;
            string lastNameResult = null;
            long idResult = 0;
            String getLoginQuery = "SELECT first_name, last_name, id, is_admin_or_employee from user_info WHERE email like @UserId AND pin = @pin";
            using (sqlCommand = new SqlCommand(getLoginQuery, DatabaseConnectionSingleton.conn))
            {
                try
                {
                    string searchTerm = string.Format("{0}%", userId);
                    sqlCommand.Parameters.Add("@UserId", SqlDbType.VarChar).Value = searchTerm;
                    sqlCommand.Parameters.Add("@pin", SqlDbType.Float).Value = pin;
                    executeDb();
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            firstNameResult = reader.GetString(0);
                            lastNameResult = reader.GetString(1);
                            idResult = reader.GetInt64(2);
                            String isAdminOrEmployee = reader.GetString(3);
                            //Set the UserInfoBean Object Properties from DB results:
                            userInfoBeanInstance.setFirstName(firstNameResult);
                            userInfoBeanInstance.setLastName(lastNameResult);
                            userInfoBeanInstance.setId(idResult);
                            if (isAdminOrEmployee.Equals("Employee"))
                            {
                                userInfoBeanInstance.setIsEmployee(true);
                            }
                            else
                            {
                                userInfoBeanInstance.setIsEmployee(false);
                            }
                        }
                    }
                    if(firstNameResult == null && lastNameResult == null)
                    {
                        return false;
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
            return true;
        }       

        //Returns User's Email based on Phone Number and DOB:
        public Boolean resetPasswordQuery(String dob, long phoneNumber)
        {
            String getLoginQuery = "SELECT email, pin FROM user_info WHERE dob like @dob AND cell_phone = @phoneNumber";
            using (sqlCommand = new SqlCommand(getLoginQuery, DatabaseConnectionSingleton.conn))
            {
                
                try
                {                    
                    //string searchTerm = string.Format("{0}%", dob);
                    sqlCommand.Parameters.Add("@dob", SqlDbType.VarChar).Value = convertStrDateToSqlDate(dob);
                    sqlCommand.Parameters.Add("@phoneNumber", SqlDbType.Float).Value = phoneNumber;
                    executeDb();
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String email = reader.GetString(0);
                            double pin = reader.GetDouble(1);

                            userInfoBeanInstance.setEmail(email);
                            userInfoBeanInstance.setPin(Convert.ToInt16(pin));
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

        public Boolean verifyManagerForEmployeeQuery(string employeeEmail, string email)
        {
            Boolean doesInfoExist = false;
            if (employeeEmail.Length == 0 || email.Length == 0)
            {
                return false;
            }
            string managerNameQuery = "SELECT manager_firstName, manager_lastName, id FROM user_info WHERE email = @employeeEmail";
            using (sqlCommand = new SqlCommand(managerNameQuery, DatabaseConnectionSingleton.conn))
            {
                try
                {
                    //string searchTerm = string.Format("{0}%", dob);
                    sqlCommand.Parameters.Add("@employeeEmail", SqlDbType.VarChar).Value = employeeEmail;
                    executeDb();
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            doesInfoExist = true;
                            String managerFirstName = reader.GetString(0);
                            String managerLastName = reader.GetString(1);
                            long id = reader.GetInt64(2);
                            if (managerFirstName.Equals(userInfoBeanInstance.getFirstName()) && managerLastName.Equals(userInfoBeanInstance.getLastName())){
                                adminEmployeeBeanInstance.Id = id;
                                return true;
                            }
                            else
                            {
                                DatabaseConnectionSingleton.conn.Close();
                                return false;
                            }
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
                if (!doesInfoExist)
                {
                    return false;
                }
                return true;
            }
        }
       
        public static String convertStrDateToSqlDate(String date)
        {
            if (date.Length != 0)
            {
                DateTime dt = DateTime.Parse(date);
                String dob = dt.ToString("yyyy-MM-dd");
                return dob;
            }
            return null;
        }


    }

    
}
