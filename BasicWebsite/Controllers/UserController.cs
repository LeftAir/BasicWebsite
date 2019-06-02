using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicWebsite.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [Route("login")]
        public ActionResult Login()
        {
            return View();
        }
        [Route("register")]
        public ActionResult Register()
        {
            return View();
        }
    }
}