using TodoList.Services;
using Microsoft.EntityFrameworkCore;
using static TodoList.Models.TaskModel;

namespace TodoList.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any tasks.
                if (context.Task.Any())
                {
                    return;   // DB has been seeded
                }

                context.Task.AddRange(
                    new TaskModel
                    {
                        Name = "test name",
                        Description = "test description",
                        CreatedDate = DateTime.Now,
                        State = TaskState.Doing,
                        Priority = TaskPriority.Low
                    },
                    new TaskModel
                    {
                        Name = "test name2",
                        Description = "test description2",
                        CreatedDate = DateTime.Now,
                        State = TaskState.Todo,
                        Priority = TaskPriority.High
                    },
                    new TaskModel
                    {
                        Name = "test name3",
                        Description = "test description3",
                        CreatedDate = DateTime.Now,
                        State = TaskState.Done,
                        Priority = TaskPriority.Low
                    }
                );
                context.SaveChanges();
            }
        }
    }
}