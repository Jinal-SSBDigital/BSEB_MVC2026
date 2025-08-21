using BSEB_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;

namespace BSEB_MVC.Controllers
{
    public class InterRegistrationForm : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public InterRegistrationForm(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public async Task<IActionResult> IndexAsync(string studentIds, string CollegeId, string faculty)
        {
            if(string.IsNullOrEmpty(studentIds))
            return View(new List<StudentRegistrationView>());

            var client= _httpClientFactory.CreateClient();
            var url = $"https://localhost:7202/api/InterRegistrationForm/GetStudentRegistrationViewDataAsync" + $"?studentIds={studentIds}&CollegeId={CollegeId}&facultyId={faculty}";
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var students = JsonSerializer.Deserialize<List<StudentRegistrationView>>(jsonString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return View(students);
            }

            return View(new List<StudentRegistrationView>());
        }
    }
}
