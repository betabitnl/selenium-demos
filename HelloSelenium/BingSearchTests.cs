using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HelloSelenium
{
    public class BingSearchTests
    {
        [Test]
        public void SearchForBartosz_YieldsBarthoszPage()
        {
            using var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://bing.com");
            driver.FindElementById("sb_form_q").SendKeys("bartosz software testing\r\n");
            driver.FindElementsByCssSelector("#b_results a")[0].Click();
            Assert.AreEqual("Home - Bartosz", driver.Title);
        }
    }
}