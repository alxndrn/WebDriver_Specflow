/*
 * 2.Navigate to the following URL:
 * https://login.bluehost.com/hosting/webmail
 * Try to login with incorrect e-mail and password. Verify that the
 * login is rejected.
 * Make another test, but this time try to login without entering
 * values in the e-mail and password fields. Verify that the user is
 * prompted to fill in the empty fields.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using WebDriver_Specflow_Task_2.Pages;

namespace WebDriver_Specflow_Task_2.Steps
{
    [Binding]
    public class WebmailLoginSteps
    {
        private LoginPage loginPage;

        public WebmailLoginSteps()
        {
            loginPage = new LoginPage();
        }
        ~WebmailLoginSteps()
        {
            loginPage = null;
        }

        [Given(@"Webmail login form is opened")]
        public void GivenWebmailLoginFormIsOpened()
        {
            loginPage.Open();
        }
        
        [When(@"I enter wrong Email")]
        public void WhenIEnterWrongEmail()
        {
            loginPage.enterEmail("test");
        }
        
        [When(@"I enter wrong Password")]
        public void WhenIEnterWrongPassword()
        {
            loginPage.enterPassword("test");
        }
        
        [When(@"I click Log in button")]
        public void WhenIClickLogInButton()
        {
            loginPage.clickLogInButton();
        }
        
        [Then(@"Invalid login attempt error message is displayed")]
        public void ThenInvalidLoginAttemptErrorMessageIsDisplayed()
        {
            Assert.IsTrue(loginPage.isInvalidLoginAttemptErrorMessageDisplayed());
        }
        
        [Then(@"Credentials required error messages are displayed")]
        public void ThenCredentialsRequiredErrorMessagesAreDisplayed()
        {
            Assert.IsTrue(loginPage.isEmailIsRequiredErrorMessageDisplayed());
            Assert.IsTrue(loginPage.isPasswordIsRequiredErrorMessageDisplayed());
        }
    }
}
