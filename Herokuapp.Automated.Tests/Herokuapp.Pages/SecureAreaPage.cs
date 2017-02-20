using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Herokuapp.Pages
{
    public class SecureAreaPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "flash")]
        public IWebElement SuccessFlash { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.example h4.subheader")]
        public IWebElement SuccessMsg { get; set; }        

        public SecureAreaPage(IWebDriver driver) : base(driver)
        {
        }

        public bool IsSuccessMsgDisplayed()
        {
            string message = "Welcome to the Secure Area. When you are done click logout below.";
            return IsDisplayed(SuccessFlash) && SuccessMsg.Text.Equals(message);
        }

    }
}