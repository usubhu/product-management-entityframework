using OceanProjects.Core.Models;
using System.Collections.Generic;

namespace OceanProjects.Core
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetAll(int categoryId, bool isActive = true);
       
        Product GetById(int id);
        Product GetByProductCode(string productCode);
        void NewProduct(Product Product);
        void EditProduct(Product Product);
        void DeleteProduct(int id);
    }
}
