using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Infos.Models;

namespace Project.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public ActionResult Form()
        {
          System.Console.WriteLine("here");
            return View();
        }

        [HttpPost("/list/clear")]
        public ActionResult Clear()
        {
            Info.Clear();
            return View();
        }

        [Route("/list")]
        public ActionResult List()
        {
        Info newInfo = new Info(
            Request.Form["name"],
            Request.Form["phone"],
            Request.Form["address"]
        );
        newInfo.Save();
        List<Info> allInfo = Info.GetAll();
            return View(allInfo);
          }
    }
}
