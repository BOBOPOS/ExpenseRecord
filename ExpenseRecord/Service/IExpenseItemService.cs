using ExpenseRecord.Dto;
namespace ExpenseRecord.Service
{
    public interface IExpenseItemService
    {
        public ExpenseItem[] ExpenseItemsData { get; set; }
        public string CreateExpenseItem(ExpenseItem expenseItem);

    }
}
