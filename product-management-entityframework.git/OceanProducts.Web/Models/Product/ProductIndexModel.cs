using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace OceanProducts.Web.Models.Product
{
    public class ProductIndexModel
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime MfgDate { get; set; }
        public int CategoryId { get; set; }
      
        public string CategoryName { get; set; }

    }
}
