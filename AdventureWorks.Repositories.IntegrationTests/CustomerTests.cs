using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventureWorks.EntityFramework;

namespace AdventureWorks.Repositories.IntegrationTests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void Should_change_a_customers_first_and_last_name()
        {
            // Arrange
            var uow = new SqlUnitOfWork();

            // Act
            var customer = uow.Customers.FindWhere(x => x.FirstName == "Jay" && x.LastName == "Adams").First();
            var customerId = customer.CustomerID;
            customer.FirstName = "John";
            customer.LastName = "Reilly";
            uow.Commit();

            // Assert
            Assert.IsNotNull(uow.Customers.FindWhere(x => x.FirstName == "John" && x.LastName == "Reilly" && x.CustomerID == customerId).SingleOrDefault());
        }

        [TestCleanup]
        public void TestCleanup()
        {
            DatabaseSnapshot.RestoreSnapShot();
        }
    }
}
