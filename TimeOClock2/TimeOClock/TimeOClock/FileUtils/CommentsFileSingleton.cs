using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TimeOClock.FileUtils
{
    class CommentsFileSingleton
    {

        private String commentsFileLocation = @"C:\Users\Public\user_comments.txt";
        private static CommentsFileSingleton commentsFileInstance = null;

        private CommentsFileSingleton()
        {
        }

        public String getTimeFileLocation()
        {
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (!File.Exists(commentsFileLocation))
                {
                    // Create a new file     
                    using (FileStream fs = File.Create(commentsFileLocation))
                    {

                    }
                }

            }
            catch (IOException)
            {
                MessageBox.Show("File could not be instantiated. Please create new File: " + commentsFileLocation);
            }
            return commentsFileLocation;
        }
        public static CommentsFileSingleton getCommentsInstance()
        {
            if (commentsFileInstance == null)
            {
                commentsFileInstance = new CommentsFileSingleton();
            }
            return commentsFileInstance;
        }

    }
}
