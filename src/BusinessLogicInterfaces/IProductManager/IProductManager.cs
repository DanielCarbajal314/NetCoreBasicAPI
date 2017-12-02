using BusinessLogicInterfaces.IProductManager.Request;
using BusinessLogicInterfaces.IProductManager.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogicInterfaces.IProductManager
{
    public interface IProductManager
    {
        Task<List<RegisteredProduct>> GetAllProducts();
        Task<RegisteredProduct> RegisterNewProduct(NewProduct newProduct);
    }
}
