using ApplicationServices.Services;
using DataAccess.Repositories;
using Domain.Repositories;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Web_Project_Net5_VueJS3.AppConfig
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddRepositoriesDI(this IServiceCollection services)
        {
            services.AddTransient<IAppRepository, AppRepository>();

            return services;
        }

        public static IServiceCollection AddServicesDI(this IServiceCollection services)
        {
            services.AddTransient<IAppService, AppService>();

            return services;
        }
    }
}