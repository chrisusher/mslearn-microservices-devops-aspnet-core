using TechTalk.SpecFlow;

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
    }
}