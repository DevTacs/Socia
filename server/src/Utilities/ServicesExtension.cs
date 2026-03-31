using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using src.Data;

namespace src.Utilities
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["ConnectionStrings:DefaultConnection"];
            services.AddDbContext<SociaDbContext>(options => options.UseSqlServer(connectionString));

            return services;
        }
    }
}