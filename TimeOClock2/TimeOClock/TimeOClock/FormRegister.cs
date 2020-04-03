using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeOClock.FileUtils;
using System.IO;
using System.Collections;
using TimeOClock.Bean;
using TimeOClock.Dao;
using TimeOClock.FieldUtils;
using TimeOClock.model;

namespace TimeOClock
{
    public partial class FormRegisterGroupBox : Form
    {

        //Initialize Necessary Objects:
        //RemoteControl rc = new RemoteControl();
        UserInfoBean userInfoBeanInstance = UserInfoBean.getUserInfoBeanInstance();
        RegisterFormModel registermModel = RegisterFormModel.getRegisterFormInstance();
        UserInfoDao persistUserInfo = new UserInfoDao();
        public static Boolean isRegistered = false;
        static UserFileSingleton userFile = UserFileSingleton.getUserFileInstance();
        public static String userFileLocation = userFile.getUserFileLocation();
        public static string[] userFilelines = System.IO.File.ReadAllLines(userFileLocation);
        public static Boolean alreadyRegistered = false;

        public FormRegisterGroupBox()
        {
            InitializeComponent();
        }

        private void FormRegisterGroupBox_Load(object sender, EventArgs e)
        {
            if (new FileInfo(userFileLocation).Length > 0)
            {
                //MessageBox.Show("Registration information already exists.");
                this.errorLabel.Visible = true;
                this.errorLabel.Text = "Registration information already exists.";
                disableAllFields();
                displayAllInfoAfterRegister();
                //return false;
            }
            else
            {
                this.errorLabel.Visible = false;
            }            
            //Verify first if the user information already exists (based on email, and cellphone). If so, disable the user to enter fields
        }
        private void registerFormButton_Click(object sender, EventArgs e)
        {
            if (this.termsCheckBox.Checked)
            {
                //If all the information on the form is filled out with proper values; then allow them to continue onto the main screen.
                //Guide them to the next page if the Pin they entered is valid:
                if (ensureAllInfo())
                {
                    this.Hide();
                    FormIndex formIndex = new FormIndex();
                    formIndex.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please accept Terms and Conditions.");
            }            
        }

        private void backButton_Click(object sender, EventArgs e)
        {            
            this.Hide();
            FormIndex formIndex = new FormIndex();
            formIndex.ShowDialog();
        }

        private void temsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormTermsAndConditions termsAndConditionsForm = new FormTermsAndConditions();
            termsAndConditionsForm.ShowDialog();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        ArrayList textList = new ArrayList();
        private Boolean ensureAllInfo()
        {
            if (firstNameTextBox.Text.Length ==0 || LastNameTextBox.Text.Length ==0 || RegistrationTextBox.Text.Length == 0 || employerTextBox.Text.Length == 0 || emailTextBox.Text.Length == 0 ||
               ManagerLastNameTextBox.Text.Length == 0 || SalaryTextBox.Text.Length == 0 || managerNameTextBox.Text.Length == 0 || passwordTextBox.Text.Length ==0 ||
               pinTextBox.Text.Length ==0 || dobTextBox.Text.Length == 0 || EmploymentStartDateTimePicker.Text.Length ==0 || managerEmailTextBox.Text.Length ==0 || EmploymentStartDateTimePicker.Text.Length ==0)
            {
                MessageBox.Show("Please enter all information properly before submitting");
                return false;
            }
            if (!validateFields())
            {
                return false;
            }
            if (new FileInfo(userFileLocation).Length > 0)
            {
               // MessageBox.Show("Registration information already exists.");
                return false;
            }            
            //Else, add data to an arrayList to store information.
            else
            {
                addDataToRegisterModel();
                addDataToArrayList();
                writeToUserTextFile();
                persistUserInfo.persistUser();
            }
        
            return true;
        }

        public void addDataToRegisterModel()
        {
            DateTime dobDateTime = DateTime.Parse(dobTextBox.Text);
            DateTime employmentStartDate = DateTime.Parse(EmploymentStartDateTimePicker.Text);

            registermModel.setFirstName(firstNameTextBox.Text);
            registermModel.setLastName(LastNameTextBox.Text);
            registermModel.setDob(dobDateTime);
            registermModel.setEmail(emailTextBox.Text);
            registermModel.setEmployer(employerTextBox.Text);
            registermModel.setManagerFirstName(managerNameTextBox.Text);
            registermModel.setManagerLastName(ManagerLastNameTextBox.Text);
            registermModel.setPay((long) Convert.ToInt64(SalaryTextBox.Text));
            registermModel.setPin((int)Convert.ToInt32(pinTextBox.Text));
            //registermModel.setPoints((int)Convert.ToInt32(point.Text)); //this will be set in another method
            registermModel.setCellPhoneNum((long) Convert.ToInt64(cellPhoneTextBox.Text));
            registermModel.setPassword(passwordTextBox.Text);
            registermModel.setIsEmployee(isEmployeeRadioButton.Checked);
            registermModel.setManagerEmail(managerEmailTextBox.Text);
            registermModel.setEmploymentDateTime(employmentStartDate);
        }
    
        public void addDataToArrayList()
        {   
            textList.Add(firstNameTextBox.Text);
            textList.Add(LastNameTextBox.Text);
            textList.Add(managerNameTextBox.Text);
            textList.Add(ManagerLastNameTextBox.Text);
            textList.Add(managerEmailTextBox.Text);
            textList.Add(employerTextBox.Text);
            textList.Add(emailTextBox.Text);
            textList.Add(SalaryTextBox.Text);
            textList.Add(EmploymentStartDateTimePicker.Text);
            textList.Add(passwordTextBox.Text);
            textList.Add(pinTextBox.Text);
            textList.Add(dobTextBox.Text);
            textList.Add(cellPhoneTextBox.Text);
            textList.Add(EmploymentStartDateTimePicker.Text);
        }

        private Boolean validateFields()
        {
            if (firstNameTextBox.Text.Length ==0 || LastNameTextBox.Text.Length == 0 || (!FieldValidator.is_LettersOnly(LastNameTextBox.Text)))
            {
                this.errorLabel.Visible = true;
                this.errorLabel.Text = "Please enter a valid first and last names.";
                return false;
            }
            else if(managerNameTextBox.Text.Length ==0 || ManagerLastNameTextBox.Text.Length == 0 || (!FieldValidator.is_LettersOnly(LastNameTextBox.Text)))
            {
                this.errorLabel.Visible = true;
                this.errorLabel.Text = "Please enter a valid Manager name.";
                return false;
            }
            else if(emailTextBox.Text.Length <= 1 || (!FieldValidator.isEmailFormatCorrect(managerEmailTextBox.Text)))
            {
                this.errorLabel.Visible = true;
                this.errorLabel.Text = "Please enter a valid Email Address for Manager.";
                return false;
            }
            else if (employerTextBox.Text.Length <= 1)
            {
                this.errorLabel.Visible = true;
                this.errorLabel.Text = "Please enter a valid Employer name.";
                return false;
            }
            else if (emailTextBox.Text.Length <= 1 || (!FieldValidator.isEmailFormatCorrect(emailTextBox.Text)))
            {
                this.errorLabel.Visible = true;
                this.errorLabel.Text = "Please enter a valid Email Address.";
                return false;                
            }
            else if (SalaryTextBox.Text.Length ==0 || (!FieldValidator.is_Int(SalaryTextBox.Text)))
            {
                this.errorLabel.Visible = true;
                this.errorLabel.Text = "Please enter a valid Salary.";
                return false;
            }
            else if (!FieldValidator.containsSpecialCharactersInNum(SalaryTextBox.Text))
            {
                this.errorLabel.Visible = true;
                this.errorLabel.Text = "Please do NOT enter special characters in Salary besides decimals.";
                return false;
            }
            else if (this.EmploymentStartDateTimePicker.Value > DateTime.Now || dobTextBox.Value >= DateTime.Now)
            {
                this.errorLabel.Visible = true;
                this.errorLabel.Text = "The Dates must be correct.";
                return false;
            }
            else if (!FieldValidator.verifyPin(Int32.Parse(this.pinTextBox.Text)))
            {
                this.errorLabel.Visible = true;
                this.errorLabel.Text = "Pin must be atleast 4 digits long, unconsecutive, and unique.";
                return false;
            }
            else if(!FieldValidator.containsSpecialCharactersInNum(pinTextBox.Text) || (!FieldValidator.is_Int(pinTextBox.Text)))
            {
                this.errorLabel.Visible = true;
                this.errorLabel.Text = "The Pin must be atleast 5 digits (only) long.";
                return false;
            }
            else if (!FieldValidator.isPhoneFieldCorrect(cellPhoneTextBox.Text)){
                this.errorLabel.Visible = true;
                this.errorLabel.Text = "The Phone number must be without special character(s) and 10 digits long.";
                return false;
            }
            return true;
        }

        public void writeToUserTextFile()
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(userFileLocation))
                    for (int i = 0; i < textList.Count; i++)
                    {
                        file.WriteLine(textList[i].ToString());
                    }
                MessageBox.Show("Data saved to: " + userFileLocation);

            }
            catch (IOException)
            {
                MessageBox.Show("Could not enter data in file. Please try again");
            }
        }
        //If the user is already registered in the File, then it will disable all the fields from the user.
        private void disableAllFields()
        {
            firstNameTextBox.Enabled = false;
            LastNameTextBox.Enabled = false;
            managerNameTextBox.Enabled = false;
            ManagerLastNameTextBox.Enabled = false;
            SalaryTextBox.Enabled = false;
            EmploymentStartDateTimePicker.Enabled = false;
            managerEmailTextBox.Enabled = false;
            employerTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            EmploymentStartDateTimePicker.Enabled = false;
            passwordTextBox.Enabled = false;
            pinTextBox.Enabled = false;
            dobTextBox.Enabled = false;
            cellPhoneTextBox.Enabled = false;
            registerFormSubmitButton.Enabled = false;
        }        
        private void displayAllInfoAfterRegister()
        {
            this.firstNameTextBox.Text = userFilelines[0].ToString().Trim();
            this.LastNameTextBox.Text = userFilelines[1].ToString().Trim();
            this.managerNameTextBox.Text = userFilelines[2].ToString().Trim();
            this.ManagerLastNameTextBox.Text = userFilelines[3].ToString().Trim();
            this.managerEmailTextBox.Text = userFilelines[4].ToString().Trim();
            this.employerTextBox.Text = userFilelines[5].ToString().Trim();
            this.emailTextBox.Text = userFilelines[6].ToString().Trim();
            this.SalaryTextBox.Text = userFilelines[7].ToString().Trim() + FieldValidator.isSalaryAnnualOrHourly(userFilelines[7]);
            this.EmploymentStartDateTimePicker.Text = userFilelines[8].ToString().Trim();
            this.passwordTextBox.Text = userFilelines[9].ToString().Trim();
            this.pinTextBox.Text = userFilelines[10].ToString().Trim();
            this.dobTextBox.Text = userFilelines[11].ToString().Trim();
            this.cellPhoneTextBox.Text = userFilelines[12].ToString().Trim(); 
            this.EmploymentStartDateTimePicker.Text = userFilelines[13].ToString().Trim();
        }

    }
}

