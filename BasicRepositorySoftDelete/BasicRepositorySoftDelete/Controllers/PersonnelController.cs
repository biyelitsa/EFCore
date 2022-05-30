using BasicRepositorySoftDelete.Models.Classes;
using BasicRepositorySoftDelete.Models.ViewModel;
using BasicRepositorySoftDelete.Repos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepositorySoftDelete.Controllers
{
    public class PersonnelController : Controller
    {
        PersonnelRepository _rep;
        PersonnelModel _model;
        public PersonnelController(PersonnelRepository rep , PersonnelModel model)
        {
            _rep = rep;
            _model = model;
        }
        public IActionResult List()
        {
            var x = _rep.List();
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
        public IActionResult Create(PersonnelModel model)
        {
            _rep.Create(model.Personnel);
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
            _rep.Delete(_rep.Find(id, false));
            _rep.Save();
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            _model.Header = "Update";
            _model.BtnClass = "btn btn-primary";
            _model.BtnVal = "Update";
            _model.Personnel = _rep.Find(id, false);
            _rep.Save();
            return View("CRUD", _model);
        }
        [HttpPost]
        public IActionResult Update(PersonnelModel model)
        {
            _rep.Update(model.Personnel);
            _rep.Save();
            return RedirectToAction("List");
        }
    }
}
