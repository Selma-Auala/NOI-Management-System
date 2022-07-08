using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NOI_System_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register() 
        {
            //Business Logic
            return await Task.FromResult(Ok("This functon was successful"));

        }
        [HttpPost]
        [Route("Login")]
        public IActionResult Login()
        {
            return BadRequest("Call Successful");
        }
    }
}
