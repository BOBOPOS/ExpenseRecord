using Microsoft.AspNetCore.Mvc;

namespace ExpenseRecord.Controllers
{
    [Route("api/items")]
    [ApiController]
    public class ExpenseRecordController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Hello");
        }
    }
}
