using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeOClock.Bean;
using TimeOClock.Dao;
using TimeOClock.model;

namespace TimeOClock
{
    public partial class FormAdminView : Form
    {
        UserInfoDao userInfoDao = new UserInfoDao();
        UserCommentsDao userCommentsDao = new UserCommentsDao();
        UserVacationDao userVacationDao = new UserVacationDao();
        IndexFormModel indexModel = IndexFormModel.getInstance();
        AdminEmployeeBean adminEmployeeBean = AdminEmployeeBean.getAdminEmployeeBeanInstance();
        AdminViewAndModifyModel adminViewAndModifyModel = new AdminViewAndModifyModel();
        public  Boolean isEmployeeVerified = false; //Will be used to modify or view user Information
        public FormAdminView()
        {
            InitializeComponent();
        }
        private void FormAdminView_Load(object sender, EventArgs e)
        {
            this.errorLabel.Visible = false;
        }
        private void enterEmailButton_Click(object sender, EventArgs e)
        {
            if(this.employeeEmailTextBox.Text.Length != 0)
            {
                adminViewAndModifyModel.setEmployeeEmail(this.employeeEmailTextBox.Text);
                if(userInfoDao.verifyManagerForEmployeeQuery(adminViewAndModifyModel.getEmployeeEmail(), indexModel.getUserId()))
                {
                    this.errorLabel.Visible = false;
                    getAdminEmplInfo();
                    isEmployeeVerified = true;
                    this.ModifyAdminInfoButton.Enabled = true;
                }
                else
                {
                    this.errorLabel.Visible = true;
                    this.errorLabel.Text = "Email is incorrect or you DON'T have access to view this employee's info.";
                    this.ModifyAdminInfoButton.Enabled = false;
                }
                
            }
            else
            {
                this.errorLabel.Visible = true;
                this.errorLabel.Text = "Please enter a value for the Employee Email.";
            }
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDomain formDomain = new FormDomain();
            formDomain.Show();
        }

        private void ModifyAdminInfoButton_Click(object sender, EventArgs e)
        {
            if (this.employeeEmailTextBox.Text.Length != 0)
            {
                if (isEmployeeVerified)
                {
                    this.Hide();
                    FormAdminModify formAdminModify = new FormAdminModify();
                    formAdminModify.Show();
                }
            }
            else
            {
                this.errorLabel.Visible = true;
                this.errorLabel.Text = "Please enter a value for the Employee Email first.";
            }
        }

        private void getAdminEmplInfo()
        {
            long id = adminEmployeeBean.Id;
            userCommentsDao.getCommentsQuery(id);
            userVacationDao.getVacationAccruedQuery(id);
            userVacationDao.getLimitedVacationInfoQuery(id);
            this.employeeCommentsTextBox.Text = adminEmployeeBean.Comment;
            this.vacationAccruedTextBox.Text = adminEmployeeBean.VacationAccruedDays.ToString();
            this.VacationBalanceTextBox.Text = adminEmployeeBean.VacationBalanceDays.ToString();
        }

       
    }
}
