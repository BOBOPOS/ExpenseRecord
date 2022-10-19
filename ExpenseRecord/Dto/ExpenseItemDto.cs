using Newtonsoft.Json;

namespace ExpenseRecord.Dto
{
    public class ExpenseItem
    {
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }

        [JsonProperty(PropertyName = "createtime")]
        public DateTime? CreateTime { get; set; }
    }
}
