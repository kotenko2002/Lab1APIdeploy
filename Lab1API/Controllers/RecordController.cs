using AutoMapper;
using Lab1API.Data;
using Lab1API.Data.Repositories.Records;
using Lab1API.DTOs;
using Lab1API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1API.Controllers
{
    [ApiController]
    [Route("api/record")]
    public class RecordController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRecordRepository _recordRepository;
        public RecordController(IRecordRepository recordRepository, IMapper mapper)
        {
            _recordRepository = recordRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> AddRecord([FromBody] RecordAddModel model)
        {
            var record = _mapper.Map<Record>(model);

            await _recordRepository.AddRecordAsync(record);
            return Ok("Success");
        }

        [HttpGet("items/{id}")]
        public async Task<Record> GetRecordsByUserId(int id)
        {
            return await _recordRepository.GetRecordById(id);
        }

        [HttpGet("items")]
        public async Task<IEnumerable<Record>> GetRecordsByUserIdAndCategoryId
            ([FromQuery] int userId, [FromQuery] int categoryId)
        {
            return await _recordRepository.GetRecordsByUserIdAndCategoryId(userId, categoryId);
        }
    }
}
