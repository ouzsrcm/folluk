using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Folluk.Controllers
{
    public class AnimalController : BaseController
    {

        public List<Data.tblAnimalType> Types;
        public List<Data.tblCoop> Coops;

        public StringBuilder sbTypes;

        public ActionResult Index()
        {
            Farm.tblAnimals = _db.tblAnimals.Where(x => x.FarmId == Farm.FarmId).ToList();
            return View(Farm);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            try
            {

                if (Id != 0)
                {
                    Farm.tblAnimal = _db.tblAnimals.Where(x => x.AnimalId == Id).FirstOrDefault();
                }

                sbTypes = new StringBuilder();
                Types = _db.tblAnimalTypes.ToList();
                AnimalTypes(Types, 0, 0, true, int.Parse(Farm.tblAnimal.AnimalTypeId.ToString()));
                ViewBag.AnimalTypes = sbTypes.ToString();

                CoopsList(true, int.Parse(Farm.tblAnimal.CoopId.ToString()));
                ViewBag.Coops = sbTypes.ToString();

                return View("Create", Farm);

            }
            catch
            {
                return Redirect("/Animal");
            }

        }

        [HttpGet]
        public ActionResult Create()
        {
            Farm.tblAnimal = new Data.tblAnimal();
            sbTypes = new StringBuilder();
            Types = _db.tblAnimalTypes.ToList();
            AnimalTypes(Types, 0, 0);
            ViewBag.AnimalTypes = sbTypes.ToString();

            CoopsList();
            ViewBag.Coops = sbTypes.ToString();

            return View(Farm);

        }

        [HttpPost]
        public ActionResult Save(Data.tblAnimal model)
        {

            Data.tblAnimal _animal;

            if (model.AnimalId != 0)
            {
                _animal = (from x in _db.tblAnimals where x.AnimalId == model.AnimalId select x).FirstOrDefault();
            }
            else _animal = new Data.tblAnimal();

            _animal.AnimalTypeId = model.AnimalTypeId;
            _animal.FarmId = model.FarmId;
            _animal.CoopId = model.CoopId;
            _animal.Title = model.Title;
            _animal.Quantity = model.Quantity;

            _animal.CreationDate = model.CreationDate;
            _animal.PublishDate = model.PublishDate;
            _animal.DeployDate = model.DeployDate;

            if (model.AnimalId == 0)
                _db.tblAnimals.Add(_animal);

            _db.SaveChanges();
            return Redirect("/Animal");

        }

        [HttpGet]
        public ActionResult Remove()
        {
            var _animal = _db.tblAnimals.Where(x => x.AnimalId == Id).FirstOrDefault();
            if (_animal != null)
            {

                var _nest = _db.tblNests.Where(x => x.AnimalId == Id).ToList();

                if (_nest.Count > 0)
                {
                    Farm.IsWarning = true;
                    Farm.WarningBody = String.Format("{0} hayvanına ait toplam {1} adet kuluçka kaydı bulundu. Bu hayvanı kaldıramazsınız.", _animal.Title, _nest.Count);
                    Farm.WarningClass = "note-danger";
                }
                else
                {
                    _db.tblAnimals.Remove(_animal);
                    _db.SaveChanges();
                    Farm.IsWarning = true;
                    Farm.WarningBody = String.Format("{0} hayvanına ait toplam {1} adet kuluçka kaydı bulundu. Sistemden başarıyla kaldırıldı.", _animal.Title, _nest.Count);
                    Farm.WarningClass = "note-success";
                }

            }
            else
            {
                Farm.IsWarning = true;
                Farm.WarningBody = " Aradığınız hayvan bulunamadı.";
                Farm.WarningClass = "note-warning";
            }
            return View("Index", Farm);
        }

        public void AnimalTypes(List<Data.tblAnimalType> dt, int MainCatID, int Level, bool Edit = true, int objId = 0)
        {
            List<Data.tblAnimalType> dr;
            Level++;
            dr = (from x in dt where x.ParentAnimalTypeId == MainCatID select x).ToList();
            int OrderMainCatID;
            string space;
            string selected = "";
            foreach (var item in dr)
            {
                if (Edit)
                {
                    if (item.AnimalTypeId == objId) selected = "selected='selected'";
                }
                OrderMainCatID = item.AnimalTypeId;
                space = new string('→', Level);
                sbTypes.AppendLine("<option value='" + item.AnimalTypeId + "' " + selected + ">" + space + item.Title + "</option>");
                AnimalTypes(dt, OrderMainCatID, Level);
            }
        }

        public void CoopsList(bool Edit = true, int objId = 0)
        {
            string selected = "";
            Coops = _db.tblCoops.Where(x => x.FarmId == Farm.FarmId).ToList();
            sbTypes = null;
            sbTypes = new StringBuilder();
            foreach (var item in Coops)
            {
                if (Edit)
                {
                    if (item.CoopId == objId) selected = "selected='selected'";
                }
                sbTypes.AppendLine("<option value='" + item.CoopId + "' " + selected + ">" + item.Title + "</option>");
            }
        }

    }
}