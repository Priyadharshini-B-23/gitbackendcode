//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Recruitment_Portal_Project.Data;
//using Recruitment_Portal_Project.Models;

//namespace Recruitment_Portal_Project.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class JobSeekerSignupModelsController : ControllerBase
//    {
//        private readonly AppDbContext _context;

//        public JobSeekerSignupModelsController(AppDbContext context)
//        {
//            _context = context;
//        }

//        // GET: api/JobSeekerSignupModels
//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<JobSeekerSignupModel>>> GetSeekerSignup()
//        {
//            return await _context.SeekerSignup.ToListAsync();
//        }

//        // GET: api/JobSeekerSignupModels/5
//        [HttpGet("{id}")]
//        public async Task<ActionResult<JobSeekerSignupModel>> GetJobSeekerSignupModel(int id)
//        {
//            var jobSeekerSignupModel = await _context.SeekerSignup.FindAsync(id);

//            if (jobSeekerSignupModel == null)
//            {
//                return NotFound();
//            }

//            return jobSeekerSignupModel;
//        }

//        // PUT: api/JobSeekerSignupModels/5
//        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
//        [HttpPut("{id}")]
//        public async Task<IActionResult> PutJobSeekerSignupModel(int id, JobSeekerSignupModel jobSeekerSignupModel)
//        {
//            if (id != jobSeekerSignupModel.JobSeekerID)
//            {
//                return BadRequest();
//            }

//            _context.Entry(jobSeekerSignupModel).State = EntityState.Modified;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!JobSeekerSignupModelExists(id))
//                {
//                    return NotFound();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return NoContent();
//        }

//        // POST: api/JobSeekerSignupModels
//        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
//        [HttpPost]
//        public async Task<ActionResult<JobSeekerSignupModel>> PostJobSeekerSignupModel(JobSeekerSignupModel jobSeekerSignupModel)
//        {
//            _context.SeekerSignup.Add(jobSeekerSignupModel);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction("GetJobSeekerSignupModel", new { id = jobSeekerSignupModel.JobSeekerID }, jobSeekerSignupModel);
//        }

//        // DELETE: api/JobSeekerSignupModels/5
//        [HttpDelete("{id}")]
//        public async Task<IActionResult> DeleteJobSeekerSignupModel(int id)
//        {
//            var jobSeekerSignupModel = await _context.SeekerSignup.FindAsync(id);
//            if (jobSeekerSignupModel == null)
//            {
//                return NotFound();
//            }

//            _context.SeekerSignup.Remove(jobSeekerSignupModel);
//            await _context.SaveChangesAsync();

//            return NoContent();
//        }

//        private bool JobSeekerSignupModelExists(int id)
//        {
//            return _context.SeekerSignup.Any(e => e.JobSeekerID == id);
//        }
//    }
//}
