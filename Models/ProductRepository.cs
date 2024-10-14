﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface ProductRepository
    {
        void Add(ProductModel productModel);
        void Edit(ProductModel productModel);

        void Delete(int PId);

        IEnumerable<ProductModel> GetAll();
        IEnumerable<ProductModel> GetByValue(string value);



    }
}
