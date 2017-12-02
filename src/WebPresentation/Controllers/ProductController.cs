using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessLogicInterfaces.IProductManager;
using BusinessLogicInterfaces.IProductManager.Responses;
using BusinessLogicInterfaces.IProductManager.Request;

namespace WebPresentation.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {

        private IProductManager _productManager;

        public ProductController(IProductManager productManager) {
            this._productManager = productManager;
        }

        // GET: api/values
        [HttpGet]
        public async Task<List<RegisteredProduct>> Get()
        {
            return await this._productManager.GetAllProducts();
        }

        // POST api/values
        [HttpPost]
        public async Task<RegisteredProduct> Post([FromBody]NewProduct newProduct)
        {
            return await this._productManager.RegisterNewProduct(newProduct);
        }
    }
}
