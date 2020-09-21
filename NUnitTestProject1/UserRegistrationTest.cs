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
    }
}