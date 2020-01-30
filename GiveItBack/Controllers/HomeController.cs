using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiveItBack.Models;
namespace GiveItBack.Controllers
{
    public class HomeController : Controller
    {
        public static List<Item> items = new List<Item>();

        public ActionResult Index()
        {
            
            for(int i = 0; i < 5; i++)
            {
                Item item = new Item();
                item.Name = "Name " + i;
                item.Category = "Category " + (i % 2 + 1);
                item.LendDate = DateTime.Now;
                item.Contact = new User { Name = "Jeff" +i, Email = $"Email{i +1}@gmail.com" };
                items.Add(item);
            }
            ViewBag.items = items;
            return View(ViewBag);
        }

     
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult AddItem()
        {
            return View();
        }

        public ActionResult UpdateItem()
        {
            return View();
        }


    }
}