namespace BSEB_MVC.Models
{
    public class StudentExamFeeViewModel
    {
        public IEnumerable<College_Mst>? College_Mst { get; set; }
        public IEnumerable<ExamType_Mst>? ExamType_Mst { get; set; }
        public IEnumerable<FacultyMaster>? FacultyMaster { get; set; }
        public IEnumerable<ExamDownloadStudentData>? ExamDownloadStudentData { get; set; }

        public string? CollegeCode { get; set; }

        //[Required(ErrorMessage = "Please select Faculty.")]
        public int? SelectedFacultyId { get; set; }
        public int? SelectedCollegeId { get; set; }
        public int? SelectedExamTypeId { get; set; }

        public IEnumerable<Student_mst>? Students { get; set; }
    }
}
