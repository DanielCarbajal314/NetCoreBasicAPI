using BusinessLogicInterfaces.IProductManager;
using BusinessLogicInterfaces.IProductManager.Request;
using BusinessLogicInterfaces.IProductManager.Responses;
using DataAccess.Context;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic.ProductManagement
{
    public class ProductManager: IProductManager
    {
        public async Task<List<RegisteredProduct>> GetAllProducts()
        {
            using (Shop shop = new Shop())
            {
                return await shop.Products.Select(x => new RegisteredProduct()
                {
                    Id = x.Id,
                    Price = x.Price,
                    Title = x.Name
                }).ToListAsync();
            }
        }

        public async Task<RegisteredProduct> RegisterNewProduct(NewProduct newProduct)
        {
            using (Shop shop = new Shop())
            {
                Product product = new Product();
                product.Name = newProduct.Title;
                product.Price = newProduct.Price;
                shop.Products.Add(product);
                await shop.SaveChangesAsync();
                RegisteredProduct registerProduct = new RegisteredProduct();
                registerProduct.Id = product.Id;
                registerProduct.Price = product.Price;
                registerProduct.Title = product.Name;
                return registerProduct;
            }
        }
    }
}
