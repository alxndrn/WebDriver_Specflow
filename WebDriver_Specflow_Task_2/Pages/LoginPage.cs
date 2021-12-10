using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriver_Specflow_Task_2.Pages
{
    public class LoginPage
    {
        private IWebDriver _driver;
        private WebDriverWait _waiter;
        private readonly string _baseUrl = "https://login.bluehost.com/hosting/webmail";

        public LoginPage()
        {
            _driver = new FirefoxDriver();
            // wait 30 seconds.
            _waiter = new WebDriverWait(_driver, new TimeSpan(0, 0, 30));
        }

        ~LoginPage()
        {
            _waiter = null;
            _driver?.Quit();
        }

        public void Open()
        {
            _driver.Navigate().GoToUrl(_baseUrl);
            _driver.Manage().Window.Maximize();
        }

        private IWebElement EmailInput => _driver.FindElement(By.Id("email"));
        private IWebElement PasswordInput => _driver.FindElement(By.Id("password"));
        private IWebElement LogInButton => _driver.FindElement(By.ClassName("btn_secondary"));
        private IWebElement EmailIsRequiredErrorMessage => _driver.FindElement(By.XPath("//span[text()='Email is required.']"));
        private IWebElement PasswordIsRequiredErrorMessage => _driver.FindElement(By.XPath("//span[text()='Password is required.']"));
        private IWebElement InvalidLoginAttemptErrorMessage => _driver.FindElement(By.XPath("//span[text()='Invalid login attempt. That account doesn't seem to be available.']"));
        public void enterEmail(string email)
        {
            EmailInput.SendKeys(email);
        }

        public void enterPassword(string password)
        {
            PasswordInput.SendKeys(password);
        }

        public void clickLogInButton()
        {
            LogInButton.Click();
        }

        public bool isInvalidLoginAttemptErrorMessageDisplayed()
        {
            return InvalidLoginAttemptErrorMessage.Displayed;
        }
        public bool isEmailIsRequiredErrorMessageDisplayed()
        {
            return EmailIsRequiredErrorMessage.Displayed;
        }
        public bool isPasswordIsRequiredErrorMessageDisplayed()
        {
            return PasswordIsRequiredErrorMessage.Displayed;
        }
    }
}
