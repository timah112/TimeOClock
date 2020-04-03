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
using TimeOClock.model;
using TimeOClock.Dao;
using System.Net.Mail;

namespace TimeOClock
{
    public partial class FormForgotPin : Form
    {
        UserInfoBean userInfoBeanInstance = UserInfoBean.getUserInfoBeanInstance();
        ForgotPinModel forgotPinModel = ForgotPinModel.getInstance();
        UserInfoDao userDao = new UserInfoDao();
        private String email = null;
        private int pin = 0;

        public FormForgotPin()
        {
            InitializeComponent();
        }
        private void FormForgotPin_Load(object sender, EventArgs e)
        {
            this.forgotPinErrorLabel.Visible = false;
        }
        private void forgotPinButton_Click(object sender, EventArgs e)
        {
            if (verifyForgotPinInfo())
            {
                if (userDao.resetPasswordQuery(forgotPinModel.getDob(), forgotPinModel.getPhoneNumber()))
                {
                    email = userInfoBeanInstance.getEmail();
                    pin = userInfoBeanInstance.getPin();
                    if(pin ==0 || email.Length == 0)
                    {
                        this.forgotPinErrorLabel.Visible = true;
                        this.forgotPinErrorLabel.Text = "Sorry, your information could not be found.";
                    }
                    else
                    {
                        MessageBox.Show("Your PIN number is: " + pin);
                        //sendEmail();
                        this.Hide();
                        FormIndex formIndex = new FormIndex();
                        formIndex.ShowDialog();
                    }                    
                }
                else
                {
                    this.forgotPinErrorLabel.Visible = true;
                    this.forgotPinErrorLabel.Text = "Sorry, your information could not be found.";
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIndex formIndex = new FormIndex();
            formIndex.ShowDialog();
        }

        private Boolean verifyForgotPinInfo()
        {
            if(this.dobTextBox.Value == null || this.cellPhoneTextBox.Text.Length ==0)
            {
                this.forgotPinErrorLabel.Visible = true;
                this.forgotPinErrorLabel.Text = "Please enter proper values.";
                return false;
            }
            else
            {
                setForgotPinInfo();
            }
            return true;
        }

        private void sendEmail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(email);
                mail.To.Add("tirmizia92@gmail.com");
                mail.Subject = "Test Mail";
                mail.Body = "This is for testing SMTP mail from GMAIL" + pin;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("tirmiza92@gmail.com", "student92");
                SmtpServer.EnableSsl = true;
                SmtpServer.UseDefaultCredentials = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Your pin is sent to your work email.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void setForgotPinInfo()
        {
            DateTime dobDateTime = this.dobTextBox.Value;
            forgotPinModel.setDob(dobDateTime.ToShortDateString());
            forgotPinModel.setPhoneNumber(Int64.Parse(this.cellPhoneTextBox.Text));
        }

       
    }
}
