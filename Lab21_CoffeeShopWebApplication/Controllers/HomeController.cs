using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//Added the Models update for Lab23
using Lab21_CoffeeShopWebApplication.Models;



namespace Lab21_CoffeeShopWebApplication.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {   //Added CoffeeShopDBEntities from Lab21
            CoffeeShopDBEntities ORM = new CoffeeShopDBEntities();
            //Add New Users to Users Table
            ViewBag.Items = ORM.Items.ToList();

            //Build Spec 6 - Modify the action that the user form posts
            // so that it adds a new User through my ORM
            ViewBag.Users = ORM.Users.ToList();

            return View();
        }

        //Pass in the User data so that we can add the new item to our DB
        public ActionResult About(User data)
        {
            CoffeeShopDBEntities ORM = new CoffeeShopDBEntities();
            //Check to make sure the Item Model that we passed in is Valid
            if (ModelState.IsValid)
            {
                //if the model is valid then we add to our DB
                ORM.Users.Add(data);
                //we have to save our changes or they won't stay in our DB
                ORM.SaveChanges();
                ViewBag.message = $"{data.UserID} has been added";
            }
            else
            {
                ViewBag.message = "Item is not valid, cannot add to DB.";
            }

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