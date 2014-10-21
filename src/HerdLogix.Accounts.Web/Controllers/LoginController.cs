using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HerdLogix.Accounts.Web.Controllers
{
    [RoutePrefix("login")]
    public class LoginController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }
    }
}