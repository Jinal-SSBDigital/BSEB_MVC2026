using BSEB_MVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace BSEB_MVC.Controllers
{
    public class Student_ExamPayFee : Controller
    {
        private readonly AppDbContext _context;

        public Student_ExamPayFee(AppDbContext context)
        {
            _context = context;
        }

        // GET: Student_ExamPayFee
        public async Task<IActionResult> Index()
        {
            ViewBag.FacultyList = await _context.Faculty_Mst.Where(f => f.IsActive).ToListAsync();
            //ViewBag.CollegeList = await _context.College_Mst.ToListAsync();
            ViewBag.ExamTypeList = await _context.ExamType_Mst.Where(e => e.IsActive).ToListAsync();

            //var students = await _context.Student_mst.ToListAsync();
            //return View(students);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetExamfeeStudent(int? SelectedFacultyId, string CollegeCode, int SelectedExamTypeId)
        {
            try
            {
                //var CollegeId = new SqlParameter("@CollegeId", string.IsNullOrEmpty(CollegeCode) ? (object)DBNull.Value : (object)CollegeCode);
                //var StudentName = new SqlParameter("@StudentName", "");
                //var FacultyId = new SqlParameter("@FacultyId", SelectedFacultyId);
                //var ExamId = new SqlParameter("@ExamId", SelectedExamTypeId);
                //var pCategoryName = new SqlParameter("@CategoryName", "");
                //var pSubCategory = new SqlParameter("@SubCategory", "makepayment");

                //var sql = "EXEC sp_GetExamDwnldStudentData @CollegeId, @StudentName, @FacultyId, @ExamId, @CategoryName, @SubCategory";

                //var list = await _context.ExamDownloadStudentData.FromSqlRaw(sql, CollegeId, StudentName, FacultyId, ExamId, pCategoryName, pSubCategory).ToListAsync();

                return Json(new { success = "true" });
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = ex.Message });
            }

        }



    }
}
