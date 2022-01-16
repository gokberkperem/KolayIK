using Microsoft.AspNetCore.Mvc;

namespace Kolayik.UI.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(PersonelModel model)
        {
            return View();
        }
    }
}
