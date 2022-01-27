using TestingSupport.PlaywrightHelpers.Common;

namespace UITests.UI.Pages.Ordering
{
    public class PlaceOrderPage : BasePage
    {
        public static WebElement PlaceOrderButton
        {
            get
            {
                return new WebElement(By.Id("btnPlaceOrder"));
            }
        }

        public static WebElement CardExpiryTextbox
        {
            get
            {
                return new WebElement(By.Id("expiryDate"));
            }
        }
    }
}