using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SnkrsMonitor.Application.Contracts;
using SnkrsMonitor.ToolKits.Base;

namespace SnkrsMonitor.Application.Product
{
    public interface IProductService
    {
        Task<ServiceResult<IEnumerable<ProductDto>>> GetProductsAsync();
    }
}
