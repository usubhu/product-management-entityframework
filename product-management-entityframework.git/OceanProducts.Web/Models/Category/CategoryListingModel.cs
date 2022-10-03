using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OceanProducts.Web.Models.Category
{
    public class CategoryListingModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name of the category")]
        [Display(Name = "Category name*")]
        [StringLength(20)]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Created Date")]
        public DateTime CreateTs { get; set; }

        [Display(Name = "Updated Date")]
        public DateTime? UpdateTs { get; set; }


    }
}
