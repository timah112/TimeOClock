using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TimeOClock.Dbo
{
    class DatabaseConnectionSingleton
    {
        private DatabaseConnectionSingleton() { }
        public static string connectionString;
        private static DatabaseConnectionSingleton dbConnectionInstance = null;
        public static SqlConnection conn = null;
        public static DatabaseConnectionSingleton getdbConnectionInstance()
        {
            if(dbConnectionInstance == null)
            {
                dbConnectionInstance = new DatabaseConnectionSingleton();
            }
            return dbConnectionInstance;
        }

        public void setUpConnection()
        {            
            connectionString = @"Data Source=NYCLAPTOP-03078;Initial Catalog=TimeOClock;Persist Security Info=True;User ID=sa;Password=Student92.";
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                //MessageBox.Show("Connection Open!");
                //SqlDataAdapter adapter = new SqlDataAdapter("Select * from User_Time", conn);
                /**
                    String time_query = "Select * from User_Time";
                    SqlDataAdapter adapter = new SqlDataAdapter(time_query, conn);
                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);

                    if (dtbl.Rows.Count == 1)
                    {
                        Console.WriteLine(dtbl.Rows.Count);
                    }
                **/
            }
            catch (SqlException)
            {
                MessageBox.Show("Connection failed");
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
