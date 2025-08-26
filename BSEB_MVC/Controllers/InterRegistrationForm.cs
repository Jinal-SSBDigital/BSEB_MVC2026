using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;
using BSEB_MVC.Models;
using System.Linq;

public class InterRegistrationFormController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public InterRegistrationFormController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [HttpGet]
    public async Task<IActionResult> IndexAsync(string studentIds, string CollegeId, string faculty)
    {
        if (string.IsNullOrEmpty(studentIds))
            return View(new List<StudentRegistrationView>());

        var client = _httpClientFactory.CreateClient();
        var url = $"https://localhost:7202/api/InterRegistrationForm/GetStudentRegistrationViewDataAsync?studentIds={studentIds}&CollegeId={CollegeId}&facultyId={faculty}";
        var response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            var jsonString = await response.Content.ReadAsStringAsync();
            var students = JsonSerializer.Deserialize<List<StudentRegistrationView>>(jsonString,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            // Process the subjects for each student
            foreach (var student in students)
            {
                // Initialize the subject groups
                student.CompulsorySubjects = new List<SubjectGroup>();
                student.ElectiveSubjects = new List<SubjectPaperResult>();
                student.AdditionalSubjects = new List<SubjectPaperResult>();
                student.VocationalSubjects = new List<SubjectPaperResult>();

                // Filter subjects by group and assign them to the respective lists
                if (student.Subjects != null)
                {
                    foreach (var subject in student.Subjects)
                    {
                        if (subject.GroupName == "Compulsory")
                        {
                            student.CompulsorySubjects.Add(new SubjectGroup
                            {
                                Group1Subject = new SubjectPaperResult
                                {
                                    SubjectCode = subject.SubjectPaperCode,
                                    SubjectName = subject.SubjectPaperName
                                }
                            });
                        }
                        else if (subject.GroupName == "Elective")
                        {
                            student.ElectiveSubjects.Add(new SubjectPaperResult
                            {
                                SubjectCode = subject.SubjectPaperCode,
                                SubjectName = subject.SubjectPaperName
                            });
                        }
                        else if (subject.GroupName == "Additional")
                        {
                            student.AdditionalSubjects.Add(new SubjectPaperResult
                            {
                                SubjectCode = subject.SubjectPaperCode,
                                SubjectName = subject.SubjectPaperName
                            });
                        }
                        else if (subject.GroupName == "Vocational Additional")
                        {
                            student.VocationalSubjects.Add(new SubjectPaperResult
                            {
                                SubjectCode = subject.SubjectPaperCode,
                                SubjectName = subject.SubjectPaperName
                            });
                        }
                    }
                }
            }

            return View(students);
        }

        return View(new List<StudentRegistrationView>());
    }
}
