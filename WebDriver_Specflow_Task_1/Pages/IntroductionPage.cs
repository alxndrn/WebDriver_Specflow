using OpenQA.Selenium;

namespace WebDriver_Specflow_Task_1.Pages
{
    public class IntroductionPage : BasePage
    {
        public IntroductionPage(IWebDriver driver) : base(driver)
        {
        }
        public override string Url => "https://www.selenium.dev/documentation/en/introduction/";
        public IWebElement TheSeleniumProjectAndToolsMenuItem => Driver.FindElement(By.XPath("//nav/div[2]/ul/li[2]/ul/li[1]/a"));
        public void navigateToTheSeleniumProjectAndToolsPage()
        {
            TheSeleniumProjectAndToolsMenuItem.Click();
        }
    }
}
