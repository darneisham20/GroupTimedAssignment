using TimedAssignment.Data;
using TimedAssignment.Services.User;
using Microsoft.EntityFrameworkCore;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
// using TimedAssignment.Services.Token;
using Microsoft.OpenApi.Models;
using TimedAssignment.Services.Post;
using TimedAssignment.Services.Comment;
using TimedAssignment.Services.Reply;



var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "TimedAssignment.WebAPI", Version = "v1" });
    });
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<IReplyService, ReplyService>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IUserService, UserService>();
// Using statement not working: Microsoft.IdentityModel.Tokens for the Token Validation Parameters and Symmetric Security Key not allowing refactoring.

// builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(Options =>
// {
//     Options.RequireHttpsMetadata = false;
//     Options.SaveToken = true;
//     Options.TokenValidationParameters = new TokenValidationParameters
//     {
//         ValidateIssuer = true,
//         ValidateAudience = true,
//         ValidIssuer = Configuration["Jwt:Issuer"],
//         ValidAudience = Configuration["Jwt:Audience"],
//         IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
//     };
// });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();