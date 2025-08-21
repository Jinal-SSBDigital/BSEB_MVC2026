namespace BSEB_MVC.Models
{
    public class DownloadRequest
    {
        // Changed to List<int> to match JavaScript's parseInt
        public List<int> StudentIds { get; set; }
        public string collegeId { get; set; }
        // Changed to int to match the data-faculty attribute and form input
        public int Faculty { get; set; }
    }
}
