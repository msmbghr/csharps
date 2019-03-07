using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Model;
using NuGet.Protocol.Core.Types;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good afternoon";
            return View("MyView");
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            
            return View();
        }
        public ViewResult ListResponses() {
            return View();
        }


        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            
            return View("Thanks",guestResponse);
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        //public string Index() {
        //    return "hello wolrd";
        //}
        
    }
}
