namespace WebApplication1.DTOs
{
    public class CategorySubCategoryMaster
    {
        public int CatId { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public int SubCatId { get; set; }

        public string? Faculty { get; set; }
        public string? College { get; set; }
        public bool? FormDownloaded { get; set; }
        public int? FacultyId { get; set; }
        public int? CollegeId { get; set; }


    }
}
