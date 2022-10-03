using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OceanProjects.Core;
using OceanProjects.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace OceanProjects.Core.Seeds
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
                .CreateScope())
            {
                ApplicationDbContext context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(Categories.Select(c => c.Value));
                }

                if (!context.Products.Any())
                {
                    var products = new Product[]
                    {
                         new Product
                         {
                             ProductCode="SKU-001",
                             Name = "Sample Product 1",
                             Category = categories["Category 1"],
                             IsActive = true,
                             Description = "This is product description. This is product description.",
                             UnitPrice = 4.5M,
                             MfgDate= System.DateTime.Today.AddDays(-100),
                             CreateTs = System.DateTime.Now,
                             UpdateTs = null,

                         },
                         new Product {
                             ProductCode="SKU-002",
                             Name = "Sample Product 2",
                             Category = categories["Category 1"],
                             IsActive = true,
                             Description = "This is product description. This is product description.",
                             UnitPrice = 2.0M,
                             MfgDate= System.DateTime.Today.AddDays(-120),
                             CreateTs = System.DateTime.Now,
                             UpdateTs = null,

                         } ,
                         new Product {
                             ProductCode="SKU-003",
                             Name = "Sample Product 2",
                             Category = categories["Category 1"],
                             IsActive = true,
                             Description = "This is product description. This is product description.",
                             UnitPrice = 2.0M,
                             MfgDate= System.DateTime.Today.AddDays(-300),
                             CreateTs = System.DateTime.Now,
                             UpdateTs = null,

                         },
                          new Product {
                             ProductCode="SKU-004",
                             Name = "Sample Product 3",
                             Category = categories["Category 2"],
                             IsActive = true,
                             Description = "This is product description. This is product description.",
                             UnitPrice = 1.75M,
                             MfgDate= System.DateTime.Today.AddDays(-150),
                             CreateTs = System.DateTime.Now,
                             UpdateTs = null,

                         }

                    };


                    context.AddRange(products);
                }

                context.SaveChanges();
            }
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var categoryList = new Category[]
                    {
                        new Category
                        {
                            Name = "Category 1",
                            Description = "Category 1",
                            CreateTs = System.DateTime.Now,
                            UpdateTs = null,
                        },
                        new Category
                        {
                            Name = "Category 2",
                            Description = "Category 2",
                            CreateTs = System.DateTime.Now,
                            UpdateTs = null,
                        },

                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category category in categoryList)
                    {
                      
                        categories.Add(category.Name, category);
                    }
                }

                return categories;
            }
        }
    }
}