using OceanProducts.Web.Models.Product;
using System.Collections.Generic;

namespace OceanProducts.Web.Models.Home
{
    public class HomeIndexModel
    {

        public int? CategoryId { get; set; }
        public string SearchQuery { get; set; }
        public IEnumerable<ProductListingModel> ProductsList { get; set; }
    }
}
