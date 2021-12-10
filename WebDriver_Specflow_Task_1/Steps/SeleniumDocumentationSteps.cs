/*
 * Make functional web tests using WebDriver that:
 * Navigates to
 * http://www.seleniumhq.org/docs/03_webdriver.jsp#introducing-the-selenium-webdriver-api-by-example
 * Using the tree on the left navigates to “Setting Up a
 * Selenium-WebDriver Project”
 * Verifies that the correct page is loaded
 * Clicks the “Maven download page” link
 * Verifies that the correct page is loaded
 * Think how to reuse your code.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using WebDriver_Specflow_Task_1.Pages;

namespace WebDriver_Specflow_Task_1.Steps
{
    [Binding]
    public class SeleniumDocumentationSteps
    {
        private IWebDriver driver = new FirefoxDriver();
        private IntroductionPage introductionPage;
        private TheSeleniumProjectAndToolsPage theSeleniumProjectAndToolsPage;
        private GridPage gridPage;

        public SeleniumDocumentationSteps()
        {
            introductionPage = new IntroductionPage(driver);
            theSeleniumProjectAndToolsPage = new TheSeleniumProjectAndToolsPage(driver);
            gridPage = new GridPage(driver);
        }

        ~SeleniumDocumentationSteps()
        {
            introductionPage = null;
            theSeleniumProjectAndToolsPage = null;
            gridPage = null;
        }

        [Given(@"Introduction page is opened")]
        public void GivenIntroductionPageIsOpened()
        {
            introductionPage.Open();
            driver.Manage().Window.Maximize();
        }

        [When(@"I navigate to The Selenium project and tools page")]
        public void WhenINavigateToTheSeleniumProjectAndToolsPage()
        {
            introductionPage.navigateToTheSeleniumProjectAndToolsPage();
        }
        
        [When(@"click on grid of browsers link")]
        public void WhenClickOnGridOfBrowsersLink()
        {
            theSeleniumProjectAndToolsPage.clickGridOfBrowsersLink();
        }
        
        [Then(@"assert that Grid page is opened")]
        public void ThenAssertThatGridPageIsOpened()
        {
            Assert.IsTrue(gridPage.isGridHeadingDisplayed());
        }
    }
}
