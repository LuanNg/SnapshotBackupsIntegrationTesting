using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventureWorks.EntityFramework;

namespace AdventureWorks.Repositories.IntegrationTests
{
    [TestClass]
    public class BuildVersionTests
    {
        [TestMethod]
        public void BuildVersions_should_return_the_correct_version_information()
        {
            // Arrange
            var uow = new SqlUnitOfWork();

            // Act
            var buildVersions = uow.BuildVersions.FindAll().ToList();

            // Assert
            Assert.AreEqual(1, buildVersions.Count);
            Assert.AreEqual("10.00.80404.00", buildVersions[0].Database_Version);
            Assert.AreEqual(new DateTime(2008, 4, 4), buildVersions[0].ModifiedDate);
            Assert.AreEqual(1, buildVersions[0].SystemInformationID);
            Assert.AreEqual(new DateTime(2008, 4, 4), buildVersions[0].VersionDate);
        }

        [TestMethod]
        public void DbContext_BuildVersions_should_return_the_correct_version_information()
        {
            // Arrange
            var dbContext = new AdventureWorks.EntityFramework.AdventureWorksLT2008R2Entities();

            // Act
            var buildVersions = dbContext.BuildVersions.ToList();

            // Assert
            Assert.AreEqual(1, buildVersions.Count);
            Assert.AreEqual("10.00.80404.00", buildVersions[0].Database_Version);
            Assert.AreEqual(new DateTime(2008, 4, 4), buildVersions[0].ModifiedDate);
            Assert.AreEqual(1, buildVersions[0].SystemInformationID);
            Assert.AreEqual(new DateTime(2008, 4, 4), buildVersions[0].VersionDate);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            DatabaseSnapshot.RestoreSnapShot();
        }
    }
}
