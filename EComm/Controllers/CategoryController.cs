using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using EComm.Data;
using EComm.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EComm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
            
        }


        // GET: api/<CategoryController>
        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    return Ok(await _context.Categories.ToListAsync());
        //}

        //// GET api/<CategoryController>/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> Get(int id)
        //{
        //    var category = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
        //    if (category == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(category);
        //}

        //// POST api/<CategoryController>
        //[HttpPost]
        //public async Task<IActionResult> Post([FromForm] Category category)
        //{
        //    string connectionString = _configuration["AzureStorage:ConnectionString"];
        //    string containerName = "storagecartphotos";
        //    BlobContainerClient containerClient = new BlobContainerClient(connectionString, containerName);
        //    BlobClient blobClient = containerClient.GetBlobClient(category.CategoryImage.FileName);
        //    MemoryStream ms = new MemoryStream();

        //    await category.CategoryImage.CopyToAsync(ms);
        //    ms.Position = 0;
        //    await blobClient.UploadAsync(ms);
        //    category.CategoryImagePath = blobClient.Uri.AbsoluteUri;

        //    await _context.Categories.AddAsync(category);
        //    await _context.SaveChangesAsync();
        //    return StatusCode(StatusCodes.Status201Created);
        //}

        //// PUT api/<CategoryController>/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(int id, [FromBody] Category category)
        //{
        //    var categoryFromDb = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
        //    if (categoryFromDb == null)
        //    {
        //        return NotFound();
        //    }

        //    categoryFromDb.Title = category.Title;
        //    categoryFromDb.DisplayOrder = category.DisplayOrder;
        //    _context.Categories.Update(categoryFromDb);
        //    await _context.SaveChangesAsync();
        //    return Ok("Category Updated");
        //}

        //// DELETE api/<CategoryController>/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var categoryFromDb = await _context.Categories.FindAsync(id);
        //    if (categoryFromDb == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Categories.Remove(categoryFromDb);
        //    await _context.SaveChangesAsync();
        //    return Ok("Category Deleted");
        //}
    }
}
