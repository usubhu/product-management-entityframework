using OceanProducts.Web.Models.Category;
using System;
using System.Globalization;

namespace OceanProducts.Web.Models.Product
{
    public class ProductListingModel
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime MfgDate { get; set; }
        public DateTime CreateTs { get; set; }
        public DateTime? UpdateTs { get; set; }
        public bool IsActive { get; set; }
        public CategoryListingModel Category { get; set; }
        public int CategoryId { get; set; }
    }
}
