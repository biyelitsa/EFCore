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
    public class PersonnelController : Controller
    {
        IBaseRepository<Personnel> _repPersonnel;
        PersonnelModel _model;
        public PersonnelController(IBaseRepository<Personnel> repPersonnel, PersonnelModel model)
        {
            _repPersonnel = repPersonnel;
            _model = model;
        }
        public IActionResult List()
        {
            var clist = _repPersonnel.List();
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
        public IActionResult Create(PersonnelModel model)
        {
            _repPersonnel.Create(model.Personnel);
            _repPersonnel.Save();
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            _model.Header = "Delete";
            _model.BtnClass = "btn btn-warning";
            _model.BtnVal = "Delete";
            _model.Personnel = _repPersonnel.Find(id);
            return View("CRUD", _model);
        }
        [HttpPost]
        public IActionResult Delete(PersonnelModel model)
        {
            _repPersonnel.Delete(model.Personnel);
            _repPersonnel.Save();
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            _model.Header = "Update";
            _model.BtnClass = "btn btn-primary";
            _model.BtnVal = "Update";
            _model.Personnel = _repPersonnel.Find(id);
            return View("CRUD", _model);
        }
        [HttpPost]
        public IActionResult Update(PersonnelModel model)
        {
            _repPersonnel.Update(model.Personnel);
            _repPersonnel.Save();
            return RedirectToAction("List");
        }
    }
}
