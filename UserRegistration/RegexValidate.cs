using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class RegexValidate
    {
        //We are using this method to match pattern of first name and
        public static string FirstName(string name)
        {
            string firstname = "^[A-Z]{1}[a-zA-Z]{2}$";      //Expression for first letter is capital and maximum charactor is 3
            Regex regex = new Regex(firstname);

            if (regex.IsMatch(name))
            {
                //Console.WriteLine(name + " is valid name");
                return "valid";
            }
            else
            {
                //Console.WriteLine(name + " is invalid.\n Please Enter First name start with capital letter and maximum 3 characters");
                return "invalid";
            }
           
        }
     
        //We are using this method to match pattern of last name
        public static string LastName(string name)
        {
            string lastname = "^[A-Z]{1}[a-zA-Z]{2}$";      //Expression for first letter is capital and maximum charactor is 3
            Regex regex = new Regex(lastname);

            if (regex.IsMatch(name))
            {
                //Console.WriteLine(name + " is valid name");
                return "valid";
            }
            else
            {
                //Console.WriteLine(name + " is invalid.\n Please Enter Last name start with capital letter and maximum 3 characters");
                return "invalid";
            }
        }
        //This method for validation of email id
        public static string EmailValid(string mail)
        {
            string emailid = "^[a-zA-Z0-9]+[+-._]{0,1}[a-zA-Z0-9]*[+-._]?[a-zA-Z0-9]*[@][a-zA-Z0-9]+[.][a-zA-Z0-9]{2,3}([.]?[a-zA-Z]{2,3}){0,1}$";
            Regex regex = new Regex(emailid);

            if (regex.IsMatch(mail))
            {
                //Console.WriteLine("Email Id is valid");
                return "valid";
            }
            else
            {
                //Console.WriteLine("Email Is Invalid,Please Enter Valid email Id\n Refer and try again: abc.xyz@bl.co.in");
                return "invalid";
            }

        }
        //This method will check whether phone no is valid or not
        public static string MobileNumValid(string number)
        {
            //Regular expression of mobile number
            string Mobnumber = "^[0-9]{1,2}[ ]{1}[0-9]{10}$";
            Regex regex = new Regex(Mobnumber);

            if (regex.IsMatch(number))
            {
                //Console.WriteLine("Mobile Number is valid");
                return "valid";
            }
            else
            {
                //Console.WriteLine("Mobile number is Invalid,Please Enter Valid MObile Number format.");
                return "invalid";
            }

        }
        public static string PassWord(string pass)
        {
            string pwd = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$";
            Regex regex = new Regex(pwd);                                           //creating a regex named obj with regular pwd.
            if (regex.IsMatch(pass))
            {
                //Console.WriteLine(pass + " is valid.");
                return "valid";
            }
            else
                //Console.WriteLine(pass + " is invalid. Password must contain atleast one capital letter,one number,one special character");
                return "invalid";
            }

        //created array to check valid email ID.
        public static void EmailArr(string[] name)
        {
            string email = "^[a-zA-Z0-9]+[+-._]{0,1}[a-zA-Z0-9]*[+-._]?[a-zA-Z0-9]*[@][a-zA-Z0-9]+[.][a-zA-Z0-9]{2,3}([.]?[a-zA-Z]{2,3}){0,1}$";
            //+ means one or more.
            //*- zero or more.
            //?- zero or 1 

            Regex regex = new Regex(email);            //creating a regex named obj with regular exp email.
            foreach (var word in name)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word + " is valid.");
                }
                else
                    Console.WriteLine(word + " is invalid.");
            }

        }

    }
}
