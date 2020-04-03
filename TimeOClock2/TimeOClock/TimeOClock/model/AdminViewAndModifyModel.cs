using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeOClock.model
{
    class AdminViewAndModifyModel
    {
        private String employeeEmail;
        private DateTime employeeHireDate;
        private int empStartVacaBalance;

        public string getEmployeeEmail()
        {
            return employeeEmail;
        }
        public void setEmployeeEmail(String employeeEmail)
        {
            this.employeeEmail = employeeEmail;
        }
        public DateTime getEmployeeHireDate()
        {
            return employeeHireDate;
        }
        public void setEmployeeHireDate(DateTime employeeHireDate)
        {
            this.employeeHireDate = employeeHireDate;
        }
        public int getEempStartVacaBalance()
        {
            return empStartVacaBalance;
        }
        public void setEmpStartVacaBalance(int empStartVacaBalance)
        {
            this.empStartVacaBalance = empStartVacaBalance;
        }

    }
}
