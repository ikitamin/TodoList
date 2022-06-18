using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class TaskModel
    {
        [Required, Key]
        public int Id { get; set; }
        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public string? Name { get; set; }
        [Required]
        [MinLength(1)]
        [MaxLength(256)]
        public string? Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        public TaskState State { get; set; } = 0;
        public TaskPriority Priority { get; set; } = 0;
    }

    public enum TaskState
    {
        Todo = 0,
        Doing,
        Done,
        Hold
    }
    public enum TaskPriority
    {
        Low = 0,
        Middle,
        High
    }
}
