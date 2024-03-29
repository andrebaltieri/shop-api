using System;
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
            try
            {
                var service = new UserService();
                var user = service.Authenticate(model.Username, model.Password);

                if (user == null)
                    return BadRequest(new { message = "Usuário ou senha inválidos" });

                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("")]
        [AllowAnonymous]
        public IActionResult Create([FromBody]User model)
        {
            var service = new UserService();
            var user = service.Create(model);

            if (user == null)
                return BadRequest(new { message = "Não foi possível criar seu usuário" });

            return Ok(user);
        }
    }
}