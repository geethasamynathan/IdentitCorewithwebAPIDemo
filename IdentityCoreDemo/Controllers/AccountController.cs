using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityCoreDemo.Repositories;
using IdentityCoreDemo.Models;

namespace IdentityCoreDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository repository;
        public AccountController(IAccountRepository repo)
        {
            repository = repo;
        }
        [HttpPost("signup")]
        public async Task<IActionResult> SignUp(SignUpModel signupModel)
        {
            var result = await repository.SignUpAsync(signupModel);
            if(result.Succeeded)
            {
                return Ok(result);

            }
            return Unauthorized();
        }

    }
}
