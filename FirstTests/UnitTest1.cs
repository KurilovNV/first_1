using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NUnit.Framework;
using first_1.Controllers;
using first_1.Model;
using Microsoft.AspNetCore.Mvc;

namespace FirstTests
{

    [TestFixture]
    public class TasksControllerTests
    {
        [Test]
        public void GetTasks_ReturnsTasks()
        {
            // Arrange
            var controller = new TasksController();

            // Act
            var result = controller.GetTasks() as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(HttpStatusCode.OK, (HttpStatusCode)result.StatusCode);

            var tasks = result.Value as List<TaskModel>;
            Assert.NotNull(tasks);
            Assert.IsNotEmpty(tasks);
        }
    }

}