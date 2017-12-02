using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogicInterfaces.IProductManager.Request
{
    public class NewProduct
    {
        public string Title { get; set; }
        public double Price { get; set; }
    }
}
