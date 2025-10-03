using BSEB_MVC.Data;
using BSEB_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BSEB_MVC.Controllers
{
    public class RegistrationForm : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly AppDbContext dbContext;

        public RegistrationForm(IHttpClientFactory httpClientFactory, AppDbContext appDbContext)
        {
            _httpClientFactory = httpClientFactory;
            dbContext = appDbContext;
        }
        private List<SelectListItem> GetFacultyList()
        {
            return dbContext.Faculty_Mst.Where(f => f.IsActive).OrderBy(f => f.FacultyName).Select(f => new SelectListItem { Value = f.Pk_FacultyId.ToString(), Text = f.FacultyName }).ToList();
        }

        public IActionResult Index()
        {

            ViewBag.FacultyList = GetFacultyList();
            return View(new List<StudentMaster>());
        }
    }
}
