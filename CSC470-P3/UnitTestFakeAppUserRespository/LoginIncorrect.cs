using System;
using CSC470_P3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFakeAppUserRespository
{
    [TestClass]
    public class LoginIncorrect
    {
        [TestMethod]
        public void LoginWithIncorrectCredentialsFail()
        {
            //Arange
            const string UserName = "Bbishop";
            const string Password = "P@ssword";
            FakeAppUserRepository userRepository = new FakeAppUserRepository();
            const bool expectedLogin = false;

            //Act
            bool actualLogin = userRepository.Login(UserName, Password);

            //Assert
            Assert.AreEqual(expectedLogin, actualLogin);
        }
    }
}
