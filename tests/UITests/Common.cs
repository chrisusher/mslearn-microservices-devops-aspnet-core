using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Playwright;
using TestingSupport.PlaywrightHelpers;
using UITests.Config;

namespace UITests
{
   public class Common
   {
      public static UITestSettings Settings { get; set; }
		public static IBrowser Browser => PlaywrightCommon.Browser;
		public static bool IsGitHubActions => Environment.GetEnvironmentVariable("GITHUB_ACTIONS") == "true";
		public static IPage Page => PlaywrightCommon.Page;
      public static IBrowserContext Context { get; internal set; }
    }
}