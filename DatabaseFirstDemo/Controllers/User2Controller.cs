using Microsoft.AspNetCore.Mvc;

namespace DatabaseFirstDemo.Controllers
{
    public class User2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
