using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumUiTest.Initiate;
using System.IO;
using System.Reflection;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var service = ChromeDriverService.CreateDefaultService(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            var webDriver = new ChromeDriver(service);

            webDriver.Navigate().GoToUrl("http://www.google.nl/");

        }
    }
}