using BSEB_MVC.Data;
using BSEB_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BSEB_MVC.Controllers
{
    public class DownloadRegForm : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly AppDbContext dbContext;

        public DownloadRegForm(IHttpClientFactory httpClientFactory,AppDbContext appDbContext)
        {
            _httpClientFactory = httpClientFactory;
            dbContext=appDbContext;
        }
        private List<SelectListItem> GetFacultyList()
        {
            return dbContext.Faculty_Mst.Where(f => f.IsActive).OrderBy(f => f.FacultyName).Select(f => new SelectListItem{Value = f.Pk_FacultyId.ToString(),Text = f.FacultyName}).ToList();
        }

        public IActionResult Index()
        {
           
            ViewBag.FacultyList = GetFacultyList();
            return View(new List<StudentMaster>());
        }

        [HttpPost]
        public async Task<IActionResult> Index(string collegeName, string studentName, int facultyId)
        {
            string collegeId = "";
            string collegeCode = "";

            var sessionCollegeName = HttpContext.Session.GetString("CollegeName");
            var sessionCollegeId = HttpContext.Session.GetString("CollegeId");

            if (sessionCollegeName == "Admin")
            {
              
                collegeCode = collegeName;
            }
            else
            {
                
                collegeId = sessionCollegeId;
                collegeId = string.IsNullOrWhiteSpace(collegeId) ? "" : collegeId;
            }
            studentName = string.IsNullOrWhiteSpace(studentName) ? "" : studentName;
            var client = _httpClientFactory.CreateClient();
            var url = $"https://localhost:7202/api/DwnldRegForm/GetStudentData" +$"?collegeId={collegeId}&collegeCode={collegeCode}&studentName={studentName}&facultyId={facultyId}";

            var response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                ModelState.AddModelError("", $"API error: {response.StatusCode}");
                ViewBag.FacultyList = GetFacultyList();
                return View(new List<StudentMaster>());
            }

            var result = await response.Content.ReadFromJsonAsync<List<StudentMaster>>();

            ViewBag.FacultyList = GetFacultyList();
            return View(result ?? new List<StudentMaster>());
        }

        [HttpPost]
        public IActionResult DownloadPdf([FromBody] DownloadRequest request)
        {
            if (request == null || request.StudentIds == null || !request.StudentIds.Any())
            {
                return Json(new { success = false, message = "No students selected." });
            }

            // Convert IDs into comma separated string
            var ids = string.Join(",", request.StudentIds);

            // Build redirect URL with query parameters
            var redirectUrl = Url.Action("Index", "InterRegistrationForm", new
            {
                studentIds = ids,
                college = request.College,
                faculty = request.Faculty
            });

            return Json(new { success = true, redirectUrl });
        }

    }
}
