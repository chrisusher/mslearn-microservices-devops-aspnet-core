using NUnit.Framework;

namespace UITests
{
   [SetupFixture]
   public class AssemblyLifecycle
   {
      [OneTimeSetup]
      public static void AssemblySetup()
      {

      }

      [OneTimeTearDown]
      public void AssemblyTeardown()
      {

      }
   }
}