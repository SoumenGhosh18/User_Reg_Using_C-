namespace NUnitTestProject1
{
    using NUnit.Framework;
    using UserRegistrationProj;

    /// <summary>
    /// Test Class
    /// </summary>
    public class UserRegistrationTest
    {
        /// <summary>
        ///  Method SetUp
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Test Method to validate first name
        /// </summary>
        [Test]
        public void When_Follow_Correct_PatternOf_FirstName_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidateFirstName("Soumen");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate first name
        /// </summary>
        [Test]
        public void When_Follow_InCorrect_PatternOf_FirstName_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidateFirstName("So");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate last name
        /// </summary>
        [Test]
        public void When_Follow_Correct_PatternOf_LastName_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidateLastName("Ghosh");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate last name
        /// </summary>
        [Test]
        public void When_Follow_InCorrect_PatternOf_LastName_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidateLastName("Gh");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate Email
        /// </summary>
        [Test]
        public void When_Follow_Correct_PatternOf_Email_Address_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidateEmailAddress("soumentaki1996@gmail.com");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate last name
        /// </summary>
        [Test]
        public void When_Follow_InCorrect_PatternOf_Email_Address_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidateEmailAddress("soumen.,taki1996@gmail.com");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate phone number
        /// </summary>
        [Test]
        public void When_Follow_Correct_PatternOf_Mobile_No_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidateMobileNumber("+919932619681");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate last name
        /// </summary>
        [Test]
        public void When_Follow_InCorrect_PatternOf_Mobile_No_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidateMobileNumber("+009932619681");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [Test]
        public void When_Follow_Correct_PatternOf_Password_Rule1_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidatePasswordRule1("soumengh");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [Test]
        public void When_Follow_InCorrect_PatternOf_Password_Rule1_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidatePasswordRule1("soumengh&&");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [Test]
        public void When_Follow_Correct_PatternOf_Password_Rule2_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidatePasswordRule2("Soumengh");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [Test]
        public void When_Follow_InCorrect_PatternOf_Password_Rule2_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidatePasswordRule2("soumengh##");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [Test]
        public void When_Follow_Correct_PatternOf_Password_Rule3_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidatePasswordRule3("Soumengh18");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [Test]
        public void When_Follow_InCorrect_PatternOf_Password_Rule3_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidatePasswordRule3("soumeng&#h18");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [Test]
        public void When_Follow_Correct_PatternOf_Password_Rule4_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidatePasswordRule4("Soumengh18@");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [Test]
        public void When_Follow_InCorrect_PatternOf_Password_Rule4_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidatePasswordRule4("soumengh18@");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate Email
        /// </summary>
        [Test]
        public void When_Follow_Every_Correct_PatternOf_Email_Address_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidateEmailAddress("soumentaki1996@gmail.com");
            Assert.IsTrue(result);
            bool result1 = userregistration.ValidateEmailAddress("soumen.taki1996@gmail.com");
            Assert.IsTrue(result1);
            bool result3 = userregistration.ValidateEmailAddress("soumen@gmail.com");
            Assert.IsTrue(result3);
            bool result4 = userregistration.ValidateEmailAddress("soumen1996@gmail.com");
            Assert.IsTrue(result4);
            bool result5 = userregistration.ValidateEmailAddress("soumen-taki1996@gmail.com");
            Assert.IsTrue(result5);
            bool result6 = userregistration.ValidateEmailAddress("soumen1996taki@gmail.com");
            Assert.IsTrue(result6);
            bool result7 = userregistration.ValidateEmailAddress("soumenghosh@gmail.in");
            Assert.IsTrue(result7);
            bool result8 = userregistration.ValidateEmailAddress("soumenghosh111@gmail.in");
            Assert.IsTrue(result8);
        }
    }
}