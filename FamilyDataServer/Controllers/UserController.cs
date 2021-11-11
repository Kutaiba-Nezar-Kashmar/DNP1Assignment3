using System;
using System.Threading.Tasks;
using FamilyDataServer.Data;
using FamilyDataServer.Models;
using Microsoft.AspNetCore.Mvc;


namespace FamilyDataServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserData userData;

        public UserController(IUserData userData)
        {
            this.userData = userData;
        }

        [HttpPost]
        public async Task<ActionResult<User>> CreateUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                User newUser = await userData.CreateUser(user);
                return Created($"{newUser.UserName}", newUser);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<User>> ValidateUser([FromQuery] string username, [FromQuery] string password)
        {
            try
            {
                User user = await userData.ValidateUser(username, password);
                return Ok(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}