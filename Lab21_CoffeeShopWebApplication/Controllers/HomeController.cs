using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Lab21_CoffeeShopWebApplication.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            return View();
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
        //this will to to my registration view
        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult Welcome(string firstName = "Whatever", string lastName = "Knowhere", 
            string mailAddress = "123 Infinity", string city = "Hollywood", string state="Washington",
            int zipCode = 12345, string emailAddress = "none@none.com", int phoneNumber=313-777-9311, 
            string passWord1 = "password", string passWord2 = "password")
        {
            //ActionResults
            ViewBag.First = firstName;
            ViewBag.Last = lastName;
            ViewBag.MailAddress = mailAddress;
            ViewBag.City = city;
            ViewBag.State = state;
            ViewBag.ZipCode = zipCode;
            ViewBag.Email = emailAddress;
            ViewBag.Phone = phoneNumber;
            ViewBag.Password1 = passWord1;
            ViewBag.Password2 = passWord2;
            return View();
        }
    }
}