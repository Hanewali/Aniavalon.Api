using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Aniavalon.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatisticsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return Ok();
        }
    }
}