using AutoMapper;
using finter_app.Areas.Manage.Helpers.DTOs.Positions;
using finter_app.Models;

namespace finter_app.Areas.Manage.Helpers.Mapper.Positions;

public class PositionMapper : Profile
{
    public PositionMapper()
    {
        CreateMap<CreatePositionDto, Position>().ReverseMap();
        CreateMap<UpdatePositionDto, Position>().ReverseMap();
    }
}
