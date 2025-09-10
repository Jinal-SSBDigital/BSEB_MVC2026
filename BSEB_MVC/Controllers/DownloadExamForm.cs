using Microsoft.AspNetCore.Mvc;

namespace BSEB_MVC.Controllers
{
    public class DownloadExamForm : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
