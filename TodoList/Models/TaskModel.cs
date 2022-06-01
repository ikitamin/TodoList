namespace TodoList.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public TaskState State { get; set; }
        public TaskPriority Priority { get; set; }
        public enum TaskState
        { 
            Todo = 0,
            Doing,
            Done, 
            Hold
        }
        public enum TaskPriority
        { 
            Low,
            Middle,
            High 
        }
    }
}
