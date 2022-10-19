using Microsoft.AspNetCore.Mvc;
using ExpenseRecord.Dto;
using ExpenseRecord.Service;
namespace ExpenseRecord.Controllers
{
    [Route("api/items")]
    [ApiController]
    public class ExpenseRecordController : Controller
    {

        private readonly IExpenseItemService _expenseItemService;
        public ExpenseRecordController(IExpenseItemService expenseItemService)
        {
            _expenseItemService = expenseItemService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Hello");
        }

        [HttpPost]
        public async Task<IActionResult> CreateExpenseItem(ExpenseItem expenseItem)
        {

            var msg = _expenseItemService.CreateExpenseItem(expenseItem);
            return Ok(msg);


        }
    }
}
