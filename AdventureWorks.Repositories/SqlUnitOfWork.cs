using System;
using System.Linq;
using System.Data.Entity;
using AdventureWorks.EntityFramework;

namespace AdventureWorks.Repositories
{
    public class SqlUnitOfWork : IUnitOfWork
    {
        public SqlUnitOfWork()
        {
            _context = new AdventureWorksLT2008R2Entities();
        }

        public IRepository<ErrorLog> ErrorLogs
        {
            get
            {
                if (_errorLogs == null) _errorLogs = new SqlRepository<ErrorLog>(_context);
                return _errorLogs;
            }
        }

        public IRepository<Address> Addresses
        {
            get
            {
                if (_addresses == null) _addresses = new SqlRepository<Address>(_context);
                return _addresses;
            }
        }

        public IRepository<Customer> Customers
        {
            get
            {
                if (_customers == null) _customers = new SqlRepository<Customer>(_context);
                return _customers;
            }
        }

        public IRepository<CustomerAddress> CustomerAddresses
        {
            get
            {
                if (_customerAddresses == null) _customerAddresses = new SqlRepository<CustomerAddress>(_context);
                return _customerAddresses;
            }
        }

        public IRepository<Product> Products
        {
            get
            {
                if (_products == null) _products = new SqlRepository<Product>(_context);
                return _products;
            }
        }

        public IRepository<ProductCategory> ProductCategories
        {
            get
            {
                if (_productCategories == null) _productCategories = new SqlRepository<ProductCategory>(_context);
                return _productCategories;
            }
        }

        public IRepository<ProductDescription> ProductDescriptions
        {
            get
            {
                if (_productDescriptions == null) _productDescriptions = new SqlRepository<ProductDescription>(_context);
                return _productDescriptions;
            }
        }

        public IRepository<ProductModel> ProductModels
        {
            get
            {
                if (_productModels == null) _productModels = new SqlRepository<ProductModel>(_context);
                return _productModels;
            }
        }

        public IRepository<ProductModelProductDescription> ProductModelProductDescriptions
        {
            get
            {
                if (_productModelProductDescriptions == null) _productModelProductDescriptions = new SqlRepository<ProductModelProductDescription>(_context);
                return _productModelProductDescriptions;
            }
        }

        public IRepository<SalesOrderDetail> SalesOrderDetails
        {
            get
            {
                if (_salesOrderDetails == null) _salesOrderDetails = new SqlRepository<SalesOrderDetail>(_context);
                return _salesOrderDetails;
            }
        }

        public IRepository<SalesOrderHeader> SalesOrderHeaders
        {
            get
            {
                if (_salesOrderHeaders == null) _salesOrderHeaders = new SqlRepository<SalesOrderHeader>(_context);
                return _salesOrderHeaders;
            }
        }

        public IRepository<BuildVersion> BuildVersions
        {
            get
            {
                if (_buildVersions == null) _buildVersions = new SqlRepository<BuildVersion>(_context);
                return _buildVersions;
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        SqlRepository<ErrorLog> _errorLogs = null;
        SqlRepository<Address> _addresses = null;
        SqlRepository<Customer> _customers = null;
        SqlRepository<CustomerAddress> _customerAddresses = null;
        SqlRepository<Product> _products = null;
        SqlRepository<ProductCategory> _productCategories = null;
        SqlRepository<ProductDescription> _productDescriptions = null;
        SqlRepository<ProductModel> _productModels = null;
        SqlRepository<ProductModelProductDescription> _productModelProductDescriptions = null;
        SqlRepository<SalesOrderDetail> _salesOrderDetails = null;
        SqlRepository<SalesOrderHeader> _salesOrderHeaders = null;
        SqlRepository<BuildVersion> _buildVersions = null;

        readonly DbContext _context;
    }
}
