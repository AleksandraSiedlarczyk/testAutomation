using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Herokuapp.Pages
{
    public class BasePage
    {
        protected static IWebDriver WebDriver;

        public BasePage(IWebDriver driver)
        {
            WebDriver = driver;
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