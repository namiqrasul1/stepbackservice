namespace TodoWebService.Models.Entities
{
    public class TodoItem
    {
        // 0515c4df-db95-44a5-ab88-387600970e72
        // 0515c4df-db95-44a5-ab88-387600970e72
        // 0515c4df-db95-44a5-ab88-387600970e72
        public int Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public string UserId { get; set; } = string.Empty;
        public virtual AppUser User { get; set; }

    }
}