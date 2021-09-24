using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Folluk.Data;
using System.IO.Compression;

namespace Folluk.Controllers
{
    public class BaseController : Controller
    {

        public dbFollukEntities _db = new dbFollukEntities();

        public string ControllerName, ControllerMethodName, URL = "";
        public int AccountId, Id = 0;
        
        public Data.tblFarm Farm;
        public Data.tblAccount Account;

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            ControllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            ControllerMethodName = this.ControllerContext.RouteData.Values["action"].ToString();

            URL = ControllerName + "/" + ControllerMethodName;

            if (Session["AccountId"] == null)
            {
                if (ControllerMethodName != "Login")
                {
                    filterContext.Result = new RedirectResult("/Account/Login");
                    return;
                }
            }
            else
            {
                //get account
                AccountId = int.Parse(Session["AccountId"].ToString());

                Account = (from x in _db.tblAccounts where x.AccountId == AccountId select x).FirstOrDefault();

                if (Account != null)
                {
                    ViewBag.AccountId = Account.AccountId;
                    ViewBag.Fullname = Account.Fullname;
                }
                else
                {
                    Session.Abandon();
                    filterContext.Result = new RedirectResult("/Account/Login");
                    return;
                }

                //get farm
                Farm = (from x in _db.tblFarms where x.AccountId == AccountId select x).FirstOrDefault();
                if (URL != "Farm/Save")
                {
                    if (URL != "Farm/Create")
                    {
                        if (Farm != null)
                        {
                            _id();
                            Farm.tblAccount = Account;
                            Farm.tblAnimalCount = (from x in _db.tblAnimals where x.FarmId == Farm.FarmId select x).ToList().Count;
                            Farm.tblCoopCount = (from x in _db.tblCoops where x.FarmId == Farm.FarmId select x).ToList().Count;
                            Farm.tblNestCount = (from x in _db.tblNests where x.FarmId == Farm.FarmId select x).ToList().Count;
                        }
                        else
                        {
                            filterContext.Result = new RedirectResult("/Farm/Create");
                            return;
                        }
                    }
                    else
                    {
                        Farm = new tblFarm();
                        Farm.tblAccount = Account;
                    }
                }
                //get farm

            }

        }

        protected void _id()
        {
            if (this.ControllerContext.RouteData.Values["id"] != null)
            {
                Id = int.Parse(this.ControllerContext.RouteData.Values["id"].ToString());
            }
            else
            {
                Id = 0;
            }
        }

    }
}