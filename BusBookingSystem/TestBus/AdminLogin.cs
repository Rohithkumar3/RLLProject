using System.ComponentModel.DataAnnotations;


namespace TestBus
{
  public class AdminLogin
    {
        public bool Login(string userID, string password)
        {
            return userID == "AD123" && password == "Admin@123";
        }
    }
    [TestFixture]
    public class AdminLoginTest
    {
        [Test]
        public void SuccessfullLogin()
        {
            var adminlogin=new AdminLogin();
            bool result = adminlogin.Login("AD123", "Admin@123");
            Assert.IsTrue(result);
        }
        [Test]
        public void UnSuccessfullIDLogin()
        {
            var adminlogin = new AdminLogin();
            bool result = adminlogin.Login("AD789", "Admin@123");
            Assert.IsFalse(result);
        }
        [Test]
        public void UnSuccessfullPasswordLogin()
        {
            var adminlogin = new AdminLogin();
            bool result = adminlogin.Login("AD123", "Admin@789456");
            Assert.IsFalse(result);
        }
    }
}


