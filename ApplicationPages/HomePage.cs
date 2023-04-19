using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SauceDemoProject.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoProject.ApplicationPages
{
    class HomePage: BasePage
    {
        UtilityClass utilityObj = new UtilityClass();
        public string productHeader_Xpath = "//span[text()='Products']";

        public IWebElement ProductHeader_ele(IWebDriver driver, string xpath)
        {
            utilityObj.Wait_ForElementVisible(driver, xpath);
            element = driver.FindElement(By.XPath(xpath));
            return element;
        }

        public bool VerifyProductHeaderIsExist(IWebDriver driver)
        {
            IWebElement productHeader = ProductHeader_ele(driver, productHeader_Xpath);
            
                Assert.IsTrue(productHeader != null, "Product Header Is Exist");
            return true;
        }
    }
}
