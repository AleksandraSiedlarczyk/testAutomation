using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Herokuapp.Pages
{
    public class BaseLoadingPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "loading")]
        public IWebElement Loading { get; set; } 

        public BaseLoadingPage(IWebDriver driver) : base(driver)
        {
        }

        public bool IsLoadingBarDislayed()
        {
            return IsDisplayed(Loading);
        }

        public void WaitTillLoadingEnd()
        {
            WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(30));
            wait.Until(driver => Loading.GetAttribute("style").Equals("display: none;"));
        }

    }
}