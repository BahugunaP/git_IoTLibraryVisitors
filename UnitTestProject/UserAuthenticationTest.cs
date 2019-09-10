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

            UserOperationsBAL userOperations = new UserOperationsBAL();
            userOperations.InsertUser(userDetail);

            userDetail.UserName = "Test2";
            userDetail.Email = "test2@gmail.com";
            userOperations.InsertUser(userDetail);

            userDetail.UserName = "Test1Updated";
            userDetail.Email = "test1@gmail.com";
            userOperations.UpdateUser(userDetail);

            userDetail.Email = "bahuguna.pankaj@gmail.com";
            userOperations.DeleteUser(userDetail);
            userDetail.Email = "test1@gmail.com";
            userOperations.GetUser(userDetail.Email);
        }
    }
}
