using AutoMapper;

namespace RevisaoApp.Application.Core
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(config => config.AddProfiles(new[] { "RevisaoApp.Application" }));
        }
    }
}