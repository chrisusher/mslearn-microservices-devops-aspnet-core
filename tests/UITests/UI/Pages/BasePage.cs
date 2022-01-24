using TestingSupport.PlaywrightHelpers.Common;

namespace UITests.UI.Pages
{
    public class BasePage
    {
        public static bool OnPage 
        {
            get
            {
                return false;
            }
        }

        public static WebElement UserElementText
        {
            get
            {
                return new WebElement(By.ClassName("esh-identity-name"));
            }
        }

        public static WebElement LoginButton
        {
            get
            {
                return new WebElement(By.Id("loginButton"));
            }
        }
    }
}