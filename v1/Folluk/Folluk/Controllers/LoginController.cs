using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Folluk.Models.Users;

namespace Folluk.Controllers
{
    public class LoginController : BaseController
    {

        ILogin login;

        public ActionResult Index()
        {
            login = new ILogin();
            return View("Index", login);
        }

        [HttpPost]
        public ActionResult Index(UserCredential model)
        {
            login = new ILogin();
            login.Model = model;
            login.Do();
            if (login.Status)
            {
                return Redirect("/Home");
            } else
            {
                return View("Index", login);
            }
        }
    }
}