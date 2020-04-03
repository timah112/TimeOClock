using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TimeOClock.FileUtils
{
    class UserFileSingleton
    {

        public String userFileLocation = @"C:\Users\Public\User_Information.txt";
        private static UserFileSingleton userFileInstance = null;
        private UserFileSingleton()
        {
        }
        public String getUserFileLocation()
        {
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (!File.Exists(userFileLocation))
                {
                    // Create a new file     
                    using (FileStream fs = File.Create(userFileLocation))
                    {

                    }
                }

            }
            catch (IOException)
            {
                MessageBox.Show("File could not be instantiated. Please create new File: " + userFileLocation);
            }
            return userFileLocation;
        }

        public static UserFileSingleton getUserFileInstance()
        {
            if (userFileInstance == null)
            {
                userFileInstance = new UserFileSingleton();
            }
            return userFileInstance;
        }

     

    }
}
