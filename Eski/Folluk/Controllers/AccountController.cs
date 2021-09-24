using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Folluk.Controllers
{
    public class AccountController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Folluk.Data.tblAccountCredential model)
        {
            try
            {

                string _username = model.Username;
                string _password = model.Password;

                var _login = (from x in _db.tblAccountCredentials where x.Username == _username && x.Password == _password select x).FirstOrDefault();

                if (_login != null)
                {

                    Session["AccountId"] = _login.AccountId.ToString();
                    Session["Fullname"] = _login.tblAccount.Fullname;

                    var _farm = (from x in _db.tblFarms where x.AccountId == _login.AccountId select x).FirstOrDefault();

                    if (_farm != null)
                    {
                        return Redirect("/Farm");
                    }
                    else
                    {
                        return Redirect("/Farm/Create");
                    }

                }
                else return RedirectToAction("Login");

            }
            catch
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Others()
        {
            return View(Farm);
        }

        public ActionResult Profile()
        {
            if (Id != 0)
            {
                Farm.tblProfile = _db.tblAccounts.Where(x => x.AccountId == Id).FirstOrDefault();
            }
            else
            {
                Farm.tblProfile = Farm.tblAccount;
            }
            
            return View(Farm);
        }

        public ActionResult Logout()
        {
            Session["AccountId"] = null;
            Session.Abandon();
            return RedirectToAction("Login");
        }

    }
}