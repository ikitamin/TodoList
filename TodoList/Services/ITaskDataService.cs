using TodoList.Models;

namespace TodoList.Services
{
    public interface ITaskDataService
    {
        List<TaskModel> GetAllTasks();
        List<TaskModel> SearchTasks(string search);
        TaskModel GetTaskById(int id);
        TaskModel GetTaskByName(string name);

        bool Delete(TaskModel task);
        bool Create(TaskModel task);
        bool Update(TaskModel task);
    }
}
