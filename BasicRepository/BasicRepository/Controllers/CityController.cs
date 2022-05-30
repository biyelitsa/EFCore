using BasicRepository.Models.Classes;
using BasicRepository.Models.ViewModel;
using BasicRepository.Repos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepository.Controllers
{
    public class CityController : Controller
    {
        IBaseRepository<City> _repCity;
        CityModel _model;
        public CityController(IBaseRepository<City> repCity, CityModel model)
        {
            _repCity = repCity;
            _model = model;
        }
        public IActionResult List()
        {
            var clist = _repCity.List();
            return View(clist);
        }
        [HttpGet]
        public IActionResult Create()
        {
            _model.Header = "Create";
            _model.BtnClass = "btn btn-primary";
            _model.BtnVal = "Create New";
            return View("CRUD", _model);
        }
        [HttpPost]
        public IActionResult Create(CityModel model)
        {
            _repCity.Create(model.City);
            _repCity.Save();
            return RedirectToAction("List");
        }
        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    _model.Header = "Delete";
        //    _model.BtnClass = "btn btn-warning";
        //    _model.BtnVal = "Delete";
        //    _model.City = _repCity.Find(id);
        //    return View("CRUD", _model);
        //}
        //[HttpPost]
        //public IActionResult Delete(CityModel model)
        //{
        //    _repCity.Delete(model.City);
        //    _repCity.Save();
        //    return RedirectToAction("List");
        //}
        [HttpGet]
        public IActionResult Delete(int id)
        {
            //var deleted = _repCity.Find(id);
            //_repCity.Delete(deleted);
            _repCity.Delete(_repCity.Find(id));
            _repCity.Save();
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            _model.Header = "Update";
            _model.BtnClass = "btn btn-primary";
            _model.BtnVal = "Update";
            _model.City = _repCity.Find(id);
            return View("CRUD", _model);
        }
        [HttpPost]
        public IActionResult Update(CityModel model)
        {
            _repCity.Update(model.City);
            _repCity.Save();
            return RedirectToAction("List");
        }
    }
}
