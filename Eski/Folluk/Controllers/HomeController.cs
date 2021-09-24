using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Folluk.Data;

namespace Folluk.Controllers
{
    public class HomeController : Controller
    {

        dbFollukEntities db = new dbFollukEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Data.tblAccount model)
        {

            try
            {
                if (model.Fullname.ToString() != "" && model.Email.ToString() != "")
                {

                    Data.tblAccount acc = new Data.tblAccount();

                    acc.Fullname = model.Fullname;
                    acc.Email = model.Email;

                    try
                    {
                        db.tblAccounts.Add(acc);
                        db.SaveChanges();
                        return Redirect("/Home/Credential/" + acc.AccountId.ToString());
                    }
                    catch
                    {
                        return Redirect("/Home/Register");
                    }

                }
                else return Redirect("/Home/Register");
            }
            catch
            {
                return Redirect("/Home/Register");
            }
        }

        public ActionResult Credential()
        {
            ViewBag.AccountId = ControllerContext.RouteData.Values["id"].ToString();
            return View("CreateCredential");
        }

        public ActionResult Success()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Credential(tblAccountCredential model)
        {

            if (model.Username.ToString().Trim() != "" && model.Password.ToString().Trim() != "")
            {

                Data.tblAccountCredential acc = new Data.tblAccountCredential();

                acc.AccountId = model.AccountId;
                acc.Username = model.Username;
                acc.Password = model.Password;

                try
                {
                    db.tblAccountCredentials.Add(acc);
                    db.SaveChanges();
                    return Redirect("/Account");
                }
                catch
                {
                    return Redirect("/Home/Credential/" + model.AccountId);
                }

            }
            else return Redirect("/Home/Credential/" + model.AccountId);

        }

    }
}