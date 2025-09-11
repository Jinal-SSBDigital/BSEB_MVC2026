using BSEB_MVC.Data;
using BSEB_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BSEB_MVC.Controllers
{
    public class Login : Controller
    {
        private readonly AppDbContext dbContext;
        private readonly IHttpClientFactory _httpClientFactory;

        public Login(IHttpClientFactory httpClientFactory, AppDbContext appDbContext)
        {
            _httpClientFactory = httpClientFactory;



            dbContext = appDbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            HttpContext.Session.Clear();
            return View(new UserMaster());
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserMaster model)
        {
            var client = _httpClientFactory.CreateClient();
            var url = $"https://localhost:7202/api/Login/LoginData?UserName={model.Username}&Password={model.Password}";

            try
            {
                var response = await client.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    ModelState.AddModelError("", "Error calling API.");
                    return View(model);
                }

                var jsonString = await response.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<LoginApiResponse>(jsonString);

                if (result.Message == "Login successful." && result.Data != null && result.Data.Any())
                {
                    var user = result.Data.First();

                    // ✅ Safe session setting (null → empty string)
                    HttpContext.Session.SetString("CollegeId", user.Id.ToString());
                    HttpContext.Session.SetString("UserName", user.UserName ?? "");
                    HttpContext.Session.SetString("CollegeName", user.CollegeName ?? "");
                    HttpContext.Session.SetString("CollegeCode", user.CollegeCode ?? "");
                    HttpContext.Session.SetString("DistrictName", user.DistrictName ?? "");
                    HttpContext.Session.SetString("DistrictCode", user.DistrictCode ?? "");
                    HttpContext.Session.SetString("PrincipalMobileNo", user.PrincipalMobileNo ?? "");
                    HttpContext.Session.SetString("EmailId", user.EmailId ?? "");

                    HttpContext.Session.SetString("ActiveModule", "registration");
                    return RedirectToAction("Index", "Dashboard");
                }

                ModelState.AddModelError("", result.Message ?? "Invalid login.");
                return View(model);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Something went wrong: " + ex.Message);
                return View(model);
            }
        }
    }
}
