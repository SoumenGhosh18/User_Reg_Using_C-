using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProj
{
    public class UserRegistrstionMain
    {
        String FIRST_NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";
        String Last_NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";
        String EmailAddress = "^[a-z0-9.+_-]+[@][a-zA-Z0-9]+[.]co(m|.in)$";
        String Phone_No = "^([0]|\\+91)?[6789]\\d{9}$";

        public bool ValidateFirstName(String firstName)
        {
            return Regex.IsMatch(firstName, FIRST_NAME_PATTERN);
        }
        public bool ValidateLastName(String lastName)
        {
            return Regex.IsMatch(lastName, FIRST_NAME_PATTERN);
        }

        public bool ValidateEmailAddress(String email)
        {
            return Regex.IsMatch(email, EmailAddress);
        }

        public bool ValidateMobileNumber(String phnNo)
        {
            return Regex.IsMatch(phnNo, Phone_No);
        }

        public bool ValidatePasswordRule1(string password1)
        {
            string passwordRule1 = "([a-z]{8,14}$)";
            return Regex.IsMatch(password1, passwordRule1);
        }
    }
}
