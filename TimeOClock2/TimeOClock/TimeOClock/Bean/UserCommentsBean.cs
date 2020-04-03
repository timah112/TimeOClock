using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeOClock.Bean
{
    class UserCommentsBean
    {
        private UserCommentsBean()
        {
        }
        private static UserCommentsBean userCommentsBeanInstance = null;
        public static UserCommentsBean getUserCommentsInstance()
        {
            if (userCommentsBeanInstance == null)
            {
                userCommentsBeanInstance = new UserCommentsBean();
            }
            return userCommentsBeanInstance;
        }

        private string comment;

        public string getComments()
        {
            return comment;
        }
        public void setComment(String comment)
        {
            this.comment = comment;
        }
    }
}
