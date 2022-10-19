using ExpenseRecord.Dto;
namespace ExpenseRecord.Service
{
    public class ExpenseItemService: IExpenseItemService
    {
        public List<ExpenseItem> ExpenseItemsData { get; set; }
        public ExpenseItemService() {
            ExpenseItemsData = new List<ExpenseItem> {
               new ExpenseItem {
                Id = Guid.NewGuid().ToString(),
                Description = "aaa",
                Type = "a",
                Amount = 123,
                CreateTime = DateTime.Now,
                },
               new ExpenseItem {
                Id = Guid.NewGuid().ToString(),
                Description = "bbb",
                Type = "b",
                Amount = 123,
                CreateTime = DateTime.Now,
                }
            };
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
