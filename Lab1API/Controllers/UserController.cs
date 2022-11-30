using AutoMapper;
using Lab1API.Data;
using Lab1API.Data.Repositories.Users;
using Lab1API.DTOs;
using Lab1API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1API.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> AddUser([FromBody] UserAddModel model)
        {
            var user = _mapper.Map<User>(model);

            await _userRepository.AddUserAsync(user);
            return Ok("Success");
        }
    }
}
