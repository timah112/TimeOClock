using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeOClock.Dao;
using TimeOClock.model;
using TimeOClock.Bean;

namespace TimeOClock
{
    public partial class FormViewDetails : Form
    {
        UserVacationDao vacationDao = new UserVacationDao();
        UserInfoDao userInfoDao = new UserInfoDao();
        IndexFormModel indexModel = IndexFormModel.getInstance();
        UserInfoBean userInfoBeanInstance = UserInfoBean.getUserInfoBeanInstance();
        UserVacationBean vacationBeanInstance = UserVacationBean.getVacationBeanInstance();

        public FormViewDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDomain formDomain = new FormDomain();
            formDomain.ShowDialog();
        }

        private void employmentHistoryLabel_Load(object sender, EventArgs e)
        {
            long id = userInfoBeanInstance.getId();
            //userInfoDao.getGenericInfoQuery(id);
            vacationDao.getLimitedVacationInfoQuery(id);
            vacationDao.getVacationAccruedQuery(id);
            setViewDetails();
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void cancelVacationButton_Click(object sender, EventArgs e)
        {

        }

        public void setViewDetails()
        {
            //If manager Last Name or First Name is too long, obbreviate one of them.
            this.managerTextBox.Text = userInfoBeanInstance.getManagerFirstName() + " " + userInfoBeanInstance.getManagerLastName();
            int numOfMonthsEmployed = getEmploymentHistory(userInfoBeanInstance.getEmployeeStartDate(), DateTime.Now);
            this.employmentHistTextBox.Text = numOfMonthsEmployed.ToString() + " Months";
            this.upcomingVacationsTextBox.Text = getVacationDays(vacationBeanInstance.getVacationRequestFromDate(), vacationBeanInstance.getVacationRequestToDate());
            this.vacationStatusTextBox.Text = vacationBeanInstance.getVacationStatus();
            this.vacationAccruedTextBox.Text = vacationBeanInstance.getVacationAccrued().ToString();
            this.vacationBalanceTextBox.Text = vacationBeanInstance.getVacationBalance().ToString() + " Days";
        }

        //This method calculates the remaining vacation balance of the user based on the vacation they've already taken.
        private void calculateVacationBalance()
        {
            //Do this by looping through the vacation accrued days in the DB table and adding all of the values.
        }
        //Calculates the number of months or years based on the employee start date:
        private int getEmploymentHistory(DateTime startDate, DateTime currentDate)
        {
            if(startDate != DateTime.MinValue)
            {
                int totalMonths = ((startDate.Year - currentDate.Year) * 12) + startDate.Month - currentDate.Month;
                return Math.Abs(totalMonths);
            }
            return 0;
           
        }
        //Method that gets the total days/hours of vacation that have been used.
        public String getVacationDays(DateTime beginDate, DateTime endDate)
        {
            
            if (beginDate == DateTime.MinValue || endDate == DateTime.MinValue)
            {
                return "0";
            }
            return beginDate.ToShortDateString() + " - " + endDate.ToShortDateString();
        }
    }


}
