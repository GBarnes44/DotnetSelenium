using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DotnetSelenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.com");
            driver.Manage().Window.Maximize();
            //IWebElement searchBox = driver.FindElement(By.Name("q"));
            SeleniumCustomMethods.Click(driver, By.Id("twotabsearchtextbox")); 
            //searchBox.SendKeys("selenium");
            SeleniumCustomMethods.EnterText(driver, By.Id("twotabsearchtextbox"), "selenium");
            //searchBox.SendKeys(Keys.Return);
            SeleniumCustomMethods.Submit(driver, By.Id("twotabsearchtextbox"));

            //IWebElement LoginLink = driver.FindElement(By.LinkText("Gmail"));
            //LoginLink.Click();

            
        }
    }
}
