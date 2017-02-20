using Herokuapp.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Herokuapp.Acceptance.Tests.Steps
{
    [Binding]
    public class DynamicControlsSteps : SetupSteps
    {
        private DynamicControlsPage _dynamicControlsPage = new DynamicControlsPage(WebDriver);

        [Given(@"dynamic controls page is loaded")]
        public void GivenDynamicControlsPageIsLoaded()
        {
            _dynamicControlsPage.Navigate();
        }

        [Given(@"checkbox is removed")]
        public void GivenCheckboxIsRemoved()
        {
            WhenIRemoveCheckbox();
            ThenCheckboxIsNotDisplayed();
        }

        [When(@"I remove checkbox")]
        public void WhenIRemoveCheckbox()
        {
            _dynamicControlsPage.RemoveCheckbox();
            _dynamicControlsPage.WaitTillLoadingEnd();
        }

        [When(@"I add checkbox")]
        public void WhenIAddCheckbox()
        {
            _dynamicControlsPage.AddCheckbox();
            _dynamicControlsPage.WaitTillLoadingEnd();
        }

        [Then(@"checkbox is not displayed")]
        public void ThenCheckboxIsNotDisplayed()
        {
            Assert.IsFalse(_dynamicControlsPage.IsCheckboxDislayed());
            Assert.IsTrue(_dynamicControlsPage.IsAfterRemovalMsgDisplayed());
        }

        [Then(@"checkbox is displayed")]
        public void ThenCheckboxIsDisplayed()
        {
            Assert.IsTrue(_dynamicControlsPage.IsCheckboxDislayed());
            Assert.IsTrue(_dynamicControlsPage.IsAfterAddingMsgDisplayed());
        }

    }
}