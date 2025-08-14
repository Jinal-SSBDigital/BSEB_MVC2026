using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BSEB_MVC.Controllers
{
    public class DashboardController : Controller
    {
        
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("CollegeId") == null)
            {
                return RedirectToAction("Index", "Login");
            }
            
            if (HttpContext.Session.GetString("ActiveModule") == null)
            {
                HttpContext.Session.SetString("ActiveModule", "registration");
            }

            
            ViewBag.IsAdmin = (HttpContext.Session.GetString("CollegeName")?.ToLower() == "Admin");

           
            ViewBag.ActiveModule = HttpContext.Session.GetString("ActiveModule");

            return View();
        }

        [HttpGet]
        public IActionResult SetModuleRegistration()
        {
            HttpContext.Session.SetString("ActiveModule", "registration");
            return RedirectToAction("Index", "DownloadRegForm");
        }

        
        [HttpGet]
        public IActionResult SetModulePreExamination()
        {
            HttpContext.Session.SetString("ActiveModule", "preexam");
            return RedirectToAction("Index", "DownloadExamForm");
        }
    }
}