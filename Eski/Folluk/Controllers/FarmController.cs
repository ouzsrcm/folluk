using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Folluk.Controllers
{
    public class FarmController : BaseController
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

        [HttpPost]
        public ActionResult Save(Folluk.Data.tblFarm model)
        {
            Data.tblFarm _farm;
            if (model.FarmId != 0)
            {
                _farm = (from x in _db.tblFarms where x.FarmId == model.FarmId select x).FirstOrDefault();
            }
            else _farm = new Data.tblFarm();

            _farm.AccountId = AccountId;
            _farm.Title = model.Title;
            _farm.Description = model.Description;

            if (model.FarmId == 0)
                _db.tblFarms.Add(_farm);

            _db.SaveChanges();
            return Redirect("/Farm/Index");

        }

    }
}