using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OceanProducts.Web.Models.Product
{
    public class NewProductModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name of the product code")]
        [Display(Name = "Product Code*")]
        [StringLength(20)]
        public string ProductCode { get; set; }

        [Required(ErrorMessage = "Please enter your name of the product")]
        [Display(Name = "Product name*")]
        [StringLength(20)]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Please enter price of the product")]
        [Range(0.1, double.MaxValue)]
        [Display(Name = "Price*")]
        public decimal? Price { get; set; }


        [Display(Name = "Manufacture Date*")]
        public DateTime MfgDate { get; set; }

        [Required(ErrorMessage = "Please select category")]
        public int? CategoryId { get; set; }
        public bool IsActive { get; set; }
    }
}
