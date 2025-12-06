using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RequestlyWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = new
            {
                Id = id,
                Name = "John Doe",
                Email = "johndoe@example.com",
                Status = "Active"
            };

            return Ok(user);
        }


        [HttpGet("profile")]
        public IActionResult GetProfile()
        {
            return Ok(new
            {
                UserName = "developer123",
                Subscription = "Premium"
            });
        }

        [HttpGet("dashboard")]
        public IActionResult GetDashboard()
        {
            return Ok(new { Message = "Dashboard Loaded" });
        }

        [HttpGet("transactions")]
        public IActionResult GetTransactions()
        {
            return Ok(new[]
            {
                  new { Id = 1, Amount = 100, Status = "Success" }
           });
        }
    }
}
