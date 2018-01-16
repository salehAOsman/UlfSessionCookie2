using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSessCookie.Controllers
{
    public class HighScoreController : Controller
    {
        // GET: HighScore
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string number)
        {
            HttpCookie myCookie= Request.Cookies["hight"];
            //1 give key word, we make object for cookie
            if (myCookie==null)
            {
            myCookie = new HttpCookie("hight");
            myCookie["values"] = number;//
            }
            else
            {
                myCookie["values"] = myCookie["values"] + '£'+ number;
            }
            myCookie.Expires = DateTime.Now.AddHours(1);//add time 
            Response.Cookies.Add(myCookie);//save cookie

            var myNumbers = myCookie["values"].Split('£');

            ViewBag.MyNumbers = myNumbers;

            return View();
        }
    }
}