using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace TimedAssignment.Services.Post
{
    public class PostService : IPostService
    {
    private readonly int _userId;
        // public PostService(IHttpContextAccessor httpContextAccessor)
        // {
        //     var userClaims = httpContextAccessor.HttpContext.User.Identity as ClaimsIdentity;
        //     var value = userClaims.FindFirst("Id")?.Value;
        //     var validId = int.TryParse(value, out _userId);
        //     if (!validId)
        //         throw new Exception("Attempted to build PostService without UserId claim.");
        // }
    }
}