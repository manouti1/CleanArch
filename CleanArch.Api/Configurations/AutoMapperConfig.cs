namespace CleanArch.Api.Configurations
{
    using AutoMapper;
    using CleanArch.Application.AutoMapper;
    using Microsoft.Extensions.DependencyInjection;

    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMappings();
        }
    }
}