using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using TimedAssignment.Services.User;
using TimedAssignment.Services.Token;

namespace TimedAssignment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // Token 
        private readonly IUserService _userService;
        private readonly ITokenService _tokenService;


        public UserController(IUserService userService, ITokenService tokenService)
        {   
            _userService = userService;
            _tokenService = tokenService;
        }

        // [HttpPost ("SignUp")]
        // public async Task<IActionResult> SignUp([FromBody] SignUpUser model)
        // {
        //     if (!ModelState.IsValid)
        //         return BadRequest(ModelState);

        //     var signUpResult = await _userService.SignUpUserAsync(model0);
        //     if (signUpResult)
        //         return Ok("You have successfully signed up!");

        //     return BadRequest("You could not be signed up.");
        // }
    }
}