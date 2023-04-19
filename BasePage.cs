using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SauceDemoProject
{
   
    public class BasePage
    {
        public IWebDriver driver = null;
        public IWebElement element = null;

        [TestInitialize]
        public void TestSetup()
        {
            //this.CloseAllBrowsers();
            //driver.Manage().Cookies.DeleteAllCookies();

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();

        }


        [TestCleanup]
        public void TestClosure()
        {
            this.CloseAllBrowsers();
        }

        public void CloseAllBrowsers()
        {
            driver.Quit();
        }


    }
}
