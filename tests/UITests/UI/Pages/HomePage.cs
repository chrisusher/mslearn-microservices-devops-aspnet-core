using TestingSupport.PlaywrightHelpers.Common;

namespace UITests.UI.Pages
{
    public class HomePage : BasePage
    {
        public static WebElement BasketButton
        {
            get
            {
                return new WebElement(By.ClassName("esh-basketstatus-badge"));
            }
        }

        public static WebElement BrandSelector
        {
            get
            {
                return new WebElement(By.Id("brand"));
            }
        }

        public static WebElement FilterButton
        {
            get
            {
                return new WebElement(By.Id("btnFilterResults"));
            }
        }

        public new static bool OnPage 
        {
            get
            {
                var item = Common.Page.WaitForSelectorAsync(By.ClassName("esh-catalog-thumbnail-wrapper").Locator).Result;

                if(item == null)
                {
                    return false;
                }
                if(item.IsVisibleAsync().Result)
                {
                    return true;
                }
                return false;
            }
        }
    }
}