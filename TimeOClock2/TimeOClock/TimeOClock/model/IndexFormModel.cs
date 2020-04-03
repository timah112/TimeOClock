using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeOClock.model
{
    class IndexFormModel
    {
        private static volatile IndexFormModel indexModelInstance;
        private IndexFormModel()
        {
        }

        public static IndexFormModel getInstance()
        {
            if (indexModelInstance == null)
            {
                indexModelInstance = new IndexFormModel();
            }

            return indexModelInstance;
        }
        private string userId;
        private int pin;

        public String getUserId()
        {
            return userId;
        }
        public void setUserId(String userId)
        {
            this.userId = userId;
        }
        public int getPin()
        {
            return pin;
        }
        public void setPin(int pin)
        {
            this.pin = pin;
        }

    }
}
