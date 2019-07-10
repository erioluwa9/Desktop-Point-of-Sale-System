using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale_System.Models
{
    public class SalesCl
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int TransID { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime DateTime { get; set; }

    }
}
