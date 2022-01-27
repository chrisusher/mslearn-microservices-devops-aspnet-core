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

        [BeforeScenario]
        public void SetupEachTest()
        {
            _ = Common.Page.GotoAsync(Common.Settings.Url).Result;
        }

        [Given("I am logged in")]
        public void GivenIAmLoggedIn()
        {
            SecurityController.Login("demouser@microsoft.com", "Pass@word1");
        }
    }
}