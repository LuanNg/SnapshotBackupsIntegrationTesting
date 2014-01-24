using AdventureWorks.EntityFramework;

namespace AdventureWorks.Repositories
{
    public interface IUnitOfWork
    {
        IRepository<ErrorLog> ErrorLogs { get; }
        IRepository<Address> Addresses { get; }
        IRepository<Customer> Customers { get; }
        IRepository<CustomerAddress> CustomerAddresses { get; }
        IRepository<Product> Products { get; }
        IRepository<ProductCategory> ProductCategories { get; }
        IRepository<ProductDescription> ProductDescriptions { get; }
        IRepository<ProductModel> ProductModels { get; }
        IRepository<ProductModelProductDescription> ProductModelProductDescriptions { get; }
        IRepository<SalesOrderDetail> SalesOrderDetails { get; }
        IRepository<SalesOrderHeader> SalesOrderHeaders { get; }
        IRepository<BuildVersion> BuildVersions { get; }

        void Commit();
    }
}
