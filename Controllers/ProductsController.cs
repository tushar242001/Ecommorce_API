using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ProductsController : ControllerBase
    {
        
       [HttpGet]
       public IActionResult GetByCategory()
        {
            return Ok("Hello World of Ecommerce");
        }
    }
}

