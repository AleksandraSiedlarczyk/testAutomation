using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Herokuapp.Pages
{
    public class BasePage
    {
        protected static IWebDriver _webDriver;

        public BasePage(IWebDriver driver)
        {
            _webDriver = driver;
            PageFactory.InitElements(driver, this);
        }

        public bool IsDisplayed(IWebElement item)
        {
            try
            {
                return item.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

    }
}