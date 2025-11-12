using System.ComponentModel.DataAnnotations;

namespace BSEB_MVC.Models
{
    public class ExamType_Mst
    {
        [Key]
        public int Pk_ExamTypeId { get; set; }
        public string ExamTypeName { get; set; }
        public bool IsActive { get; set; }
    }
}
