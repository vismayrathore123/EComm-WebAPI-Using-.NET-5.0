using EComm.Data;
using EComm.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task<IActionResult> Get()
        {
          
            return Ok(await _context.Categories.ToListAsync());
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task< IActionResult> Get(int id)
        {
            return Ok(await _context.Categories.FirstOrDefaultAsync(x=>x.Id==id));
        }

        // POST api/<CategoryController>
        [HttpPost]
        public async Task< IActionResult> Post([FromBody] Category category)
        {
           await  _context.Categories.AddAsync(category);
           await _context.SaveChangesAsync();
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public async Task <IActionResult> Put(int id, [FromBody] Category category)
        {
            var categoryfromDb = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
            if (categoryfromDb == null)
            {
                return NotFound();
            }
            else
            {


                categoryfromDb.Title = category.Title;
                categoryfromDb.DisplayOrder = categoryfromDb.DisplayOrder;
                _context.Categories.Update(categoryfromDb);
               await _context.SaveChangesAsync();
                return Ok("Category Updated");
            }
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var categoryfromDb = _context.Categories.Find(id);
            if (categoryfromDb == null)
            {
                return NotFound();
            }
            else
            {
                _context.Categories.Remove(categoryfromDb);
               await  _context.SaveChangesAsync();
                return Ok("Category Deleted");
            }
        }
    }
}
