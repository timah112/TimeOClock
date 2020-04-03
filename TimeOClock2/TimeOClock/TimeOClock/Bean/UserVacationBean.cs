using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeOClock.Bean
{
    class UserVacationBean
    {
        
        private UserVacationBean()
        {
        }
        private static UserVacationBean userVacationBeanInstance = null;
        public static UserVacationBean getVacationBeanInstance()
        {
            if (userVacationBeanInstance == null)
            {
                userVacationBeanInstance = new UserVacationBean();
            }
            return userVacationBeanInstance;
        }

        private int vacationId;
        private int vacationBalance;
        private int vacationAccrued;
        private DateTime vacationRequestFromDate;
        private DateTime vacationRequestToDate;
        private long userId;
        private String vacationStatus;


        public int getVacationId()
        {
            return vacationId;
        }
        public void setVacationId(int vacationId)
        {
            this.vacationId = vacationId;
        }
        public int getVacationBalance()
        {
            return vacationBalance;
        }
        public void setVacationBalance(int vacationBalance)
        {
            this.vacationBalance = vacationBalance;
        }
        public int getVacationAccrued()
        {
            return vacationAccrued;
        }
        public void setVacationAccrued(int vacationAccrued)
        {
            this.vacationAccrued = vacationAccrued;
        }
        public DateTime getVacationRequestFromDate()
        {
            return vacationRequestFromDate;
        }
        public void setVacationRequestFromDate(DateTime vacationRequestFromDate)
        {
            this.vacationRequestFromDate = vacationRequestFromDate;
        }
        public DateTime getVacationRequestToDate()
        {
            return vacationRequestToDate;
        }
        public void setVacationRequestToDate(DateTime vacationRequestToDate)
        {
            this.vacationRequestToDate = vacationRequestToDate;
        }
        public long getUserId()
        {
            return userId;
        }
        public void setUserId(int userId)
        {
            this.userId = userId;
        }
        public String getVacationStatus()
        {
            return vacationStatus;
        }
        public void setVacationStatus(String vacationStatus)
        {
            this.vacationStatus = vacationStatus;
        }
    }
}
