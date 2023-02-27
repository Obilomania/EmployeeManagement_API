using EmployeeManagement.API.DTOs.Job;
using EmployeeManagement.API.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers
{
    [Route("api/Job")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IJobRepository _db;
        public JobController(IJobRepository db)
        {
            _db = db;
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> GetAJobs()
        {
            var jobs = await _db.GetJobsAsync();
            return Ok(jobs);
        }


        [HttpGet]
        [Route("Get/{id}")]
        public async Task<IActionResult> GetJob(int id)
        {
            var job = await _db.GetJobAsync(id);
            return Ok(job);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateJob(JobCreate jobCreate)
        {
            var id = await _db.CreateJobAsync(jobCreate);
            return Ok(id);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> UpdateJob(JobUpdate jobUpdate)
        {
            await _db.UpdateJobAsync(jobUpdate);
            return Ok();
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> DeleteJob(JobDelete jobDelete)
        {
            await _db.DeleteJobAsync(jobDelete);
            return Ok();
        }
    }
}
