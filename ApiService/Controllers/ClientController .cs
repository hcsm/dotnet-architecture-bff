using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ApiService.Model;

namespace Sqit.CustomerApi.Controllers
{
    [Route("service")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly List<ClientDTO> customers = null;

        [HttpGet("{id:int}")]
        public IActionResult GetClient(int id)
        {
            ClientDTO _client = new ClientDTO();
            _client.Id = id;
            _client.Type = (id % 2 == 0 ? "Par" : "Ímpar");

            return Ok(_client);
        }
    }
}