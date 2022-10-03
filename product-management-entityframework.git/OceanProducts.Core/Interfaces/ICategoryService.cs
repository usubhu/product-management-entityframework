using OceanProjects.Core.Models;
using System.Collections.Generic;

namespace OceanProjects.Core
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAll();
        Category GetById(int id);
        void NewCategory(Category category);
        void EditCategory(Category category);
        void DeleteCategory(int id);
    }
}
