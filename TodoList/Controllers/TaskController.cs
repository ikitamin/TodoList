using Microsoft.AspNetCore.Mvc;
using TodoList.Models;
using static TodoList.Models.TaskModel;

namespace TodoList.Controllers
{
    public class TaskController : Controller
    {
        private readonly ILogger<TaskController> _logger;

        public TaskController(ILogger<TaskController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            TaskModel task = new TaskModel()
            {
                Id = 1, Name = "test name",
                Description = "test description",
                CreatedDate = DateTime.Now,
                State = TaskState.Doing,
                Priority = TaskPriority.Low
            };
            return View(task);
        }
    }
}
