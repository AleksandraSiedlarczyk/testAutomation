using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace Herokuapp.Acceptance.Tests.Steps
{
    [Binding]
    public class SetupSteps
    {
        public static IWebDriver WebDriver;

        [BeforeScenario]
        public static void Setup()
        {
            WebDriver = new FirefoxDriver();
            WebDriver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public static void TearDown()
        {
            if (WebDriver != null)
            {
                WebDriver.Close();
            }
        }

    }
}