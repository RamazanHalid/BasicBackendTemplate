using Microsoft.AspNetCore.Mvc;
using ToDoList.BusinessLogic;
using ToDoList.Entities;

namespace ToDoList.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDosController : ControllerBase
    {

        private IToDoService _toDoService;

        public ToDosController(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _toDoService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        
        
        [HttpPost("add")]
        public IActionResult Add(ToDo toDo)
        {
            var result = _toDoService.Add(toDo);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(ToDo toDo)
        {
            var result = _toDoService.Delete(toDo);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(ToDo toDo)
        {
            var result = _toDoService.Update(toDo);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}