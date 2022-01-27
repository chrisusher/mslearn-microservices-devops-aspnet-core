using TechTalk.SpecFlow;
using UITests.UI.Controllers;

namespace UITests.Steps
{
    [Binding]
    public class CommonSteps
    {
        private ScenarioContext _scenarioContext;

        public CommonSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        #region Lifecycle Methods

        [BeforeScenario]
        public void SetupTest()
        {
            _ = Common.Page.GotoAsync(Common.Settings.Url).Result;
        }
             
        #endregion

        #region Given Methods

        [Given("I am logged in")]
        public void GivenIAmLoggedIn()
        {
            SecurityController.Login("demouser@microsoft.com", "Pass@word1");
        }

        [Given("I am not logged in")]
        public void GivenIAmNotLoggedIn()
        {
            SecurityController.Logout();
        }
             
        #endregion
    }
}