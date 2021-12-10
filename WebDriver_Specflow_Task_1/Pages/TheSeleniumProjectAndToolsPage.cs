using OpenQA.Selenium;

namespace WebDriver_Specflow_Task_1.Pages
{
    class TheSeleniumProjectAndToolsPage : BasePage
    {
        public TheSeleniumProjectAndToolsPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement GridOfBrowsersLink => Driver.FindElement(By.XPath("//section/div[2]/div[3]/p[5]/a"));

        public void clickGridOfBrowsersLink()
        {
            GridOfBrowsersLink.Click();
        }
    }
}
