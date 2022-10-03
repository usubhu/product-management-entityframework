using System;

namespace OceanProjects.Core.Models
{
    public class Product
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
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
