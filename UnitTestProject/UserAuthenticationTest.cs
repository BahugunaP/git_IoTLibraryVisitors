using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using IoTSolutionsBAL;
using Entities;


namespace UnitTestProject
{
    [TestClass]
    public class UserAuthenticationTest
    {
        [TestMethod]
        public void UpdateUser()
        {
            UserDetail userDetail = new UserDetail();
            userDetail.UserName = "Test1";
            userDetail.Email = "test1@gmail.com";

            Mock<UserOperationsBAL> auth = new Mock<UserOperationsBAL>();
            auth.Setup(x => x.IsUserExists(1)).Returns(true);

            Assert.IsTrue(string.Equals(userDetail.UserName, "Test1"), "Both Strings Are Equal");
            //TODO: Dependency Injection and Mocking is required before doing unit testing 
        }
    }
}
