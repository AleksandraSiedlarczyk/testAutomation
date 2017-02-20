using Herokuapp.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Herokuapp.Acceptance.Tests.Steps
{
    [Binding]
    public class FormAuthSteps : SetupSteps
    {
        private FormAuthPage _formAuthPage = new FormAuthPage(WebDriver);
        private SecureAreaPage _secureAreaPage = new SecureAreaPage(WebDriver);

        [Given(@"form authentication page is loaded")]
        public void GivenFormAuthenticationPageIsLoaded()
        {
            _formAuthPage.Navigate();
        }

        [When(@"I log in with ""(.*)"" username and ""(.*)"" password")]
        public void WhenILogInWithUsernameAndPassword(string login, string pass)
        {
            _formAuthPage.Login(login, pass);
        }

        [Then(@"a secure area opens")]
        public void ThenASecureAreaOpens()
        {
            Assert.IsTrue(_secureAreaPage.IsSuccessMsgDisplayed());
        }

        [Then(@"an invalid username message opens")]
        public void ThenAnInvalidUsernameMessageOpens()
        {
            Assert.IsTrue(_formAuthPage.IsInvalidUsernameMsgDisplayed());
        }

        [Then(@"an invalid password message opens")]
        public void ThenAnInvalidPasswordMessageOpens()
        {
            Assert.IsTrue(_formAuthPage.IsInvalidPasswordMsgDisplayed());
        }

    }
}