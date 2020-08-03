﻿namespace CleanArch.Infra.IoC
{
    using CleanArch.Application.Interfaces;
    using CleanArch.Application.Services;
    using CleanArch.Domain.CommandHandler;
    using CleanArch.Domain.Commands;
    using CleanArch.Domain.Core.Bus;
    using CleanArch.Domain.Interfaces;
    using CleanArch.Infra.Bus;
    using CleanArch.Infra.Data.Context;
    using CleanArch.Infra.Data.Repository;
    using MediatR;
    using Microsoft.Extensions.DependencyInjection;

    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handler
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();

            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();

            services.AddScoped<UniversityDbContext>();
        }
    }
}