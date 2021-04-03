using System;
using AutoMapper;
using ReactNetVanilla.Controllers.Resources;
using ReactNetVanilla.Core.Models;

namespace ReactNetVanilla.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Comment, CommentResource>();
        }
    }
}
