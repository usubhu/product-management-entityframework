using OceanProducts.Web.Models.Product;
using System.Collections.Generic;

namespace OceanProducts.Web.Models.Category
{
    public class CategoryTopicModel
    {
        public CategoryListingModel Category { get; set; }
        public IEnumerable<ProductListingModel> Products { get; set; }
        public string SearchQuery { get; set; }
    }
}
