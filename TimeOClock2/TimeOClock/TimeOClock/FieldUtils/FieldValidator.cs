using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeOClock.FieldUtils
{
    class FieldValidator
    {
        static string specialChar = @"\|!#$%&/()=?»«@£§€{}-;'<>_,";
        static FormRegisterGroupBox formRegister = new FormRegisterGroupBox();
        public static Boolean is_LettersOnly(String str)
        {
            foreach (char c in str)
            {
                if (Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
            //return obj.GetType() == typeof(string) ? true : false;         
        }

        public static Boolean is_Int(String str)
        {
            foreach(char c in str){
                if (Char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
            //return obj.GetType() == typeof(int) ? true : false;
        }

        public static Boolean containsSpecialCharactersInNum(String str)
        {
            foreach (var item in specialChar)
            {
                if (str.Contains(item)) return false;
            }
            return true;
        }
        public static Boolean containsSpecialCharactersInStr(String str)
        {
            char[] strArray = str.ToCharArray();
            for (int i = 0; i < strArray.Length; i++)
            {
                if (!Char.IsLetter(strArray[i]))
                {
                    return false;
                }

            }
            return true;
        }

        public static Boolean isEmailFormatCorrect(String email)
        {
            return (!email.Contains("@")) ? false : true;
            
        }

        public static Boolean isPhoneFieldCorrect(String phone)
        {           
            foreach (var item in specialChar)
            {
                if (phone.Contains(item)) return false;
            }
            if(phone.Length < 10 || phone.Length > 12)
            {
                return false;
            }
            if (!is_Int(phone))
            {
                return false;
            }

            return true;
        }

        public static Boolean verifyPassword(String password)
        {
            if(password.Length < 6)
            {                
                formRegister.errorLabel.Text = "Please ensure the password length is atleast 6 characters long";
                return false;
            }
            return true;
        }


        public static String isSalaryAnnualOrHourly(String salary)
        {
            long salaryNum = Int64.Parse(salary);

            if (salaryNum > 1000)
            {
                return " / Year";
            }
            else
            {
                return " / Hour";
            }
        }

        public static Boolean verifyPin(int pin)        
        {
           // formRegister.errorLabel.Visible = true;
            Boolean isNumNonConsecutive = false;
            Boolean isNumDifferent = false;
            if(pin.ToString().Length < 4)
            {                
                return false;
            }
            int[] pinArr = convertNumToArr(pin);
            for(int i =0; i < pinArr.Length-1; i++)
            {
                if(pinArr[i+1] - pinArr[i] != 1 && pinArr[i + 1] - pinArr[i] != -1)
                {
                    isNumNonConsecutive = true;
                }
                if(pinArr[i] != pinArr[i + 1])
                {
                    isNumDifferent = true;
                }
            }

            return (isNumNonConsecutive && isNumDifferent) ? true : false;
        }

        public static int[] convertNumToArr(int num)
        {
            var digits = new List<int>();

            for (; num != 0; num /= 10)
                digits.Add(num % 10);

            var arr = digits.ToArray();
            Array.Reverse(arr);
            return arr;
        }       

    }
}
