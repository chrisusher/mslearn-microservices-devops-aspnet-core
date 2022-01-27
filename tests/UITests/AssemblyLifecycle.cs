using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Playwright;
using NUnit.Framework;
using UITests.Config;
using UITests.Helpers;

namespace UITests
{
   [SetUpFixture]
   public class AssemblyLifecycle
   {
      [OneTimeSetUp]
      public static void AssemblySetup()
      {
         var configBuilder = new ConfigurationBuilder()
                                 .AddJsonFile(Path.Combine(Environment.CurrentDirectory, "appsettings.json"))
                                 .AddEnvironmentVariables();
         
         var configuration = configBuilder.Build();

         Common.Settings = configuration.GetSection("UITestSettings").Get<UITestSettings>();

         DeploymentHelper.WaitForDeployment();

         BrowserHelper.SetupBrowser();
      }

      [OneTimeTearDown]
      public void AssemblyTeardown()
      {
         var stopTracing = Common.Context.Tracing.StopAsync(new TracingStopOptions
         {
            Path = "trace.zip"
         });
         stopTracing.GetAwaiter().GetResult();

         _ = Common.Browser.DisposeAsync();
      }
   }
}