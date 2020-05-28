using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnkrsMonitor.Application.Contracts;
using SnkrsMonitor.Product.Repositories;
using SnkrsMonitor.ToolKits.Base;

namespace SnkrsMonitor.Application.Product.ImpI
{
    public class ProductService : ServiceBase, IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ServiceResult<IEnumerable<ProductDto>>> GetProductsAsync()
        {
            var result = new ServiceResult<IEnumerable<ProductDto>>();
            IEnumerable<SnkrsMonitor.Product.Product> products = await _productRepository.GetListAsync();
            IEnumerable<ProductDto> productDtos= products.Select(e => new ProductDto()
            {
                Code = e.Code,
                IndexPicUrl = e.IndexPicUrl,
                Name = e.Name,
                No = e.No,
                Price = e.Price
            });
            //result.Result = productDtos.ToList();
            result.IsSuccess(productDtos);
            return result;
        }
    }
}
