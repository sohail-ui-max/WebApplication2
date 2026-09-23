using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = new List<Student>
            {
                new Student { Id = 1, Name = "Alice", Age = 20 },
                new Student { Id = 2, Name = "Bob", Age = 22 },
                new Student { Id = 3, Name = "Charlie", Age = 21 }
            };

            return Ok(students);
        }
    }
}
