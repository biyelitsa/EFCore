using CoreDbFirst.Models;
using CoreDbFirst.Models.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDbFirst.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindContext _db;
        public CategoryController(NorthwindContext db)
        {
            _db = db;
        }
        public IActionResult List()
        {
            var cList = _db.Set<Category>().ToList();
            return View(cList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            CategoryModel model = new CategoryModel();
            model.Header = "Create";
            model.BtnClass = "btn btn-primary";
            model.BtnVal = "Create new";
            return View("CRUD", model);
        }
        [HttpPost]
        public IActionResult Create(CategoryModel model)
        {
            _db.Set<Category>().Add(model.Category);
            _db.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            CategoryModel model = new CategoryModel();
            model.Header = "Update";
            model.BtnClass = "btn btn-primary";
            model.BtnVal = "Update";
            model.Category = _db.Set<Category>().Find(id);
            return View("CRUD", model);
        }
        [HttpPost]
        public IActionResult Update(CategoryModel model)
        {
            _db.Set<Category>().Update(model.Category);
            _db.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            _db.Set<Category>().Remove(_db.Set<Category>().Find(id));
            _db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
