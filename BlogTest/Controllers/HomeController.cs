using Microsoft.AspNetCore.Mvc;

namespace BlogTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
	}
}