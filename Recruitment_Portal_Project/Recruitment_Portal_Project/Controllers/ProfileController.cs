//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Recruitment_Portal_Project.Data;
//using Recruitment_Portal_Project.Models;
//using System.Text;

//namespace Recruitment_Portal_Project.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProfileController : ControllerBase
//    {
//        private readonly AppDbContext _profiledetails;

//        private readonly IWebHostEnvironment _environment;

//        private readonly IConfiguration _configuration;


//        public ProfileController(AppDbContext profiledetails,IWebHostEnvironment environment,IConfiguration configuration)

//        {
//            _profiledetails = profiledetails;
//            _environment = environment;
//            _configuration = configuration;
//        }

//        //[HttpGet("{Item_Id}")]

//        //public async Task<ProfileModel> GetById(int id)

//        //{

//        //    return await _profiledetails.Resume.FindAsync(id);

//        //}

//        //[HttpGet("{id}/Image")]

//        //public IActionResult GetImage(int id)

//        //{

//        //    var request = _profiledetails.Resume.Find(id);

//        //    if (request == null)

//        //    {

//        //        return NotFound(); // User not found 

//        //    }



//        //    // Construct the full path to the image file 

//        //    var imagePath = Path.Combine(_environment.WebRootPath, "images", request.UniqueFileName);



//        //    // Check if the image file exists 

//        //    if (!System.IO.File.Exists(imagePath))

//        //    {

//        //        return NotFound(); // Image file not found 

//        //    }



//        //    // Serve the image file 

//        //    return PhysicalFile(imagePath, "image/jpeg");

//        //}

     

//        [HttpPost("{id}")]
//        public async Task<ActionResult<ProfileModel>> CreateUser([FromForm] ProfileModel request,int id)
//        {
//            JobSeekerSignupModel jobs = _profiledetails.SeekerSignup.FirstOrDefault(j => j.JobSeekerID == id);


//            // Generate a unique file name 
//            var uniqueFileName = $"{Guid.NewGuid()}_{request.Resume.FileName}";



//            // Save the image to a designated folder (e.g., wwwroot/images) 
//            var uploadsFolder = Path.Combine(_environment.WebRootPath, "Images");
//            var filePath = Path.Combine(uploadsFolder, uniqueFileName);



//            using (var stream = new FileStream(filePath, FileMode.Create))
//            {
//                await request.Resume.CopyToAsync(stream);
//            }



          




//            ProfileModel form = new ProfileModel()
//            {
//                JobSeekerRegistrationID = request.JobSeekerRegistrationID,
//                FirstName = request.FirstName,
//                LastName = request.LastName,
//                EmailId = request.EmailId,
//                Qualification = request.Qualification,
//                Experience = request.Experience,
//                TenthPercentage = request.TenthPercentage,
//                TwelvethPercentage = request.TwelvethPercentage,
//                CGPA = request.CGPA,
//                PhoneNumber = request.PhoneNumber,
//                SkillSet = request.SkillSet,


//                Location = request.Location,

     
//                UniqueFileName = uniqueFileName,

//                JobSeekerSignupModel= jobs



//            };



//            _profiledetails.Profile.Add(form);
//            await _profiledetails.SaveChangesAsync();


//              var imageUrl = $"{Request.Scheme}://{Request.Host}/Images/{uniqueFileName}";

//              return Ok(new { ImageUrl = imageUrl });
//        }


//    }
//}
