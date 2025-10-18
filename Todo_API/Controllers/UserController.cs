using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;
using Todo_API.Models;

namespace Todo_API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UserController : ControllerBase
  {
    [HttpGet("index")]
    public IActionResult GetCurrentUser()
    {
      var username = User.Identity?.Name ?? "Unknown";
      return Ok(new
      {
        username,
        displayName = username.Split('\\').Last(), // OCEANUS\thodoris.kotoufos → thodoris.kotoufos
        isAuthenticated = User.Identity?.IsAuthenticated
      });
    }
  }
}