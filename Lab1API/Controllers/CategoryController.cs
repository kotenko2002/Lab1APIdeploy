using Lab1API.Data;
using Lab1API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Lab1API.Controllers
{
    [ApiController]
    [Route("api/category")]
    public class CategoryController : ControllerBase
    {
        [HttpPost]
        public ActionResult AddCategory([FromBody] Category category)
        {
            if (category == null)
            {
                return BadRequest("Empty request body");
            }

            if (DbContext.Categories.Any(item => item.Id == category.Id))
            {
                return BadRequest("Category with such Id already exists");
            }

            DbContext.Categories.Add(category);
            return Ok("Success");
        }

        [HttpGet("items")]
        public ActionResult<IEnumerable<Category>> GetAllCategories()
        {
            var categories = DbContext.Categories;
            if (categories == null)
            {
                return NotFound();
            }

            return Ok(categories);
        }
    }
}
