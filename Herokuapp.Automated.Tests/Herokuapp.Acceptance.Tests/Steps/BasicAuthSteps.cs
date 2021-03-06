﻿using Herokuapp.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Herokuapp.Acceptance.Tests.Steps
{
    [Binding]
    public class BasicAuthSteps : SetupSteps
    {
        private BasicAuthPage _basicAuthPage = new BasicAuthPage(WebDriver);

        [When(@"I log in with correct data")]
        public void WhenILogInWithCorrectData()
        {
            _basicAuthPage.LoginCorrectly();
        }        
        
        [Then(@"a success message is displayed")]
        public void ThenASuccessMessageIsDisplayed()
        {
            Assert.IsTrue(_basicAuthPage.IsWelcomeMsgDisplayed());
        }
        
    }
}