﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BLMock.Models;

namespace BLMock.Controllers
{
    [ApiController]
    //[Route("[controller]")]

    public class MockController : ControllerBase
    {
        private static string _notificationFileName = "notification.json";

        [HttpGet]
        [Route("api/v2/notifications")]
        public NotificationPage GetNotifications([FromQuery] string from_datetime, string to_datetime, string p)
        {
            string filePath;

            //if (p == null)
            //{
            //    filePath = Path.Combine("Responses", "notifications", $"{_notificationFileName}");
            //}
            //else
            //{
            //    filePath = Path.Combine("Responses", "notifications", $"notificationPage{p}.json");
            //}

            filePath = Path.Combine("Responses", "notifications", $"{_notificationFileName}");

            if (!System.IO.File.Exists(filePath))
            {
                throw new Exception($"No encontro archivo. Path: {filePath}");
            }
            
            var json =  System.IO.File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<NotificationPage>(json);
        }

        [HttpGet]
        [Route("api/v2/orders/{id}")]
        public Order GetOrders(string id)
        {
            string filePath = Path.Combine("Responses", "orders", $"{id}.json");

            if (!System.IO.File.Exists(filePath))
            {
                throw new Exception($"No encontro archivo. Path: {filePath}");
            }

            var json = System.IO.File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<Order>(json);
        }

        [HttpPost]
        [Route("api/v2/notifications")]
        public IActionResult SetNotification([FromQuery] string fileName)
        {
            if (fileName == null)
            {
                return BadRequest();
            }

            _notificationFileName = fileName;

            return Ok();
        }
    }
}