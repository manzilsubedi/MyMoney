using Microsoft.AspNetCore.Mvc;

namespace MyMoney.Controllers
{
    public class TranscationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
