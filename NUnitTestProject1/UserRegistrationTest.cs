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
        public void ValidateFirstName()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidateFirstName("Soumen");
            Assert.IsTrue(result);
        }

        [Test]
        public void ValidateLastName()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidateLastName("Ghosh");
            Assert.IsTrue(result);
        }

        [Test]
        public void ValidateEmailAddress()
        {
            UserRegistrstionMain userregistration = new UserRegistrstionMain();
            bool result = userregistration.ValidateEmailAddress("soumentaki1996@gmail.com");
            Assert.IsTrue(result);
        }
    }
}