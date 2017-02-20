using Herokuapp.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Herokuapp.Acceptance.Tests.Steps
{
    [Binding]
    public class DynamicLoadingSteps : SetupSteps
    {
        private DynamicLoadingPage _dynamicLoadingPage = new DynamicLoadingPage(WebDriver);

        [Given(@"dynamic loading page is loaded")]
        public void GivenDynamicLoadingPageIsLoaded()
        {
            _dynamicLoadingPage.Navigate();
        }
        
        [When(@"I start loading")]
        public void WhenIStartLoading()
        {
            _dynamicLoadingPage.StartLoading();
        }
        
        [Then(@"a loading bar appears")]
        public void ThenALoadingBarAppears()
        {
            Assert.IsTrue(_dynamicLoadingPage.IsLoadingBarDislayed());            
        }
        
        [Then(@"""(.*)"" message is displayed")]
        public void ThenMessageIsDisplayed(string msg)
        {
            _dynamicLoadingPage.WaitTillLoadingEnd();
            Assert.IsTrue(_dynamicLoadingPage.IsMessageDisplayed(msg));
        }

    }
}