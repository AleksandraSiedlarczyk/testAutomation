using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Linq;

namespace Herokuapp.Pages
{
    public class FormAuthPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.CssSelector, Using = "form#login button.radius")]
        public IWebElement LoginBtn { get; set; }

        [FindsBy(How = How.Id, Using = "flash")]
        public IWebElement ErrorMsg { get; set; }

        private const string URL = @"http://the-internet.herokuapp.com/login";

        public FormAuthPage(IWebDriver driver) : base(driver)
        {
        }

        public void Navigate()
        {
            WebDriver.Navigate().GoToUrl(URL);
        }

        public void Login(string login, string password)
        {
            Username.SendKeys(login);
            Password.SendKeys(password);
            LoginBtn.Click();
        }

        private string GetTextFromFlash()
        {
            return ErrorMsg.Text.Split('\r').First();
        }

        public bool IsInvalidUsernameMsgDisplayed()
        {
            return GetTextFromFlash().Equals("Your username is invalid!");
        }

        public bool IsInvalidPasswordMsgDisplayed()
        {
            return GetTextFromFlash().Equals("Your password is invalid!");
        }

    }
}