using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Herokuapp.Pages
{
    public class BasicAuthPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = ".example p")]
        public IWebElement Message { get; set; }        

        public BasicAuthPage(IWebDriver driver) : base(driver)
        {
        }

        public bool IsWelcomeMsgDisplayed()
        {
            string welcomeMsg = "Congratulations! You must have the proper credentials.";
            return Message.Text.Equals(welcomeMsg);
        }

    }
}