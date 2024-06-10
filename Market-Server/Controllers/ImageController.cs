using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Market_Server.Controllers
{
    [ApiController]
    [Route("api/image")]
    public class ImageController : ControllerBase
    {
        [HttpGet("{imageName}")]
        public IActionResult GetImage(string imageName)
        {
            var imagePath = Path.Combine("wwwroot", "images", $"{imageName}.jpeg");
            if (System.IO.File.Exists(imagePath))
            {
                var stream = new FileStream(imagePath, FileMode.Open);
                return File(stream, "image/jpeg");
            }
            else
            {
                return NotFound();
            }
        }
    }
}

