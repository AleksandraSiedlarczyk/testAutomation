using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Herokuapp.Pages
{
    public class DynamicLoadingPage : BaseLoadingPage
    {
        [FindsBy(How = How.CssSelector, Using = "#start button")]
        public IWebElement StartBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#finish h4")]
        public IWebElement FinishMsg { get; set; }

        private const string URL = @"http://the-internet.herokuapp.com/dynamic_loading/1";

        public DynamicLoadingPage(IWebDriver driver) : base(driver)
        {
        }

        public void Navigate()
        {
            _webDriver.Navigate().GoToUrl(URL);
        }

        public void StartLoading()
        {
            StartBtn.Click();
        }

        public bool IsMessageDisplayed(string msgText)
        {
            return FinishMsg.Text.Equals(msgText);
        }

    }
}