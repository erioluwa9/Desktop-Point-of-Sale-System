using Point_of_Sale_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale_System
{
    interface IPointOfSale
    {
        
        bool AddCategory(CategoryCl category);

        bool AddCustomer(CustomerCl customer);

        bool AddProduct(ProductCl product);

        bool AddSale(SalesCl sale);

        bool AddSaleList(SalesList salesList);

        List<SalesList> SalesList { get; set; }
        List<SalesDetails> SalesDetails { get; set; }
    }
}
