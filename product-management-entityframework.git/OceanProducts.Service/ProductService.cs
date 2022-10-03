using Microsoft.EntityFrameworkCore;
using OceanProjects.Core;
using OceanProjects.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace OceanProducts.Service
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

		public void DeleteProduct(int id)
		{
            var Product = GetById(id);
            if(Product == null)
            {
                throw new ArgumentException();
            }
            _context.Remove(Product);
            _context.SaveChanges();
		}

		public void EditProduct(Product Product)
        {
            var model = _context.Products.First(f => f.Id == Product.Id);
            Product.UpdateTs = DateTime.Now;
            _context.Entry<Product>(model).State = EntityState.Detached;

            _context.Update(Product);
            _context.SaveChanges();
        }
		public IEnumerable<Product> GetAll()
        {
            return _context.Products
                .Include(Product => Product.Category );
        }
        public IEnumerable<Product> GetAll(int categoryId,  bool isActive= true)
        {
            return _context.Products
                .Include(Product => Product.Category).Where(w => w.CategoryId== categoryId && w.IsActive == isActive);
        }
      
        public Product GetById(int id)
        {
            return GetAll().FirstOrDefault(Product => Product.Id == id);
        }
        public Product GetByProductCode(string productCode)
        {
            return GetAll().FirstOrDefault(Product => Product.ProductCode == productCode);
        }

     
        public void NewProduct(Product Product)
        {
            Product.CreateTs = DateTime.Now;
            _context.Add(Product);
            _context.SaveChanges();
        }
    }
}
