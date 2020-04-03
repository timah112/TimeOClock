using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeOClock.ClockStates;
using TimeOClock.FileUtils;
using TimeOClock.Bean;
using TimeOClock.Dao;
using TimeOClock.model;
using TimeOClock.FieldUtils;


namespace TimeOClock
{
    public partial class FormDomain : Form
    {
        ClockInStates clockInState = new ClockInStates();
        ClockOutStates clockOutState = new ClockOutStates();
        
        static TimeFileSingleton timeFile = TimeFileSingleton.getInstance();
        static String timeFileLocation = timeFile.getTimeFileLocation();
        UserInfoBean userInfoBeanInstance = UserInfoBean.getUserInfoBeanInstance();
        static CommentsFileSingleton commentsFile = CommentsFileSingleton.getCommentsInstance();
        static String commentsFileLocation = commentsFile.getTimeFileLocation();
        public string[] commentsFilelines = System.IO.File.ReadAllLines(commentsFileLocation);
        IndexFormModel indexModel = IndexFormModel.getInstance();
        UserInfoDao persistUserInfo = new UserInfoDao();
        DomainModel domainModelInstance = DomainModel.getDomainModelInstance();
        UserCommentsDao userCommentsDao = new UserCommentsDao();
        UserVacationDao userVacationDao = new UserVacationDao();

        public FormDomain()
        {
            InitializeComponent();
        }
        private void FormDomain_Load(object sender, EventArgs e)
        {
            if(indexModel.getUserId() != null && indexModel.getPin() != 0)
            {
                long id = userInfoBeanInstance.getId();
                persistUserInfo.getGenericInfoQuery(id);
                this.payTextBox.Text = userInfoBeanInstance.getPay().ToString() + FieldValidator.isSalaryAnnualOrHourly(userInfoBeanInstance.getPay().ToString());
            }
            if (userInfoBeanInstance.getIsEmployee())
            {
                this.adminSettingsButton.Enabled = false;
            }
            else
            {
                this.adminSettingsButton.Enabled = true;
            }
            this.formDomanErrorLabel.Visible = false;
            currentTimeLabel.Text = DateTime.Now.ToLongTimeString();
            currentDateLabel.Text = DateTime.Now.ToLongDateString();
        }
        private void clockInButton_Click(object sender, EventArgs e)
        {
            enableOrDisableButton(true);
        }

        private void clockOutButton_Click(object sender, EventArgs e)
        {   
            enableOrDisableButton(true);
                
        }

        private void enableOrDisableButton(Boolean isClockedIn){
            clockInState.action(isClockedIn);
            clockOutState.action(isClockedIn);

            if(clockInState.isButtonEnabled == false)
            {
                clockInButton.Enabled = clockInState.isButtonEnabled;
                MessageBox.Show("Button is disabled");
                clockOutButton.Enabled = clockOutState.isButtonEnabled;
            }
            if(clockOutState.isButtonEnabled == false)
            {
                clockOutButton.Enabled = clockOutState.isButtonEnabled;
                MessageBox.Show("Button is disabled");
                clockInButton.Enabled = clockInState.isButtonEnabled;
                
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void currentTimeLable_Click(object sender, EventArgs e)
        {
            currentTimeLabel.Text = DateTime.Now.ToLongTimeString();
        }
              
        private void currentDateLabel_Click(object sender, EventArgs e)
        {
            currentDateLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void ptoDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ForgotToClockLabelLink.LinkVisited = true;
            this.Hide();
            FormViewDetails formViewDetails = new FormViewDetails();
            formViewDetails.ShowDialog();
        }
        private void ptoButton_Click(object sender, EventArgs e)
        {
            if (calculateVacationInfo())
            {
                setDomainModelObj();
                userVacationDao.insertVacationRequestQuery(userInfoBeanInstance.getId(), domainModelInstance.getPtoRequestFromDate(),
                                                            domainModelInstance.getPtoRequestToDate(), 140, DomainModel.PENDING_STATUS, this.numOfVacationDays);
            }
            
           
        }
        private void adminSettingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdminView formAdminView = new FormAdminView();
            formAdminView.ShowDialog();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIndex formIndex = new FormIndex();
            formIndex.ShowDialog();
        }

        private void ForgotToClockLabelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            WeeklyClock weeklyClock = new WeeklyClock();
            weeklyClock.Show();
        }
        private void concernsSubmitButton_Click(object sender, EventArgs e)
        {
            submitCommentsOrConcerns();
        }
        private void clearTextButton_Click(object sender, EventArgs e)
        {
            commentsTextBox.Text = null;
        }
        String comments;
        public void submitCommentsOrConcerns()
        {
            comments = commentsTextBox.Text;
            if (!String.IsNullOrEmpty(comments) || comments.Length > 0)
            {
                this.formDomanErrorLabel.Visible = false;
                domainModelInstance.setComment(comments);
                userCommentsDao.insertCommentsQuery(indexModel.getUserId(), indexModel.getPin(), domainModelInstance.getComment());
                System.IO.File.WriteAllText(commentsFileLocation, comments);
                MessageBox.Show("Comments saved successfully.");
            }
            else
            {
                this.formDomanErrorLabel.Visible = true;
                this.formDomanErrorLabel.Text= "Please enter a comment before submitting.";
            }

        }
        int numOfVacationDays = 0;
        private Boolean calculateVacationInfo()
        {            
            this.formDomanErrorLabel.Visible = false;
            this.requestPtoFromTimePicker.Value.ToShortDateString();

            DateTime inTime = Convert.ToDateTime(requestPtoFromTimePicker.Text);
            DateTime outTime = Convert.ToDateTime(requestPtoToTimePicker.Text);

            numOfVacationDays = getNumberOfWorkingDays(inTime, outTime);
            if (isStartDateLesser)
            {
                MessageBox.Show("Total Days of vacation are: " + numOfVacationDays);
                //MessageBox.Show("Total Days of vacation are: " + outTime.Subtract(inTime).Days.ToString());
            }
            else
            {
                this.formDomanErrorLabel.Visible = true;
                this.formDomanErrorLabel.Text = "The 'From' Date must be lesser than or equal to the 'To' Date.";
                return false;
            }           
            return true;
        }
        private Boolean isStartDateLesser = false;
        private int getNumberOfWorkingDays(DateTime start, DateTime stop)
        {
            int days = 0;
            while (start <= stop)
            {
                isStartDateLesser = true;
                if (start.DayOfWeek != DayOfWeek.Saturday && start.DayOfWeek != DayOfWeek.Sunday)
                {
                    ++days;
                }
                start = start.AddDays(1);
            }
            return days;
        }

        private void setDomainModelObj()
        {            
            DateTime ptoRequestFrom = this.requestPtoFromTimePicker.Value;
            DateTime ptoRequestTo = this.requestPtoToTimePicker.Value;
            domainModelInstance.setPtoRequestFromDate(ptoRequestFrom.ToShortDateString());
            domainModelInstance.setPtoRequestToDate(ptoRequestTo.ToShortDateString());
        }

        private void labelCalendarReminder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitCalendarLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitCalendarLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            this.labelCalendarReminder.LinkVisited = true;
            //Call the Process.Start method to open the default browser with a URL:
            System.Diagnostics.Process.Start("https://www.google.com/calendar/");
        }

        
    }
}
