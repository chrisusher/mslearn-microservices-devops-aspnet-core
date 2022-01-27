using NUnit.Framework;
using TechTalk.SpecFlow;
using UITests.UI.Controllers;
using UITests.UI.Pages;

namespace UITests.Steps.Security
{
    [Binding]
    public class LoginSteps
    {
        private ScenarioContext _scenarioContext;

        public LoginSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When("I login with Email '(.*)' and Password '(.*)'")]
        public void WhenILoginWithDetails(string email, string password)
        {
            SecurityController.Login(email, password);
        }

        [Then("The login attempt is successful")]
        public void ThenLoginIsSuccessful()
        {
            Assert.IsTrue(SecurityController.IsLoggedIn, "User not successfully logged in.");
        }

        [Then("The login attempt is not successful")]
        public void ThenLoginIsUnsuccesful()
        {
            Assert.IsTrue(LoginPage.OnLoginPage, "User not kept on Login Page after unsuccesful login.");
        }
    }
}