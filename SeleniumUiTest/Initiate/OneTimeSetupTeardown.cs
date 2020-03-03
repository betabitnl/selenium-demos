using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumUiTest.Initiate;

[SetUpFixture]
public class OneTimeSetupTearDown
{
    [OneTimeSetUp]
    public void Init()
    {
        Startup.Configuration = Startup.BuildConfiguration();
        Startup.WebDriver = Startup.StartWebDriver();
        Login();
    }

    [OneTimeTearDown]
    public void Cleanup()
    {
        Startup.WebDriver.Quit();
    }

    private void Login()
    {
        UrlService.NavigateTo();
        var webDriver = Startup.WebDriver;
        var nameField = webDriver.FindElement(By.XPath("//input[@placeholder='Enter a name']"));
        nameField.SendKeys("Betabitter");
        var submitButton = webDriver.FindElement(By.XPath("//span[text()='Submit']"));
        submitButton.Click();
    }
}