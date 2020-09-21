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
    }
}
