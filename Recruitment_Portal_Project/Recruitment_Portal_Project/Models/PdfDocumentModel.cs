using System.ComponentModel.DataAnnotations.Schema;

namespace Recruitment_Portal_Project.Models
{
    public class PdfDocumentModel
    {
        public int Id { get; set; }

        public string FileName { get; set; }

        public byte[] FIelData { get; set; }

        public DateTime UploadDate { get; set; }

        [ForeignKey("JobSeekerID")]

        public JobSeekerSignupModel JobSeekerId { get; set; }
    }
}
