using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Online_Shop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Online_Shop.Controllers
{
    public class ProductController : Controller
    {

        private IProductRepository repository;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        
        public ActionResult Index()
        {        
            
            return View(repository);
        }
    }
}
