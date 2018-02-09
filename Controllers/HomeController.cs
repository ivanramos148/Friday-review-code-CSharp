using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
          public ActionResult index()
        {
            return View();
        }

          [HttpPost("/list/clear")]
        public ActionResult Clear()
        {
            Car.Clear();
            return View();
        }






    }
}
