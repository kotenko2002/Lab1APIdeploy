using AutoMapper;
using Lab1API.Data;
using Lab1API.Data.Repositories.Currencies;
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
        private readonly IСurrencyRepository _currencyRepository;
        public UserController(
            IMapper mapper,
            IUserRepository userRepository,
            IСurrencyRepository сurrencyRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _currencyRepository = сurrencyRepository;
        }

        [HttpPost]
        public async Task<ActionResult> AddUser([FromBody] UserAddModel model)
        {
            var user = _mapper.Map<User>(model);

            await _userRepository.AddUserAsync(user);
            return Ok("Success");
        }

        [HttpGet("currencies")]
        public async Task<IEnumerable<Сurrency>> GetAllCurrencies()
        {
            return await _currencyRepository.GetAllCategories();
        }

        [HttpPost("currency")]
        public async Task<ActionResult> ChangeDefaultСurrency([FromBody] DefaultCurrencyEditModel model)
        {
            await _userRepository.ChangeUserDefaultСurrencyAsunc(model.UserId, model.CurrencyId);
            return Ok("Success");
        }
    }
}
