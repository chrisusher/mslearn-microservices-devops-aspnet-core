using System;
using TestingSupport.Common.Utilities;
using static ThisAssembly;

namespace UITests.Helpers
{
    public class DeploymentHelper
    {
        public static void WaitForDeployment()
        {
            if (Common.IsGitHubActions)
            {
                WaitUtility.WaitFor(() => APIHelper.API.GetResponse("version/git").Content != Git.Sha, "Deployment to Complete...", true, TimeSpan.FromMinutes(5), TimeSpan.FromSeconds(10));
            }
        }
    }
}