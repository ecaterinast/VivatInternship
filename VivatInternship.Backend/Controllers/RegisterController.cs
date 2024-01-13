using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using VivatInternship.Backend.Data;
using VivatInternship.Backend.Data.DbModel;
using VivatInternship.Backend.Interfaces;
using VivatInternship.Backend.Models;
using VivatInternship.Backend.Models.User;
using VivatInternship.Backend.Services;

namespace VivatInternship.Backend.Controllers
{
     [Route("api/[controller]")]
     [ApiController]
     public class RegisterController : ControllerBase
     {
          private readonly IConfiguration _configuration;
          private readonly BasketContext _basketContext;
          private readonly IUserService _userService;

          public RegisterController(IConfiguration configuration, BasketContext basketContext, IUserService userService)
          {
               _configuration = configuration;
               _userService = userService;
               _basketContext = basketContext;
          }
          [HttpPost]
          public void Register(RegisterModel user)
          {
               _userService.Register(user);
          }

     }
}
