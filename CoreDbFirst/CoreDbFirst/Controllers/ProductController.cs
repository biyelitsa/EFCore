using CoreDbFirst.Models.Data;
using CoreDbFirst.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDbFirst.Controllers
{
    public class ProductController : Controller
    {
        NorthwindContext _db;
        public ProductController(NorthwindContext db)
        {
            _db = db;
        }
        public IActionResult List()
        {
            //var pList = _db.Set<ProductList>().FromSqlRaw(
            //    "select ProductID, ProductName, CompanyName, CategoryName, UnitPrice from Products p inner join Suppliers s on(p.SupplierID = s.SupplierID) inner join Categories c on(c.CategoryID = p.CategoryID)"
            //    ).ToList();
            var pList = _db.Set<Product>().FromSqlRaw(
                "select * from Products"
                ).ToList();
            return View(pList);
        }
    }
}
