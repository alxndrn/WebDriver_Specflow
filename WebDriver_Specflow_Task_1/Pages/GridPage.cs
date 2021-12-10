using OpenQA.Selenium;

namespace WebDriver_Specflow_Task_1.Pages
{
    public class GridPage : BasePage
    {
        public GridPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement GridHeading => Driver.FindElement(By.Id("grid"));

        public bool isGridHeadingDisplayed()
        {
            return GridHeading.Displayed;
        }
    }
}
