using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Herokuapp.Pages
{
    public class BasicAuthPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = ".example p")]
        public IWebElement Message { get; set; }     
        
        private const string LOGIN_URL = @"http://admin:admin@the-internet.herokuapp.com/basic_auth";

        public BasicAuthPage(IWebDriver driver) : base(driver)
        {
        }

        public void LoginCorrectly()
        {
            WebDriver.Navigate().GoToUrl(LOGIN_URL);
        }

        public bool IsWelcomeMsgDisplayed()
        {
            string welcomeMsg = "Congratulations! You must have the proper credentials.";
            return Message.Text.Equals(welcomeMsg);
        }

    }
}