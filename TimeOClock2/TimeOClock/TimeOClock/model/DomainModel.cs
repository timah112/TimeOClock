using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeOClock.model
{
    class DomainModel
    {
        private static volatile DomainModel domainModelInstance;
        private DomainModel()
        {
        }

        public static DomainModel getDomainModelInstance()
        {
            if (domainModelInstance == null)
            {
                domainModelInstance = new DomainModel();
            }

            return domainModelInstance;
        }

        private string ptoRequestFromDate;
        private string ptoRequestToDate;
        private string comment;
        private int vacationBalanceHours; 

        public const string PENDING_STATUS = "Pending";
        public const string APPROVED_STATUS = "Approved";
        public const string DEINIED_STATUS = "Denied";

        public string getPtoRequestFromDate()
        {
            return this.ptoRequestFromDate;
        }
        public void setPtoRequestFromDate(string ptoRequestFromDate)
        {
            this.ptoRequestFromDate = ptoRequestFromDate;
        }
        public String getPtoRequestToDate()
        {
            return this.ptoRequestToDate;
        }
        public void setPtoRequestToDate(String ptoRequestToDate)
        {
            this.ptoRequestToDate = ptoRequestToDate;
        }

        public string getComment()
        {
            return this.comment;
        }
        public void setComment(string comment)
        {
            this.comment = comment;
        }
        public int getVacationBalanceHours()
        {
            return vacationBalanceHours;
        }
        public void setVacationBalanceHours(int vacationBalanceHours)
        {
            this.vacationBalanceHours = vacationBalanceHours;
        }


    }
}
