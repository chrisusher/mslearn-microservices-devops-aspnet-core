using TestingSupport.PlaywrightHelpers.Common;

namespace UITests.UI.Pages
{
    public class LoginPage : BasePage
    {
        public static bool OnLoginPage => Common.Page.Url.ToLower().Contains("/identity/Account/Login");

        public static WebElement EmailTextbox
        {
            get
            {
                return new WebElement(By.Name("Email"));
            }
        }

        public static WebElement PasswordTextbox
        {
            get
            {
                return new WebElement(By.Name("Password"));
            }
        }

        public static new WebElement LoginButton
        {
            get
            {
                return new WebElement(By.Id("loginButton"));
            }
        }
    }
}