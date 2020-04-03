using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TimeOClock.FileUtils
{
    class TimeFileSingleton
    {

        private String timeFileLocation = @"C:\Users\Public\User_Time_Info.txt";
        private static TimeFileSingleton timeFileInstance = null;

        private TimeFileSingleton()
        {
        }

        public String getTimeFileLocation()
        {
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (!File.Exists(timeFileLocation))
                {
                    // Create a new file     
                    using (FileStream fs = File.Create(timeFileLocation))
                    {

                    }
                }

            }
            catch (IOException)
            {
                MessageBox.Show("File could not be instantiated. Please create new File: " + timeFileLocation);
            }
            return timeFileLocation;
        }
        public static TimeFileSingleton getInstance()
        {
            if (timeFileInstance == null)
            {
                timeFileInstance = new TimeFileSingleton();
            }
            return timeFileInstance;
        }

    }
}
