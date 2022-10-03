using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OceanProducts.Web.Models.Category
{
    public class CategoryIndexModel
    {
        public IEnumerable<CategoryListingModel> CategoryList { get; set; }
    }
}
