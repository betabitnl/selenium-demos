using System.IO;

namespace SeleniumUiTest.Initiate
{
    public static class UrlService
    {
        public static void NavigateTo(string urlExtension = "")
        {
            Startup.WebDriver.Navigate().GoToUrl(Path.Combine(Startup.Configuration["baseUrl"], urlExtension));
        }
    }
}
