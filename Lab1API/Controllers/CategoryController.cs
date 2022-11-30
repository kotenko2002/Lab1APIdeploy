using AutoMapper;
using Lab1API.Data;
using Lab1API.Data.Repositories.Categories;
using Lab1API.DTOs;
using Lab1API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1API.Controllers
{
    [ApiController]
    [Route("api/category")]
    public class CategoryController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> AddCategory([FromBody] CategoryAddModel model)
        {
            var category = _mapper.Map<Category>(model);

            await _categoryRepository.AddCategoryAsync(category);
            return Ok("Success");
        }

        [HttpGet("items")]
        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _categoryRepository.GetAllCategories();
        }
    }
}
