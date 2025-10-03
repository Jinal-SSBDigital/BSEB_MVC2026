namespace WebApplication1.DTOs
{
    public class CategoryMaster
    {
       // public Guid CatId { get; set; }
        public string CategoryName { get; set; }
        public string status { get; set; }

        public DateTime createddate { get; set; }
       
    }
    public class SubCategoryMaster
    {
        // public Guid CatId { get; set; }
        public string SubCategoryName { get; set; }
        public string status { get; set; }

        public DateTime createddate { get; set; }
        public int CatId { get; set; }

    }
}
