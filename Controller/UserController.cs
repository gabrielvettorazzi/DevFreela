using FreelaDev.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace FreelaDev.Controller;

[Route("api/users")]
public class UserController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok();
    }

    [HttpPost]
    public IActionResult Post([FromBody] CreateUserModel createUserModel)
    {
        return CreatedAtAction(nameof(GetById), new { id = 1 }, createUserModel);
    }
   
    // api/users//login
    [HttpPut("{id}/login")]
    public IActionResult Login(int id, [FromBody] LoginModel login)
    {
        return NoContent();
    }
}