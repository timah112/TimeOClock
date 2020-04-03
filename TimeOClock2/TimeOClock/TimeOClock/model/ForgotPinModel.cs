using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeOClock.model
{
    class ForgotPinModel
    {
        /** Creating the Singleton for this Object**/
        private static volatile ForgotPinModel forgotPinModelInstance;
        private ForgotPinModel()
        {
        }

        public static ForgotPinModel getInstance()
        {
            if (forgotPinModelInstance == null)
            {
                forgotPinModelInstance = new ForgotPinModel();
            }

            return forgotPinModelInstance;
        }
        private String dob;
        private long phoneNumber;

        public string getDob()
        {
            return dob;
        }
        public void setDob(string dob)
        {
            this.dob = dob;
        }
        public long getPhoneNumber()
        {
            return phoneNumber;
        }
        public void setPhoneNumber(long phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
    }
}
