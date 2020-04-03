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

namespace TimeOClock
{
    public partial class FormAdminModify : Form
    {

        UserInfoDao userInfoDao = new UserInfoDao();
        UserCommentsDao userCommentsDao = new UserCommentsDao();
        UserVacationDao userVacationDao = new UserVacationDao();
        AdminEmployeeBean adminEmployeeBean = AdminEmployeeBean.getAdminEmployeeBeanInstance();
        FormViewDetails formViewDetails = new FormViewDetails();
        public FormAdminModify()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdminView formAdminView = new FormAdminView();
            formAdminView.Show();
        }

        private void FormAdminModify_Load(object sender, EventArgs e)
        {
            this.ErrorLabel.Visible = false;
            long id = adminEmployeeBean.Id;
            userVacationDao.getLimitedVacationInfoQuery(id);
            this.VacationRequestTextBox.Text = formViewDetails.getVacationDays(adminEmployeeBean.VacationRequestFromDate, adminEmployeeBean.VacationRequestToDate);
        }

      

        private void submitEmployeeInfoTextBox_Click(object sender, EventArgs e)
        {
            if (verifyFeilds())
            {
                this.ErrorLabel.Visible = false;
            }
        }

        private Boolean verifyFeilds()
        {
            String hireDateStr = this.employeeHireDateTextBox.Text;
            String startingVacationBalance = this.startingVacationBalanceTextBox.Text;
            if (!hireDateStr.Contains("-"))
            {
                this.ErrorLabel.Visible = true;
                this.ErrorLabel.Text = "Enter date in Proper format: YYYY-MM-DD.";
                return false;
            }
            if(startingVacationBalance.Length != 0)
            {
                foreach (char c in startingVacationBalance)
                {
                    if (!Char.IsDigit(c))
                    {
                        this.ErrorLabel.Visible = true;
                        this.ErrorLabel.Text = "Enter number(s) only for Vacation Days.";
                        return false;
                    }
                }
            }
            else
            {
                this.ErrorLabel.Visible = true;
                this.ErrorLabel.Text = "Enter all info before submitting.";
            }
            return true;
        }
    }
}
