using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Todo_API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TodoController : ControllerBase
  {
    [HttpGet("index")]
    public IActionResult GetTodos()
    {
      // Placeholder for fetching Todo items from the database
      var todos = new[]
      {
        new { Id = 1, Title = "Sample Todo 1", Status = "pending" },
        new { Id = 2, Title = "Sample Todo 2", Status = "in_progress" }
      };
      return Ok(todos);
    }

    [HttpPost("index")]
    public IActionResult CreateTodo()
    {
      // Placeholder for creating a new Todo item in the database
      return Ok(
        new { Id = 3, Title = "New Todo", Status = "pending" });
    }

    [HttpPut("index/{id}")]
    public IActionResult UpdateTodo(int id)
    {
      // Placeholder for updating an existing Todo item in the database
      return Ok(
        new { Id = id, Title = "Updated Todo", Status = "done" });
    }
  }
}
