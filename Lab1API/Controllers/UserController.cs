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
        private readonly ICurrencyRepository _currencyRepository;
        public UserController(
            IMapper mapper,
            IUserRepository userRepository,
            ICurrencyRepository сurrencyRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _currencyRepository = сurrencyRepository;
        }

        [HttpPost]
        public async Task<ActionResult> AddUser([FromBody] UserAddModel model)
        {
            var user = _mapper.Map<User>(model);

            var userId = await _userRepository.AddUserAsync(user);
            return Ok($"Success. UserId = {userId}");
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

        [HttpGet("secretRequest")]
        public async Task<ActionResult> AddCurrencies()
        {
            await _currencyRepository.SecretRequestAsync();
            return Ok("Success");
        }
    }
}
