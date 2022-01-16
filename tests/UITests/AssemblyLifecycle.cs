using NUnit.Framework;

namespace UITests
{
   [SetUpFixture]
   public class AssemblyLifecycle
   {
      [OneTimeSetUp]
      public static void AssemblySetup()
      {

      }

      [OneTimeTearDown]
      public void AssemblyTeardown()
      {

      }
   }
}