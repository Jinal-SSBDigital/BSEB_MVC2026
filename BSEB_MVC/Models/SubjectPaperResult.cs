namespace BSEB_MVC.Models
{
    public class SubjectPaperResult
    {
        public int? SubjectCode { get; set; }
        public string? SubjectName { get; set; }

        // New properties to align with the error message
        public string? GroupName { get; set; }
        public string? SubjectPaperName { get; set; }
        public int? SubjectPaperCode { get; set; }

        // Extra properties, as seen in your input (if you want to use these as well)
        public string? Name1 { get; set; }
        public int? Code1 { get; set; }
        public string? Name2 { get; set; }
        public int? Code2 { get; set; }
        public string? Name3 { get; set; }
        public int? Code3 { get; set; }
    }
}
