using Microsoft.AspNetCore.Mvc;
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

    public class MockController : ControllerBase
    {
        private static string _notificationFileName = "notification1.json";
        private static bool _usePagination = false;

        [HttpGet]
        [Route("api/v2/notifications")]
        public IActionResult GetNotifications([FromQuery] string from_datetime, string to_datetime, string p)
        {
            string filePath;

            if (_usePagination)
            {
                if (p == null)
                {
                    p = "1";
                }

                filePath = Path.Combine("Responses", "notifications", $"notificationPage{p}.json");
            }
            else
            {
                filePath = Path.Combine("Responses", "notifications", $"{_notificationFileName}");
            }

            //filePath = Path.Combine("Responses", "notifications", $"{_notificationFileName}");

            if (!System.IO.File.Exists(filePath))
            {
                throw new Exception($"No encontro archivo. Path: {filePath}");
            }
            
            var json =  System.IO.File.ReadAllText(filePath);

            return Ok(JObject.Parse(json));
        }

        [HttpGet]
        [Route("api/v2/orders/{id}")]
        public IActionResult GetOrders(string id)
        {
            string filePath = Path.Combine("Responses", "orders", $"{id}.json");

            if (!System.IO.File.Exists(filePath))
            {
                throw new Exception($"No encontro archivo. Path: {filePath}");
            }

            var json = System.IO.File.ReadAllText(filePath);

            return Ok(JObject.Parse(json));
        }

        [HttpPost]
        [Route("api/v2/notifications")]
        public IActionResult SetNotification([FromQuery] string fileName, string usePagination)
        {
            if (fileName != null)
            {
                _notificationFileName = fileName;
            }

            if (usePagination != null && usePagination == "1")
            {
                _usePagination = true;
            }

            return Ok(new { FileName = _notificationFileName, UsePagination = _usePagination });
        }
    }
}
