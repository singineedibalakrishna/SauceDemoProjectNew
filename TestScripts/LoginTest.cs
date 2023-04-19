using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SauceDemoProject.ApplicationPages;
using System;

namespace SauceDemoProject
{
    [TestClass]
    public class LoginTest: BasePage
    {
        LoginPage loginPage = new LoginPage();
        HomePage homePageObj = new HomePage();

        [TestMethod]
        public void LoginWithValidUser()
        {
            //Login with valid user credentials
            loginPage.LoginToSwagLabUser(driver,"standard_user", "secret_sauce");
            Assert.IsTrue(homePageObj.VerifyProductHeaderIsExist(driver),"User is not Navigated to Product/Home Page");
            
        }
    }
}
