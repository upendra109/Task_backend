using Microsoft.EntityFrameworkCore;
using TS.Models;

namespace TS.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<TaskItem> TaskItems { get; set; }
        public DbSet<UserItem> UserItems { get; set;}
    }
}