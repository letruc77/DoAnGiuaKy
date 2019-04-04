using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTestWebApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLogin()
        {
            string UserName = "letruc9394@gmail.com";
            string PassWord = " Sa@123456";
            AccountController account = new AccountController();
            LoginViewModel model = new LoginViewModel();
            model.Email = UserName;
            model.Password = PassWord;
            model.RememberMe = true;
            Assert(account.Login(model, returnUrl = null),true);

        }
    }
}
