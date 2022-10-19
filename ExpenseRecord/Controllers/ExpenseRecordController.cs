using Microsoft.AspNetCore.Mvc;
using ExpenseRecord.Dto;
using ExpenseRecord.Service;
using System.Linq;
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


        [HttpPost]
        public async Task<IActionResult> CreateExpenseItem(ExpenseItem expenseItem)
        {
            var msg = _expenseItemService.CreateExpenseItem(expenseItem);
            return Ok(msg);
        }

        [HttpGet]
        public IActionResult ShowAllExpenseItems()
        {
            return Ok(_expenseItemService.ExpenseItemsData);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteExpenseItem([FromRoute] string id)
        {
            _expenseItemService.ExpenseItemsData.RemoveAll(item => item.Id == id);
            return Ok();
        }
        
    }
}
