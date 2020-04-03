using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeOClock.Bean
{
    class UserInfoBean
    {
        private UserInfoBean()
        {
        }
        private static UserInfoBean userInfoBeanInstance = null;
        public static UserInfoBean getUserInfoBeanInstance()
        {
            if (userInfoBeanInstance == null)
            {
                userInfoBeanInstance = new UserInfoBean();
            }
            return userInfoBeanInstance;
        }

        private String firstName;
        private String lastName;
        private DateTime dob;
        private long pay;
        private long cellPhone;
        private String managerFirstName;
        private String managerLastName;
        private String managerEmail;
        private String email;
        private int pin;
        private String employer;
        private Boolean isEmployee;
        private String password;
        private long points;
        private long id;
        private DateTime employeeStartDate;

        public string getFirstName()
        {
            return firstName;
        }
        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }
        public String getLastName()
        {
            return lastName;
        }
        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }
        public DateTime getDob()
        {
            return dob;
        }
        public void setDob(DateTime dob)
        {
            this.dob = dob;
        }
        public long getPay()
        {
            return pay;
        }
        public void setPay(long pay)
        {
            this.pay = pay;
        }
        public long getCellPhoneNum()
        {
            return cellPhone;
        }
        public void setCellPhoneNum(long cellPhone)
        {
            this.cellPhone = cellPhone;
        }
        public String getManagerFirstName()
        {
            return managerFirstName;
        }
        public void setManagerFirstName(String managerFirstName)
        {
            this.managerFirstName = managerFirstName;
        }
        public String getManagerLastName()
        {
            return managerLastName;
        }
        public void setManagerLastName(String managerLastName)
        {
            this.managerLastName = managerLastName;
        }
        public String getManagerEmail()
        {
            return managerEmail;
        }
        public void setManagerEmail(String managerEmail)
        {
            this.managerEmail = managerEmail;
        }
        public string getEmail()
        {
            return email;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }
        public int getPin()
        {
            return pin;
        }
        public void setPin(int pin)
        {
            this.pin = pin;
        }
        public String getEmployer()
        {
            return employer;
        }
        public void setEmployer(String employer)
        {
            this.employer = employer;
        }
        public Boolean getIsEmployee()
        {
            return isEmployee;
        }
        public void setIsEmployee(Boolean isEmployee)
        {
            this.isEmployee = isEmployee;
        }
        public String getPassword()
        {
            return password;
        }
        public void setPassword(String password)
        {
            this.password = password;
        }
        public long getPoints()
        {
            return points;
        }
        public void setPoints(long points)
        {
            this.points = points;
        }
        public long getId()
        {
            return this.id;
        }
        public void setId(long id)
        {
            this.id = id;
        }
        public DateTime getEmployeeStartDate()
        {
            return employeeStartDate;
        }
        public void setEmployeeStartDate(DateTime employeeStartDate)
        {
            this.employeeStartDate = employeeStartDate;
        }

    }
}
