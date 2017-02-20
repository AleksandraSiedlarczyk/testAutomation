using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Herokuapp.Pages
{
    public class HomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/ul/li[2]/a")]
        public IWebElement BasicAuthLink { get; set; }

        private const string URL = @"http://the-internet.herokuapp.com/";
        private const string LOGIN_URL = @"http://admin:admin@the-internet.herokuapp.com/basic_auth";

        public HomePage(IWebDriver driver) : base(driver)
        {
        }
        public void Navigate()
        {
            _webDriver.Navigate().GoToUrl(URL);
        }

        public void LoginCorrectly()
        {
            _webDriver.Navigate().GoToUrl(LOGIN_URL);
        }

    }
}