using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using SnkrsMonitor.Product.Repositories;
using Volo.Abp.EntityFrameworkCore;

namespace SnkrsMonitor.Repositories
{
    public class ProductRepository : EfCoreRepository<SnkrsMonitorDbContext, SnkrsMonitor.Product.Product, Guid>, IProductRepository
    {
        public ProductRepository(IDbContextProvider<SnkrsMonitorDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
