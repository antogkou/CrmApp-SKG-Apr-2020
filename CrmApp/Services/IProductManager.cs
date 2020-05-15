using CrmApp.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp.Services
{
    public interface IProductManager
    {
        Product CreateProduct(ProductOption prodOption);
        Product FindProductById(int id);
        Product Update(ProductOption prodOption, int productId);
        bool HardDeleteProductById(int id);
        List<Product> GetAllProducts();
        List<Product> GetAll();
    }
}
