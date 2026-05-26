using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetSelenium
{
    public class SeleniumCustomMethods
    {
        public static void Click(IWebDriver driver, By locator)

        {
            driver.FindElement(locator).Click();

        }

        public static void EnterText(IWebDriver driver, By locator, string text)

        {
            driver.FindElement(locator).Clear();
            driver.FindElement(locator).SendKeys(text);

        }

        public static void Submit(IWebDriver driver, By locator)

        {
            driver.FindElement(locator).Submit();
            

        }

        

    }
}
