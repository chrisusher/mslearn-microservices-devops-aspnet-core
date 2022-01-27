using System.Linq;
using Microsoft.Playwright;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TestingSupport.Common.Utilities;
using TestingSupport.PlaywrightHelpers.Common;
using UITests.UI.Pages;

namespace UITests.Steps
{
    [Binding]
    public class HomePageSteps
    {
        private ScenarioContext _scenarioContext;

        public HomePageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        
        [When("I add an Item")]
        public void WhenIAddAnItem()
        {
            WaitUtility.WaitFor(() => HomePage.OnPage, "Home Page to show items from the Catalog");

            var item = Common.Page.QuerySelectorAllAsync(By.ClassName("esh-catalog-thumbnail-wrapper").Locator).Result
                .FirstOrDefault();

            if(item != null)
            {
                _ = item.ClickAsync();
            }
        }

        [When("I set the Brand to '(.*)'")]
        public void WhenISetTheBrandTo(string brandName)
        {
            _ = Common.Page.ClickAsync(HomePage.BrandSelector.By.Locator);

            _ = Common.Page.SelectOptionAsync(HomePage.BrandSelector.By.Locator, new SelectOptionValue
            {
                Label = brandName
            }).Result;
        }

        [When("I click Apply on the Results Filter")]
        public void WhenIApplyTheResultFilter()
        {
            HomePage.FilterButton.Click();
        }

        [Then("There are (.*) Catalog Items visible")]
        public void ThenThereAreXCatalogItemsVisible(int visibleItems)
        {
            var items = Common.Page.QuerySelectorAllAsync(By.ClassName("esh-catalog-thumbnail-wrapper").Locator).Result;

            Assert.AreEqual(visibleItems, items.Count, "Incorrect number of Items visible");
        }
    }
}