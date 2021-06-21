using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using tutorial_dotnet.Data;
using tutorial_dotnet.DTOs;
using tutorial_dotnet.Models;

namespace tutorial_dotnet.controllers
{
    // api/command
    [Route("api/[controller]")]
    [ApiController]
    public class CommadsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;
        private readonly IMapper _mapper;

        public CommadsController(ICommanderRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
        }

        [HttpGet("{id}", Name = "GetCommandById")]
        public ActionResult<CommandReadDto> GetCommandById(int id)
        {
            var commandItems = _repository.GetCommandByID(id);
            if (commandItems != null)
            {


                return Ok(_mapper.Map<CommandReadDto>(commandItems));
            }
            else
            {
                return NotFound();
            }

        }


        //post api/commands
        [HttpPost]
        public ActionResult<CommandReadDto> CreateCommand(CommandCreateDto commandCreateDto)
        {
            var commandModel = _mapper.Map<Command>(commandCreateDto);
            _repository.CreateCommand(commandModel);
            _repository.SaveChanges();

            var commandReadDto = _mapper.Map<CommandReadDto>(commandModel);

            return CreatedAtRoute(nameof(GetCommandById), new { id = commandReadDto.id }, commandReadDto);
        }

        [HttpPut("{id}")]
        //put api/command{id}
        public ActionResult updateCommand(int id, CommandUpdateDTO commandUpdate)
        {
            var idCheck = _repository.GetCommandByID(id);
            if (idCheck == null)
            {
                return NotFound();
            }
            _mapper.Map(commandUpdate, idCheck);
            _repository.UpdateCommand(idCheck);
            _repository.SaveChanges();
            return NoContent();
        }

        // [HttpPatch]
        // public ActionResult 


    }
}