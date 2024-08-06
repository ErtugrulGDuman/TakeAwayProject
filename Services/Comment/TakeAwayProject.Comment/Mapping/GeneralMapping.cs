using AutoMapper;
using TakeAwayProject.Comment.DAL.Entities;
using TakeAwayProject.Comment.DTO;

namespace TakeAwayProject.Comment.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<UserComment, ResultUserCommentDto>().ReverseMap();
            CreateMap<UserComment, UpdateUserCommmnetDto>().ReverseMap();
            CreateMap<UserComment, CreateUserCommmnetDto>().ReverseMap();
            CreateMap<UserComment, GetByIdUserCommmnetDto>().ReverseMap();
            CreateMap<UserComment, GetByProductIdUserCommmnetDto>().ReverseMap();
        }
    }
}
