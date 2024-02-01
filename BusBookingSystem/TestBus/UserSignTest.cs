using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBus
{
   
    public class UserSignTest
    {
        public bool Login(string userID,string password)
        {
            return userID == "1234" && password == "Mah@12345";
        }
    }
    [TestFixture]
    
    public class UserLogin
    {
        [Test]
        public void SuccessfulLoginTest()
        {
            var userSignTest = new UserSignTest();
            bool result = userSignTest.Login("1234", "Mah@12345");
            Assert.IsTrue(result);
        }
        [Test]
        public void InvalidIdTest() 
        {
            var userSignTest = new UserSignTest();
            bool result = userSignTest.Login("5555", "Mah@12345");
            Assert.IsFalse(result);
        }
        [Test]
        public void InvalidPasswordTest()
        {
            var userSignTest = new UserSignTest();
            bool result = userSignTest.Login("1234", "Ravi@12345");
            Assert.IsFalse(result);
        }
    }
}
