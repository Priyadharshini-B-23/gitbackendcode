using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recruitment_Portal_Project.Models
{
    public class ProfileModel
    {

        [Key]
        public int JobSeekerRegistrationID { get; set; }
        [Required]

        public string? FirstName { get; set; }
        [Required]

        public string? LastName { get; set; }
        [Required]

        public string? EmailId { get; set; }
        [Required]


        public string? Qualification { get; set; }
        [Required]

        public string? Experience { get; set; }

        [Required]



        public float TenthPercentage { get; set; }
        [Required]


        public float TwelvethPercentage { get; set; }
        [Required]

        public float CGPA { get; set; }
        [Required]

        public long PhoneNumber { get; set; }
        [Required]

        public string? SkillSet { get; set; }
        [Required]

        public string? Location { get; set; }


        public byte[] Resume { get; set; }

        public string? UniqueFileName { get; set; }
        [ForeignKey("JobSeekerID")]
        public int JobSeekerSignupModel { get; set; }

    }
}
