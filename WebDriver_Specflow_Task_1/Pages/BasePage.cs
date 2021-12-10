using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebDriver_Specflow_Task_1.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver Driver;
        protected WebDriverWait DriverWait;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            // wait 30 seconds.
            DriverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
        }

        ~BasePage()
        {
            DriverWait = null;
            Driver?.Quit();
        }

        public virtual string Url => string.Empty;

        public virtual void Open(string part = "")
        {
            if (string.IsNullOrEmpty(Url))
            {
                throw new ArgumentException("The main URL cannot be null or empty.");
            }

            Driver.Navigate().GoToUrl(string.Concat(Url, part));
        }
    }
}
