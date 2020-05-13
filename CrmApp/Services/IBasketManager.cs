using CrmApp.Models;
using CrmApp.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp.Services
{
    public interface IBasketManager
    {
        Basket CreateBasket(BasketOption baskOption);
        BasketProduct AddProduct(BasketProductOption bskProd);
        Basket FindBasketById(int basketId);
        List<Basket> FindCustomerBaskets(int custId);
        bool DeleteProduct(BasketProductOption bskProdOpt);

    }
}
