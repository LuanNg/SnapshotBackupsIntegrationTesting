using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventureWorks.Repositories.IntegrationTests
{
    [TestClass]
    public static class SetUpTearDown
    {
        [AssemblyInitialize]
        public static void TestRunInitialize(TestContext context)
        {
            try
            {
                // Try to delete the snapshot in case it was left over from aborted test runs
                DatabaseSnapshot.DeleteSnapShot();
            }
            catch { /* this should fail with snapshot does not exist */ }

            DatabaseSnapshot.SetupStoredProcedures();
            DatabaseSnapshot.CreateSnapShot();
        }


        [AssemblyCleanup]
        public static void TestRunCleanup()
        {
            DatabaseSnapshot.DeleteSnapShot();
        }
    }
}
