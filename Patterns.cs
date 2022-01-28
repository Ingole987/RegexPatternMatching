using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexMatching
{
    class Patterns
    {
        //public static string regex = "^([A-Za-z0-9]+[.#+_])*[A-Za-z0-9]+[@][A-Za-z]+[.][A-Za-z]{2,3}([.][A-Za-z]{2})?$";
        //public static string RegexRulesFor3char = "^([0-9]*[a-zA-Z]{3,})[0-9a-zA-Z]*$";
        //public static string Regex_Pincode = "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        //public static string regex = "^[0-9]*[A-Za-z]{3,}[0-9A-Za-z]*$";
        //public static string regex = "^[1-9][0-9]{5}$";
        //public static string regex = "^[1-9][0-9]{2}[ ]?[0-9]{3}$";
        //public static string regex = "^[A-Za-z0-9]+[@][A-Za-z]+[.][a-z]{3}$";
        //public static string regex = "^[A-Za-z0-9]+([.#_+][A-Za-z0-9]+)*[@][A-Za-z]+[.][a-z]{2,3}([.][a-z]{2})?$";
        
        public static string REGEX_FIRSTNAME = "^[A-Z][a-zA-Z]*$";
        public bool validateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, REGEX_FIRSTNAME);
        }

        public static string REGEX_LASTNAME = "^[A-Z][a-zA-Z]*$";
        public bool validateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, REGEX_LASTNAME);
        }

        public static string REGEX_EMAILID = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        public bool validateEmailId(string EmailId)
        {
            return Regex.IsMatch(EmailId, REGEX_EMAILID);
        }

        public static string REGEX_PHONENUMBER = @"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}$";
        public bool validatePhoneNumber(string PhoneNumber)
        {
            return Regex.IsMatch(PhoneNumber, REGEX_PHONENUMBER);
        }

        public static string REGEX_PASSWORD = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*])[A-Za-z0-9!@#$%^&*]{8,20}$";
        public bool validatePassword(string sample)
        {
            return Regex.IsMatch(sample, REGEX_PASSWORD);
        }
    }
}
