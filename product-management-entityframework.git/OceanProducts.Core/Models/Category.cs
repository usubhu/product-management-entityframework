using System;
using System.Collections.Generic;

namespace OceanProjects.Core.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateTs { get; set; }
        public DateTime? UpdateTs { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
