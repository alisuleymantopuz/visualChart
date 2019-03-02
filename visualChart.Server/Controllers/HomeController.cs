using Microsoft.AspNetCore.Mvc;
namespace visualChart.Server.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
