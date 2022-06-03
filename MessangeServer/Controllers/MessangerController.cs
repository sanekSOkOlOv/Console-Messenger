using ConsoleMessanger;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MessangeServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessangerController : ControllerBase
    {
        public static List<Message> ListOfMessange = new List<Message>();

        // GET api/<MessangerController>/5
        [HttpGet("{id}")]
        public string GetMessanges(int id)
        {
            string OutputString = "Not found";
            if ((id < ListOfMessange.Count) && (id >= 0))
            {
                OutputString = JsonConvert.SerializeObject(ListOfMessange[id]);
            }
            Console.WriteLine(String.Format("Запрошено сообщение № {0} : {1}", id, OutputString));
            return OutputString;
        }

        // POST api/<MessangerController>
        [HttpPost]
        public IActionResult SendMessages([FromBody] Message msg)
        {
            if (msg == null) return BadRequest();

            ListOfMessange.Add(msg);

            Console.WriteLine(String.Format("Всего сообщений:{0}. Посланное сообщение: {1} ", ListOfMessange.Count, msg));

            return new OkResult();

        }
    }
}
