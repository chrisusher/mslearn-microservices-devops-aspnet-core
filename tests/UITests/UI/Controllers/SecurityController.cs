using System;
using Microsoft.Playwright;
using TestingSupport.PlaywrightHelpers.Common;
using UITests.UI.Pages;

namespace UITests.UI.Controllers
{
    public class SecurityController
    {
        public static bool IsLoggedIn 
        {
            get
            {
                try
                {
                    var loginButton = Common.Page.WaitForSelectorAsync(By.Id("loginButton").Locator, new PageWaitForSelectorOptions
                    {
                        Timeout = (float)TimeSpan.FromSeconds(2).TotalMilliseconds
                    }).Result;

                    if(loginButton == null)
                    {
                        return true;
                    }
                    if(loginButton.IsVisibleAsync().Result)
                    {
                        return false;
                    }
                    return true;
                }
                catch (System.Exception)
                {
                    return true;
                }
            }
        }

        public static void Login(string username, string password)
        {
            if(!IsLoggedIn)
            {
                var item = Common.Page.WaitForSelectorAsync(By.ClassName("esh-catalog-thumbnail-wrapper").Locator, new PageWaitForSelectorOptions
                {
                    Timeout = TimeSpan.FromSeconds(10).Milliseconds
                }).Result;

                HomePage.LoginButton.Click();
                
                LoginPage.EmailTextbox.SendKeys(username);

                LoginPage.PasswordTextbox.SendKeys(password);

                LoginPage.LoginButton.Click();
            }
        }

        public static void Logout()
        {
            if(IsLoggedIn)
            {   
                //TODO Implement Logout
            }
        }
    }
}