using Herokuapp.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Herokuapp.Acceptance.Tests.Steps
{
    [Binding]
    public class SortableDataTablesSteps : SetupSteps
    {
        private SortableTablesPage _sortableTablesPage = new SortableTablesPage(WebDriver);
        private string _email;

        [Given(@"sortable data tables page is loaded")]
        public void GivenSortableDataTablesPageIsLoaded()
        {
            _sortableTablesPage.Navigate();
        }

        [When(@"I get ""(.*)"" email")]
        public void WhenIGetEmail(string name)
        {
            _email = _sortableTablesPage.GetEmailOf(name);
        }

        [Then(@"is equals to ""(.*)""")]
        public void ThenIsEqualsTo(string expectedEmail)
        {
            Assert.AreEqual(expectedEmail, _email);
        }

    }
}