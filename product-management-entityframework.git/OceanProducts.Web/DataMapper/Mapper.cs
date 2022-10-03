using OceanProducts.Web.Models.Category;
using OceanProducts.Web.Models.Home;
using OceanProducts.Web.Models.Product;
using OceanProjects.Core;
using OceanProjects.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace OceanProducts.Web.DataMapper
{
    public class Mapper
    {

        #region Category

        public Category CategoryListingToModel(CategoryListingModel model)
        {
            return new Category
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                UpdateTs = model.UpdateTs,
                CreateTs =model.CreateTs
            };
        }

        public CategoryListingModel ProductToCategoryListing(Product Product)
        {
            var category = Product.Category;
            return CategoryToCategoryListing(category);
        }

        public CategoryListingModel CategoryToCategoryListing(Category category)
        {
            return new CategoryListingModel
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                CreateTs = category.CreateTs,
                UpdateTs = category.UpdateTs,
                
            };
        }

        #endregion


        #region Product

        public NewProductModel ProductToNewProductModel(Product Product)
        {
            return new NewProductModel
            {
                Id = Product.Id,
                ProductCode = Product.ProductCode,
                Name = Product.Name,
                CategoryId = Product.CategoryId,
                Description = Product.Description,
                Price = Product.UnitPrice,
               
            };
        }


        public Product NewProductModelToProduct(NewProductModel model, bool newInstance, ICategoryService categoryService)
        {
            var Product = new Product
            {
                Name = model.Name,
                Category = categoryService.GetById(model.CategoryId.Value),
                CategoryId = model.CategoryId.Value,
                ProductCode = model.ProductCode,
                UnitPrice = model.Price.Value,
                MfgDate = model.MfgDate,
                IsActive  = true,
                Description = model.Description,
              
            };

            if (!newInstance)
            {
                Product.Id = model.Id;
            }

            return Product;
        }

      

        #endregion

        #region Home

        public HomeIndexModel ProductsToHomeIndexModel(IEnumerable<Product> Products)
        {

            var ProductsListing = Products.Select(Product => new ProductListingModel
            {
                Id = Product.Id,
                Name = Product.Name,
                Category = CategoryToCategoryListing(Product.Category),
                CategoryId = Product.CategoryId,
                ProductCode = Product.ProductCode,
                UnitPrice = Product.UnitPrice,
                MfgDate = Product.MfgDate,
                IsActive = Product.IsActive,
                Description = Product.Description,
                CreateTs = Product.CreateTs,
                UpdateTs = Product.UpdateTs
            });

            return new HomeIndexModel
            {
                ProductsList = ProductsListing
            };
        }

        #endregion
   
    }
}
