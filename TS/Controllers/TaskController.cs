using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TS.Models;
using TS.Repository;

namespace TS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly TaskRepository tsk;
        public TaskController(TaskRepository taskRepository)
        {
            this.tsk = taskRepository;
        }
        [HttpGet]
        public async Task<ActionResult> TaskList()
        {
            var allTasks = await tsk.GetAllTasks();
            return Ok(allTasks);
        }
        [HttpPost]
        public async Task<ActionResult> AddTask(TaskItem vm)
        {
            await tsk.SaveTask(vm);
            return Ok(vm);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> deleteTask(int id)
        {
            await tsk.DeleteTask(id);
            return Ok();
        }
    }
}