using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace SeleniumUiTest.Initiate
{
    public static class Startup
    {
        public static IWebDriver WebDriver;
        public static IConfiguration Configuration;

        public static IConfigurationRoot BuildConfiguration()
        {
            return new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false, true)
                .Build();
        }

        public static IWebDriver StartWebDriver()
        {
            var service = ChromeDriverService.CreateDefaultService(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            var webDriver = new ChromeDriver(service);
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            return webDriver;
        }
    }
}