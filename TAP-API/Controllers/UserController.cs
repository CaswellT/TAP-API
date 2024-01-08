using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TAP_API.Models;

namespace TAP_API.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet, Route("Get-Message")]
        public IActionResult GetMessage()
        {
            UserInfo user = new UserInfo { FirstName = "John", LastName = "Eads" };



            return Ok($"{user.FirstName} {user.LastName} can now use .net 8");
        }
    }
}
