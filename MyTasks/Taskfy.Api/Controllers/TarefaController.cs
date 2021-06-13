using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Taskfy.Api.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Taskfy.Api.Controllers
{
    [Route("api/tarefa")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private static List<Tarefa> _minhasTarefas = new List<Tarefa>();


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_minhasTarefas);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var tarefa = _minhasTarefas.FirstOrDefault(item => item.Id == id);

            if (tarefa == default)
                return NotFound(tarefa);

            return Ok(tarefa);
        }
    }
}
