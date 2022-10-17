using Lab1API.Data;
using Lab1API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Lab1API.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public ActionResult AddUser([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest("Empty request body");
            }

            if (DbContext.Users.Any(item => item.Id == user.Id))
            {
                return BadRequest("User with such Id already exists");
            }

            DbContext.Users.Add(user);
            return Ok("Success");
        }

        [HttpGet]

        public ActionResult<IEnumerable<User>> GetAllUsers([FromBody] User user)
        {
            return Ok(DbContext.Users);
        }
    }
}
