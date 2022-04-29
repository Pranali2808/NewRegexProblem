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
            try
            {
                //Arrange
                RegexValidate user = new RegexValidate();
                string firstName = "Pranali";
                //Act
                bool result = user.ValidateFirstName(firstName);
            }
            catch (InvalidUserDetailsCustomException e)
            {
                //Assert
                Assert.AreEqual("Invalid password.", e.Message);
            }
        }

        [TestMethod]
        public void LastNameTest()
        {
            try
            {
                //Arrange
                RegexValidate user = new RegexValidate();
                string lastName = "Rane";
                //Act
                bool result = user.ValidateLastName(lastName);
            }
            catch (InvalidUserDetailsCustomException e)
            {
                //Assert
                Assert.AreEqual("Invalid password.", e.Message);
            }
        }

        [TestMethod]
        public void EmailIdTest()
        {
            try
            {
                //Arrange
                RegexValidate user = new RegexValidate();
                string email = "ranepranali1997@gmail.com";
                //Act
                bool result = user.ValidateEmail(email);
            }
            catch (InvalidUserDetailsCustomException e)
            {
                //Assert
                Assert.AreEqual("Invalid password.", e.Message);
            }
        }

        [TestMethod]
        public void MobileNumberTest()
        {
            try
            {
                //Arrange
                RegexValidate user = new RegexValidate();
                string mobileNumber = "91 9130679234";
                //Act
                bool result = user.ValidateMobileNo(mobileNumber);
            }
            catch (InvalidUserDetailsCustomException e)
            {
                //Assert
                Assert.AreEqual("Invalid password.", e.Message);
            }
        }

        [TestMethod]
        public void PasswordTest()
        {
            try
            {
                //Arrange
                RegexValidate user = new RegexValidate();
                string password = "Pranali@123";
                //Act
                bool result = user.ValidatePassword(password);
            }
            catch (InvalidUserDetailsCustomException e)
            {
                //Assert
                Assert.AreEqual("Invalid password.", e.Message);
            }
        }
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void ValidateMultipleEmailsTest(string email)
        {
            //Arrange
            RegexValidate user = new RegexValidate();
            //Act
            bool result = user.ValidateEmailSamples(email);
            //Assert
            Assert.IsTrue(result);
        }
    }
}

