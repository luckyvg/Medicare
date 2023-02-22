using DataLayer.IRepository;
using DataLayer.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Startup
{
    public static class RegisterServices
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {
            //changed from AddScoped to AddTransient so that the given dependency should be constructed afresh every time it is needed
            services.AddTransient<IUserRepository, UserRepository>();
           
            return services;
        }
    }
}
