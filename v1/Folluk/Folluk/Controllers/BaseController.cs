using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Folluk.Models;
using Folluk.Models.Utility;

namespace Folluk.Controllers
{
    public class BaseController : Controller
    {

        public int Id { get; set; }

        public string ControllerName { get; set; }
        public string ActionName { get; set; }

        public bool IsAuthenticate { get; set; }
        public int UserId { get; set; }

        public List<OController> Controllers = new List<OController>();

        IWarning OWarning;

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            OWarning = new IWarning();

            _id();
            _url();
            _session();
            _controllers();

            OController tempController = (from x in this.Controllers where x.Name == this.ControllerName select x).FirstOrDefault();
            
            if(tempController != null && tempController.IsAuthenticationRequired)
            {
                if (!this.IsAuthenticate)
                {
                    filterContext.Result = new RedirectResult("/Login");
                    return;
                }
            }
            
            base.OnActionExecuting(filterContext);
        }

        void _id()
        {
            try
            {
                this.Id = int.Parse(ControllerContext.RouteData.Values["id"].ToString());
            }
            catch
            {
                this.Id = 0;
            }
        }
        void _url()
        {
            try
            {
                this.ControllerName = ControllerContext.RouteData.Values["controller"].ToString();
                this.ActionName = ControllerContext.RouteData.Values["action"].ToString();
            }
            catch
            {
                this.ActionName = this.ControllerName = "";
            }
        }
        void _session()
        {
            try
            {
                this.UserId = int.Parse(Session["UserId"].ToString());
                this.IsAuthenticate = true;
            }
            catch
            {
                this.IsAuthenticate = false;   
            }
        }
        void _controllers()
        {
            this.Controllers.Add(new OController(1, "Login", false));
            this.Controllers.Add(new OController(1, "Home", false));
            this.Controllers.Add(new OController(1, "Irklar", true));
            this.Controllers.Add(new OController(1, "Ureticiler", true));
        }

    }
}