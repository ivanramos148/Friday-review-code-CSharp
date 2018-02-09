using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Address.Models;

namespace Project.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
          public ActionResult Form()
        {
            return View();
        }

          [HttpPost("/list/clear")]
        public ActionResult Clear()
        {
            adds.Clear();
            return View();
        }
        [Route("/list")]
        public ActionResult List()
        {
        Address newAddress = new Address(
            Request.Form["name"],
            Request.Form["phone"],
            Request.Form["address"])
        );
        newAddress.Save();
        List<Address> allAddress = adds.GetAll();
            return View(allAddress);
          }
    }
}
