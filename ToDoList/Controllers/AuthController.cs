using Microsoft.AspNetCore.Mvc;
using ToDoList.BusinessLogic;
using ToDoList.BusinessLogic.Abstract;
using ToDoList.Entities;

namespace ToDoList.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
           
            var userToLogin = _authService.Login(userForLoginDto);
            if (userToLogin.Success)
            {

                return Ok(userToLogin);

            }

            return BadRequest(userToLogin);
            

        }

        [HttpPost("register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists = _authService.UserExists(userForRegisterDto.Email);
            if (userExists.Success)
            {
                _authService.Register(userForRegisterDto, userForRegisterDto.Password);
                return Ok(userExists);
            }

            return BadRequest(userExists);
  
        }
    }
}