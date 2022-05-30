using FirstCore.Models.Data;
using FirstCore.Models.Data.Classes;
using FirstCore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCore.Controllers
{
    public class CityController : Controller
    {
        PerContext _db;

        CityModel _model;
        public CityController(PerContext db, CityModel model)
        {
            _db = db;
            _model = model;
        }
        public IActionResult List()
        {
            var clist = _db.Set<City>().Include(x => x.Personnels).ToList();
            return View(clist);
        }
        public IActionResult Create()
        {
            //CityModel model = new CityModel();
            _model.Heading = "Create";
            _model.BtnVal = "Add";
            _model.BtnClass = "btn btn-primary";
            return View("CRUD", _model);
        }
        [HttpPost]
        public IActionResult Create(CityModel model)
        {
            _db.Set<City>().Add(model.City);
            _db.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //CityModel model = new CityModel();
            _model.Heading = "Edit";
            _model.BtnVal = "Ok";
            _model.BtnClass = "btn btn-primary";
            _model.City = _db.Set<City>().Find(id);
            //var p = _model.City.Personnels;
            return View("CRUD", _model);
        }
        [HttpPost]
        public IActionResult Edit(CityModel model)
        {
            _db.Set<City>().Update(model.City);
            _db.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            //CityModel model = new CityModel();
            _model.Heading = "Delete";
            _model.BtnVal = "Ok";
            _model.BtnClass = "btn btn-primary";
            _model.City = _db.Set<City>().Find(id);
            return View("CRUD", _model);
        }
        [HttpPost]
        public IActionResult Delete(CityModel model)
        {
            _db.Set<City>().Remove(model.City);
            _db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
