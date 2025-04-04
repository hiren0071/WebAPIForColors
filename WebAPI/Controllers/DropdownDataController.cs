using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DropdownDataController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetDropdownOptions()
        {
            var options = new[]
            {
                new { id = 1, name = "Red" },
                new { id = 2, name = "Yellow" },
                new { id = 3, name = "Green" },
                new { id = 4, name = "Blue" },
                new { id = 5, name = "Pink" }
            };

            return Ok(options);
        }
    }
}
