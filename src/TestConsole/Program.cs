using BusinessLogic.ProductManagement;
using BusinessLogicInterfaces.IProductManager.Request;
using BusinessLogicInterfaces.IProductManager.Responses;
using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TestDataBase();
            ProductManager productManager = new ProductManager();
            NewProduct newProduct = new NewProduct();
            newProduct.Price = 10;
            newProduct.Title = "Caramelo";
            RegisteredProduct registeredProduct = productManager.RegisterNewProduct(newProduct).Result;
            Console.WriteLine(registeredProduct.Id);
            Console.ReadKey();
        }

        private static void TestDataBase()
        {
            Shop shop = new Shop();
            shop.Database.EnsureCreated();
            var products = shop.Products.ToList();
            Console.WriteLine(products.Count);
            Console.ReadKey();
        }
    }
}
