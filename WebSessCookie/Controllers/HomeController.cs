using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSessCookie.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string name)
        {
            List<string> names;
            if (Session["Names"]==null)
            {
                names=new List<string>();
            }
            else
            {
               names=(List<string>)Session["Names"];
            }

            names.Add(name);
            Session["Names"] = names;
            return View();
        }
    }
}