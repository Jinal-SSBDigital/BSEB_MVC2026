using System.ComponentModel.DataAnnotations;

namespace BSEB_MVC.Models
{
    public class FacultyMaster
    {
        [Key]
        public int Pk_FacultyId { get; set; }
        public string FacultyName { get; set; }
        public bool IsActive { get; set; }
    }
}
