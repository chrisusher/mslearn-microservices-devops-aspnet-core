using System;
using Microsoft.Playwright;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TestingSupport.Common.Utilities;
using TestingSupport.PlaywrightHelpers.Common;
using UITests.UI.Pages;
using UITests.UI.Pages.Ordering;

namespace UITests.Steps.Ordering
{
    [Binding]
    public class OrderingSteps
    {
        private ScenarioContext _scenarioContext;

        public OrderingSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When("I navigate to My Shopping Bag")]
        public void WhenINavigateToMyShoppingBag()
        {
            HomePage.BasketButton.Click();
        }

        [When("I complete the Checkout")]
        public void WhenICompleteTheCheckout()
        {
            WaitUtility.WaitFor(() => BasketPage.OnPage, "Basket Page to Load");

            while(BasketPage.OnPage)
            {
                BasketPage.CheckoutButton.Click();
            }
            PlaceOrderPage.CardExpiryTextbox.SendKeys("12/22");
            PlaceOrderPage.PlaceOrderButton.Click();   
        }

        [Then("My order appears in My Order List")]
        public void ThenMyOrderAppearsInMyOrderList()
        {
            _ = Common.Page.WaitForSelectorAsync(By.ClassName("esh-orders-item").Locator, new PageWaitForSelectorOptions
            {
                Timeout = (float)TimeSpan.FromSeconds(2).TotalMilliseconds
            }).Result;

            var orderRows = Common.Page.QuerySelectorAllAsync(By.ClassName("esh-orders-item").Locator).Result;

            Assert.IsTrue(orderRows.Count > 0, "My order has not appeared on My Orders Page");
        }
    }
}