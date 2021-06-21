using AutoMapper;
using tutorial_dotnet.DTOs;
using tutorial_dotnet.Models;

namespace tutorial_dotnet.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //source->Destination
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDTO, Command>();
        }
    }
}