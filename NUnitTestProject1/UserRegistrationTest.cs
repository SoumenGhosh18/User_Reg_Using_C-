using NUnit.Framework;
using UserRegistrationProj;

namespace NUnitTestProject1
{
    public class UserRegistrationTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void When_Follow_Correct_PatternOf_FirstName_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidateFirstName("Soumen");
            Assert.IsTrue(result);
        }

        [Test]
        public void When_Follow_Correct_PatternOf_LastName_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidateLastName("Ghosh");
            Assert.IsTrue(result);
        }

        [Test]
        public void When_Follow_Correct_PatternOf_Email_Address_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidateEmailAddress("soumentaki1996@gmail.com");
            Assert.IsTrue(result);
        }

        [Test]
        public void When_Follow_Correct_PatternOf_Mobile_No_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidateMobileNumber("+919932619681");
            Assert.IsTrue(result);
        }

        [Test]
        public void When_Follow_Correct_PatternOf_Password_Rule1_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidatePasswordRule1("soumengh");
            Assert.IsTrue(result);
        }

        [Test]
        public void When_Follow_Correct_PatternOf_Password_Rule2_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidatePasswordRule2("Soumengh");
            Assert.IsTrue(result);
        }

        [Test]
        public void When_Follow_Correct_PatternOf_Password_Rule3_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidatePasswordRule3("Soumengh18");
            Assert.IsTrue(result);
        }

        [Test]
        public void When_Follow_Correct_PatternOf_Password_Rule4_Should_Pass()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidatePasswordRule4("Soumengh18@");
            Assert.IsTrue(result);
        }

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