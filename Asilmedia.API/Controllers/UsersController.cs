using AsilMedia.Application.DataTransferObject;
using AsilMedia.Application.Services.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asilmedia.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly IUserService _userService;

        public UsersController(IUserService userService)
            => _userService = userService;

        [HttpPost]
        public async Task<IActionResult> Register(UserDTO userDTO)
        {
            var user = await _userService.InsertAsync(userDTO);

            return Ok(user);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            return Ok(await _userService.SelectAllAsync());
        }
    }
}
