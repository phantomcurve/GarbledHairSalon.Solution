using Microsoft.AspNetCore.Mvc;

namespace BestRestos.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}