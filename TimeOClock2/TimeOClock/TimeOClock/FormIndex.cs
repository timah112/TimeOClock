using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeOClock.Dbo;
using TimeOClock.model;
using TimeOClock.FieldUtils;
using TimeOClock.Dao;

namespace TimeOClock
{
    public partial class FormIndex : Form
    {
        //Instantiate Objects:
        DatabaseConnectionSingleton dbConnection = DatabaseConnectionSingleton.getdbConnectionInstance();
        UserInfoDao persistUserInfo = new UserInfoDao();
        IndexFormModel indexModel = IndexFormModel.getInstance();

        public FormIndex()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.errorLabel.Visible = false;
            dbConnection.setUpConnection();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            //MessageBox.Show("Please enter your information");
            FormRegisterGroupBox formRegister = new FormRegisterGroupBox();
            formRegister.ShowDialog();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            //Guide them to the next page if the Pin they entered is valid:
            if (ensureAllInfo())
            {
                if(persistUserInfo.verifyLoginQuery(indexModel.getUserId(), indexModel.getPin())){
                    this.Hide();
                    FormDomain formDomain = new FormDomain();
                    formDomain.ShowDialog();
                }
                else
                {
                    this.errorLabel.Visible = true;
                    this.errorLabel.Text = "Your User ID or PIN is incorrect.";
                }                
            }            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormForgotPin forgotPinForm = new FormForgotPin();
            forgotPinForm.ShowDialog();
        }

        public Boolean ensureAllInfo()
        {
            if(this.userIdTextBox.Text.Length ==0)
            {
                this.errorLabel.Visible = true;
                this.errorLabel.Text = "Please enter proper User ID.";
                return false;
            }
            if (this.pinTextBox.Text.Length == 0 || (!FieldValidator.is_Int(pinTextBox.Text)))
            {
                this.errorLabel.Visible = true;
                this.errorLabel.Text = "Please enter proper PIN number.";
                return false;
            }
            setIndexFormInfo();
            return true;
        }
        public void setIndexFormInfo()
        {
            indexModel.setUserId(this.userIdTextBox.Text);
            indexModel.setPin(Int32.Parse(this.pinTextBox.Text));
        }

    }
}
