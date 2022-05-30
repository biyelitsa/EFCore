using BasicRepositorySoftDelete.Models.Data;
using BasicRepositorySoftDelete.Models.ViewModel;
using BasicRepositorySoftDelete.Repos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepositorySoftDelete.Controllers
{
    public class CityController : Controller
    {
        
        CityRepository _rep;
        CityModel _model;
        public CityController(CityRepository rep, CityModel model)
        {
            _rep = rep;
            _model = model;
        }
       
        public IActionResult List()
        {
            var x = _rep.List();
            return View(x);
        }
        public IActionResult RecoverList()
        {
            var x = _rep.RecoverList();
            return View(x);
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
            _rep.Create(model.City);
            _rep.Save();
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
            _rep.Delete(_rep.Find(id,false));
            _rep.Save();
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Recover(int id)
        {
            //var deleted = _repCity.Find(id);
            //_repCity.Delete(deleted);
            _rep.Recover(_rep.Find(id, true));
            _rep.Save();
            return RedirectToAction("RecoverList");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            _model.Header = "Update";
            _model.BtnClass = "btn btn-primary";
            _model.BtnVal = "Update";
            _model.City = _rep.Find(id, false);
            _rep.Save();
            return View("CRUD", _model);
        }
        [HttpPost]
        public IActionResult Update(CityModel model)
        {
            _rep.Update(model.City);
            _rep.Save();
            return RedirectToAction("List");
        }
    }
}
