using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeOClock.Bean
{
    //This is the Employee Object that is under a specific admin. The fields contain limited info about the employee from the Admin's perspective.
    class AdminEmployeeBean
    {
        private AdminEmployeeBean()
        {
        }
        private static AdminEmployeeBean adminEmployeeBeanInstance = null;
        public static AdminEmployeeBean getAdminEmployeeBeanInstance()
        {
            if (adminEmployeeBeanInstance == null)
            {
                adminEmployeeBeanInstance = new AdminEmployeeBean();
            }
            return adminEmployeeBeanInstance;
        }

        private long id;
        private int vacationAccruedDays;
        private int vacationBalanceDays;
        private int dayHours;
        private int weekHours;
        private DateTime firstClockIn;
        private DateTime lastClockOut;
        string comment;
        private DateTime vacationRequestFromDate;
        private DateTime vacationRequestToDate;

        public long Id { get => id; set => id = value; }
        public int VacationAccruedDays { get => vacationAccruedDays; set => vacationAccruedDays = value; }
        public int VacationBalanceDays { get => vacationBalanceDays; set => vacationBalanceDays = value; }
        public int DayHours { get => dayHours; set => dayHours = value; }
        public int WeekHours { get => weekHours; set => weekHours = value; }
        public DateTime FirstClockIn { get => firstClockIn; set => firstClockIn = value; }
        public DateTime LastClockOut { get => lastClockOut; set => lastClockOut = value; }
        public string Comment { get => comment; set => comment = value; }
        public DateTime VacationRequestFromDate { get => vacationRequestFromDate; set => vacationRequestFromDate = value; }
        public DateTime VacationRequestToDate { get => vacationRequestToDate; set => vacationRequestToDate = value; }
    }
}
