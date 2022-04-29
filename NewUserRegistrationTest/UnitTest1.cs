using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewUserRegistrationProblem;

namespace NewUserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FistNameTest()
        {
            //Arrange
            RegexValidate user = new RegexValidate();
            string firstName = "Pranali";
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void LastNameTest()
        {
            //Arrange
            RegexValidate user = new RegexValidate();
            string lastName = "Rane";
            //Act
            bool result = user.ValidateLastName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailIdTest()
        {
            //Arrange
            RegexValidate user = new RegexValidate();
            string email = "ranepranali1997@gmail.com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void MobileNumberTest()
        {
            //Arrange
            RegexValidate user = new RegexValidate();
            string mobileNumber = "91 9130679234";
            //Act
            bool result = user.ValidateMobileNo(mobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void PasswordTest()
        {
            //Arrange
            RegexValidate user = new RegexValidate();
            string password = "Pranali@123";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsTrue(result);

        }
    }
}
