using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Core.Student.Command;
using StudentManagement.Core.Student.Query;
using StudentManagement.Services.Model;

namespace StudentManagement.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<VmStudent>> GetAll()
        {
            var data = await _mediator.Send(new GetAllStudentQuery());
            return Ok(data);
        }

        [HttpGet("id")]
        public async Task <ActionResult<VmStudent>> GetById(int id)
        {
            var data = await _mediator.Send(new GetStudentById(id));
            return Ok(data);
        }
        [HttpPost]
        public async Task <ActionResult<VmStudent>> Create([FromBody]VmStudent student)
        {
            var data = await _mediator.Send(new CreateStudent(student));
            return Ok(data);
        }

        [HttpPut("id")]

        public async  Task<ActionResult <VmStudent>> Update(int id, [FromBody]VmStudent student)
        {
            var data = await _mediator.Send(new UpdateStudent(id, student));
            return Ok(data);
        }
        [HttpDelete("id")]

        public async Task<ActionResult <VmStudent>> Delete(int id)
        {
            var data = await _mediator.Send(new DeleteStudent(id));
            return Ok(data);

        }






    }
    

    
    

    
}
