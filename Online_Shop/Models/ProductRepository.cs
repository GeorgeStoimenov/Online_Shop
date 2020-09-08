using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Models
{
    public class ProductRepository : IProductRepository
    {
        //public IEnumerable<Product> Products => new List<Product>
        //{
        //    new Product{ProductId = 1, ProductName = "Chips", UnitPrice = 2.50M, UnitsInStock = 50, Category = "Snacks"},
        //    new Product{ProductId = 2, ProductName = "Tortilla", UnitPrice = 2.30M, UnitsInStock = 70, Category = "Snacks"},
        //    new Product{ProductId = 3, ProductName = "Popcorn", UnitPrice = 0.89M, UnitsInStock = 120, Category = "Snacks"},
        //    new Product{ProductId = 4, ProductName = "Corona", UnitPrice = 1.50M, UnitsInStock = 50, Category = "Beers"},
        //    new Product{ProductId = 5, ProductName = "Budweiser", UnitPrice = 2.10M, UnitsInStock = 70, Category = "Beers"},
        //    new Product{ProductId = 6, ProductName = "Popcorn", UnitPrice = 0.89M, UnitsInStock = 120, Category = "Snacks"},
        //    new Product{ProductId = 7, ProductName = "Popcorn", UnitPrice = 0.89M, UnitsInStock = 120, Category = "Snacks"}
        //};
        private ProductContext context;
        public ProductRepository(ProductContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;    
        
    }
}
