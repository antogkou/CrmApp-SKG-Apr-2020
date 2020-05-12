using CrmApp.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp.Services
{
    public interface IProductManager
    {
        List<Product> GetAllProducts();
        Product GetProduct(int id);

        Product PostProduct(ProductOption prodOpt);

        Product PutProduct(int id, ProductOption custOpt);
        bool HardDeleteProduct(int id);
    }
}
