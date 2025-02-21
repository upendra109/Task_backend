using System;
using Microsoft.EntityFrameworkCore;
using TS.data;
using TS.Models;

namespace TS.Repository
{
    public class TaskRepository
    {
        private readonly AppDbContext db;
        public TaskRepository(AppDbContext dbContext)
        {
            this.db = dbContext;
        }
        public async Task<List<TaskItem>> GetAllTasks()
        {
            return await db.TaskItems.ToListAsync();
        }
        public async Task SaveTask(TaskItem tsk)
        {
            await db.TaskItems.AddAsync(tsk);
            await db.SaveChangesAsync();
        }

        public async Task DeleteTask(int id)
        {
            var taskitem = await db.TaskItems.FindAsync(id);
            if (taskitem == null)
            {
                throw new Exception("Task not found");
            }
            db.TaskItems.Remove(taskitem);
            await db.SaveChangesAsync();
        }
    }
}