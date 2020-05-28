using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SnkrsMonitor.Application.Contracts;
using SnkrsMonitor.Application.Product;
using SnkrsMonitor.ToolKits.Base;
using Volo.Abp.AspNetCore.Mvc;

namespace SnkrsMonitor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : AbpController
    {
        private readonly IHelloWorldService _helloWorldService;
        private readonly IProductService _productService;

        public HelloWorldController(IHelloWorldService helloWorldService,IProductService productService)
        {
            _helloWorldService = helloWorldService;
            _productService = productService;
        }

        [HttpGet]
        public async Task<ServiceResult<IEnumerable<ProductDto>>> HelloWorld()
        {
             var result= await _productService.GetProductsAsync();
             return result;
        }
    }
}
