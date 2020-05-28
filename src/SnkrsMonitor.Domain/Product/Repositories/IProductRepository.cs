using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories;

namespace SnkrsMonitor.Product.Repositories
{
    public interface IProductRepository : IRepository<Product, Guid>
    {
    }
}
