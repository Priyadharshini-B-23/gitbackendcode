using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recruitment_Portal_Project.Models
{
    public class JobDetailsModel
    {
        [Key]

        public int JobID { get; set; }
        [Required]

        public string? JobName { get; set; }
        [Required]

        public string? Role { get; set; }
        [Required]

        public string? CompanyName { get; set; }
        [Required]


        public string? CompanyType { get; set; }
        [Required]

        public string? Location { get; set; }
        [Required]

        public string? Description { get; set; }
        [Required]

        public string? AboutCompany { get; set; }
        [Required]

        public int salary { get; set; }
        [Required]

        public string? EmployeeType { get; set; }
        [ForeignKey("JobProviderID")]
        public JobProviderSignupModel SignupModel { get; set; }
        public string Status { get; set; }
    }
}
