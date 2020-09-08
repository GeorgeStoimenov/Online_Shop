using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
       
    }
}
