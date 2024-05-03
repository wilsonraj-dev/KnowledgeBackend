using Knowledge.Backend.Application.DTOs;
using Knowledge.Backend.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Knowledge.Backend.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Get a list of all users
        /// </summary>
        /// <returns>Returns a list of all users</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetAllUsers()
        {
            var users = await _userService.GetUsersDTOAsync();

            if (users == null)
            {
                return NotFound("No users found");
            }

            return Ok(users);
        }

        /// <summary>
        /// Get a user by id
        /// </summary>
        /// <returns>As categorias encontrada</returns>
        /// <param name="id"></param>
        /// <returns>Returns the user found</returns>
        [HttpGet]
        [Route("GetUserById/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<UserDTO>> GetUserById(int id)
        {
            var user = await _userService.GetUserDTOByIdAsync(id);

            if (user.Id != id)
            {
                return BadRequest($"User {id} not found.");
            }
            else if (user == null)
            {
                return NotFound("No users found.");
            }

            return Ok(user);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<UserWithPasswordDTO>> CreateUser([FromBody] UserWithPasswordDTO user)
        {
            if (user == null)
            {
                return BadRequest("Invalid data");
            }

            await _userService.CreateUserDTOAsync(user);
            return Ok(user);
        }

        [HttpPut]
        [Route("UpdateUser/{id:int}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<UserDTO>> UpdateUser(int id, [FromBody] UserDTO user)
        {
            if (id != user.Id)
            {
                return BadRequest("Error when trying update user");
            }
            if (user == null)
            {
                return NotFound("User not found");
            }

            await _userService.UpdateUserDTOAsync(user);
            return Created();
        }

        [HttpDelete]
        [Route("DeleteUser/{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<UserDTO>> DeleteUser(int id)
        {
            var user = await _userService.GetUserDTOByIdAsync(id);

            if (user == null)
            {
                return NotFound("User not found");
            }

            await _userService.DeleteUserDTOAsync(id);
            return NoContent();
        }
    }
}
