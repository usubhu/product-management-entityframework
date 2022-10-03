using Microsoft.AspNetCore.Mvc;
using OceanProducts.Web.DataMapper;
using OceanProducts.Web.Models;
using System.Diagnostics;
using OceanProjects.Core;
using System.Linq;
using OceanProducts.Web.Models.Category;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OceanProducts.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _ProductService;
        private readonly Mapper _mapper;

        public HomeController(IProductService ProductService, ICategoryService categoryService)
        {
            _ProductService = ProductService;
            _categoryService = categoryService;
            _mapper = new Mapper();
        }


        [Route("/")]
        [Route("Index/{id}")]
        public IActionResult Index(int id = 0)
        {
            GetCategoriesForDropDownList();
            var products = _ProductService.GetAll();
            if (id > 0)
                products = _ProductService.GetAll(id, true);
            var model = _mapper.ProductsToHomeIndexModel(products);
            model.CategoryId = id;
            return View(model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private void GetCategoriesForDropDownList()
        {
            var categories = _categoryService.GetAll().Select(category => new CategoryDropdownModel
            {
                Id = category.Id,
                Name = category.Name
            });
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
        }
    }
}
