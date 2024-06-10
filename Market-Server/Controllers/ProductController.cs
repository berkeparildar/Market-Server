using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Market_Server.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : Controller
    {
        [HttpGet("{categoryName}")]
        public IActionResult GetSite(string categoryName)
        {
            string filePath = Path.Combine("Data", $"{categoryName}.json");
            if (System.IO.File.Exists(filePath))
            {
                string jsonData = System.IO.File.ReadAllText(filePath);
                return Content(jsonData, "application/json");
            }
            else
            {
                return NotFound();
            }
        }
    }
}

