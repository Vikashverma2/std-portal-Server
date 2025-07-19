using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StdPortel.Models;
using StdPortel.Services;
// Copyright @Vikash Verma
namespace StdPortel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StdController : ControllerBase
    {
        private readonly IStdServices _stdServices;

        public StdController(IStdServices stdServices)
        {
            _stdServices = stdServices;
        }

        [HttpPost]
        public async Task<IActionResult> CreatedNewStd([FromBody] Students students)
        {
            if (students == null)
                return BadRequest("Invalid student data");

            await _stdServices.CreateStudent(students);
            return Ok(new { message = "Student created successfully", student = students });
        }

        [HttpGet]
        public async Task<ActionResult<List<Students>>> GetSutdentData()
        {
            var studentslist = await _stdServices.GetSutdentData();
            return Ok(studentslist);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteStudent([FromQuery] string studentId)
        {
            if (string.IsNullOrEmpty(studentId))
                return BadRequest("Student ID is required");

            var response = await _stdServices.DeleteStudent(studentId);
            return Ok(new { message = response });
        }
    }
}
