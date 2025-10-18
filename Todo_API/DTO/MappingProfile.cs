using AutoMapper;
using Todo_API.DTO.Todo;

namespace Todo_API.DTO
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
          CreateMap<CreateTodoDto, Models.Todo>();
          CreateMap<UpdateTodoDto, Models.Todo>();
          CreateMap<Models.Todo, CreateTodoDto>();
          CreateMap<Models.Todo, UpdateTodoDto>();
        }
    }
}