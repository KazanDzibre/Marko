using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiels
{
	public class CommandsProfile : Profile
	{
		public CommandsProfile()
		{
			CreateMap<Command, CommandReadDto>();

			CreateMap<CommandCreateDto, Command>();

			CreateMap<CommandUpdateDto, Command>();

			CreateMap<Command, CommandUpdateDto>();
		}

		
	}
}
