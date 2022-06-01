﻿namespace TodoList.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public enum Status { Todo, Doing, Done, Hold }
    }
}