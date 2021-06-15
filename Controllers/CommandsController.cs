using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using tutorial_dotnet.Data;
using tutorial_dotnet.Models;

namespace tutorial_dotnet.controllers
{
    // api/command
    [Route("api/[controller]")]
    [ApiController]
    public class CommadsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        public CommadsController(ICommanderRepo repository)
        {
            _repository = repository;
        }
        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItems = _repository.GetCommandByID(id);
            return Ok(commandItems);
        }
    }
}