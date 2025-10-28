using Microsoft.AspNetCore.Mvc;

namespace MyMoney.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
