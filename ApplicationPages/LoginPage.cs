using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SauceDemoProject.Utility;
using SeleniumExtras.WaitHelpers;

namespace SauceDemoProject.ApplicationPages
{
    public class LoginPage: BasePage
    {
        public IWebElement element;
        UtilityClass utilityObj = new UtilityClass();
        HomePage homePage = new HomePage();
        public string userName_Xpath = "//input[@id = 'user-name']";
        public string password_Xpath = "//input[@id = 'password']";
        public string loginButton_Xpath = "//input[@id = 'login-button']";



        public IWebElement UserName_ele(IWebDriver driver)
        {
            utilityObj.Wait_ForElementClickable(driver,userName_Xpath);
            element = driver.FindElement(By.XPath(userName_Xpath));
            return element;
        }

        public IWebElement Password_ele(IWebDriver driver)
        {
            utilityObj.Wait_ForElementClickable(driver, password_Xpath);
            element = driver.FindElement(By.XPath(password_Xpath));
            return element;
        }

        public IWebElement loginButton_ele(IWebDriver driver)
        {
            utilityObj.Wait_ForElementClickable(driver,loginButton_Xpath);
            element = driver.FindElement(By.XPath(loginButton_Xpath));
            return element;
        }

        
               

        public void LoginToSwagLabUser(IWebDriver driver, string loginUserId, string loginPassword)
        {
            IWebElement userName = UserName_ele(driver);
            userName.Click();
            userName.SendKeys(loginUserId);
            IWebElement password = Password_ele(driver);
            password.Click();
            password.SendKeys(loginPassword);
            IWebElement loginButton = loginButton_ele(driver);
            loginButton.Click();
            //return new HomePage();
        }
    }
}
