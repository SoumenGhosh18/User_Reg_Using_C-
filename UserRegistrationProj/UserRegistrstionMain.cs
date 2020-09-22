﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProj
{
    public class UserRegistrstionMain
    {
        String FIRST_NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";
        String Last_NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";
        String EmailAddress = "^[a-z0-9.+_-]+[@][a-zA-Z0-9]+[.](com|in)$";
        String Phone_No = "^([0]|\\+91)?[6789]\\d{9}$";
        string passwordRule1 = "([a-z]{8,14}$)";
        string passwordRule2 = "^(?=.*[A-Z])(?=.*[a-z])(.{8,15})$";
        string passwordRule3 = "^(?=.*[0-9])(?=.*[A-Z])(?=.*[a-z])(.{8,15})$";
        string passwordRule4 = "(?=.*[0-9])(?=.*[@]{1})(?=.*[A-Z])(?=.*[a-z])(.{8,15})$";

        public bool ValidateFirstName(String firstName)
        {
            return Regex.IsMatch(firstName, FIRST_NAME_PATTERN);
        }

        public bool ValidateLastName(String lastName)
        {
            return Regex.IsMatch(lastName, Last_NAME_PATTERN);
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
           
            return Regex.IsMatch(password1, passwordRule1);
        }

        public bool ValidatePasswordRule2(string password2)
        {

            return Regex.IsMatch(password2, passwordRule2);
        }

        public bool ValidatePasswordRule3(string password3)
        {

            return Regex.IsMatch(password3, passwordRule3);
        }

        public bool ValidatePasswordRule4(string password4)
        {

            return Regex.IsMatch(password4, passwordRule4);
        }
    }
}
