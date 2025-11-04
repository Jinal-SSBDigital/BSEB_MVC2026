namespace BSEB_MVC.Models
{
    public class Student_PayMst
    {
        public int StudentID { get; set; }
        public string? StudentName { get; set; }
        public string? FatherName { get; set; }
        public string? MotherName { get; set; }
        public string? RegistrationNo { get; set; }
        public DateTime? DOB { get; set; }
        public string? Faculty { get; set; }
        public string? College { get; set; }
        public int? FacultyId { get; set; }
        public int? CollegeId { get; set; }

        public string? CasteCategoryCode { get; set; } = "";
        public string? ExamTypeName { get; set; } = "";
        public string? BaseFee { get; set; } = "";
        public string? ConcessionFee { get; set; } = "";

        public bool? IsFirstExam { get; set; }
    }
}
