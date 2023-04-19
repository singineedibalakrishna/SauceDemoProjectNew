using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoProject.Utility
{
    class UtilityClass: BasePage
    {

        public void Wait_ForElementClickable(IWebDriver driver, string xpath)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(200));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(xpath)));
        }

        public void Wait_ForElementVisible(IWebDriver driver, string xpath)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(200));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
        }
    }
}
