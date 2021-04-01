using Seed.Domain.Entitys;
using Seed.Dto;

namespace Seed.Application.Config
{
    public class DominioToDtoProfileSeed : AutoMapper.Profile
    {

        public DominioToDtoProfileSeed()
        {
            CreateMap(typeof(Sample), typeof(SampleDto)).ReverseMap();
            CreateMap(typeof(Sample), typeof(SampleDtoSpecialized));
            CreateMap(typeof(Sample), typeof(SampleDtoSpecializedResult));
            CreateMap(typeof(Sample), typeof(SampleDtoSpecializedReport));
            CreateMap(typeof(Sample), typeof(SampleDtoSpecializedDetails));

        }

    }
}
