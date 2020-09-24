//-----------------------------------------------------------------------
// <copyright file="UserRegistrationMain.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace UserRegistrationProj
{
    using System;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Main Class
    /// </summary>
    public class UserRegistrstionMain
    {
        /// <summary>
        /// FirstName regular expression pattern
        /// </summary>
        string FIRST_NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";

        /// <summary>
        ///  LastName regular expression pattern
        /// </summary>
        string Last_NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";

        /// <summary>
        /// Email Number regular expression pattern
        /// </summary>
        string EmailAddress = "^[a-z0-9.+_-]+[@][a-zA-Z0-9]+[.](com|in)$";

        /// <summary>
        /// Phone Number regular expression pattern
        /// </summary>
        string Phone_No = "^([0]|\\+91)?[6789]\\d{9}$";

        /// <summary>
        /// Password Number regular expression pattern
        /// </summary>
        string passwordRule1 = "([a-z]{8,14}$)";

        /// <summary>
        /// Password Number regular expression pattern
        /// </summary>
        string passwordRule2 = "^(?=.*[A-Z])(?=.*[a-z])(.{8,15})$";

        /// <summary>
        /// Password Number regular expression pattern
        /// </summary>
        string passwordRule3 = "^(?=.*[0-9])(?=.*[A-Z])(?=.*[a-z])(.{8,15})$";

        /// <summary>
        /// Password Number regular expression pattern
        /// </summary>
        string passwordRule4 = "(?=.*[0-9])(?=.*[@]{1})(?=.*[A-Z])(?=.*[a-z])(.{8,15})$";

        public bool ValidateFirstName(String firstName)
        {
            return Regex.IsMatch(firstName, this.FIRST_NAME_PATTERN);
        }
      
        public bool ValidateLastName(String lastName)
        {
            return Regex.IsMatch(lastName, this.Last_NAME_PATTERN);
        }

        public bool ValidateEmailAddress(String email)
        {
            return Regex.IsMatch(email, this.EmailAddress);
        }

        public bool ValidateMobileNumber(String phnNo)
        {
            return Regex.IsMatch(phnNo, this.Phone_No);
        }

        /// <summary>
        /// Method to validate password rule 1
        /// </summary>
        /// <param name="password"> password to validate</param>
        /// <returns>valid or invalid.</returns>   
        public bool ValidatePasswordRule1(string password1)
        {
           
            return Regex.IsMatch(password1, this.passwordRule1);
        }

        /// <summary>
        /// Method to validate password rule 1
        /// </summary>
        /// <param name="password"> password to validate</param>
        /// <returns>valid or invalid.</returns>   
        public bool ValidatePasswordRule2(string password2)
        {

            return Regex.IsMatch(password2,this.passwordRule2);
        }

        /// <summary>
        /// Method to validate password rule 1
        /// </summary>
        /// <param name="password"> password to validate</param>
        /// <returns>valid or invalid.</returns> 
        public bool ValidatePasswordRule3(string password3)
        {

            return Regex.IsMatch(password3, this.passwordRule3);
        }

        public bool ValidatePasswordRule4(string password4)
        {
            return Regex.IsMatch(password4, this.passwordRule4);
        }
    }
}
