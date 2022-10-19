namespace ExpenseRecord.Dto
{
    public class ExpenseItemDto
    {
        public class ToDoItemDto
        {
            public string? Id { get; set; }

            public string? Description { get; set; }

            public string? Type { get; set; }

            public double? Amount { get; set; }

            public DateTime? CreateTime { get; set; }
        }
    }
}
