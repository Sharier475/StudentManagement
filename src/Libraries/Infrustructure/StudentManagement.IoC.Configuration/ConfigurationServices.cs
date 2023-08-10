using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentManagement.Core;
using StudentManagement.Core.Mapper;
using StudentManagement.Infrustructure;
using StudentManagement.Repositories.Base;
using StudentManagement.Repositories.Interface;

namespace StudentManagement.IoC.Configuration
{
    public static class ConfigurationServices
    {
        public static IServiceCollection AddExtention(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<StudentManagementDbContext>(options
                => options.UseSqlServer(configuration.GetConnectionString("DbConnection")));

            services.AddTransient<IStudentRepository,StudentRepository>();
            services.AddAutoMapper(typeof(CommonMapper).Assembly);
            services.AddMediatR(options => options.RegisterServicesFromAssemblies(typeof(ICore).Assembly));
            return services;

        }
       

    }
}
