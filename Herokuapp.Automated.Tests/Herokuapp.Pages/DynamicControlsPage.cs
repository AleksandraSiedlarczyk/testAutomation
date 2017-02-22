using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Herokuapp.Pages
{
    public class DynamicControlsPage : BaseLoadingPage
    {
        [FindsBy(How = How.Id, Using = "btn")]
        public IWebElement Btn { get; set; }

        [FindsBy(How = How.Id, Using = "checkbox")]
        public IWebElement Checkbox { get; set; }

        [FindsBy(How = How.Id, Using = "message")]
        public IWebElement Message { get; set; }

        private const string URL = @"http://the-internet.herokuapp.com/dynamic_controls";

        public DynamicControlsPage(IWebDriver driver) : base(driver)
        {
        }

        public void Navigate()
        {
            WebDriver.Navigate().GoToUrl(URL);
        }

        public void RemoveCheckbox()
        {
            if (Btn.Text.Equals("Remove"))
            {
                Btn.Click();
            }
        }

        public void AddCheckbox()
        {
            if (Btn.Text.Equals("Add"))
            {
                Btn.Click();
            }
        }

        public bool IsCheckboxDislayed()
        {
            return IsDisplayed(Checkbox);
        }

        public bool IsAfterRemovalMsgDisplayed()
        {
            string removalMsg = "It's gone!";
            return Message.Displayed && Message.Text.Equals(removalMsg);
        }

        public bool IsAfterAddingMsgDisplayed()
        {
            string addedMsg = "It's back!";
            return Message.Displayed && Message.Text.Equals(addedMsg);
        }

    }
}