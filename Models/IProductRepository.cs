using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface IProductRepository
    {
        void PAdd(ProductModel productModel);
        void PEdit(ProductModel productModel);

        void PDelete(int PId);

        IEnumerable<ProductModel> PGetAll();
        IEnumerable<ProductModel> PGetByValue(string Pvalue);



    }
}
