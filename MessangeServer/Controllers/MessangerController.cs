﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MessangeServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MessangerController : ControllerBase
    {
        // GET api/<MessangerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Id = " + id.ToString();
        }

        // POST api/<MessangerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
