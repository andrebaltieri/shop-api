using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using store.Models;
using store.Services;

namespace store.Controllers
{
    [Route("v1/account")]
    public class AccountController : Controller
    {
        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult Authenticate([FromBody]User model)
        {
            var service = new UserService();
            var user = service.Authenticate(model.Username, model.Password);

            if (user == null)
                return BadRequest(new { message = "Usuário ou senha inválidos" });

            return Ok(user);
        }

        [HttpPost("")]
        [AllowAnonymous]
        public IActionResult Create([FromBody]User model)
        {
            var service = new UserService();
            var user = service.Authenticate(model.Username, model.Password);

            if (user == null)
                return BadRequest(new { message = "Usuário ou senha inválidos" });

            return Ok(user);
        }
    }
}