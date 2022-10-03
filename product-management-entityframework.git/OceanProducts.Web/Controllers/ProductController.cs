using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OceanProducts.Web.DataMapper;
using OceanProducts.Web.Models.Category;
using OceanProducts.Web.Models.Product;
using System;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using OceanProjects.Core;

namespace OceanProducts.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _ProductService;
        private readonly Mapper _mapper;
        private IHostingEnvironment _environment;

        public ProductController(ICategoryService categoryService, IProductService productService, IHostingEnvironment environment)
        {
            _categoryService = categoryService;
            _ProductService = productService;
            _environment = environment;
            _mapper = new Mapper();
        }

        [Route("Products/{id}")]
        public IActionResult Index(int id)
        {
            var product = _ProductService.GetById(id);

            var model = new ProductIndexModel
            {
                Id = product.Id,
                ProductCode = product.ProductCode,
                Name = product.Name,
                MfgDate = product.MfgDate,
                UnitPrice = product.UnitPrice,
                Description = product.Description,
                CategoryId = product.Category.Id,
                CategoryName = product.Category.Name
            };

            return View(model);
        }

        public IActionResult New(int categoryId = 0)
        {
            GetCategoriesForDropDownList();
            NewProductModel model = new NewProductModel
            {
                CategoryId = categoryId
            };

            ViewBag.ActionText = "create";
            ViewBag.Action = "New";
            ViewBag.CancelAction = "Topic";
            ViewBag.SubmitText = "Create Product";
            ViewBag.RouteId = categoryId;
            ViewBag.ControllerName = "Category";

            if (categoryId == 0)
            {
                ViewBag.CancelAction = "Index";
                ViewBag.ControllerName = "Home";
            }

            return View("CreateEdit", model);
        }

      
        [HttpPost]
        public IActionResult New(NewProductModel model)
        {
            // Check product code 
           var product= _ProductService.GetByProductCode(model.ProductCode);
            GetCategoriesForDropDownList();
            ViewBag.ActionText = "create";
            ViewBag.Action = "New";
            ViewBag.ControllerName = "Category";
            ViewBag.CancelAction = "/";
            ViewBag.SubmitText = "Create Product";
            ViewBag.RouteId = model.CategoryId;
            if (product != null)
            {
                ViewBag.ErrorMessage = "Error Duplicate Product Code, Please enter unique product code";
                return View("CreateEdit", model);
            }
                
            else if (ModelState.IsValid && product == null && _categoryService.GetById(model.CategoryId.Value) != null)
            {
                var Product = _mapper.NewProductModelToProduct(model, true, _categoryService);
                _ProductService.NewProduct(Product);
                return new RedirectResult(url: $"/Index/{model.CategoryId}", permanent: true,
                            preserveMethod: true);
            }
            

           

            return View("CreateEdit", model);
        }

      
        public IActionResult Edit(int id)
        {
            ViewBag.ActionText = "change";
            ViewBag.Action = "Edit";
            ViewBag.CancelAction = "Index";
            ViewBag.SubmitText = "Save Changes";
            ViewBag.ControllerName = "Product";
            ViewBag.RouteId = id;

            GetCategoriesForDropDownList();

            var Product = _ProductService.GetById(id);
            if (Product != null)
            {
                var model = _mapper.ProductToNewProductModel(Product);
                return View("CreateEdit", model);
            }

            return View("CreateEdit");
        }

        [HttpPost]
        public IActionResult Edit(NewProductModel model)
        {
            ViewBag.ActionText = "change";
            ViewBag.Action = "Edit";
            ViewBag.CancelAction = "Index";
            ViewBag.SubmitText = "Save Changes";
            ViewBag.ControllerName = "Product";
            ViewBag.RouteId = model.Id;
            GetCategoriesForDropDownList();

            if (ModelState.IsValid)
            {
                var Product = _mapper.NewProductModelToProduct(model, false, _categoryService);
                _ProductService.EditProduct(Product);
                
                return new RedirectResult(url: $"/Index/{model.CategoryId}", permanent: true,
                            preserveMethod: true);
                
            }

           

            return View("CreateEdit", model);
        }

       
        public IActionResult Delete(int id)
        {
          
            _ProductService.DeleteProduct(id);

            return new RedirectResult(url: "/", permanent: true,
                             preserveMethod: true);
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
