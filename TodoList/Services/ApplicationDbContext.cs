using Microsoft.EntityFrameworkCore;

namespace TodoList.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Models.TaskModel> Task { get; set; }
    }
}
