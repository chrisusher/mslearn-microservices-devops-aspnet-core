using TestingSupport.PlaywrightHelpers.Common;

namespace UITests.UI.Pages.Ordering
{
    public class BasketPage : BasePage
    {
        public static WebElement CheckoutButton
        {
            get
            {
                return new WebElement(By.Id("btnCheckout"));
            }
        }

        public static WebElement ContinueShoppingButton
        {
            get
            {
                return new WebElement(By.Id("btnContinueShopping"));
            }
        }

        public new static bool OnPage 
        {
            get
            {
                if(CheckoutButton.Displayed && ContinueShoppingButton.Displayed)
                {
                    return true;
                }
                return false;
            }
        }
    }
}