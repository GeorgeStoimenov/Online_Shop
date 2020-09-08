using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ProductContext context = app.ApplicationServices.GetRequiredService<ProductContext>();
            context.Database.EnsureDeleted();
            context.Database.Migrate();
            if(!context.Products.Any())
            {
                
                context.Products.AddRange(
                    new Product { ProductName = "Chips", UnitPrice = 2.50M, UnitsInStock = 50, Category = "Snacks" },
                    new Product { ProductName = "Tortilla", UnitPrice = 2.30M, UnitsInStock = 70, Category = "Snacks" },
                    new Product { ProductName = "Popcorn", UnitPrice = 0.89M, UnitsInStock = 0, Category = "Snacks" },
                    new Product { ProductName = "Corona", UnitPrice = 1.50M, UnitsInStock = 50, Category = "Beers" },
                    new Product { ProductName = "Budweiser", UnitPrice = 2.10M, UnitsInStock = 70, Category = "Beers" },
                    new Product { ProductName = "Heineken", UnitPrice = 2.20M, UnitsInStock = 0, Category = "Beers" },
                    new Product { ProductName = "Grolsh", UnitPrice = 2.30M, UnitsInStock = 0, Category = "Beers" });
                context.SaveChanges();
            }
        }
    }
}
