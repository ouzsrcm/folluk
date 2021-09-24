using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Folluk.Controllers
{
    public class CoopController : BaseController
    {
        public ActionResult Index()
        {
            return View(Farm);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(Farm);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            Farm.tblCoops = (from x in _db.tblCoops where x.CoopId == Id select x).ToList();
            if (Farm.tblCoops.Count < 1) return Redirect("/Coop");
            return View(Farm);
        }

        [HttpGet]
        public ActionResult Animal()
        {
            Farm.tblAnimals = (from x in _db.tblAnimals where x.CoopId == Id select x).ToList();
            return View(Farm);
        }

        [HttpPost]
        public ActionResult Save(Data.tblCoop model)
        {
            Data.tblFarm _farm;
            Data.tblCoop _coop;

            if (model.CoopId != 0)
            {
                _coop = (from x in _db.tblCoops where x.CoopId == model.CoopId select x).FirstOrDefault();
            }
            else _coop = new Data.tblCoop();

            _farm = (from x in _db.tblFarms where x.AccountId == AccountId select x).FirstOrDefault();

            if (_farm != null)
            {
                _coop.FarmId = _farm.FarmId;
                _coop.Title = model.Title;
                _coop.Description = model.Description;

                if (model.CoopId == 0)
                    _db.tblCoops.Add(_coop);

                _db.SaveChanges();
                return Redirect("/Coop");

            }
            else
            {
                return Redirect("/Farm/Create");
            }

        }

        [HttpGet]
        public ActionResult Remove()
        {
            var _coop = (from x in _db.tblCoops where x.CoopId == Id select x).FirstOrDefault();
            var _animals = (from x in _db.tblAnimals where x.CoopId == _coop.CoopId select x).ToList();
            if (_animals.Count > 0)
            {
                Farm.IsWarning = true;
                Farm.WarningBody = _coop.Title + " kümesinde hayvanlar var.";
                Farm.WarningBody += "Lütfen onları başka bir kümese alın yada sistemden kaldırın.";
                Farm.WarningClass = "note-warning";
            }
            else
            {
                try
                {

                    _db.tblCoops.Remove(_coop);
                    _db.SaveChanges();

                    Farm.IsWarning = true;
                    Farm.WarningBody = _coop.Title + " kümesi kaldırıldı.";
                    Farm.WarningClass = "note-success";
                }
                catch
                {
                    Farm.IsWarning = true;
                    Farm.WarningBody = _coop.Title + " kümesi kaldırılamadı. Bunu hemen düzeltiyoruz.";
                    Farm.WarningClass = "note-danger";
                }

            }
            return View("Index", Farm);
        }

    }
}