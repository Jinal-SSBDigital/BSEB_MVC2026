using System.ComponentModel.DataAnnotations;

namespace BSEB_MVC.Models
{
    public class Student_mst
    {
        [Key]
        public int Pk_StudentId { get; set; }

        public string? OfssReferenceNo { get; set; }
        public int? Fk_BoardId { get; set; }
        public string? MatricPassingYear { get; set; }

        public string? StudentFullName { get; set; }
        public string? FatherName { get; set; }
        public string? MotherName { get; set; }
        //public string? Faculty { get; set; }
        //public string? ExamTypeName { get; set; }
        //public string? College { get; set; }
        public string? AadharCardNo { get; set; }

        public int? Fk_CollegeId { get; set; }
        public int? Fk_FacultyId { get; set; }
        public int? Fk_GenderId { get; set; }
        public int? Fk_ExamTypeId { get; set; }
        public int? Fk_CasteCategoryId { get; set; }
        public int? Fk_ReligionId { get; set; }
        public int? Fk_NationalityId { get; set; }
        public int? Fk_MaritalStatusId { get; set; }
        public int? Fk_ExamMediumId { get; set; }

        public string? IdentificationMark1 { get; set; }
        public string? IdentificationMark2 { get; set; }
        public string? StudentUniqueId { get; set; }

        public string? EmailId { get; set; }
        public string? MobileNo { get; set; }
        public string? PreviousRollNumber { get; set; }
        public string? PreviousYearExamination { get; set; }
        public string? RollCode { get; set; }
        public string? RollNumber { get; set; }
        public string? RegistrationNo { get; set; }

        public bool? IsRegFeeSubmit { get; set; }
        public bool? IsRegFormSubmit { get; set; }
        public bool? IsExamFeeSubmit { get; set; }
        public bool? IsExamFormSubmit { get; set; }
        public bool? RegisterFormDownloaded { get; set; }

        public int? FK_AreaId { get; set; }
        public DateTime? DOB { get; set; }

        public string? SubDivisionName { get; set; }
        public string? DistrictName { get; set; }
        public bool? IsDifferentlyAbled { get; set; }
        public string? ParentGuardianMobileNo { get; set; }
        public string? Address { get; set; }
        public string? PinCode { get; set; }

        public string? BankBranchName { get; set; }
        public string? IFSCCode { get; set; }
        public string? StudentBankAccountNo { get; set; }
        public string? CategoryName { get; set; }

        public string? StudentPhotoPath { get; set; }
        public string? StudentSignaturePath { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public bool? IsRegCardUploaded { get; set; }
        public string? RegCardPath { get; set; }

        public string? TheoryExamCenterCode { get; set; }
        public string? TheoryExamCenterName { get; set; }
        public string? PracticalExamCenterCode { get; set; }
        public string? PracticalExamCenterName { get; set; }

        public string? ApaarId { get; set; }
        public bool? IsDeclarationFormSubmitted { get; set; }
        public bool? IsDeclarationFormDownloaded { get; set; }
        public string? DeclarationFormPath { get; set; }

        public string? MatricRollNumber { get; set; }
        public string? MatricRollCode { get; set; }
        public bool? ExamFormDownloaded { get; set; }

        public string? AadharFileName { get; set; }
        public string? BlockRemarks { get; set; }

        //public bool? IsOldStudent { get; set; }
        public bool? IsFirstExam { get; set; }

        //public DateTime? ValidFrom { get; set; }
        //public DateTime? ValidTo { get; set; }
        //public DateTime? InsertedToHistoryDate { get; set; }
    }
}
