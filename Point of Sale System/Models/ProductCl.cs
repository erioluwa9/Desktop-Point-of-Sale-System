using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale_System.Models
{
    public class ProductCl
    {        
        public int Id { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }

    }
}
