using EComm.Data;
using EComm.Helper;
using EComm.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EComm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoversController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CoversController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] BookCover cover)
        {

            cover.ImageUrl = await FileHelper.UploadImage(cover.ImageFile);

            await _context.BookCovers.AddAsync(cover);
            await _context.SaveChangesAsync();
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
