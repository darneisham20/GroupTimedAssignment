using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using TimedAssignment.Services.Post;


namespace TimedAssignment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        // [HttpPost ("PostContent")]
        // public async Task<IActionResult> PostContent([FromBody] CreatePost request)
        // {
        //     if (!ModelState.IsValid)
        //         return BadRequest(ModelState);
            
        //     if (await _postService.CreatePostAsync(request))
        //         return Ok("You have successfully posted!");

        //     return BadRequest("Your post was not posted.");
        // }
    }
}