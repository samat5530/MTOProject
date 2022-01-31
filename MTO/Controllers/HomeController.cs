using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MTO.Models;

namespace MTO.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Done()
        {
            return View();
        }
        public ActionResult Test()
        {
            return View();
        }
        public ActionResult Teacher()
        {
            return View();
        }
        public ActionResult Stud()
        {
            return View();
        }
        public ActionResult LogOut()
        {
            HttpContext.Response.Cookies["MyID"].Value = null;
            HttpContext.Response.Cookies["Name"].Value = null;
            HttpContext.Response.Cookies["FirstName"].Value = null;
            Response.Cookies["Session"].Value = "0";
            return Redirect("/Home/Index");
        }
        public ActionResult UserPage()
        {
            ViewBag.my_id = HttpContext.Request.Cookies["MyID"].Value;

            return View();
        }
        public ActionResult Login()
        {
            if (HttpContext.Request.Cookies["Session"] == null)
            {
                HttpCookie Session = new HttpCookie("Session", "0");
                HttpContext.Response.Cookies.Add(Session);
                return View();
            }
            else
            {
                if (HttpContext.Request.Cookies["Session"].Value == "0")
                    return View();

                else return View("UserPage");
            }
            
        }

        public ActionResult LoginUser(string inputFirstName,string inputName, string inputLastName, string inputPassword)
        {
            DataManager db = new DataManager();
            int[] status = db.User.LoginUser(inputFirstName, inputName, inputLastName, inputPassword);
            if (status[1] == 1) {
                ViewBag.Error=0;
                HttpCookie cookie = new HttpCookie("MyID", "0");
                HttpCookie cookie2 = new HttpCookie("MyID", "0");
                HttpCookie cookie3 = new HttpCookie("MyID", "0");
                cookie["MyID"] = status[3].ToString();
                cookie2["FirstName"] = inputFirstName;
                cookie3["Name"] = inputName;
                HttpContext.Response.Cookies.Add(cookie);
                HttpContext.Response.Cookies.Add(cookie2);
                HttpContext.Response.Cookies.Add(cookie3);
                HttpContext.Response.Cookies["Session"].Value = "1";
                ViewBag.UserName = inputName;
                ViewBag.UserFirstName = inputFirstName;
                return View();
            }
            else
            {
                ViewBag.Error =1;
                return View();
            }
            
        }
        public ActionResult Index()
        {
            if (HttpContext.Request.Cookies["Session"] != null)
            {
                if (HttpContext.Request.Cookies["Session"].Value == "1")
                    return View();
                else
                {
                    return View();
                }
            }
            else
            {
                HttpCookie Session = new HttpCookie("Session", "0");
                HttpContext.Response.Cookies.Add(Session);
                return View();
            }
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}