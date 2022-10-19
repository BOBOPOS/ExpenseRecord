using ExpenseRecord.Dto;

namespace ExpenseRecord.Service
{
    public interface IExpenseItemService
    {
        public List<ExpenseItem> ExpenseItemsData { get; set; }
        public string CreateExpenseItem(ExpenseItem expenseItem);
    }
}
