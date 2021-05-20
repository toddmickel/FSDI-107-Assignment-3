// Indended function: Application programming interface for passing data to and from the server
using System;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    public class ApiController : Controller
    {
        public IActionResult Test()
        {
            return Content("Hello from API");
        }

        [HttpPost]
        public IActionResult SaveTask([FromBody] Task data)
        {
            Console.WriteLine("SaveTask function called: " + data.Title);

            // get the object

            // save it on the database

            // assign a unique ID
            data.Id = 1;

            // return the object back
            return Json(data);
        }

        public IActionResult RetrieveTasks()
        {
            return Ok();
        }
    }
}