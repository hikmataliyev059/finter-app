using AutoMapper;
using finter_app.Areas.Manage.Helpers.DTOs.Agents;
using finter_app.Models;

namespace finter_app.Areas.Manage.Helpers.Mapper.Agents;

public class AgentMapper : Profile
{
    public AgentMapper()
    {
        CreateMap<CreateAgentDto, Agent>().ReverseMap();
        CreateMap<UpdateAgentDto, Agent>().ReverseMap();
    }
}
