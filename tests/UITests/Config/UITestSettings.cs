using UITests.Model.Enums;

namespace UITests.Config
{
   public class UITestSettings
   {
      public string Url { get; set; } = "";
      public BrowserType Browser { get; set; } = BrowserType.Chrome;
      public bool Headless { get; set; }
   }
}