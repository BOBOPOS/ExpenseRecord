using ExpenseRecord.Dto;
namespace ExpenseRecord.Service
{
    public class ExpenseItemService: IExpenseItemService
    {
        public ExpenseItem[]? ExpenseItemsData { get; set; }
        public ExpenseItemService() {
            ExpenseItemsData = new ExpenseItem[0];
        }
        public string CreateExpenseItem(ExpenseItem expenseItem)
        {
            var id = Guid.NewGuid().ToString();
            var tempExpenseItem = new ExpenseItem
            {
                Id = id,
                Description = expenseItem.Description,
                Type = expenseItem.Type,
                Amount = expenseItem.Amount,
                CreateTime = DateTime.Now
            };
            ExpenseItemsData.Append(tempExpenseItem);
            return id;
        }

    }
}
