using Microsoft.AspNetCore.Mvc;

namespace Kolayik.UI.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int MyProperty { get; set; }
    }
}
