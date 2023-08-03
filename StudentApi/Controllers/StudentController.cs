using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly DataContext context;

        public StudentController(DataContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Student>>> Get()
        {
            return Ok(await context.Students.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Student>>> Get(int id)
        {
            var student = await context.Students.FindAsync(id);
            if (student == null)
                    return BadRequest("Id not found");
            return Ok(student);
        }

        [HttpPost]
        public async Task<ActionResult<List<Student>>> AddStudent(Student Student)
        { 
            context.Students.Add(Student);
            await context.SaveChangesAsync();

            var students = await context.Students.ToListAsync();
            return Ok(students);
        }

        [HttpPut]
        public async Task<ActionResult<List<Student>>> PutStudent(Student request)
        {
            var student = await context.Students.FindAsync(request.id);
            if (student == null)
                return BadRequest("Student not found");

            student.FirstName = request.FirstName;
            student.LastName = request.LastName;
            student.Email = request.Email;
            student.Phone = request.Phone;

            await context.SaveChangesAsync();
            return Ok(await context.Students.ToListAsync());
        }

        [HttpDelete("{id}")]    
        public async Task<ActionResult<List<Student>>> Delete(int id)
        {
            var student = await context.Students.FindAsync(id);
            if (student == null)
                return BadRequest("Student not found");

            context.Students.Remove(student);
            await context.SaveChangesAsync();

            return Ok(await context.Students.ToListAsync());
        }
    }
}
