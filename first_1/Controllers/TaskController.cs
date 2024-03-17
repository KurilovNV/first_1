using first_1.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace first_1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTasks()
        {
            var tasks = new List<TaskModel>
            {
                new TaskModel { Question = "What is the port side of a ship?", Answer = "The left side of the ship when facing forward" },
                new TaskModel { Question = "What does the term 'full steam ahead' mean?", Answer = "To proceed at maximum speed" }
                // Add more tasks here
            };
            return Ok(tasks);
        }
    }
}
