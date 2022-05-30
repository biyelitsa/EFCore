using FirstCore.Models.Data;
using FirstCore.Models.Data.Classes;
using FirstCore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCore.Controllers
{
    public class PersonnelController : Controller
    {
        PerContext _db;

        PersonnelModel _model;
        public PersonnelController(PerContext db, PersonnelModel model)
        {
            _db = db;
            _model = model;
        }
        public IActionResult List()
        {
            var plist = _db.Set<Personnel>().Select(x => new Personnel
            {
                Name = x.Name,
                Surname = x.Surname,
                CityId = x.CityId,
            }).ToList();
            return View("List", plist);
            //return View(_db.Set<Personnel>().ToList());
        }
        private List<City> GetCityList()
        {
            return _db.Set<City>().Select(x => new City
            {
                CityId = x.CityId,
                CityName = x.CityName
            }).ToList();
        }
        public IActionResult Create()
        {
            //PersonnelModel model = new PersonnelModel();
            _model.Heading = "Create";
            _model.BtnVal = "Add";
            _model.BtnClass = "btn btn-primary";
            _model.CityList = GetCityList();
            return View("CRUD", _model);
        }
        [HttpPost]
        public IActionResult Create(PersonnelModel model)
        {
            _db.Set<Personnel>().Add(model.Personnel);
            _db.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //PersonnelModel model = new PersonnelModel();
            _model.Heading = "Edit";
            _model.BtnVal = "Ok";
            _model.BtnClass = "btn btn-primary";
            _model.Personnel = _db.Set<Personnel>().Find(id);
            _model.CityList = GetCityList();
            return View("CRUD", _model);
        }
        [HttpPost]
        public IActionResult Edit(PersonnelModel model)
        {
            _db.Set<Personnel>().Update(model.Personnel);
            _db.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            //PersonnelModel model = new PersonnelModel();
            _model.Heading = "Delete";
            _model.BtnVal = "Ok";
            _model.BtnClass = "btn btn-primary";
            _model.Personnel = _db.Set<Personnel>().Find(id);
            return View("CRUD", _model);
        }
        [HttpPost]
        public IActionResult Delete(PersonnelModel model)
        {
            _db.Set<Personnel>().Remove(model.Personnel);
            _db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
