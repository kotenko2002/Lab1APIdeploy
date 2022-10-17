﻿using Lab1API.Data;
using Lab1API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Lab1API.Controllers
{
    [ApiController]
    [Route("api/record")]
    public class RecordController : ControllerBase
    {
        [HttpPost]
        public ActionResult AddRecord([FromBody] Record record)
        {
            if (record == null)
            {
                return BadRequest("Empty request body");
            }

            if (DbContext.Records.Any(item => item.Id == record.Id))
            {
                return BadRequest("Record with such Id already exists");
            }

            DbContext.Records.Add(record);
            return Ok("Success");
        }

        [HttpGet("items/{id}")]
        public ActionResult<IEnumerable<Record>> GetRecordsByUserId(int id)
        {
            var records = DbContext.Records.Where(item => item.UserId == id).ToList();

            if (records.Count == 0)
            {
                return NotFound();
            }

            return Ok(records);
        }

        [HttpGet("items")]
        public ActionResult<IEnumerable<Record>> GetRecordsByUserIdAndCategoryId
            ([FromQuery] int userId, [FromQuery] int categoryId)
        {
            var records = DbContext.Records
                .Where(item => item.UserId == userId && item.CategoryId == categoryId)
                .ToList();

            if (records.Count == 0)
            {
                return NotFound();
            }

            return Ok(records);
        }
    }
}
