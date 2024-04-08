using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Recruitment_Portal_Project.Models
{
    public class ApplicationDetailsModel
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("JobID ")]
        public JobDetailsModel jobId { get; set; }

        [Required]
        public string? JobProviderName { get; set; }
        [Required]

        public string? PreferredLocation { get; set; }
        [ForeignKey("JobSeekerID")]
        public JobSeekerSignupModel SeekerSignupModel { get; set; }
    }
}
