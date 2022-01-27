using Microsoft.Playwright;
using TestingSupport.PlaywrightHelpers;

namespace UITests.Helpers
{
    public class BrowserHelper
    {
        public static void SetupBrowser()
        {
            PlaywrightCommon.PlaywrightInstance = Playwright.CreateAsync().Result;

            switch(Common.Settings.Browser)
            {
                case Model.Enums.BrowserType.Chrome:
                    PlaywrightCommon.Browser = PlaywrightCommon.PlaywrightInstance.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
                    {
                        Channel = "chrome",
                        Headless = Common.Settings.Headless
                    }).Result;
                    break;

                case Model.Enums.BrowserType.Edge:
                    PlaywrightCommon.Browser = PlaywrightCommon.PlaywrightInstance.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
                    {
                        Channel = "msedge",
                        Headless = Common.Settings.Headless
                    }).Result;
                    break;

                case Model.Enums.BrowserType.Firefox:
                    PlaywrightCommon.Browser = PlaywrightCommon.PlaywrightInstance.Firefox.LaunchAsync(new BrowserTypeLaunchOptions
                    {
                        Headless = Common.Settings.Headless
                    }).Result;
                    break;

                case Model.Enums.BrowserType.Safari:
                    PlaywrightCommon.Browser = PlaywrightCommon.PlaywrightInstance.Webkit.LaunchAsync(new BrowserTypeLaunchOptions
                    {
                        Headless = Common.Settings.Headless
                    }).Result;
                    break;
            }

            Common.Context = PlaywrightCommon.Browser.NewContextAsync().Result;
            Common.Context.Tracing.StartAsync(new TracingStartOptions
            {
                Screenshots = true,
                Snapshots = true
            });

            PlaywrightCommon.Page = Common.Context.NewPageAsync().Result;

            _ = PlaywrightCommon.Page.GotoAsync(Common.Settings.Url).Result;
        }
    }
}