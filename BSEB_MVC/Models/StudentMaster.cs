namespace BSEB_MVC.Models
{
    public class StudentMaster
    {
        public int StudentID { get; set; }
        public string? StudentName { get; set; }
        public string? FatherName { get; set; }
        public string? MotherName { get; set; }
        public DateTime? DOB { get; set; }
        public string? Faculty { get; set; }
        public string? College { get; set; }
        public bool? FormDownloaded { get; set; }
        public int? FacultyId { get; set; }
        public int? CollegeId { get; set; }

        public string SubCategoryName { get; set; }
        public string status { get; set; }

        public DateTime createddate { get; set; }
        public int CatId { get; set; }

        //public DateTime createddate { get; set; }
        //public int CatId { get; set; }

    }
}
