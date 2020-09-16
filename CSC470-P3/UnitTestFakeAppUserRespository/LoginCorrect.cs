using System;
using CSC470_P3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFakeAppUserRespository
{
    [TestClass]
    public class LoginCorrect
    {
        [TestMethod]
        public void LoginWithCorrectCredentialsSuccessful()
        {
            //Arange
            const string UserName = "Dbishop";
            const string Password = "P@ssword";
            FakeAppUserRepository userRepository = new FakeAppUserRepository();
            const bool expectedLogin = true;
            
            //Act
            bool actualLogin = userRepository.Login(UserName, Password);

            //Assert
            Assert.AreEqual(expectedLogin, actualLogin);
        }
    }
}
