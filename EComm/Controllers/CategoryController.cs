using EComm.Data;
using EComm.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EComm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public IActionResult Get()
        {
            
          
            return Ok(_context.Categories);
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_context.Categories.FirstOrDefault(x=>x.Id==id));
        }

        // POST api/<CategoryController>
        [HttpPost]
        public IActionResult Post([FromBody] Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Category category)
        {
            var categoryfromDb = _context.Categories.FirstOrDefault(x => x.Id == id);
            if (categoryfromDb == null)
            {
                return NotFound();
            }
            else
            {


                categoryfromDb.Title = category.Title;
                categoryfromDb.DisplayOrder = categoryfromDb.DisplayOrder;
                _context.Categories.Update(categoryfromDb);
                _context.SaveChanges();
                return Ok("Category Updated");
            }
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var categoryfromDb = _context.Categories.Find(id);
            if (categoryfromDb == null)
            {
                return NotFound();
            }
            else
            {
                _context.Categories.Remove(categoryfromDb);
                _context.SaveChanges();
                return Ok("Category Deleted");
            }
        }
    }
}
